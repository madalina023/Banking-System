using banking_system.models;
using banking_system.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace banking_system.service
{
    internal class ValidationService
    {
        private const string LETTERS_PATTERN = "^[a-zA-Z]+$";

        private const string USERNAME_PATTERN = "^[A-Za-z][A-Za-z0-9!@#$%^&*?]{5,20}$";

        private const string PASSWORD_PATTERN = ".{6,20}";
        
        private const string CARD_NUMBER_PATTERN = "[0-9]{16}";
        
        private const string CARD_OWNER_PATTERN = "^((?:[A-Za-z]+ ?){1,3})$";

        private const string EXPIRY_DATE_PATTERN = "^(0[1-9]|1[0-2])\\/?([0-9]{4}|[0-9]{2})$";

        private const string SECURITY_CODE_PATTERN = "^[0-9]{3,4}$";

        private const string ONLY_NUMBERS_PATTERN = "^[0-9]*$";

        public ValidationService() { }

        public string IsNameValid(string input)
        {
            if (input.Equals("") || input.Equals("Enter your first name...") || input.Equals("Enter your last name..."))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(input, LETTERS_PATTERN).Success
                ? ""
                : ErrorConstants.INVALID_NAME;
        }

        public string IsUsernameValid(string input, User user)
        {
            if (input.Equals("") || input.Equals("Enter an username..."))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            if (!Regex.Match(input, USERNAME_PATTERN).Success)
            {
                return ErrorConstants.INVALID_USERNAME;
            }

            if (user != null && user.Username.Equals(input))
            {
                return ErrorConstants.USER_ALREADY_EXISTS;
            }

            return "";
        }

        public string IsPasswordValid(string password, string confirmPassword)
        {
            if (password.Equals("") || password.Equals("Enter your password..."))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(password, PASSWORD_PATTERN).Success
                ? password.Equals(confirmPassword)
                    ? ""
                    : ErrorConstants.PASSWORD_DO_NOT_MATCH
                : ErrorConstants.INVALID_PASSWORD;
        }

        public string IsCardNumberValid(string input)
        {
            if (input.Equals("") || input.Equals("1234 5678 9012 3456"))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            string trimmedInput = Regex.Replace(input, @"\s", string.Empty);
            return Regex.Match(trimmedInput, CARD_NUMBER_PATTERN).Success
                ? ""
                : ErrorConstants.INVALID_CARD_NUMBER;
        }

        public string IsCardOwnerValid(string input)
        {
            if (input.Equals("") || input.Equals("Ex. John Doe"))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(input, CARD_OWNER_PATTERN).Success
                ? ""
                : ErrorConstants.INVALID_CARD_OWNER;
        }

        public string IsExpiryDateValid(string input)
        {
            if (input.Equals("") || input.Equals("01/19"))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(input, EXPIRY_DATE_PATTERN).Success
                ? ""
                : ErrorConstants.INVALID_EXPIRY_DATE;
        }

        public string IsSecurityNumberValid(string input)
        {
            if (input.Equals("") || input.Equals("***"))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(input, SECURITY_CODE_PATTERN).Success
                ? ""
                : ErrorConstants.INVALID_SECURITY_CODE;
        }

        public string ValidateLoginCredentials(User user, string username, string password)
        {
            if (username.Equals("") || username.Equals("Type your username...") || password.Equals("") || password.Equals("Type your password..."))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            if (user == null)
            {
                return ErrorConstants.INVALID_LOGIN_USERNAME;
            }

            if (!user.Password.Equals(password))
            {
                return ErrorConstants.INVALID_LOGIN_PASSWORD;
            }

            return "";
        }

        public string ValidateDepositAmount(string input)
        {
            if (input.Equals(""))
            {
                return ErrorConstants.EMPTY_FIELD;
            }

            return Regex.Match(input, ONLY_NUMBERS_PATTERN).Success
                ? ""
                : ErrorConstants.DEPOSIT_FORMAT_ERROR;
        }
    }
}
