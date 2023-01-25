using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal class User 
    {
        //user class is for the customers in the library
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public User(int userID, string name, string address, int age)
        {
            UserID = userID;
            Name = name;
            Address = address;
            Age = age;
        }
        public string GetUserDetails()
        {
            return $"User ID: {UserID}, Name: {Name}, Address: {Address}, Age: {Age}";
        }



    }

   
}
