using banking_system.models;
using banking_system.persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.service
{
    public class TransactionService
    {
        public int SaveTransaction(Transaction transaction)
        {
            Console.WriteLine(String.Format("INFO: Saving the following transaction={0}", transaction.ToString()));
            int success = TransactionRepository.SaveTransaction(transaction);
            Console.WriteLine("Transaction was successfully saved.");

            return success;
        }

        public List<Transaction> GetAllTransactionsByUsername(string username)
        {
            Console.WriteLine("INFO: Trying to retrieve all transactions from database.");
            DataTable dt = TransactionRepository.GetAllTransactionsByUsername(username);
            List<Transaction> transactions = new List<Transaction>();
            foreach (DataRow dr in dt.Rows)
            {
                string transactionType = dr["transaction_type"].ToString();
                double amount = double.Parse(dr["amount"].ToString());
                string cardOwner = dr["card_owner"].ToString();
                string cardNumber = dr["card_number"].ToString();
                string date = dr["date"].ToString();
                Transaction transaction = new Transaction(transactionType, amount, cardOwner, cardNumber, date);
                transactions.Add(transaction);
            }

            Console.WriteLine("INFO: All transactions successfully retrieved.");
            return transactions;
        }
    }
}
