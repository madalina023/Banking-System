using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.models
{
    public class CardData
    {

        public CardData() { }

        public CardData(int cardId, string cardNumber, string cardOwner, string expiryDate, string securityCode, double sold)
        {
            CardId = cardId;
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
            Sold = sold;
        }

        public CardData(string cardNumber, string cardOwner, string expiryDate, string securityCode)
        {
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
        }

        public CardData(string cardNumber, string cardOwner, string expiryDate, double sold)
        {
            CardNumber = cardNumber;
            CardOwner = cardOwner;
            ExpiryDate = expiryDate;
            Sold = sold;
        }

        public int CardId{ get; set; }

        public string CardNumber { get; set; }

        public string CardOwner { get; set; }

        public string ExpiryDate { get; set; }

        public string SecurityCode { get; set; }

        public double Sold { get; set; }

        public override string ToString()
        {
            return CardId + " " + CardNumber + " " + CardOwner + " " + ExpiryDate + " " + SecurityCode + " " + Sold;
        }
    }
}
