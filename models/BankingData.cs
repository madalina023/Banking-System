using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.models
{
    public class BankingData
    {

        public BankingData(int bankingDataId, string cardNumber, string cardOwner, string expiryDate, string securityCode, int userId)
        {
            BankingDataId = bankingDataId;
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
            UserId = userId;
        }

        public BankingData(string cardNumber, string cardOwner, string expiryDate, string securityCode, int userId)
        {
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
            UserId = userId;
        }

        public BankingData(string cardNumber, string cardOwner, int userId)
        {
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            UserId = userId;
        }

        public int BankingDataId { get; set; }

        public string CardNumber { get; set; }

        public string CardOwner { get; set; }

        public string ExpiryDate { get; set; }

        public string SecurityCode { get; set; }

        public int UserId { get; set; }

        public override string ToString()
        {
            return BankingDataId + "," + CardNumber + "," + CardOwner + "," + ExpiryDate + "," + SecurityCode + "," + UserId;
        }
        public  string ToCSVFormat()
        {
            return CardNumber + "," + CardOwner + "," + ExpiryDate + "," + SecurityCode + "," + UserId;
        }
    }
}
