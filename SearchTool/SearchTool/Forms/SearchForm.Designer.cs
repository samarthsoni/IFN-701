namespace SearchTool
{
    partial class SearchForm
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
            this.EnterQueryLabel = new System.Windows.Forms.Label();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SavePathBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BrowseSaveDirButton = new System.Windows.Forms.Button();
            this.ResultFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterQueryLabel
            // 
            this.EnterQueryLabel.AutoSize = true;
            this.EnterQueryLabel.Location = new System.Drawing.Point(45, 35);
            this.EnterQueryLabel.Name = "EnterQueryLabel";
            this.EnterQueryLabel.Size = new System.Drawing.Size(82, 13);
            this.EnterQueryLabel.TabIndex = 0;
            this.EnterQueryLabel.Text = "Enter the query:";
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(134, 35);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(642, 20);
            this.QueryTextBox.TabIndex = 1;
            this.QueryTextBox.TextChanged += new System.EventHandler(this.QueryTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(794, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultBox.Location = new System.Drawing.Point(48, 84);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(728, 279);
            this.ResultBox.TabIndex = 3;
            this.ResultBox.Text = "";
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(45, 68);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(146, 13);
            this.ResultsLabel.TabIndex = 4;
            this.ResultsLabel.Text = "The retrieved documents are:";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(48, 381);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(157, 13);
            this.SaveLabel.TabIndex = 5;
            this.SaveLabel.Text = "Save Results (Select Directory):";
            // 
            // SavePathBox
            // 
            this.SavePathBox.Location = new System.Drawing.Point(212, 381);
            this.SavePathBox.Name = "SavePathBox";
            this.SavePathBox.Size = new System.Drawing.Size(461, 20);
            this.SavePathBox.TabIndex = 6;
            this.SavePathBox.Text = "F:\\QUT\\Sem 2 2016\\701 Project\\dataset\\windows application";
            this.SavePathBox.TextChanged += new System.EventHandler(this.SavePathBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(794, 381);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseSaveDirButton
            // 
            this.BrowseSaveDirButton.Location = new System.Drawing.Point(701, 379);
            this.BrowseSaveDirButton.Name = "BrowseSaveDirButton";
            this.BrowseSaveDirButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseSaveDirButton.TabIndex = 8;
            this.BrowseSaveDirButton.Text = "Browse...";
            this.BrowseSaveDirButton.UseVisualStyleBackColor = true;
            this.BrowseSaveDirButton.Click += new System.EventHandler(this.BrowseSaveDirButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(48, 410);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(53, 13);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Error Log:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 429);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BrowseSaveDirButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SavePathBox);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.EnterQueryLabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterQueryLabel;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.TextBox SavePathBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BrowseSaveDirButton;
        private System.Windows.Forms.FolderBrowserDialog ResultFolderBrowserDialog;
        private System.Windows.Forms.Label ErrorLabel;
    }
}