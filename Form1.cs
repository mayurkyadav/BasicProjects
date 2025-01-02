using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Assignment_3_PC_
{
    public partial class Form1 : Form
    {
        public bool IsPostBack { get; private set; }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AwaitingNoteMode();
                LoadAppointments();
                EmptyAll();
            }
        }

        private bool ValidationInput()
        {
            bool IsValid = false;
            return IsValid;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e) //update button
        {
            string filePath = "appointments.txt";
            if (listBoxName.SelectedIndex != -1)
            {
            string username = txtBoxName.Text.Trim();
            string noteID = txtboxNoteID.Text.Trim();
            int parsedNoteID;
            if (!int.TryParse(noteID, out parsedNoteID))
            {

                lblError.Text = "Note ID should be an integer.";
                return;
                
            }
            

            // Validate username contains only alphabetic characters
            if (!IsAlphabetic(username))
            {
                lblError.Text = "Username should contain only alphabetic characters.";
                
                return;
            }
                string selectedUsername = listBoxName.SelectedItem.ToString();
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (parts.Length == 6 && parts[0] == selectedUsername)
                    {
                        // Update the username, password, problems, date, and note in the file
                        lines[i] = $"{txtBoxName.Text.Trim()}|{txtboxNoteID.Text.Trim()}|{string.Join(";", listBoxProblems.Items.Cast<string>())}|{dateTimePicker1.Value.ToString("yyyy-MM-dd")}|{string.Join(";", listBoxVitals.Items.Cast<string>())}|{richTextBox1.Text.Replace("\n", ";").Replace("\r", "")}";

                        // Write the modified lines back to the file
                        File.WriteAllLines(filePath, lines);

                        // Update the ListBox with the new username
                        listBoxName.Items[listBoxName.SelectedIndex] = txtBoxName.Text.Trim();

                        lblError.Text = "Note was updated succesfully";
                        return;
                    }
                }
            }
        }
        public void AwaitingNoteMode()
        {
            BtnAddNote.Enabled = false;
            BtnUpdateNote.Enabled = false;
            BtnDeleteNote.Enabled = false;
            txtboxNoteID.Enabled = false;
            txtBoxName.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtBoxNewProblem.Enabled = false;
            BtnRmvePblm.Enabled = false;
            BtnAdd.Enabled = false;
        }

        public void EditingNoteMode()
        {
            BtnAddNote.Enabled = false;
            BtnUpdateNote.Enabled = true;
            BtnDeleteNote.Enabled = true;
            txtboxNoteID.Enabled = true;
            txtBoxName.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtBoxNewProblem.Enabled = true;
            BtnRmvePblm.Enabled = true;
            BtnAdd.Enabled = true;
        }

          private void AddMode()
        {
            BtnAddNote.Enabled = true;
            BtnUpdateNote.Enabled = false;
            BtnDeleteNote.Enabled = false;
            txtboxNoteID.Enabled = true;
            txtBoxName.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtBoxNewProblem.Enabled = true;
            BtnRmvePblm.Enabled = true;
            BtnAdd.Enabled = true;

        }

        public void LoadAppointments()
        {
            string filePath = "appointments.txt";
            if (File.Exists(filePath))
            {
               string[] lines = File.ReadAllLines(filePath);
              foreach (string line in lines)
              {
                 string[] parts = line.Split('|');
                  if (parts.Length >= 2) // Assuming at least username and password are present
                  {
                       string username = parts[0];
                       listBoxName.Items.Add(username);
                    }
                }
            }
        }
        private void EmptyAll()
        {
            txtBoxName.Text = "";
            txtboxNoteID.Text = "";
            listBoxProblems.Items.Clear();
            listBoxVitals.Items.Clear();
            richTextBox1.Clear();
        }
        private void BtnNewNote_Click(object sender, EventArgs e)
        {

            EmptyAll();
            AddMode();
        }

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            EditingNoteMode();
            if (listBoxName.SelectedIndex != -1)
            {
                string selectedUsername = listBoxName.SelectedItem.ToString();
                string filePath = "appointments.txt";
                txtboxNoteID.Enabled = false;

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 5 && parts[0] == selectedUsername)
                        {
                            txtBoxName.Text = parts[0]; // Username
                            txtboxNoteID.Text = parts[1]; // id
                            dateTimePicker1.Value = DateTime.Parse(parts[3]); // Date

                            // Assign the note to the rich text box

                            string[] problemList = parts[2].Split(';');
                            listBoxProblems.Items.Clear();
                            foreach (string problem in problemList)
                            {
                                listBoxProblems.Items.Add(problem); // Problems
                            }
                            string[] vitalList = parts[4].Split(';');
                            listBoxVitals.Items.Clear();
                            foreach (string vital in vitalList)
                            {
                                listBoxVitals.Items.Add(vital); // Vitals
                            }

                            // Load the note into the RichTextBox without the semicolons
                            richTextBox1.Text = parts[5].Replace(";", "\n");

                            break; // Exit the loop once the data is found
                        }
                    }
                }
            }
        }





        public void AddNotetoListBox()
        {
            
            string username = txtBoxName.Text.Trim();
            string noteID = txtboxNoteID.Text.Trim();
            string problems = string.Join(";", listBoxProblems.Items.Cast<string>());
            DateTime date = dateTimePicker1.Value;
            string noteContent = richTextBox1.Text.Trim().Replace("\n", ";");

            // Validate noteID is an integer
            
            int parsedNoteID;
            if (!int.TryParse(noteID, out parsedNoteID))
            {
                AddMode();
                lblError.Text = "Note ID should be an integer Create new note again.";
                return;
               
            }
            

            // Validate username contains only alphabetic characters
            if (!IsAlphabetic(username))
            {
                lblError.Text = "Username should contain only alphabetic characters Create new note again.";
              
                return;
            }
            else
            {

                // Call the AddNoteToFile method if validation passes
                FileIO.AddNoteToFile(username, noteID, problems, date, noteContent, listBoxName);
                lblError.Text = "Note was added successfully.";
            }
        }

        // Method to check if a string contains only alphabetic characters
        private bool IsAlphabetic(string input)
        {
            return input.All(char.IsLetter);
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {

            AddNotetoListBox();
            EditingNoteMode();


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string problemText = txtBoxNewProblem.Text.Trim();

            // Check if the problem text is not empty
            if (!string.IsNullOrEmpty(problemText))
            {
                // Add the problem text to the items of the problem ListBox
                listBoxProblems.Items.Add(problemText);

                // Clear the problem TextBox for the next input
                txtBoxNewProblem.Clear();
            }

            else if (listBoxName.SelectedIndex != -1)
            {
                // Check if the problem text is not empty
                if (!string.IsNullOrEmpty(problemText))
                {
                    // Add the problem text to the items of the problem ListBox
                    listBoxProblems.Items.Add(problemText);

                    // Clear the problem TextBox for the next input
                    txtBoxNewProblem.Clear();
                }
            }
        }


        private void BtnRmvePblm_Click(object sender, EventArgs e)
        {
            if (listBoxProblems.SelectedIndex != -1)
            {
                // Remove the selected problem from the listBoxProblems
                listBoxProblems.Items.RemoveAt(listBoxProblems.SelectedIndex);

            }
            else
            {
                lblError.Text = "Please first select a problem to delete";
            }
        }

        private void BtnDeleteNote_Click(object sender, EventArgs e)
        {
            string filePath = "appointments.txt";
            string selectedNoteId = listBoxName.SelectedItem?.ToString();

            if (selectedNoteId != null)
            {
                try
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    // Create a new list to store the updated lines
                    var updatedLines = new List<string>();

                    // Iterate through each line
                    foreach (string line in lines)
                    {
                        // Split the line by the delimiter
                        string[] parts = line.Split('|');

                        // Check if the note ID matches
                        if (parts.Length > 0 && parts[0] != selectedNoteId)
                        {
                            // If not, add it to the updated lines
                            updatedLines.Add(line);
                        }
                    }

                    // Write the updated lines back to the file
                    File.WriteAllLines(filePath, updatedLines);

                    // Remove the note from the listbox
                    listBoxName.Items.Remove(selectedNoteId);
                    EmptyAll();
                    lblError.Text = "Note was deleted succesfully";
                }
                catch (Exception ex)
                {
                    // Handle any exceptions (e.g., file not found, permission issues, etc.)
                    MessageBox.Show($"Error deleting note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> extractedVitals = ValidationHelper.ExtractVitals(richTextBox1.Text);

            // Clear the existing items in the listBoxVitals
            listBoxVitals.Items.Clear();

            // Add the extracted vital measurements to the listBoxVitals
            foreach (string vital in extractedVitals)
            {
                listBoxVitals.Items.Add(vital);
            }
        }
    }
}
