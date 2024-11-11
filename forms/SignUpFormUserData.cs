using banking_system.models;
using banking_system.service;
using banking_system.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system.forms
{
    public partial class SignUpFormUserData : Form
    {

        private ValidationService ValidationService;
        private UserService UserService;

        public SignUpFormUserData()
        {
            InitializeComponent();
        }

        private void HandleFirstNameTextBoxMouseClickEvent(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.firstNameTextBox, "Enter your first name...");
        }

        private void HandleFirstNameTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.firstNameTextBox, "Enter your first name...");
        }

        private void HandleFirstNameTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.firstNameTextBox);
        }

        private void HandleLastNameMouseClickEvent(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.lastNameTextBox, "Enter your last name...");

        }

        private void HandleLastNameTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.lastNameTextBox, "Enter your last name...");
        }

        private void HandleLastNameTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.lastNameTextBox);
        }


        private void HandleUsernameTextBoxClickEvent(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.usernameTextBox, "Enter an username...");
        }

        private void HandleUsernameTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.usernameTextBox, "Enter an username...");
        }

        private void HandleUsernameTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.usernameTextBox);
        }

        private void HandlePasswordTextBoxClickEvent(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.passwordTextBox, "Enter your password...");
            this.passwordTextBox.UseSystemPasswordChar = true;
        }

        private void HandlePasswordTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text.Length == 0)
            {
                Console.WriteLine("sdasdasd");
                this.passwordTextBox.UseSystemPasswordChar = false;
            }
            TextBoxService.AdjustTextOnCursorExited(this.passwordTextBox, "Enter your password...");
        }

        private void HandlePasswordTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.passwordTextBox);
        }

        private void HandleConfirmPasswordTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.confirmPasswordTextBox, "Confirm your password...");
        }

        private void HandleConfirmPasswordTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            if (this.confirmPasswordTextBox.Text.Equals(""))
            {
                this.passwordTextBox.UseSystemPasswordChar = false;
            }
            TextBoxService.AdjustTextBoxOnTyping(this.confirmPasswordTextBox);
        }

        private void HandleConfirmPasswordTextBoxClickEvent(object sender, MouseEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.confirmPasswordTextBox, "Confirm your password...");
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void HandleRegistration(object sender, MouseEventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string confirmPassword = this.confirmPasswordTextBox.Text;
            User _user = UserService.GetUserByUsername(username);

            string firstNameValidationResult = ValidationService.IsNameValid(firstName);
            string lastNameValidationResult = ValidationService.IsNameValid(lastName);
            string usernameValidationResult = ValidationService.IsUsernameValid(username, _user);
            string passwordValidationResult = ValidationService.IsPasswordValid(password, confirmPassword);
            bool isRegistrationValid = firstNameValidationResult.Equals("") &&
                lastNameValidationResult.Equals("") &&
                usernameValidationResult.Equals("") &&
                passwordValidationResult.Equals("");

            if (!isRegistrationValid)
            {
                this.errorLabel.Text = ErrorConstants.REGISTRATION_UNSUCCESSFUL + "\n";
                if (!firstNameValidationResult.Equals(""))
                {
                    this.errorLabel.Text += firstNameValidationResult;
                } else if (!lastNameValidationResult.Equals(""))
                {
                    this.errorLabel.Text += lastNameValidationResult;
                } else if (!usernameValidationResult.Equals(""))
                {
                    this.errorLabel.Text += usernameValidationResult;
                } else if (!passwordValidationResult.Equals(""))
                {
                    this.errorLabel.Text += passwordValidationResult;
                }
                LabelService.CenterLabel(this, this.errorLabel);
                this.errorLabel.Visible = true;
            } else
            {
                User user = new User(firstName, lastName, username, password);
                string userString = user.ToString();
                
                int success = UserService.SaveUser(user);

                if (success == 0)
                {
                    this.errorLabel.Text = ErrorConstants.REGISTRATION_UNSUCCESSFUL + "\n" + ErrorConstants.CARD_WAS_NOT_SAVED;
                    LabelService.CenterLabel(this, this.errorLabel);
                    this.errorLabel.Visible = true;
                } else
                {
                    FileService.SaveToCsv("D:\\C#\\Proiect\\banking-system\\banking-system\\files\\users.csv", userString);
                    SignInForm signInForm = new SignInForm();
                    signInForm.Show();
                    this.Hide();
                }
            }
        }

        private void HandleBackButtonClick(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void HandleSignUpFormUserDataLoad(object sender, EventArgs e)
        {
            ValidationService = new ValidationService();
            UserService = new UserService();
        }
    }
}
