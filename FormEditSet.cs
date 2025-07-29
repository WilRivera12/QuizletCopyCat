using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletGUI
{
    public partial class FormEditSet : Form
    {
        public FormEditSet()
        {
            InitializeComponent();
            LoadSets(DataFolder());
        }

        private void LoadSets(string filePath)
        {
            string[] files = Directory.GetFiles(filePath);
            
            // Got outside help in order for the newest sets show first
            files = files.OrderByDescending(f => File.GetCreationTime(f)).ToArray();
            foreach (string file in files)
            {
                // Adds each file name to the dropdown list
                comboCurrent.Items.Add(Path.GetFileNameWithoutExtension(file)); 
            }
            if (comboCurrent.Items.Count == 0)
            {
                MessageBox.Show("No flashcard sets found.\nPlease go to the menu and one first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private string DataFolder()
        {
            string a = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\data"));
            return a;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = comboCurrent.SelectedItem.ToString();
            string filePath = Path.Combine(DataFolder(), selectedFile + ".csv");
            LoadFlashcards(filePath);
        }
        private void LoadFlashcards(string filePath)
        {
            fPanelFlashcards.Controls.Clear();

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] input = line.Split('|');

                // Get the question from the 1st part of the split line
                string question = "";
                if (input.Length > 0)
                { 
                    question = input[0]; 
                }
                
                // Get the answer from the 2nd part of the split line
                string answer = "";
                if (input.Length > 1)
                {
                    answer = input[1];
                }
             
                // Creates panel (each individual flashcard)
                Panel card = new Panel { Width = 640, Height = 100, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(10) };

                // Creates text box for the "Question" part
                TextBox txtQuestion = new TextBox();
                txtQuestion.Text = question;
                txtQuestion.Name = "txtQuestion";
                txtQuestion.Multiline = true;
                txtQuestion.ForeColor = Color.Black;
                txtQuestion.Font = new Font("Palatino Linotype", 14, FontStyle.Bold);
                txtQuestion.Width = 280;
                txtQuestion.Height = 75;
                txtQuestion.Location = new Point(30, 10);

                // Creates text box for the "Answer" part
                TextBox txtAnswer = new TextBox();
                txtAnswer.Text = answer;
                txtAnswer.Name = "txtAnswer";
                txtAnswer.Multiline = true;
                txtAnswer.ForeColor = Color.Black;
                txtAnswer.Font = new Font("Palatino Linotype", 14, FontStyle.Bold);
                txtAnswer.Width = 280;
                txtAnswer.Height = 75;
                txtAnswer.Location = new Point(330, 10);

                // Adds the text boxes to the Panel, then adds Panel to FlowLayoutPanel so it scrolls
                card.Controls.Add(txtQuestion);
                card.Controls.Add(txtAnswer);
                fPanelFlashcards.Controls.Add(card);
            }
            
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.WindowState = this.WindowState;
            form.Show();
            this.Hide();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            // Create Panel for the new flashcard
            Panel flashcardPanel = new Panel();
            flashcardPanel.BorderStyle = BorderStyle.FixedSingle;
            flashcardPanel.Width = 640; 
            flashcardPanel.Height = 100;
            flashcardPanel.Margin = new Padding(10);

            // Create Question TextBox
            TextBox txtQuestion = new TextBox();
            txtQuestion.Text = "Enter question...";
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Multiline = true;
            txtQuestion.ForeColor = Color.Black;
            txtQuestion.Font = new Font("Palatino Linotype", 14, FontStyle.Bold);
            txtQuestion.Width = 280;
            txtQuestion.Height = 75;
            txtQuestion.Location = new Point(30, 10);

            // Create Answer TextBox
            TextBox txtAnswer = new TextBox();
            txtAnswer.Text = "Enter answer...";
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Multiline = true;
            txtAnswer.ForeColor = Color.Black;
            txtAnswer.Font = new Font("Palatino Linotype", 14, FontStyle.Bold);
            txtAnswer.Width = 280;
            txtAnswer.Height = 75;
            txtAnswer.Location = new Point(330, 10);

            // Add controls to panel
            flashcardPanel.Controls.Add(txtQuestion);
            flashcardPanel.Controls.Add(txtAnswer);

            // Add panel to FlowLayoutPanel
            fPanelFlashcards.Controls.Add(flashcardPanel);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Displays error message ff user tries to save, but doesn't choose a set to save it to
            if (comboCurrent.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flashcard set first.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            
            // Finds file path for the set that the user chose
            string setName = comboCurrent.SelectedItem.ToString();
            string filePath = Path.Combine(DataFolder(), setName + ".csv");

            StreamWriter sw = new StreamWriter(filePath);
            
            // Looks at each flashcard in the FlowLayoutPanel
            foreach (Control flashcardPanel in fPanelFlashcards.Controls)
            {
                // Make sure the variables we use to write to the csv file is empty
                string txtQuestion = "";
                string txtAnswer = "";

                // Go through each text box inside the panel, assign it to variables
                foreach (Control textBox in flashcardPanel.Controls)
                {

                    if (textBox is TextBox box1 && textBox.Name == "txtQuestion")
                    {
                        txtQuestion = box1.Text.ToString();
                    }
                    else if (textBox is TextBox box2 && textBox.Name == "txtAnswer")
                    {
                        txtAnswer = box2.Text.ToString();
                    }
                }

                // Save to file if flashcards have text
                if (txtQuestion.Trim() != "" && txtAnswer.Trim() != "")
                {
                    sw.WriteLine(txtQuestion + "|" + txtAnswer);
                    
                }
                // Displays error message if flashcards are empty
                else
                {
                    MessageBox.Show("You cannot save an empty card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sw.Close();
                    return;
                }
            }
            sw.Close();
            MessageBox.Show($"Your flashcards were saved to {setName}", "Success", MessageBoxButtons.OK);
        }
    }
}
