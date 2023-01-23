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
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }


        public Loan(DateTime startDate, DateTime dueDate)
        {
            StartDate = startDate.Date;
            DueDate = dueDate.Date;
            User = User;
            Item = Item;


        }

    }
}
