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
    public partial class FormCreateSet : Form
    {
        public FormCreateSet()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.WindowState = this.WindowState;
            form.Show();
            this.Hide();
        }
        private string DataFolder()
        {
            // Creates absolute path because I kept creating the csv file in wrong place, used Stack Overflow
            string a = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\data"));
            return a;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Ensure user enters a name before creating the set
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please name your flashcard set before continuing.", "Error: Unnamed Set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Text = "";
                txtName.Focus();
                return;
            }

            // Assign variable + Get file path with the name of the new csv file
            string setName = txtName.Text.Trim();
            string filePath = Path.Combine(DataFolder(), setName + ".csv");

            // Ensure no other sets have the same name
            if (File.Exists(filePath))
            {
                MessageBox.Show("A flashcard set with this name already exists!", "Duplicate Set", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            // Creates csv file 
            File.WriteAllText(filePath, "");

            // MessageBox.Show("Created file at:\n" + filePath);

            var form = new FormEditSet();
            form.WindowState = this.WindowState; 
            form.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Focus();
        }
    }
}
