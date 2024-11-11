using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace banking_system
{
    partial class SignInForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.usernameTextBox.Location = new System.Drawing.Point(499, 248);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(345, 27);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "Type your username...";
            this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleUsernameTextBoxClick);
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleUsernameTextBoxTyping);
            this.usernameTextBox.Leave += new System.EventHandler(this.HandleUsernameTextBoxPointerLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.passwordTextBox.Location = new System.Drawing.Point(499, 357);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(345, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Type your password...";
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandlePasswordTextBoxClick);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandlePasswordTextBoxTyping);
            this.passwordTextBox.Leave += new System.EventHandler(this.HandlePasswordTextBoxPointerLeave);
            // 
            // signInButton
            // 
            this.signInButton.FlatAppearance.BorderSize = 1230;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signInButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signInButton.Location = new System.Drawing.Point(562, 538);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(219, 51);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In ";
            this.signInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleSignInButtonClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Location = new System.Drawing.Point(495, 210);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 19);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(495, 320);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // signUpButton
            // 
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signUpButton.FlatAppearance.BorderSize = 1230;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(562, 620);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(219, 51);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.HandleSignUpButtonClick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Transparent;
            this.loginLabel.Location = new System.Drawing.Point(587, 46);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(194, 66);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "LOGIN";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(15)))), ((int)(((byte)(2)))));
            this.errorLabel.Location = new System.Drawing.Point(495, 443);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(53, 19);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "label1";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 767);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SignInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HandleSignInFormLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Button signUpButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

