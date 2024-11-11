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
    public partial class UserMenu : Form
    {
        public string username { get; set; }

        public UserMenu()
        {
            InitializeComponent();
        }

        private void HandleAddCardButtonClick(object sender, EventArgs e)
        {
            SignUpFormBankingData signUpFormBankingData = new SignUpFormBankingData();
            signUpFormBankingData.username = username;
            signUpFormBankingData.Show();
            this.Hide();
        }

        private void HandleDepositClickButton(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.Username = username;
            depositForm.Show();
            this.Hide();
        }

        private void HandleLogOutButtonClick(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void HandleShowTransactionsButtonClick(object sender, EventArgs e)
        {
            TransactionsForm transactionForm = new TransactionsForm();
            transactionForm.Username = username;
            transactionForm.Show();
            this.Hide();
        }

        private void HandleShowCardsButtonClick(object sender, EventArgs e)
        {
            CardsForm cardsForm = new CardsForm();
            cardsForm.Username = username;
            cardsForm.Show();
            this.Hide();
        }

        private void HandleWithdrawClickButton(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            withdrawForm.Username = username;
            withdrawForm.Show();
            this.Hide();
        }
    }
}
