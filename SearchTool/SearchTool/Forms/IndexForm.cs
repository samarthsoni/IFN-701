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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            FileOpenButton.Enabled = false;
            SearchAttributeComboBox.Enabled = false;
            IndexBrowseButton.Enabled = false;
            IndexButton.Enabled = false;
            SearchFormButton.Enabled = false;

        }

        private void FileBrowseButton_Click(object sender, EventArgs e)
        {
            MyFileDialog.ShowDialog();
            FilePath.Text = MyFileDialog.FileName;

        }

        private void FileOpenButton_Click(object sender, EventArgs e)
        {
            Program.SE.read_file(FilePath.Text);

            SearchAttributeComboBox.Enabled = true;
            IndexBrowseButton.Enabled = true;
            string[] labels = Program.SE.get_attributes();
            for(int i=0;i<labels.Length;i++)
            {
                SearchAttributeComboBox.Items.Add(labels[i]);
            }
        }

        private void IndexBrowseButton_Click(object sender, EventArgs e)
        {
            MyFolderBrowserDialog.ShowDialog();
            IndexPath.Text = MyFolderBrowserDialog.SelectedPath;
        }

        private void IndexButton_Click(object sender, EventArgs e)
        {
            SearchFormButton.Enabled = true;
            string message=Program.SE.index_functionality(IndexPath.Text, SearchAttributeComboBox.Text);
            MessageLabel.Text = message;
        }

        private void SearchFormButton_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm(SearchAttributeComboBox.Text);
            searchform.ShowDialog();
            
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(FilePath.Text))
            {
                FileOpenButton.Enabled = true;
                ErrorLabel.Text = "Error Log:";
            }
            else
                ErrorLabel.Text = "Error Log: File Not Found";
        }

        private void IndexPath_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(IndexPath.Text))
            {
                IndexButton.Enabled = true;
                ErrorLabel.Text = "Error Log:";
            }
            else
                ErrorLabel.Text = "Error Log: Directory Not Found";


        }
    }
}
