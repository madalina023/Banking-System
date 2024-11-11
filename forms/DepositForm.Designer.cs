namespace banking_system.forms
{
    partial class DepositForm
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
            this.components = new System.ComponentModel.Container();
            this.depositLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cardOwnerTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositLabel.Location = new System.Drawing.Point(358, 38);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(255, 66);
            this.depositLabel.TabIndex = 8;
            this.depositLabel.Text = "DEPOSIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your deposit value:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(12, 175);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(287, 26);
            this.amountTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter your card number:";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(12, 269);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(287, 26);
            this.cardNumberTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter the card owner:";
            // 
            // cardOwnerTextBox
            // 
            this.cardOwnerTextBox.Location = new System.Drawing.Point(12, 372);
            this.cardOwnerTextBox.Name = "cardOwnerTextBox";
            this.cardOwnerTextBox.Size = new System.Drawing.Size(287, 26);
            this.cardOwnerTextBox.TabIndex = 14;
            // 
            // depositButton
            // 
            this.depositButton.FlatAppearance.BorderSize = 1230;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depositButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depositButton.Location = new System.Drawing.Point(369, 513);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(219, 51);
            this.depositButton.TabIndex = 15;
            this.depositButton.Text = "Deposit";
            this.depositButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.HandleDepositButtonClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(2)))));
            this.errorLabel.Location = new System.Drawing.Point(451, 450);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(53, 19);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "label1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 1230;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(369, 603);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(219, 51);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.HandleBackButtonClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.menuStrip1.Size = new System.Drawing.Size(945, 33);
            this.menuStrip1.TabIndex = 23;
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
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.cardOwnerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardOwnerTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsCSVToolStripMenuItem;
    }
}