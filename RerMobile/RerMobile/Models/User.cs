using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace RerMobile.Models
{
    [Table("Users")]
    public class User
    {
        public User (string email, string login, string password)
        {
            Email = email;
            Login = login;
            Password = password;
        }
        public User() { }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Email { get; set; }
        [Unique]
        public string Login { get; set; }
        [Unique]
        public string Password { get; set; }
    }
}
