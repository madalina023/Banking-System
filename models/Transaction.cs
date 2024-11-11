using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.models
{
    public class Transaction
    {
        public Transaction(int transactionId, string transactionType, double sold, string cardOwner, string cardNumber, string username, string date)
        {
            TransactionId = transactionId;
            TransactionType = transactionType;
            Sold = sold;
            CardOwner = cardOwner;
            CardNumber = cardNumber;
            Username = username;
            Date = date;
        }

        public Transaction(string transactionType, double sold, string cardOwner, string cardNumber, string username, string date)
        {
            TransactionType = transactionType;
            Sold = sold;
            CardOwner = cardOwner;
            CardNumber = cardNumber;
            Username = username;
            Date = date;
        }

        public Transaction(string transactionType, double sold, string cardOwner, string cardNumber, string date)
        {
            TransactionType = transactionType;
            Sold = sold;
            CardOwner = cardOwner;
            CardNumber = cardNumber;
            Date = date;
        }

        public int TransactionId { get; set; }

        public string TransactionType { get; set; }

        public string CardOwner { get; set; }

        public string CardNumber { get; set; }

        public double Sold { get; set; }

        public string Username { get; set; }

        public string Date { get; set; }
        public override string ToString()
        {
            return TransactionId + "," + TransactionType + "," + Sold + "," + CardOwner + "," + CardNumber + "," + Username;
        }
        public string ToCSVFormat()
        {
            return TransactionType + "," + Sold + "," + CardOwner + "," + CardNumber + "," + Username;
        }
    }
}
