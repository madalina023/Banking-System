namespace banking_system.forms
{
    partial class SignUpFormUserData
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
            this.signUpLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLabel.Location = new System.Drawing.Point(628, 24);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(240, 66);
            this.signUpLabel.TabIndex = 7;
            this.signUpLabel.Text = "SIGN UP";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(559, 163);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(87, 19);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(563, 201);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(345, 27);
            this.firstNameTextBox.TabIndex = 8;
            this.firstNameTextBox.Text = "Enter your first name...";
            this.firstNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleFirstNameTextBoxMouseClickEvent);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleFirstNameTextBoxTypingEvent);
            this.firstNameTextBox.Leave += new System.EventHandler(this.HandleFirstNameTextBoxCursorExitedEvent);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(559, 262);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 19);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(563, 300);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(345, 27);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.Text = "Enter your last name...";
            this.lastNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleLastNameMouseClickEvent);
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleLastNameTextBoxTypingEvent);
            this.lastNameTextBox.Leave += new System.EventHandler(this.HandleLastNameTextBoxCursorExitedEvent);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(559, 364);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 19);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.usernameTextBox.Location = new System.Drawing.Point(563, 402);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(345, 27);
            this.usernameTextBox.TabIndex = 12;
            this.usernameTextBox.Text = "Enter an username...";
            this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleUsernameTextBoxClickEvent);
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleUsernameTextBoxTypingEvent);
            this.usernameTextBox.Leave += new System.EventHandler(this.HandleUsernameTextBoxCursorExitedEvent);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(559, 462);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.passwordTextBox.Location = new System.Drawing.Point(563, 500);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(345, 27);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.Text = "Enter your password...";
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandlePasswordTextBoxClickEvent);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandlePasswordTextBoxTypingEvent);
            this.passwordTextBox.Leave += new System.EventHandler(this.HandlePasswordTextBoxCursorExitedEvent);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(559, 559);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(140, 19);
            this.confirmPasswordLabel.TabIndex = 17;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(563, 597);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(345, 27);
            this.confirmPasswordTextBox.TabIndex = 16;
            this.confirmPasswordTextBox.Text = "Confirm your password...";
            this.confirmPasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleConfirmPasswordTextBoxClickEvent);
            this.confirmPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleConfirmPasswordTextBoxTypingEvent);
            this.confirmPasswordTextBox.Leave += new System.EventHandler(this.HandleConfirmPasswordTextBoxCursorExitedEvent);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(629, 766);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(191, 46);
            this.nextPageButton.TabIndex = 18;
            this.nextPageButton.Text = "Register";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleRegistration);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(629, 851);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(191, 45);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.HandleBackButtonClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(2)))));
            this.errorLabel.Location = new System.Drawing.Point(559, 692);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(53, 19);
            this.errorLabel.TabIndex = 20;
            this.errorLabel.Text = "label1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // SignUpFormUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 923);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.signUpLabel);
            this.Name = "SignUpFormUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.HandleSignUpFormUserDataLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label errorLabel;
    }
}