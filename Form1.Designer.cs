namespace QuizletGUI
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboCurrent = new System.Windows.Forms.ComboBox();
            this.lblSelectSet = new System.Windows.Forms.Label();
            this.btnStudySet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(554, 96);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 101);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quizler";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateNew.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateNew.FlatAppearance.BorderSize = 2;
            this.btnCreateNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnCreateNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateNew.Location = new System.Drawing.Point(142, 304);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(451, 151);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.TabStop = false;
            this.btnCreateNew.Text = "Create New Flashcard Set";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStudy.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStudy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStudy.FlatAppearance.BorderSize = 2;
            this.btnStudy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnStudy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnStudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudy.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudy.Location = new System.Drawing.Point(798, 384);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(451, 151);
            this.btnStudy.TabIndex = 3;
            this.btnStudy.TabStop = false;
            this.btnStudy.Text = "Study Existing Flashcard Sets";
            this.btnStudy.UseVisualStyleBackColor = false;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1202, 784);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 93);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 784);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 93);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(142, 501);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(451, 151);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit Existing Flashcard Set";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboCurrent
            // 
            this.comboCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboCurrent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboCurrent.DropDownHeight = 200;
            this.comboCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCurrent.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.comboCurrent.FormattingEnabled = true;
            this.comboCurrent.IntegralHeight = false;
            this.comboCurrent.ItemHeight = 58;
            this.comboCurrent.Location = new System.Drawing.Point(459, 293);
            this.comboCurrent.MaxDropDownItems = 30;
            this.comboCurrent.Name = "comboCurrent";
            this.comboCurrent.Size = new System.Drawing.Size(830, 66);
            this.comboCurrent.TabIndex = 22;
            this.comboCurrent.Visible = false;
            // 
            // lblSelectSet
            // 
            this.lblSelectSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelectSet.AutoSize = true;
            this.lblSelectSet.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.lblSelectSet.Location = new System.Drawing.Point(126, 290);
            this.lblSelectSet.Name = "lblSelectSet";
            this.lblSelectSet.Size = new System.Drawing.Size(312, 79);
            this.lblSelectSet.TabIndex = 21;
            this.lblSelectSet.Text = "Select Set:";
            this.lblSelectSet.Visible = false;
            // 
            // btnStudySet
            // 
            this.btnStudySet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStudySet.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStudySet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStudySet.FlatAppearance.BorderSize = 2;
            this.btnStudySet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnStudySet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnStudySet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudySet.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudySet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudySet.Location = new System.Drawing.Point(473, 450);
            this.btnStudySet.Name = "btnStudySet";
            this.btnStudySet.Size = new System.Drawing.Size(468, 151);
            this.btnStudySet.TabIndex = 23;
            this.btnStudySet.TabStop = false;
            this.btnStudySet.Text = "Study Selected Set";
            this.btnStudySet.UseVisualStyleBackColor = false;
            this.btnStudySet.Visible = false;
            this.btnStudySet.Click += new System.EventHandler(this.btnStudySet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1414, 889);
            this.Controls.Add(this.btnStudySet);
            this.Controls.Add(this.comboCurrent);
            this.Controls.Add(this.lblSelectSet);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboCurrent;
        private System.Windows.Forms.Label lblSelectSet;
        private System.Windows.Forms.Button btnStudySet;
    }
}

