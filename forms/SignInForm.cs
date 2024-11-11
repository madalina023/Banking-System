using banking_system.forms;
using banking_system.models;
using banking_system.persistence;
using banking_system.service;
using banking_system.utils;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace banking_system
{

    public partial class SignInForm : Form {

        private UserService UserService;
        private ValidationService ValidationService;

        public SignInForm() {
            InitializeComponent();
        }

        private void HandleSignInButtonClick(object sender, MouseEventArgs e) 
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            User user = UserService.GetUserByUsername(username);
            string loginValidationResult = ValidationService.ValidateLoginCredentials(user, username, password);
            if (!loginValidationResult.Equals(""))
            {
                this.errorLabel.Text = ErrorConstants.AUTHENTICATION_UNSUCCESSFUL + "\n" + loginValidationResult;
                LabelService.CenterLabel(this, this.errorLabel);
                this.errorLabel.Visible = true;
            } else
            {
                UserMenu userMenu = new UserMenu();
                userMenu.username = username;
                userMenu.Show();
                this.Hide();
            }
        }

        private void HandleUsernameTextBoxTyping(object sender, KeyPressEventArgs e) 
        {
            TextBoxService.AdjustTextBoxOnTyping(this.usernameTextBox);
        }

        private void HandleUsernameTextBoxClick(object sender, MouseEventArgs e) 
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.usernameTextBox, "Type your username...");
        }

        private void HandleUsernameTextBoxPointerLeave(object sender, EventArgs e) 
        {
            TextBoxService.AdjustTextOnCursorExited(this.usernameTextBox, "Type your username...");
        }

        private void HandlePasswordTextBoxPointerLeave(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text.Equals(""))
            {
                this.passwordTextBox.UseSystemPasswordChar = false;
            }
            TextBoxService.AdjustTextOnCursorExited(this.passwordTextBox, "Type your password...");
        }

        private void HandlePasswordTextBoxTyping(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.passwordTextBox);
        }

        private void HandlePasswordTextBoxClick(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.passwordTextBox, "Type your password...");
            this.passwordTextBox.UseSystemPasswordChar = true;
        }

        private void HandleSignUpButtonClick(object sender, EventArgs e)
        {
            SignUpFormUserData signUpFormUserData = new SignUpFormUserData();
            signUpFormUserData.Show();
            this.Hide();
        }

        private void HandleSignInFormLoad(object sender, EventArgs e)
        {
            UserService = new UserService();
            ValidationService = new ValidationService();
        }

        private void PaintForm(object sender, PaintEventArgs e)
        {
            int R1 = 186, G1 = 83, B1 = 112;
            int R2 = 244, G2 = 226, B2 = 216;
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(R1, G1, B1), 1);
            Rectangle rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(
                rectangle, 
                Color.FromArgb(R1, G1, B1), 
                Color.FromArgb(R2, G2, B2), 
                LinearGradientMode.Vertical
            );
            graphics.FillRectangle(lgb, rectangle);
            graphics.DrawRectangle(pen, rectangle);
        }
    }
}
