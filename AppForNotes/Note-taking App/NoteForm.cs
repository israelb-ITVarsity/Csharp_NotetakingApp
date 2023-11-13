using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using NoteTakingApp.Data;
using System.IO;
using System.Drawing;
using System.Text;


namespace NoteTakingApp
{
    public partial class NoteForm : Form
    {
        DataTable table;
        List<NoteEntry> noteEntries;

        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private TextBox searchBox;
        private Button SearchButton_Click;
        private Timer reminderTimer;



        public NoteForm()
        {
            InitializeComponent();

            // disable scaling
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Attach the FormClosing event handler
            this.FormClosing += NoteForm_FormClosing;

            // Initialize the openFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            // Create and configure the search TextBox
            searchTextBox = new TextBox();
            searchTextBox.Location = new Point(10, 10); // Adjust the location as needed
            searchTextBox.Size = new Size(200, 20); // Adjust the size as needed
            this.Controls.Add(searchTextBox);

            // Create and configure the search Button
            searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Location = new Point(220, 10); // Adjust the location as needed
            searchButton.Size = new Size(75, 20); // Adjust the size as needed
            searchButton.Click += new EventHandler(SearchButton_Click_Click);
            this.Controls.Add(searchButton);

            // Initialize and configure the reminderTimer
            reminderTimer = new Timer();
            reminderTimer.Interval = 60000; // Set the interval in milliseconds (e.g., 60 seconds)
            reminderTimer.Tick += timer_Tick; // Add an event handler for the timer tick
            reminderTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            foreach (DataRow row in table.Rows)
            {
                if (row["Reminder"] != DBNull.Value)
                {
                    DateTime reminderTime = (DateTime)row["Reminder"];

                    if (currentTime >= reminderTime)
                    {
                        // Display a reminder notification (e.g., a message box)
                        string title = row["Title"].ToString();
                        string message = row["Messages"].ToString();
                        MessageBox.Show($"Reminder for Note: {title}\n\n{message}", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the reminder to avoid showing it again
                        row["Reminder"] = DBNull.Value;
                    }
                }
            }
        }




        private void NoteForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            table.Columns.Add("Reminder", typeof(DateTime)); // To set reminders when loaded



            savedNotesTable.DataSource = table;

            savedNotesTable.Columns["Messages"].Visible = false;

            savedNotesTable.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            savedNotesTable.Columns["Title"].FillWeight = 100;


            // Load the data from the JSON file
            LoadDataFromJsonFile();
        }


        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the data to the JSON file
            SaveDataToJsonFile();
        }

        private void LoadDataFromJsonFile()
        {
            string filePath = "storage.json";

            if (!File.Exists(filePath))
            {
                // File doesn't exist, create a new one with an empty array
                File.WriteAllText(filePath, "[]");
            }


            string json = File.ReadAllText("storage.json");
            noteEntries = JsonConvert.DeserializeObject<List<NoteEntry>>(json);

            // Clear the DataTable
            table.Rows.Clear();

            // Add the data from noteEntries to the DataTable
            foreach (NoteEntry entry in noteEntries)
            {
                table.Rows.Add(entry.Title, entry.Message, entry.ImageData);
            }
        }

        private void SaveDataToJsonFile()
        {
            noteEntries = new List<NoteEntry>();

            // Retrieve the data from the savedNotesTable and populate noteEntries
            foreach (DataGridViewRow row in savedNotesTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    NoteEntry entry = new NoteEntry
                    {
                        Title = row.Cells["Title"].Value.ToString(),
                        Message = row.Cells["Messages"].Value.ToString()
                    };
                    noteEntries.Add(entry);
                }
            }

            // Serialize noteEntries to JSON
            string json = JsonConvert.SerializeObject(noteEntries, Formatting.Indented);

            // Write the JSON data to the file
            File.WriteAllText("storage.json", json);

            //Save the data to a textFile I created on my laptop
            string savePath = "SaveNotes.txt";
            File.WriteAllText(savePath, json);
        }


        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleEntryBox.Clear();
            MessageEntryBox.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Get the selected image file path (if an image is selected)
            string imagePath = pictureBox.Image != null ? openFileDialog.FileName : string.Empty;

            // Get the selected reminder date and time
            DateTime reminder = reminderDateTimePicker.Value;

            table.Rows.Add(TitleEntryBox.Text, MessageEntryBox.Text, imagePath, reminder);

            TitleEntryBox.Clear();
            MessageEntryBox.Clear();
            pictureBox.Image = null; // Clear the PictureBox

            if (pictureBox.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        //Save the displayed image to the specified location
                        pictureBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0) 
            {
                // do nothing
            }
            else
            {
                // if the row count is not 0, then it is 1+
                // this means that there will always be a selected row and we read that
                int index = savedNotesTable.CurrentCell.RowIndex;

                // unneeded clear but whatever
                TitleEntryBox.Clear();
                MessageEntryBox.Clear();

                // load selected content
                TitleEntryBox.Text = table.Rows[index].ItemArray[0].ToString();
                MessageEntryBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (table.Rows.Count == 0) 
            {
                // do nothing
            } 
            else 
            {
                TitleEntryBox.Clear();
                MessageEntryBox.Clear();

                int selectedRowIndex = savedNotesTable.CurrentCell.RowIndex;

                savedNotesTable.Rows.RemoveAt(selectedRowIndex);

                // Check if there are still rows after deletion
                if (savedNotesTable.Rows.Count > 0)
                {
                    // Select the next row if available
                    if (selectedRowIndex >= savedNotesTable.Rows.Count)
                    {
                        // If the last row was deleted, select the new last row
                        savedNotesTable.Rows[savedNotesTable.Rows.Count - 1].Selected = true;
                    }
                    else
                    {
                        // Select the row following the deleted one
                        savedNotesTable.Rows[selectedRowIndex].Selected = true;
                    }
                }
            }
        }

        private void ImageUploadBtn_Click(object sender, EventArgs e)
        {
            using ( openFileDialog )
                {
                //openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the selected image file path
                    string imagePath = openFileDialog.FileName;

                    //Display the selected image in the PictureBox
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        //Save the displayed image to the specified location
                        pictureBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower(); // Convert the search text to lowercase for case-insensitive search

            // Filter the DataTable based on the search text
            DataRow[] filteredRows = table.Select($"Title LIKE '%{searchText}%' OR Messages LIKE '%{searchText}%'");

            // Clear the current DataGridView
            table.Rows.Clear();

            // Add the filtered rows to the DataTable
            foreach (DataRow row in filteredRows)
            {
                table.Rows.Add(row.ItemArray);
            }
        }

        private void savedNotesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}