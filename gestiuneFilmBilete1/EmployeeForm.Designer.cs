namespace gestiuneFilmBilete1
{
    partial class EmployeeForm
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
            this.addTicketsButton = new System.Windows.Forms.Button();
            this.viewListButton = new System.Windows.Forms.Button();
            this.exportListButton = new System.Windows.Forms.Button();
            this.noOfTicketsLabel = new System.Windows.Forms.Label();
            this.filmNameLabel = new System.Windows.Forms.Label();
            this.noOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.filmNameTextBox = new System.Windows.Forms.TextBox();
            this.rowNumberLabel = new System.Windows.Forms.Label();
            this.seatNumberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTicketsButton
            // 
            this.addTicketsButton.Location = new System.Drawing.Point(87, 56);
            this.addTicketsButton.Name = "addTicketsButton";
            this.addTicketsButton.Size = new System.Drawing.Size(178, 47);
            this.addTicketsButton.TabIndex = 0;
            this.addTicketsButton.Text = "Add Tickets";
            this.addTicketsButton.UseVisualStyleBackColor = true;
            this.addTicketsButton.Click += new System.EventHandler(this.AddTicketsButton_Click);
            // 
            // viewListButton
            // 
            this.viewListButton.Location = new System.Drawing.Point(87, 134);
            this.viewListButton.Name = "viewListButton";
            this.viewListButton.Size = new System.Drawing.Size(178, 49);
            this.viewListButton.TabIndex = 1;
            this.viewListButton.Text = "View List";
            this.viewListButton.UseVisualStyleBackColor = true;
            this.viewListButton.Click += new System.EventHandler(this.ViewListButton_Click);
            // 
            // exportListButton
            // 
            this.exportListButton.Location = new System.Drawing.Point(87, 226);
            this.exportListButton.Name = "exportListButton";
            this.exportListButton.Size = new System.Drawing.Size(178, 45);
            this.exportListButton.TabIndex = 2;
            this.exportListButton.Text = "Export List";
            this.exportListButton.UseVisualStyleBackColor = true;
            this.exportListButton.Click += new System.EventHandler(this.ExportListButton_Click);
            // 
            // noOfTicketsLabel
            // 
            this.noOfTicketsLabel.AutoSize = true;
            this.noOfTicketsLabel.Location = new System.Drawing.Point(336, 56);
            this.noOfTicketsLabel.Name = "noOfTicketsLabel";
            this.noOfTicketsLabel.Size = new System.Drawing.Size(118, 17);
            this.noOfTicketsLabel.TabIndex = 3;
            this.noOfTicketsLabel.Text = "Number of tickets";
            // 
            // filmNameLabel
            // 
            this.filmNameLabel.AutoSize = true;
            this.filmNameLabel.Location = new System.Drawing.Point(336, 114);
            this.filmNameLabel.Name = "filmNameLabel";
            this.filmNameLabel.Size = new System.Drawing.Size(72, 17);
            this.filmNameLabel.TabIndex = 4;
            this.filmNameLabel.Text = "Film name";
            // 
            // noOfTicketsTextBox
            // 
            this.noOfTicketsTextBox.Location = new System.Drawing.Point(460, 56);
            this.noOfTicketsTextBox.Name = "noOfTicketsTextBox";
            this.noOfTicketsTextBox.Size = new System.Drawing.Size(195, 22);
            this.noOfTicketsTextBox.TabIndex = 5;
            // 
            // filmNameTextBox
            // 
            this.filmNameTextBox.Location = new System.Drawing.Point(460, 114);
            this.filmNameTextBox.Name = "filmNameTextBox";
            this.filmNameTextBox.Size = new System.Drawing.Size(195, 22);
            this.filmNameTextBox.TabIndex = 6;
            // 
            // rowNumberLabel
            // 
            this.rowNumberLabel.AutoSize = true;
            this.rowNumberLabel.Location = new System.Drawing.Point(336, 176);
            this.rowNumberLabel.Name = "rowNumberLabel";
            this.rowNumberLabel.Size = new System.Drawing.Size(89, 17);
            this.rowNumberLabel.TabIndex = 7;
            this.rowNumberLabel.Text = "Row Number";
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.AutoSize = true;
            this.seatNumberLabel.Location = new System.Drawing.Point(336, 226);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(91, 17);
            this.seatNumberLabel.TabIndex = 8;
            this.seatNumberLabel.Text = "Seat Number";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(336, 274);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date";
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(460, 173);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(195, 22);
            this.rowTextBox.TabIndex = 10;
            // 
            // seatTextBox
            // 
            this.seatTextBox.Location = new System.Drawing.Point(460, 223);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(195, 22);
            this.seatTextBox.TabIndex = 11;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(460, 274);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(195, 22);
            this.dateTextBox.TabIndex = 12;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.seatNumberLabel);
            this.Controls.Add(this.rowNumberLabel);
            this.Controls.Add(this.filmNameTextBox);
            this.Controls.Add(this.noOfTicketsTextBox);
            this.Controls.Add(this.filmNameLabel);
            this.Controls.Add(this.noOfTicketsLabel);
            this.Controls.Add(this.exportListButton);
            this.Controls.Add(this.viewListButton);
            this.Controls.Add(this.addTicketsButton);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTicketsButton;
        private System.Windows.Forms.Button viewListButton;
        private System.Windows.Forms.Button exportListButton;
        private System.Windows.Forms.Label noOfTicketsLabel;
        private System.Windows.Forms.Label filmNameLabel;
        private System.Windows.Forms.TextBox noOfTicketsTextBox;
        private System.Windows.Forms.TextBox filmNameTextBox;
        private System.Windows.Forms.Label rowNumberLabel;
        private System.Windows.Forms.Label seatNumberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
    }
}