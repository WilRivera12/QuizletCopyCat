namespace QuizletGUI
{
    partial class FormEditSet
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
            this.fPanelFlashcards = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentSet = new System.Windows.Forms.Label();
            this.comboCurrent = new System.Windows.Forms.ComboBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 101);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Edit Set";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fPanelFlashcards
            // 
            this.fPanelFlashcards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fPanelFlashcards.AutoScroll = true;
            this.fPanelFlashcards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fPanelFlashcards.Location = new System.Drawing.Point(12, 182);
            this.fPanelFlashcards.Name = "fPanelFlashcards";
            this.fPanelFlashcards.Size = new System.Drawing.Size(1390, 596);
            this.fPanelFlashcards.TabIndex = 17;
            this.fPanelFlashcards.WrapContents = false;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnAddCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCard.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCard.Location = new System.Drawing.Point(289, 784);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(389, 93);
            this.btnAddCard.TabIndex = 17;
            this.btnAddCard.Text = "Add Flashcard";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(755, 784);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(368, 93);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1200, 784);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 93);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentSet
            // 
            this.lblCurrentSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurrentSet.AutoSize = true;
            this.lblCurrentSet.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSet.Location = new System.Drawing.Point(427, 43);
            this.lblCurrentSet.Name = "lblCurrentSet";
            this.lblCurrentSet.Size = new System.Drawing.Size(232, 51);
            this.lblCurrentSet.TabIndex = 19;
            this.lblCurrentSet.Text = "Current Set:";
            // 
            // comboCurrent
            // 
            this.comboCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboCurrent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCurrent.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCurrent.FormattingEnabled = true;
            this.comboCurrent.Location = new System.Drawing.Point(675, 49);
            this.comboCurrent.MaxDropDownItems = 30;
            this.comboCurrent.Name = "comboCurrent";
            this.comboCurrent.Size = new System.Drawing.Size(656, 44);
            this.comboCurrent.TabIndex = 20;
            this.comboCurrent.SelectedIndexChanged += new System.EventHandler(this.comboCurrent_SelectedIndexChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMainMenu.FlatAppearance.BorderSize = 2;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 784);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 93);
            this.btnMainMenu.TabIndex = 21;
            this.btnMainMenu.Text = "Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "Questions:                                      |  Answers:";
            // 
            // FormEditSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1414, 889);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.comboCurrent);
            this.Controls.Add(this.lblCurrentSet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.fPanelFlashcards);
            this.Name = "FormEditSet";
            this.Text = "FormEditSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel fPanelFlashcards;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentSet;
        private System.Windows.Forms.ComboBox comboCurrent;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
    }
}