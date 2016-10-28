namespace SearchTool
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileLabel = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FileBrowseButton = new System.Windows.Forms.Button();
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.SearchAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.AttributeLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.IndexPath = new System.Windows.Forms.TextBox();
            this.IndexBrowseButton = new System.Windows.Forms.Button();
            this.IndexButton = new System.Windows.Forms.Button();
            this.MyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MyFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchFormButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(18, 71);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(70, 13);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File Location:";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.SteelBlue;
            this.Message.Location = new System.Drawing.Point(335, 14);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(276, 24);
            this.Message.TabIndex = 1;
            this.Message.Text = "Welcome to the Search Tool";
            this.Message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(100, 68);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(581, 20);
            this.FilePath.TabIndex = 2;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.Location = new System.Drawing.Point(702, 66);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FileBrowseButton.TabIndex = 3;
            this.FileBrowseButton.Text = "Browse..";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.FileBrowseButton_Click);
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Location = new System.Drawing.Point(793, 66);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(75, 23);
            this.FileOpenButton.TabIndex = 4;
            this.FileOpenButton.Text = "Open File";
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // SearchAttributeComboBox
            // 
            this.SearchAttributeComboBox.FormattingEnabled = true;
            this.SearchAttributeComboBox.Location = new System.Drawing.Point(157, 121);
            this.SearchAttributeComboBox.Name = "SearchAttributeComboBox";
            this.SearchAttributeComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchAttributeComboBox.TabIndex = 5;
            this.SearchAttributeComboBox.Text = "Select";
            // 
            // AttributeLabel
            // 
            this.AttributeLabel.AutoSize = true;
            this.AttributeLabel.Location = new System.Drawing.Point(15, 124);
            this.AttributeLabel.Name = "AttributeLabel";
            this.AttributeLabel.Size = new System.Drawing.Size(119, 13);
            this.AttributeLabel.TabIndex = 6;
            this.AttributeLabel.Text = "Select Search Attribute:";
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(18, 160);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(125, 13);
            this.IndexLabel.TabIndex = 7;
            this.IndexLabel.Text = "Index Directory Location:";
            // 
            // IndexPath
            // 
            this.IndexPath.Location = new System.Drawing.Point(157, 160);
            this.IndexPath.Name = "IndexPath";
            this.IndexPath.Size = new System.Drawing.Size(524, 20);
            this.IndexPath.TabIndex = 8;
            this.IndexPath.Text = "F:\\QUT\\Sem 2 2016\\701 Project\\dataset\\windows application";
            this.IndexPath.TextChanged += new System.EventHandler(this.IndexPath_TextChanged);
            // 
            // IndexBrowseButton
            // 
            this.IndexBrowseButton.Location = new System.Drawing.Point(702, 160);
            this.IndexBrowseButton.Name = "IndexBrowseButton";
            this.IndexBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.IndexBrowseButton.TabIndex = 9;
            this.IndexBrowseButton.Text = "Browse..";
            this.IndexBrowseButton.UseVisualStyleBackColor = true;
            this.IndexBrowseButton.Click += new System.EventHandler(this.IndexBrowseButton_Click);
            // 
            // IndexButton
            // 
            this.IndexButton.Location = new System.Drawing.Point(488, 232);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(132, 23);
            this.IndexButton.TabIndex = 10;
            this.IndexButton.Text = "Index Doc";
            this.IndexButton.UseVisualStyleBackColor = true;
            this.IndexButton.Click += new System.EventHandler(this.IndexButton_Click);
            // 
            // MyFileDialog
            // 
            this.MyFileDialog.FileName = "openFileDialog1";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(299, 237);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(174, 13);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "Click the button to index document.";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(302, 267);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(174, 13);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Click the button to begin searching.";
            // 
            // SearchFormButton
            // 
            this.SearchFormButton.Location = new System.Drawing.Point(488, 261);
            this.SearchFormButton.Name = "SearchFormButton";
            this.SearchFormButton.Size = new System.Drawing.Size(132, 23);
            this.SearchFormButton.TabIndex = 13;
            this.SearchFormButton.Text = "Go to Search";
            this.SearchFormButton.UseVisualStyleBackColor = true;
            this.SearchFormButton.Click += new System.EventHandler(this.SearchFormButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(21, 306);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(53, 13);
            this.ErrorLabel.TabIndex = 14;
            this.ErrorLabel.Text = "Error Log:";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 350);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SearchFormButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.IndexButton);
            this.Controls.Add(this.IndexBrowseButton);
            this.Controls.Add(this.IndexPath);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.AttributeLabel);
            this.Controls.Add(this.SearchAttributeComboBox);
            this.Controls.Add(this.FileOpenButton);
            this.Controls.Add(this.FileBrowseButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.FileLabel);
            this.Name = "IndexForm";
            this.Text = "Index Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button FileBrowseButton;
        private System.Windows.Forms.Button FileOpenButton;
        private System.Windows.Forms.ComboBox SearchAttributeComboBox;
        private System.Windows.Forms.Label AttributeLabel;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.TextBox IndexPath;
        private System.Windows.Forms.Button IndexBrowseButton;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.OpenFileDialog MyFileDialog;
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowserDialog;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchFormButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

