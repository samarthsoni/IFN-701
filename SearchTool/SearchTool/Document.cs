using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Documents;

namespace SearchTool
{
    class CSVDocument
    {
        public string [][] Instances
        { get; set; }
        public string [] Attributes
        { get; set; }
        public int NoOfInstances
        { get; set; }

        public void read_doc(string path)
        {
            var reader = new StreamReader(File.OpenRead(path));

            List<string[]> listA = new List<string[]>();
            int i = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                string[] newValues = new string[values.Length + 1];
                newValues[0] = i.ToString();
                Array.Copy(values, 0, newValues, 1, values.Length);

                i++;
                listA.Add(newValues);
            }

            NoOfInstances = i;
            Attributes = listA.First();
            Attributes[0] = "ID";
            listA.RemoveAt(0);
            Instances = listA.ToArray();
        }

        public string [,] get_attributeColumn(string attributeName)
        {
            int i,index=0;
            for(i=0;i<Attributes.Length;i++)
            {
                if (Attributes[i] == attributeName)
                    index = i;
            }

            string[,] attributeColumn = new string[Instances.Length,2];

            for(int j=0;j<Instances.Length;j++)
            {
                attributeColumn[j,1] = Instances[j][index];
                attributeColumn[j,0] = Instances[j][0];
            }
            return attributeColumn;
        }

        public void save_result(string [][] results,string filesavepath)
        {
            string temp = "";
            var csv = new StringBuilder();

            for(int u=1;u<Attributes.Length;u++)
            {
                temp = temp + Attributes[u] + ",";
            }
            csv.AppendLine(temp);
            for (int u=0;u<results.Length;u++)
            {
                temp = "";
                for (int j = 1; j < Attributes.Length; j++)
                {
                    temp = temp + Instances[int.Parse(results[u][0]) - 1][j] + ",";
                }

                csv.AppendLine(temp);
            }

            File.WriteAllText(filesavepath+"\\results.csv", csv.ToString());
        }
        
    }
}
