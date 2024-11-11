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
    public class CardService
    {
        public CardService() { }
        
        public CardData GetCardByData(CardData cardData)
        {
            DataTable dt = CardRepostiory.GetCardByData(cardData);
            foreach (DataRow dr in dt.Rows)
            {
                int cardId = Int32.Parse(dr["card_id"].ToString());
                cardData.CardId = cardId;
            }

            return cardData;
        }

        public CardData GetCardByCardOwnerAndCardNumber(CardData cardData)
        {
            DataTable dt = CardRepostiory.GetCardByCardNumberAndCardOwner(cardData);
            foreach (DataRow dr in dt.Rows)
            {
                int cardId = Int32.Parse(dr["card_id"].ToString());
                cardData.CardId = cardId;
            }

            return cardData;
        }

        public void UpdateCardByCardOwnerAndCardNumber(CardData cardData)
        {
            Console.WriteLine("INFO: Trying to update card with data=" + cardData.ToString());
            CardRepostiory.UpdateCardByCardNumberAndCardOwner(cardData);
            Console.WriteLine("INFO: Update done successfully.");
        }

        public List<CardData> GetAllCardsByUsername(string username)
        {
            Console.WriteLine("INFO: Trying to retrieve all cards that belong to " + username);
            DataTable dt = CardRepostiory.GetAllCardsByUsername(username);
            List<CardData> cards = new List<CardData>();
            foreach (DataRow dr in dt.Rows)
            {
                string cardOwner = dr["card_owner"].ToString();
                string cardNumber = dr["card_number"].ToString();
                string expiryDate = dr["expiry_date"].ToString();
                double sold = double.Parse(dr["sold"].ToString());
                CardData cardData = new CardData(cardNumber, cardOwner, expiryDate, sold);
                Console.WriteLine(cardData.ToString());
                cards.Add(cardData);
            }

            Console.WriteLine("INFO: All cards belonging to " + username + " were successfully retrieved.");
            return cards;
        }
    }
}
