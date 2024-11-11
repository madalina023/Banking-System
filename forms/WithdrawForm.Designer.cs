namespace banking_system.forms
{
    partial class WithdrawForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.cardOwnerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 1230;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(395, 609);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(219, 51);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(2)))));
            this.errorLabel.Location = new System.Drawing.Point(477, 456);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(53, 19);
            this.errorLabel.TabIndex = 31;
            this.errorLabel.Text = "label1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // withdrawButton
            // 
            this.withdrawButton.FlatAppearance.BorderSize = 1230;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.withdrawButton.Location = new System.Drawing.Point(395, 519);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(219, 51);
            this.withdrawButton.TabIndex = 30;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.HandleWithdrawButton);
            // 
            // cardOwnerTextBox
            // 
            this.cardOwnerTextBox.Location = new System.Drawing.Point(12, 391);
            this.cardOwnerTextBox.Name = "cardOwnerTextBox";
            this.cardOwnerTextBox.Size = new System.Drawing.Size(287, 26);
            this.cardOwnerTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter the card owner:";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(12, 288);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(287, 26);
            this.cardNumberTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter your card number:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(12, 194);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(287, 26);
            this.amountTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter your withdrawal value:";
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawLabel.Location = new System.Drawing.Point(356, 44);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(338, 66);
            this.withdrawLabel.TabIndex = 23;
            this.withdrawLabel.Text = "WITHDRAW";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 33);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.saveAsCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // saveAsCSVToolStripMenuItem
            // 
            this.saveAsCSVToolStripMenuItem.Name = "saveAsCSVToolStripMenuItem";
            this.saveAsCSVToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveAsCSVToolStripMenuItem.Text = "Save As CSV";
            this.saveAsCSVToolStripMenuItem.Click += new System.EventHandler(this.saveAsCSVToolStripMenuItem_Click);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 694);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.cardOwnerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawLabel);
            this.Name = "WithdrawForm";
            this.Text = "Withdraw";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox cardOwnerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsCSVToolStripMenuItem;
    }
}