namespace QuizletGUI
{
    partial class FormStudy
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnNextCard = new System.Windows.Forms.Button();
            this.txtFlashcard = new System.Windows.Forms.TextBox();
            this.lblQorA = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1390, 101);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quizler";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(12, 784);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 93);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFlip.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFlip.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFlip.FlatAppearance.BorderSize = 2;
            this.btnFlip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnFlip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFlip.Location = new System.Drawing.Point(1070, 348);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(305, 124);
            this.btnFlip.TabIndex = 8;
            this.btnFlip.TabStop = false;
            this.btnFlip.Text = "Flip Card";
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnNextCard
            // 
            this.btnNextCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextCard.FlatAppearance.BorderSize = 2;
            this.btnNextCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnNextCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnNextCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCard.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextCard.Location = new System.Drawing.Point(731, 633);
            this.btnNextCard.Name = "btnNextCard";
            this.btnNextCard.Size = new System.Drawing.Size(451, 151);
            this.btnNextCard.TabIndex = 9;
            this.btnNextCard.TabStop = false;
            this.btnNextCard.Text = "Next Card -->";
            this.btnNextCard.UseVisualStyleBackColor = false;
            this.btnNextCard.Click += new System.EventHandler(this.btnNextCard_Click);
            // 
            // txtFlashcard
            // 
            this.txtFlashcard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFlashcard.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtFlashcard.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.txtFlashcard.ForeColor = System.Drawing.Color.White;
            this.txtFlashcard.Location = new System.Drawing.Point(390, 249);
            this.txtFlashcard.Multiline = true;
            this.txtFlashcard.Name = "txtFlashcard";
            this.txtFlashcard.ReadOnly = true;
            this.txtFlashcard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFlashcard.Size = new System.Drawing.Size(635, 322);
            this.txtFlashcard.TabIndex = 10;
            this.txtFlashcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQorA
            // 
            this.lblQorA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQorA.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.lblQorA.Location = new System.Drawing.Point(390, 145);
            this.lblQorA.Name = "lblQorA";
            this.lblQorA.Size = new System.Drawing.Size(635, 101);
            this.lblQorA.TabIndex = 11;
            this.lblQorA.Text = "\"Question\" or \"Answer\"";
            this.lblQorA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIndex.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.lblIndex.Location = new System.Drawing.Point(390, 145);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(130, 101);
            this.lblIndex.TabIndex = 12;
            this.lblIndex.Text = "#1";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevious.Location = new System.Drawing.Point(250, 633);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(451, 151);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<-- Previous Card";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // FormStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1414, 889);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblQorA);
            this.Controls.Add(this.txtFlashcard);
            this.Controls.Add(this.btnNextCard);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormStudy";
            this.Text = "FormStudy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnNextCard;
        private System.Windows.Forms.TextBox txtFlashcard;
        private System.Windows.Forms.Label lblQorA;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnPrevious;
    }
}