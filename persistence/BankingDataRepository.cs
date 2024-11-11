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
    public class BankingDataRepository
    {
        public static int SaveBankingData(BankingData bankingData)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            int success = -1;
            try
            {
                connection.Open();
                string query = String.Format(
                    "select * from banking_data_insert('{0}', '{1}', '{2}', '{3}', '{4}')",
                    bankingData.CardNumber,
                    bankingData.CardOwner,
                    bankingData.ExpiryDate,
                    bankingData.SecurityCode,
                    bankingData.UserId
                );
                string sql = @query;
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                success = (int)command.ExecuteScalar();
                connection.Close();

            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex.Message);
            }

            return success;
        }

        public static DataTable GetBankingDataByCardNumberCardOwnerUserId(BankingData bankingData)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string query = String.Format("select * from banking_data where card_owner='{0}', card_number='{1}' and user_id={2}", 
                    bankingData.CardOwner, 
                    bankingData.CardNumber, 
                    bankingData.UserId
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
    }
}
