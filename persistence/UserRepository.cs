using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.persistence
{
    public class UserRepository
    {
        public static DataTable GetAllUsers()
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string sql = @"select * from users";
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

        public static int SaveUser(models.User user)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            int success = -1;
            try
            {
                connection.Open();
                string query = String.Format(
                    "select * from user_insert('{0}', '{1}', '{2}', '{3}')", 
                    user.FirstName, 
                    user.LastName, 
                    user.Username, 
                    user.Password
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

        public static DataTable GetUserByUsername(string username)
        {
            Npgsql.NpgsqlConnection connection = PsqlConnection.GetPsqlConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string query = String.Format("select * from users where username='{0}'", username);
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
