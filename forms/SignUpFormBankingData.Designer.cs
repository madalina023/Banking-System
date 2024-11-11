namespace banking_system.forms
{
    partial class SignUpFormBankingData
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
            this.bankingDataLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cardOwnerLabel = new System.Windows.Forms.Label();
            this.cardOwnerTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.expiryDateTextBox = new System.Windows.Forms.TextBox();
            this.securityCodeLabel = new System.Windows.Forms.Label();
            this.securityCodeTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bankingDataLabel
            // 
            this.bankingDataLabel.AutoSize = true;
            this.bankingDataLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankingDataLabel.Location = new System.Drawing.Point(518, 69);
            this.bankingDataLabel.Name = "bankingDataLabel";
            this.bankingDataLabel.Size = new System.Drawing.Size(424, 66);
            this.bankingDataLabel.TabIndex = 8;
            this.bankingDataLabel.Text = "BANKING DATA";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumberLabel.Location = new System.Drawing.Point(550, 268);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(106, 19);
            this.cardNumberLabel.TabIndex = 10;
            this.cardNumberLabel.Text = "Card Number";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cardNumberTextBox.Location = new System.Drawing.Point(554, 303);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(345, 27);
            this.cardNumberTextBox.TabIndex = 11;
            this.cardNumberTextBox.Text = "1234 5678 9012 3456";
            this.cardNumberTextBox.Click += new System.EventHandler(this.HandleCardNumberTextBoxClickEvent);
            this.cardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleCardNumberTextBoxTypingEvent);
            this.cardNumberTextBox.Leave += new System.EventHandler(this.HandleCardNumberTextBoxCursorExitedEvent);
            // 
            // cardOwnerLabel
            // 
            this.cardOwnerLabel.AutoSize = true;
            this.cardOwnerLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardOwnerLabel.Location = new System.Drawing.Point(550, 360);
            this.cardOwnerLabel.Name = "cardOwnerLabel";
            this.cardOwnerLabel.Size = new System.Drawing.Size(96, 19);
            this.cardOwnerLabel.TabIndex = 12;
            this.cardOwnerLabel.Text = "Card Owner";
            // 
            // cardOwnerTextBox
            // 
            this.cardOwnerTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardOwnerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cardOwnerTextBox.Location = new System.Drawing.Point(554, 397);
            this.cardOwnerTextBox.Name = "cardOwnerTextBox";
            this.cardOwnerTextBox.Size = new System.Drawing.Size(345, 27);
            this.cardOwnerTextBox.TabIndex = 13;
            this.cardOwnerTextBox.Text = "Ex. John Doe";
            this.cardOwnerTextBox.Click += new System.EventHandler(this.HandleCardOwnerTextBoxClickEvent);
            this.cardOwnerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleCardOwnerTextBoxTypingEvent);
            this.cardOwnerTextBox.Leave += new System.EventHandler(this.HandleCardOwnerTextBoxCursorExitedEvent);
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateLabel.Location = new System.Drawing.Point(550, 456);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(91, 19);
            this.expiryDateLabel.TabIndex = 14;
            this.expiryDateLabel.Text = "Expiry Date";
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.expiryDateTextBox.Location = new System.Drawing.Point(554, 495);
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.Size = new System.Drawing.Size(121, 27);
            this.expiryDateTextBox.TabIndex = 15;
            this.expiryDateTextBox.Text = "01/19";
            this.expiryDateTextBox.Click += new System.EventHandler(this.HandleExpiryDateTextBoxClickEvent);
            this.expiryDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleExpiryDateTextBoxTypingEvent);
            this.expiryDateTextBox.Leave += new System.EventHandler(this.HandleExpiryDateTextBoxCursorExitedEvent);
            // 
            // securityCodeLabel
            // 
            this.securityCodeLabel.AutoSize = true;
            this.securityCodeLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.securityCodeLabel.Location = new System.Drawing.Point(774, 456);
            this.securityCodeLabel.Name = "securityCodeLabel";
            this.securityCodeLabel.Size = new System.Drawing.Size(112, 19);
            this.securityCodeLabel.TabIndex = 16;
            this.securityCodeLabel.Text = "Security Code";
            // 
            // securityCodeTextBox
            // 
            this.securityCodeTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.securityCodeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.securityCodeTextBox.Location = new System.Drawing.Point(778, 495);
            this.securityCodeTextBox.Name = "securityCodeTextBox";
            this.securityCodeTextBox.Size = new System.Drawing.Size(121, 27);
            this.securityCodeTextBox.TabIndex = 17;
            this.securityCodeTextBox.Text = "***";
            this.securityCodeTextBox.Click += new System.EventHandler(this.HandleSecurityCodeTextBoxClickEvent);
            this.securityCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleSecurityCodeTextBoxTypingEvent);
            this.securityCodeTextBox.Leave += new System.EventHandler(this.HandleSecurityCodeTextBoxCursorExitedEvent);
            // 
            // registerButton
            // 
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerButton.FlatAppearance.BorderSize = 1230;
            this.registerButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(622, 678);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(219, 51);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.HandleRegisterButton);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(2)))));
            this.errorLabel.Location = new System.Drawing.Point(550, 608);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(53, 19);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "label1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.FlatAppearance.BorderSize = 1230;
            this.backButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(622, 766);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(219, 51);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.HandleBackButtonClick);
            // 
            // SignUpFormBankingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 921);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.securityCodeTextBox);
            this.Controls.Add(this.securityCodeLabel);
            this.Controls.Add(this.expiryDateTextBox);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.cardOwnerTextBox);
            this.Controls.Add(this.cardOwnerLabel);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.bankingDataLabel);
            this.Name = "SignUpFormBankingData";
            this.Text = "SignUpFormBankingData";
            this.Load += new System.EventHandler(this.HandleSignUpFormBankingDataLoad);
            this.Click += new System.EventHandler(this.HandleCardOwnerTextBoxClickEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankingDataLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label cardOwnerLabel;
        private System.Windows.Forms.TextBox cardOwnerTextBox;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.TextBox expiryDateTextBox;
        private System.Windows.Forms.Label securityCodeLabel;
        private System.Windows.Forms.TextBox securityCodeTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
    }
}