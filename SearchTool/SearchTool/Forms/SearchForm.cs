using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTool
{
    public partial class SearchForm : Form
    {
        string searchAttribute;
        string[][] results;
        public SearchForm(string searchattribute)
        {
            InitializeComponent();
            searchAttribute = searchattribute;

            SearchButton.Enabled = false;
            BrowseSaveDirButton.Enabled = false;
            SaveButton.Enabled = false;
            ResultBox.ReadOnly = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            results=Program.SE.search_functionality(QueryTextBox.Text, searchAttribute);
            
            string display = "";

            for (int y = 0; y < results.Length; y++)
            {
                display = display + results[y][0]+" "+results[y][1] + "\n\n";
            }
            ResultBox.Text = display;
            BrowseSaveDirButton.Enabled = true;

            ResultsLabel.Text = Program.SE.NoOfDocs + " Documents Retrieved. "+results.Length+" Documents displayed";
        }

        private void BrowseSaveDirButton_Click(object sender, EventArgs e)
        {
            ResultFolderBrowserDialog.ShowDialog();
            SavePathBox.Text = ResultFolderBrowserDialog.SelectedPath;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.SE.saveresults(results,SavePathBox.Text);
        }

        private void QueryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QueryTextBox.Text != ""|| QueryTextBox.Text != " ")
            {
                SearchButton.Enabled = true;
                ErrorLabel.Text = "Error Log:";
            }
            else
            {
                SearchButton.Enabled = false;
                ErrorLabel.Text = "Error Log: Enter a Query";
            }
        }

        private void SavePathBox_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(SavePathBox.Text))
            {
                SaveButton.Enabled = true;
                ErrorLabel.Text = "Error Log:";
            }
            else
                ErrorLabel.Text = "Error Log: Directory Not Found"; 
        }
    }
}
