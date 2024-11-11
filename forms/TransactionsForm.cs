using banking_system.models;
using banking_system.service;
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
    public partial class TransactionsForm : Form
    {

        public string Username { get; set; }

        private int Index = 0;

        private int ItemsPerPage = 0;

        private Boolean WasHeaderPrinted = false;

        public List<Transaction> Transactions { get; set; }

        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void HandleBackButtonClick(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.username = Username;
            userMenu.Show();
            this.Hide();
        }

        private void TransactionsFormLoad(object sender, EventArgs e)
        {
            TransactionService transactionService = new TransactionService();
            List<Transaction> transactions = transactionService.GetAllTransactionsByUsername(Username);
            Transactions = transactions;
            transactionsGridView.ColumnCount = 5;

            transactionsGridView.Columns[0].Name = "Transaction Type";
            transactionsGridView.Columns[1].Name = "Amount";
            transactionsGridView.Columns[2].Name = "Card Owner";
            transactionsGridView.Columns[3].Name = "Card Number";
            transactionsGridView.Columns[4].Name = "Date";

            foreach(Transaction transaction in transactions)
            {
                transactionsGridView.Rows.Add(
                    transaction.TransactionType,
                    "$" + transaction.Sold.ToString(),
                    transaction.CardOwner,
                    transaction.CardNumber,
                    transaction.Date
                );
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (!WasHeaderPrinted) {
                e.Graphics.DrawString("TRANSACTIONS", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, 10));
                WasHeaderPrinted = true;
            }
            
            int yValue = 100;

            while (Index < Transactions.Count)
            {
                Transaction transaction = Transactions[Index];
                e.Graphics.DrawString("Transaction type: " + transaction.TransactionType, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, yValue));
                e.Graphics.DrawString("Amount: " + transaction.Sold.ToString() + "$", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, yValue + 50));
                e.Graphics.DrawString("Card number: " + transaction.CardNumber, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, yValue + 100));
                e.Graphics.DrawString("Card owner: " + transaction.CardOwner, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, yValue + 150));
                e.Graphics.DrawString("Date: " + transaction.Date, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, yValue + 200));
                yValue += 350;
                ItemsPerPage += 1;
                Index += 1;

                if (ItemsPerPage < 3)
                { 
                    e.HasMorePages = false;
                } else
                {
                    ItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
