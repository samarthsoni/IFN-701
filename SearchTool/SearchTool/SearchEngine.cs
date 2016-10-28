using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser


namespace SearchTool
{
    class SearchEngine
    {
        CSVDocument CSVdoc;

        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;

        public int NoOfDocs { get; set; }

        public SearchEngine()
        {
            luceneIndexDirectory = null; // Is set in Create Index
            analyzer = null;  // Is set in CreateAnalyser
            writer = null; // Is set in CreateWriter
            CSVdoc = new CSVDocument();
        }

        //To read the document
        public void read_file(string path)
        {
            CSVdoc.read_doc(path);
        }

        //Returns instances
        public string [] get_attributes()
        {
            return CSVdoc.Attributes;
        }

        //Open the index directory
        public void OpenIndex(string indexPath)
        {
            /* Make sure to pass a new directory that does not exist */
            luceneIndexDirectory = FSDirectory.Open(indexPath+"\\index");
        }


        //Creating Analyser
        public void CreateAnalyser()
        {
            List<string> stopword = new List<string>();

            System.IO.StreamReader reader2 = new System.IO.StreamReader("StopWords.txt");
            string line = "";
            while ((line = reader2.ReadLine()) != null)
            {
                stopword.Add(line);
            }

            string[] s = stopword.ToArray();

            // TODO: Enter code to create the Lucene Analyser 
            //analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English", s);
        }

        //Creating Writer
        public void CreateWriter()
        {
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);

            // TODO: Enter code to create the Lucene Writer
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
        }


        //Writing text to index
        public void IndexText(string searchattribute)
        {
            string [,] att = CSVdoc.get_attributeColumn(searchattribute);


            for(int c=0;c<att.Length/2;c++)
            {
                Lucene.Net.Documents.Field field0 = new Field("ID", att[c, 0], Field.Store.YES, Field.Index.NO,
                Field.TermVector.NO);

                Lucene.Net.Documents.Field field1 = new Field(searchattribute, att[c,1], Field.Store.YES, Field.Index.ANALYZED,
                Field.TermVector.WITH_POSITIONS_OFFSETS);

                Lucene.Net.Documents.Document doc = new Document();
                doc.Add(field0);
                doc.Add(field1);
                writer.AddDocument(doc);
            }
            
        }


        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

        //Indexing is done using followinf method
        public string index_functionality(string iPath, string searchattribute)
        {

            OpenIndex(iPath);
            CreateAnalyser();
            CreateWriter();
            IndexText(searchattribute);
            CleanUpIndexer();

            return "The Document is Indexed";
        }

        /// <summary>
        /// Initialises the searcher object
        /// </summary>
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
        }

        /// <summary>
        /// Initialises the parser object
        /// </summary>
        public void CreateParser(string label)
        {
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, label, analyzer);
        }

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearch()
        {
            searcher.Dispose();
        }

        public TopDocs SearchIndex(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 2800);
            NoOfDocs = results.TotalHits;
            return results;

        }

        public List<string[]> DisplayResults(TopDocs results,string label)
        {
            List<string[]> retrievedDocs = new List<string[]>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                // retrieve the document from the 'ScoreDoc' object
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string[] temp = new string[2];
                temp[0] = doc.Get("ID");
                temp[1] = doc.Get(label);
                retrievedDocs.Add(temp);
            }

            return retrievedDocs;
        }

        public string[][] search_functionality(string querytext,string label)
        {
            List<string[]> docid = new List<string[]>();
            CreateSearcher();
            CreateParser(label);
            TopDocs td = SearchIndex(querytext);
            docid = DisplayResults(td,label);

            CleanUpSearch();
            string[][] docid2 = docid.ToArray();
            return docid2;
        }

        public void saveresults(string [][] result,string path)
        {
            CSVdoc.save_result(result, path);
        }
    }
}
