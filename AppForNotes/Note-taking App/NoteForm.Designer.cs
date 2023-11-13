namespace NoteTakingApp
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleEntryBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageEntryBox = new System.Windows.Forms.TextBox();
            this.savedNotesTable = new System.Windows.Forms.DataGridView();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ImageUploadBtn = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SearchButton_Click = new System.Windows.Forms.Button();
            this.reminderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleEntryBox
            // 
            this.TitleEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleEntryBox.Location = new System.Drawing.Point(97, 39);
            this.TitleEntryBox.Margin = new System.Windows.Forms.Padding(0);
            this.TitleEntryBox.Name = "TitleEntryBox";
            this.TitleEntryBox.Size = new System.Drawing.Size(632, 20);
            this.TitleEntryBox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(53, 43);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(29, 84);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 13);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message:";
            // 
            // MessageEntryBox
            // 
            this.MessageEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageEntryBox.Location = new System.Drawing.Point(97, 84);
            this.MessageEntryBox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageEntryBox.Multiline = true;
            this.MessageEntryBox.Name = "MessageEntryBox";
            this.MessageEntryBox.Size = new System.Drawing.Size(643, 428);
            this.MessageEntryBox.TabIndex = 3;
            // 
            // savedNotesTable
            // 
            this.savedNotesTable.AllowUserToAddRows = false;
            this.savedNotesTable.AllowUserToDeleteRows = false;
            this.savedNotesTable.AllowUserToResizeColumns = false;
            this.savedNotesTable.AllowUserToResizeRows = false;
            this.savedNotesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedNotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedNotesTable.Location = new System.Drawing.Point(768, 39);
            this.savedNotesTable.Margin = new System.Windows.Forms.Padding(0);
            this.savedNotesTable.Name = "savedNotesTable";
            this.savedNotesTable.ReadOnly = true;
            this.savedNotesTable.RowHeadersVisible = false;
            this.savedNotesTable.RowHeadersWidth = 51;
            this.savedNotesTable.RowTemplate.Height = 24;
            this.savedNotesTable.Size = new System.Drawing.Size(187, 473);
            this.savedNotesTable.TabIndex = 4;
            this.savedNotesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.savedNotesTable_CellContentClick);
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBtn.Location = new System.Drawing.Point(97, 527);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(56, 19);
            this.NewBtn.TabIndex = 5;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(672, 527);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(56, 19);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadBtn.Location = new System.Drawing.Point(768, 527);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(56, 19);
            this.ReadBtn.TabIndex = 7;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Location = new System.Drawing.Point(898, 527);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 19);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(145, 266);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(285, 208);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // ImageUploadBtn
            // 
            this.ImageUploadBtn.Location = new System.Drawing.Point(436, 451);
            this.ImageUploadBtn.Name = "ImageUploadBtn";
            this.ImageUploadBtn.Size = new System.Drawing.Size(86, 23);
            this.ImageUploadBtn.TabIndex = 10;
            this.ImageUploadBtn.Text = "Upload Image";
            this.ImageUploadBtn.UseVisualStyleBackColor = true;
            this.ImageUploadBtn.Click += new System.EventHandler(this.ImageUploadBtn_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(763, 11);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(129, 20);
            this.searchBox.TabIndex = 13;
            // 
            // SearchButton_Click
            // 
            this.SearchButton_Click.Location = new System.Drawing.Point(898, 9);
            this.SearchButton_Click.Name = "SearchButton_Click";
            this.SearchButton_Click.Size = new System.Drawing.Size(52, 23);
            this.SearchButton_Click.TabIndex = 14;
            this.SearchButton_Click.Text = "Search";
            this.SearchButton_Click.UseVisualStyleBackColor = true;
            this.SearchButton_Click.Click += new System.EventHandler(this.SearchButton_Click_Click);
            // 
            // reminderDateTimePicker
            // 
            this.reminderDateTimePicker.Location = new System.Drawing.Point(508, 119);
            this.reminderDateTimePicker.Name = "reminderDateTimePicker";
            this.reminderDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reminderDateTimePicker.TabIndex = 15;
            this.reminderDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Set a reminder";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reminderDateTimePicker);
            this.Controls.Add(this.SearchButton_Click);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ImageUploadBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.savedNotesTable);
            this.Controls.Add(this.MessageEntryBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleEntryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoteForm";
            this.Text = "Temporary Note-taking App";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox TitleEntryBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageEntryBox;
        private System.Windows.Forms.DataGridView savedNotesTable;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ImageUploadBtn;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker reminderDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}

    