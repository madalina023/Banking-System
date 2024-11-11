using banking_system.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.persistence
{
    public class CardRepostiory
    {
        public static DataTable GetCardByData(CardData cardData)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string query = String.Format("select * from cards\r\n\twhere card_owner = '{0}' " +
                    "and card_number = '{1}' and expiry_date = '{2}' and security_code = '{3}';'", 
                    cardData.CardOwner,
                    cardData.CardNumber,
                    cardData.ExpiryDate,
                    cardData.SecurityCode
                    );
                string sql = @query;
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                dt.Load(command.ExecuteReader());
                connection.Close();
                Console.WriteLine(dt.Columns.ToString());
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

        public static DataTable GetCardByCardNumberAndCardOwner(CardData cardData)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string query = String.Format("select * from cards\r\n\twhere card_owner = '{0}' " +
                    "and card_number = '{1}'",
                    cardData.CardOwner,
                    cardData.CardNumber
                    );
                string sql = @query;
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                dt.Load(command.ExecuteReader());
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

        public static void UpdateCardByCardNumberAndCardOwner(CardData cardData)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();

            try
            {
                Console.WriteLine("Amount: " + cardData.Sold);
                Console.WriteLine("Card owner: " + cardData.CardOwner);
                Console.WriteLine("Card number: " + cardData.CardNumber);
                connection.Open();
                string query = String.Format("update cards set sold = sold + {0} where card_owner = '{1}' and card_number = '{2}'",
                    cardData.Sold,
                    cardData.CardOwner,
                    cardData.CardNumber
                );
                string sql = @query;
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }
        }

        public static DataTable GetAllCardsByUsername(string username)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                Console.WriteLine(username);
                connection.Open();
                string query = String.Format(
                   "select c.card_owner, c.card_number, c.expiry_date, c.sold from cards c, banking_data bd, users u " +
                   "where c.card_number = bd.card_number and c.card_owner = bd.card_owner and u.user_id = bd.user_id " +
                   "and u.username = '{0}'",
                   username
               ); 
                string sql = @query;
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                dt.Load(command.ExecuteReader());
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }

            return dt;
        }
    }
}
