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
        public User User { get; set; }
        public Item Item { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public Loan(DateTime startDate, DateTime dueDate)
        {
            
            StartDate = startDate;
            DueDate = dueDate;
        }

        public void ReturnItem()
        {
            if (DateTime.Now > DueDate)
            {
                var fine = new Penalty();
                fine.Fine = 10;
                Console.WriteLine($"You have been fined {fine.Fine} for late return");
            }
            else
            {
                Console.WriteLine("Thank you for returning the item on time");
            }
        }

        public override string ToString()
        {
            return $"User: {User}, Item: {Item},  Start Date: {StartDate}, Due Date: {DueDate}";

        }
    }
    
    
}



