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
    public class UserService
    {
        public UserService() { }

        public List<User> GetAllUsers()
        {
            Console.WriteLine("INFO: Trying to retrieve all users from database.");
            DataTable dt = UserRepository.GetAllUsers();
            List<User> users = new List<User>();
            foreach (DataRow dr in dt.Rows)
            {
                int userId = Int32.Parse(dr["user_id"].ToString());
                string firstName = dr["first_name"].ToString();
                string lastName = dr["last_name"].ToString();
                string username = dr["username"].ToString();
                string password = dr["password"].ToString();
                User user = new User(userId, firstName, lastName, username, password);
                users.Add(user);
            }

            Console.WriteLine("INFO: All users successfully retrieved.");
            return users;
        }

        public int SaveUser(User user)
        {
            Console.WriteLine(String.Format("INFO: Saving the following user={0}", user.ToString()));
            int success = UserRepository.SaveUser(user);
            Console.WriteLine("User was successfully saved.");

            return success;
        }

        public User GetUserByUsername(string username)
        {
            Console.WriteLine(String.Format("INFO: Trying to retrieved User with username={0}.", username));
            DataTable dt = UserRepository.GetUserByUsername(username);
            User user = null;
            foreach (DataRow dr in dt.Rows)
            {
                int userId = Int32.Parse(dr["user_id"].ToString());
                string firstName = dr["first_name"].ToString();
                string lastName = dr["last_name"].ToString();
                string password = dr["password"].ToString();
                user = new User(userId, firstName, lastName, username, password);
            }

            Console.WriteLine(String.Format("INFO: User with username={0} successfully retrieved.", username));
            return user;
        }
    }
}
