using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletGUI
{
    public partial class FormStudy : Form
    {
        private List<(string Question, string Answer)> flashcards = new List<(string, string)>();
        private int index = 0;
        private bool showsQuestion = true;

        public FormStudy()
        {
            InitializeComponent();

            // Changes the title based on which set the user selected
            lblTitle.Text = "Current Set: " + Form1.SelectedSetName;
           
            LoadCards();
            
            DisplayCard();
        }

        private void LoadCards()
        {
            string filePath = Path.Combine(DataFolder(), Form1.SelectedSetName+".csv");
            string[] data = File.ReadAllLines(filePath);

            // Adds all flashcards from selected set to a list
            foreach (string line in data)
            {
                string[] QueAns = line.Split('|');
                if (QueAns.Length == 2)
                {
                    flashcards.Add((QueAns[0].Trim(), QueAns[1].Trim()));
                }
                else
                {
                    MessageBox.Show($"Invalid line: \"{line}\".\nPlease remove any \"|\" or newlines from this card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
            }
        }

        private void DisplayCard()
        {
            // Initially displays first card, is also used to "flip" the card and display the next card
            (string Question, string Answer) card = flashcards[index];
            if (showsQuestion)
            {
                txtFlashcard.Text = card.Question;
                lblQorA.Text = "Question";
            }
            else
            {
                txtFlashcard.Text = card.Answer;
                lblQorA.Text = "Answer";
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.WindowState = this.WindowState;
            form.Show();
            this.Hide();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            // Changes boolean variable to its opposite, and displays the other side of the card
            showsQuestion = !showsQuestion;
            DisplayCard();
        }

        private void btnNextCard_Click(object sender, EventArgs e)
        {
            // Displays current card number & goes back to first card if user goes through all cards
            index++;
            if (index >= flashcards.Count)
            {
                index = 0; 
                MessageBox.Show("You have seen every card in this set!", "Congrats", MessageBoxButtons.OK);
                lblIndex.Text = $"#{index + 1}";
            }
            lblIndex.Text = $"#{index + 1}";

            // Displays the "Question" side of the next card
            showsQuestion = true;
            DisplayCard();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Displays current card number & displays error message if pressed while at first card
            index--;
            if (index < 0)
            {
                index = flashcards.Count-1;
            }
            lblIndex.Text = $"#{index+1}";

            // Displays the "Question" side of the previous card
            showsQuestion = true;
            DisplayCard();
        }
    }
}
