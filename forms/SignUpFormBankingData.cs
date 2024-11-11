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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system.forms
{
    public partial class SignUpFormBankingData : Form
    {
        private BankingDataService BankingDataService;

        private ValidationService ValidationService;

        private UserService UserService;

        private CardService CardService;

        public string username { get; set; }

        public SignUpFormBankingData()
        {
            InitializeComponent();
        }

        private void HandleCardNumberTextBoxClickEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.cardNumberTextBox, "1234 5678 9012 3456");
        }

        private void HandleCardNumberTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.cardNumberTextBox);
            string trimmedCardNumber = Regex.Replace(this.cardNumberTextBox.Text, @"\s", string.Empty);
            if (!this.cardNumberTextBox.Text.Equals("") && e.KeyChar != (char)8 && trimmedCardNumber.Length % 4 == 0)
            {
                this.cardNumberTextBox.Text += " ";
                this.cardNumberTextBox.Select(this.cardNumberTextBox.Text.Length, 0);
            }
        }

        private void HandleCardNumberTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.cardNumberTextBox, "1234 5678 9012 3456");
        }

        private void HandleCardOwnerTextBoxClickEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.cardOwnerTextBox, "Ex. John Doe");
        }

        private void HandleCardOwnerTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.cardOwnerTextBox, "Ex. John Doe");
        }

        private void HandleCardOwnerTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.cardOwnerTextBox);
        }

        private void HandleExpiryDateTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.expiryDateTextBox, "01/19");
        }

        private void HandleExpiryDateTextBoxClickEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.expiryDateTextBox, "01/19");
        }

        private void HandleExpiryDateTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.expiryDateTextBox);
        }

        private void HandleSecurityCodeTextBoxClickEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextBoxOnMouseClick(this.securityCodeTextBox, "***");
        }

        private void HandleSecurityCodeTextBoxCursorExitedEvent(object sender, EventArgs e)
        {
            TextBoxService.AdjustTextOnCursorExited(this.securityCodeTextBox, "***");
        }

        private void HandleSecurityCodeTextBoxTypingEvent(object sender, KeyPressEventArgs e)
        {
            TextBoxService.AdjustTextBoxOnTyping(this.securityCodeTextBox);
        }

        private void HandleRegisterButton(object sender, EventArgs e)
        {
            string cardNumber = this.cardNumberTextBox.Text;
            string cardOwner = this.cardOwnerTextBox.Text;
            string expiryDate = this.expiryDateTextBox.Text;
            string securityCode = this.securityCodeTextBox.Text;

            service.ValidationService validationService = new service.ValidationService();

            string cardNumberValidationResult = validationService.IsCardNumberValid(cardNumber);
            string cardOwnerValidationResult = validationService.IsCardOwnerValid(cardOwner);
            string expiryDateValidationResult = validationService.IsExpiryDateValid(expiryDate);
            string securityCodeValidationResult = validationService.IsSecurityNumberValid(securityCode);

            bool isRegistrationValid = cardNumberValidationResult.Equals("")
                && cardOwnerValidationResult.Equals("")
                && expiryDateValidationResult.Equals("")
                && securityCodeValidationResult.Equals("");

            if (!isRegistrationValid)
            {
                this.errorLabel.Text = utils.ErrorConstants.REGISTRATION_UNSUCCESSFUL + "\n";
                if (!cardNumberValidationResult.Equals(""))
                {
                    this.errorLabel.Text += cardNumberValidationResult;
                } else if (!cardOwnerValidationResult.Equals(""))
                {
                    this.errorLabel.Text += cardOwnerValidationResult;
                } else if (!expiryDateValidationResult.Equals(""))
                {
                    this.errorLabel.Text += expiryDateValidationResult;
                } else if (!expiryDateValidationResult.Equals(""))
                {
                    this.errorLabel.Text += securityCodeValidationResult;
                }


                LabelService.CenterLabel(this, this.errorLabel);
                this.errorLabel.Visible = true;
                
            } else
            {
                CardData cardData = new CardData(
                    cardNumber,
                    cardOwner,
                    expiryDate,
                    securityCode
                );
                CardData retrievedCardData = CardService.GetCardByData(cardData);

                if (retrievedCardData.CardId <= 0)
                {
                    this.errorLabel.Text = ErrorConstants.REGISTRATION_UNSUCCESSFUL + "\n" + ErrorConstants.CARD_WAS_NOT_FOUND;
                    LabelService.CenterLabel(this, this.errorLabel);
                    this.errorLabel.Visible = true;
                } else
                {
                    User user = UserService.GetUserByUsername(username);
                    BankingData bankingData = new BankingData(
                        cardNumber,
                        cardOwner,
                        expiryDate,
                        securityCode,
                        user.UserId
                    );
                    int success = BankingDataService.SaveBankingData(bankingData);
                    if (success == 1)
                    {
                        string bankingDataString = bankingData.ToString();
                        FileService.SaveToCsv("D:\\C#\\Proiect\\banking-system\\banking-system\\files\\banking-data.csv", bankingDataString);
                        UserMenu userMenu = new UserMenu();
                        userMenu.username = username;
                        userMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.errorLabel.Text = ErrorConstants.REGISTRATION_UNSUCCESSFUL + "\n" + ErrorConstants.USER_WAS_NOT_SAVED;
                        LabelService.CenterLabel(this, this.errorLabel);
                        this.errorLabel.Visible = true;
                    }
                }
            }
        }

        private void HandleSignUpFormBankingDataLoad(object sender, EventArgs e)
        {
            BankingDataService = new BankingDataService();
            ValidationService = new ValidationService();
            UserService = new UserService();
            CardService = new CardService();
        }

        private void HandleBackButtonClick(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.username = username;
            userMenu.Show();
            this.Hide();
        }
    }
}
