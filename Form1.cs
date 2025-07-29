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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var form = new FormCreateSet();
            form.WindowState = this.WindowState; // Keeps it fullscreen if it already is when pressed
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Ensures that at least 1 set exists
            LoadSets(DataFolder());
            if (comboCurrent.Items.Count == 0)
            {
                MessageBox.Show("No flashcard sets found.\nPlease go to the menu and one first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new FormEditSet();
            form.WindowState = this.WindowState; // Keeps it fullscreen if it already is when pressed
            form.Show();
            this.Hide();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            comboCurrent.Show();
            lblSelectSet.Show();
            btnBack.Show();
            btnStudySet.Show();
            btnCreateNew.Hide();
            btnEdit.Hide();
            btnStudy.Hide();
            LoadSets(DataFolder());
        }

        private void LoadSets(string filePath)
        {
            comboCurrent.Items.Clear();
            string[] files = Directory.GetFiles(filePath);

            // Got outside help in order for the newest sets show first
            files = files.OrderByDescending(f => File.GetCreationTime(f)).ToArray();
            
            foreach (string file in files)
            {
                // Adds each file name to the dropdown list
                comboCurrent.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private string DataFolder()
        {
            string a = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\data"));
            return a;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            comboCurrent.Hide();
            lblSelectSet.Hide();
            btnStudySet.Hide();
            btnBack.Hide();
            btnCreateNew.Show();
            btnEdit.Show();
            btnStudy.Show();
        }

        // Global variable will be used in FormStudy
        public static string SelectedSetName; 

        private void btnStudySet_Click(object sender, EventArgs e)
        {
            // Shows error messagebox if user doesn't choose a set
            if (comboCurrent.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flashcard set before continuing.", "Error: No Set Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            SelectedSetName = comboCurrent.SelectedItem.ToString();
            string filePath = Path.Combine(DataFolder(), SelectedSetName + ".csv");
            string[] data = File.ReadAllLines(filePath);
            
            // Shows error message if user tries to study an empty set
            if (data.Length == 0)
            {
                MessageBox.Show("No flashcards found in this set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var form = new FormStudy();
            form.WindowState = this.WindowState; // Keeps it fullscreen if it already is  when pressed
            form.Show();
            this.Hide();
        }
    }
}
