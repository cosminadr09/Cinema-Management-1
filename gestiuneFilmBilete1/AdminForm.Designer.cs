namespace gestiuneFilmBilete1
{
    partial class AdminForm
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
            this.createFilmButton = new System.Windows.Forms.Button();
            this.viewListFilmButton = new System.Windows.Forms.Button();
            this.updateFilmButton = new System.Windows.Forms.Button();
            this.deleteFilmButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.productionLabel = new System.Windows.Forms.Label();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.premiereDateLabel = new System.Windows.Forms.Label();
            this.scheduleDateLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.productionTextBox = new System.Windows.Forms.TextBox();
            this.distributionTextBox = new System.Windows.Forms.TextBox();
            this.premiereDateTextBox = new System.Windows.Forms.TextBox();
            this.scheduleDateTextBox = new System.Windows.Forms.TextBox();
            this.deadlineTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.noOfTicketsLabel = new System.Windows.Forms.Label();
            this.noOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createFilmButton
            // 
            this.createFilmButton.Location = new System.Drawing.Point(614, 194);
            this.createFilmButton.Name = "createFilmButton";
            this.createFilmButton.Size = new System.Drawing.Size(143, 37);
            this.createFilmButton.TabIndex = 0;
            this.createFilmButton.Text = "Create Film";
            this.createFilmButton.UseVisualStyleBackColor = true;
            this.createFilmButton.Click += new System.EventHandler(this.CreateFilmButton_Click);
            // 
            // viewListFilmButton
            // 
            this.viewListFilmButton.Location = new System.Drawing.Point(614, 279);
            this.viewListFilmButton.Name = "viewListFilmButton";
            this.viewListFilmButton.Size = new System.Drawing.Size(143, 41);
            this.viewListFilmButton.TabIndex = 1;
            this.viewListFilmButton.Text = "View list";
            this.viewListFilmButton.UseVisualStyleBackColor = true;
            this.viewListFilmButton.Click += new System.EventHandler(this.ViewListFilmButton_Click);
            // 
            // updateFilmButton
            // 
            this.updateFilmButton.Location = new System.Drawing.Point(614, 41);
            this.updateFilmButton.Name = "updateFilmButton";
            this.updateFilmButton.Size = new System.Drawing.Size(143, 37);
            this.updateFilmButton.TabIndex = 2;
            this.updateFilmButton.Text = "Update Film";
            this.updateFilmButton.UseVisualStyleBackColor = true;
            this.updateFilmButton.Click += new System.EventHandler(this.UpdateFilmButton_Click);
            // 
            // deleteFilmButton
            // 
            this.deleteFilmButton.Location = new System.Drawing.Point(614, 119);
            this.deleteFilmButton.Name = "deleteFilmButton";
            this.deleteFilmButton.Size = new System.Drawing.Size(143, 41);
            this.deleteFilmButton.TabIndex = 3;
            this.deleteFilmButton.Text = "Delete Film";
            this.deleteFilmButton.UseVisualStyleBackColor = true;
            this.deleteFilmButton.Click += new System.EventHandler(this.DeleteFilmButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(614, 368);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(143, 37);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(37, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.Location = new System.Drawing.Point(37, 79);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(76, 17);
            this.productionLabel.TabIndex = 6;
            this.productionLabel.Text = "Production";
            // 
            // distributionLabel
            // 
            this.distributionLabel.AutoSize = true;
            this.distributionLabel.Location = new System.Drawing.Point(37, 119);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Size = new System.Drawing.Size(79, 17);
            this.distributionLabel.TabIndex = 7;
            this.distributionLabel.Text = "Distribution";
            // 
            // premiereDateLabel
            // 
            this.premiereDateLabel.AutoSize = true;
            this.premiereDateLabel.Location = new System.Drawing.Point(37, 162);
            this.premiereDateLabel.Name = "premiereDateLabel";
            this.premiereDateLabel.Size = new System.Drawing.Size(99, 17);
            this.premiereDateLabel.TabIndex = 8;
            this.premiereDateLabel.Text = "Premiere Date";
            // 
            // scheduleDateLabel
            // 
            this.scheduleDateLabel.AutoSize = true;
            this.scheduleDateLabel.Location = new System.Drawing.Point(37, 201);
            this.scheduleDateLabel.Name = "scheduleDateLabel";
            this.scheduleDateLabel.Size = new System.Drawing.Size(110, 17);
            this.scheduleDateLabel.TabIndex = 9;
            this.scheduleDateLabel.Text = "Scheduled Hour";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Location = new System.Drawing.Point(37, 247);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(64, 17);
            this.deadlineLabel.TabIndex = 10;
            this.deadlineLabel.Text = "Deadline";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(193, 41);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(234, 22);
            this.titleTextBox.TabIndex = 11;
            // 
            // productionTextBox
            // 
            this.productionTextBox.Location = new System.Drawing.Point(192, 76);
            this.productionTextBox.Name = "productionTextBox";
            this.productionTextBox.Size = new System.Drawing.Size(234, 22);
            this.productionTextBox.TabIndex = 12;
            // 
            // distributionTextBox
            // 
            this.distributionTextBox.Location = new System.Drawing.Point(192, 116);
            this.distributionTextBox.Name = "distributionTextBox";
            this.distributionTextBox.Size = new System.Drawing.Size(234, 22);
            this.distributionTextBox.TabIndex = 13;
            // 
            // premiereDateTextBox
            // 
            this.premiereDateTextBox.Location = new System.Drawing.Point(193, 157);
            this.premiereDateTextBox.Name = "premiereDateTextBox";
            this.premiereDateTextBox.Size = new System.Drawing.Size(233, 22);
            this.premiereDateTextBox.TabIndex = 14;
            // 
            // scheduleDateTextBox
            // 
            this.scheduleDateTextBox.Location = new System.Drawing.Point(193, 201);
            this.scheduleDateTextBox.Name = "scheduleDateTextBox";
            this.scheduleDateTextBox.Size = new System.Drawing.Size(233, 22);
            this.scheduleDateTextBox.TabIndex = 15;
            // 
            // deadlineTextBox
            // 
            this.deadlineTextBox.Location = new System.Drawing.Point(194, 244);
            this.deadlineTextBox.Name = "deadlineTextBox";
            this.deadlineTextBox.Size = new System.Drawing.Size(233, 22);
            this.deadlineTextBox.TabIndex = 16;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(194, 330);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(235, 22);
            this.newNameTextBox.TabIndex = 17;
            // 
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Location = new System.Drawing.Point(194, 368);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(235, 22);
            this.newUsernameTextBox.TabIndex = 18;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(194, 405);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(235, 22);
            this.newPasswordTextBox.TabIndex = 19;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(37, 330);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(45, 17);
            this.newNameLabel.TabIndex = 20;
            this.newNameLabel.Text = "Name";
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(37, 368);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.newUsernameLabel.TabIndex = 21;
            this.newUsernameLabel.Text = "Username";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(37, 405);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.newPasswordLabel.TabIndex = 22;
            this.newPasswordLabel.Text = "Password";
            // 
            // noOfTicketsLabel
            // 
            this.noOfTicketsLabel.AutoSize = true;
            this.noOfTicketsLabel.Location = new System.Drawing.Point(37, 291);
            this.noOfTicketsLabel.Name = "noOfTicketsLabel";
            this.noOfTicketsLabel.Size = new System.Drawing.Size(123, 17);
            this.noOfTicketsLabel.TabIndex = 23;
            this.noOfTicketsLabel.Text = "Number of Tickets";
            // 
            // noOfTicketsTextBox
            // 
            this.noOfTicketsTextBox.Location = new System.Drawing.Point(195, 286);
            this.noOfTicketsTextBox.Name = "noOfTicketsTextBox";
            this.noOfTicketsTextBox.Size = new System.Drawing.Size(230, 22);
            this.noOfTicketsTextBox.TabIndex = 24;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noOfTicketsTextBox);
            this.Controls.Add(this.noOfTicketsLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newUsernameLabel);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newUsernameTextBox);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.deadlineTextBox);
            this.Controls.Add(this.scheduleDateTextBox);
            this.Controls.Add(this.premiereDateTextBox);
            this.Controls.Add(this.distributionTextBox);
            this.Controls.Add(this.productionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.scheduleDateLabel);
            this.Controls.Add(this.premiereDateLabel);
            this.Controls.Add(this.distributionLabel);
            this.Controls.Add(this.productionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.deleteFilmButton);
            this.Controls.Add(this.updateFilmButton);
            this.Controls.Add(this.viewListFilmButton);
            this.Controls.Add(this.createFilmButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createFilmButton;
        private System.Windows.Forms.Button viewListFilmButton;
        private System.Windows.Forms.Button updateFilmButton;
        private System.Windows.Forms.Button deleteFilmButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.Label premiereDateLabel;
        private System.Windows.Forms.Label scheduleDateLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox productionTextBox;
        private System.Windows.Forms.TextBox distributionTextBox;
        private System.Windows.Forms.TextBox premiereDateTextBox;
        private System.Windows.Forms.TextBox scheduleDateTextBox;
        private System.Windows.Forms.TextBox deadlineTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label noOfTicketsLabel;
        private System.Windows.Forms.TextBox noOfTicketsTextBox;
    }
}