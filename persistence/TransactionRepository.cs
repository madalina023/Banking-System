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
    public class TransactionRepository
    {
        public static int SaveTransaction(models.Transaction transaction)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            int success = -1;
            try
            {
                connection.Open();
                string query = String.Format(
                    "select * from transaction_insert('{0}', {1}, '{2}', '{3}', '{4}', '{5}')",
                    transaction.TransactionType,
                    transaction.Sold,
                    transaction.CardOwner,
                    transaction.CardNumber,
                    transaction.Username,
                    transaction.Date
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

        public static DataTable GetAllTransactionsByUsername(string username)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string query = String.Format(
                   "select * from transactions where username='{0}'",
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
