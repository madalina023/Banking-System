using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.models
{
    public class User
    {

        public User(int userId, string firstName, string lastName, string username, string password)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        public int UserId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return UserId.ToString() + "," + FirstName + "," + LastName + "," + Username + "," + Password;
        }
        public string ToCSVFormat()
        {
            return FirstName + "," + LastName + "," + Username + "," + Password;
        }

    }
}
