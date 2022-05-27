using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace RerMobile.Models
{
    [Table("Project")]
    public class Project
    {
        public Project(string name, string description, string telephone, string email, string address, string paht)
        {
            Name = name;
            Description = description;
            Telephone = telephone;
            Email = email;
            Address = address;
            ImagePath = paht;
        }
        public Project() { }
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        [Unique]
        public string Description { get; set; }
        [Unique]
        public string Telephone { get; set; }
        [Unique]
        public string Email { get; set; }
        [Unique]
        public string Address { get; set; }
        [Unique]
        public string ImagePath { get; set; }
    }
}
