using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tww
{
    internal class Library
    {
        
        public List<Item> _items { get; set; }
        public List<User> _users { get; set; }
        public List<Loan> _loans { get; set; }


        public Library()
        {
            
            _items = new List<Item>();
            _users = new List<User>();
            _loans = new List<Loan>();
        }


        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public void AddLoan(Loan loan)
        {
            _loans.Add(loan);
        }

        public void RemoveItem(int itemId)
        {
            var item = _items.Find(x => x.ItemId == itemId);
            if (item != null)
            {
                _items.Remove(item);
                Console.WriteLine("Item removed");
            }
            else
            {
                Console.WriteLine("Item doesn't exists");
            }
        }

       

        public void DisplayItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("No items in the library.");
            }
            else
            {
                foreach (var item in _items)
                {

                    Console.WriteLine("Type: {0}\nItem Id: {1}\nTitle: {2}\n" , item.Type,item.ItemId, item.Title );
                }
            }
        }

        public void DisplayLoans()
        {

            if (_loans.Count == 0)
            {
                Console.WriteLine("No loans were issued.");
            }
            else
            {
                foreach (var loan in _loans)
                {
                    Console.WriteLine("Loan issued:{0}:\nDue Date:{1}\n UserId: {2}\nItem Id: {3} ", loan.StartDate,
                        loan.DueDate, loan.User.UserID, loan.Item.ItemId);

                }
            }
        }

        public void AddUser(User user)
                {
                    _users.Add(user);
                }
                public void DisplayUsers()
                {
                    if (_users.Count == 0)
                    {
                        Console.WriteLine("No user found in the library.");
                    }
                    else
                    {
                        foreach (var user in _users)
                        {

                            Console.WriteLine("User Id: {0}\nName: {1}\nAddress: {2}\nAge: {3}" , user.UserID, user.Name, user.Address, user.Age);
                        }
                    }
                }

                public void RemoveUser(int userId)
                {
                    var user = _users.Find(x => x.UserID == userId);
                    if (user != null)
                    {
                        _users.Remove(user);
                        Console.WriteLine("User removed.");
                    }
                    else
                    {
                        Console.WriteLine("Users doesn't exists.");
                    }
                }

                //public void GetUser(int userId)
                //{
                //    var user = _users.Find(x => x.UserID == userId);
                //    if (user != null)
                //    {
                //        Console.WriteLine("Enter Item Id: ");

                //    }
                //    else
                //    {
                //        Console.WriteLine("User doesn't exists.");
                //    }

                //}

                public User? GetUser(int getUserId)
                {
                    foreach (var user in _users)
                    {
                        if (user.UserID == getUserId)
                        {
                            return user;

                        }
                        
                    }

                    return null;
                }

                public Item? GetItem(int getItemId)
                {
                    foreach (var item in _items)
                    {
                        if (item.ItemId == getItemId)
                        {
                            return item;
                        }
                    }

                    return null;

                }


                //public void RemoveLoan(int loanId)
                //{
                //    var loan = _loans.Find(x => x.LoanId == loanId);
                //    if (loan != null)
                //    {
                //        _loans.Remove(loan);
                //        Console.WriteLine("Loan removed.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Loan doesn't exists.");
                //    }
                //}



    }

}

   

