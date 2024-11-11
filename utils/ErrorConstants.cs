using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.utils
{
    internal class ErrorConstants
    {
        public const string EMPTY_FIELD = "All fields must be completed.";

        public const string INVALID_NAME = "The name related fields should only contain letters.";

        public const string INVALID_USERNAME = "Username must contain between 6 and 20 characters, must start with a letter and must not contain white spaces.";

        public const string INVALID_PASSWORD = "Password must contain between 6 and 20 characters.";

        public const string PASSWORD_DO_NOT_MATCH = "Passwords do not match.";
        
        public const string REGISTRATION_UNSUCCESSFUL = "The registration was not successfully completed.";

        public const string AUTHENTICATION_UNSUCCESSFUL = "The authentication was unsuccessful.";

        public const string INVALID_CARD_NUMBER = "Invalid card number.";

        public const string INVALID_CARD_OWNER = "Invalid card owner.";

        public const string INVALID_EXPIRY_DATE = "The expiration date is not valid or does not have the proper format.";

        public const string INVALID_SECURITY_CODE = "Invalid security code.";

        public const string INVALID_LOGIN_USERNAME = "Incorrect username.";

        public const string INVALID_LOGIN_PASSWORD = "Incorrect password.";

        public const string USER_WAS_NOT_SAVED = "User was not properly registered. Try again later.";

        public const string USER_ALREADY_EXISTS = "This user already exists.";

        public const string CARD_WAS_NOT_SAVED = "Card was not saved.";

        public const string CARD_WAS_NOT_FOUND = "The following card was not found.";

        public const string DEPOSIT_ERROR = "The deposit action could not be performed.";

        public const string TRANSACTION_ERROR = "Transaction failed.";

        public const string DEPOSIT_FORMAT_ERROR = "The deposit amount does not have the proper format.";
    }
}
