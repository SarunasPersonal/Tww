using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tww
{
    internal class Loan
    {
        //class for the loaning of items
        public User User { get; set; }
        public Item Item { get; set; }
        public DateTime StartDate { get; set; }
        
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        


        public Loan(User user, Item item, DateTime startDate, DateTime returnDate)
        {
            User = user;
            Item = item;

            StartDate = startDate;
            ReturnDate = returnDate;
            IsReturned = false;
        }
        
       








    }
    
    
}



