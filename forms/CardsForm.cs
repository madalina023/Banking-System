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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace banking_system.forms
{
    public partial class CardsForm : Form
    {

        public string Username { get; set; }

        public CardsForm()
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

        private void CardsFormLoad(object sender, EventArgs e)
        {
            CardService cardService = new CardService();
            List<CardData> cards = cardService.GetAllCardsByUsername(Username);

            cardsGridView.ColumnCount = 4;

            cardsGridView.Columns[0].Name = "Card Owner";
            cardsGridView.Columns[1].Name = "Card Number";
            cardsGridView.Columns[2].Name = "Expiry Date";
            cardsGridView.Columns[3].Name = "Sold";

            foreach (CardData cardData in cards)
            {
                cardsGridView.Rows.Add(
                    cardData.CardOwner,
                    cardData.CardNumber,
                    cardData.ExpiryDate,
                    "$" + cardData.Sold
                );
            }
        }
    }
}
