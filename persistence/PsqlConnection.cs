using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.persistence
{
    public class PsqlConnection
    {
        private static Npgsql.NpgsqlConnection Connection;

        private PsqlConnection() {}

        public static Npgsql.NpgsqlConnection GetPsqlConnection()
        {
            if (Connection == null)
            {
                Console.WriteLine("INFO: Connecting to the database.");
                Connection = new Npgsql.NpgsqlConnection(utils.BankingSystemConstants.CONNECTION_METADATA);
                Console.WriteLine("INFO: Successfully connected to the database.");
            }

            return Connection;
        }

    }
}
