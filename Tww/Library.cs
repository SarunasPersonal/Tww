using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tww
{
    //Library class stores multiple methods
    internal class Library
    {
        public User User { get; set; }
        public Item Item { get; set; }
        public Loan Loan { get; set; }

        public List<Item> _items { get; set; }
        public List<User> _users { get; set; }
        public List<Loan> _loans { get; set; }


        public Library()
        {
            User = User;
            Item = Item;
            Loan = Loan;

            _items = new List<Item>();
            _users = new List<User>();
            _loans = new List<Loan>();
        }


        //Adds the item to the list
        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        //Adds Loan to the list
        public void AddLoan(Loan loan)
        {
            _loans.Add(loan);
        }

        //Removes item 
        public void RemoveItem(int itemId)
        {
            // Used Find method [ .find ]  to find item id in item list
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
            //displays the item
            if (_items.Count == 0)
            {
                Console.WriteLine("No items in the library.");
            }
            else
            {
                //loop through the _items list and outputs all items in the list
                foreach (var item in _items)
                {

                    Console.WriteLine("Type: {0}\nItem Id: {1}\nTitle: {2}\n", item.Type, item.ItemId, item.Title);
                }
            }
        }

        public void DisplayLoans()
        {

            //Display the loans. Items User loaned.

            if (_loans.Count == 0)
            {
                Console.WriteLine("No loans were issued.");
            }
            else
            {
                foreach (var loan in _loans)
                    //check if loan user and loan item isn't null
                    // if not null outputs required data
                {
                    if (loan.User != null && loan.Item != null)
                    {
                        Console.WriteLine(
                            "Loan issue Date: {0}\nReturn Date:{1}\nUserId: {2}\nItem Id:{3}\nItem title: {4}\nItem Type: {5}\nReturned?: {6}\n ",
                            loan.StartDate.ToShortDateString(), loan.ReturnDate.ToShortDateString(), loan.User.UserID, loan.Item.ItemId, loan.Item.Title, loan.Item.Type,loan.IsReturned);
                    }
                    
                    else
                    {
                        Console.WriteLine("Loan doesn't have associated User or Item");
                    }
                }
            

        }
        

    }
    

    public void AddUser(User user)
        //adds user to the _users list
        {
            _users.Add(user);
        }

        public void DisplayUsers()
        //displays the users
        {
            if (_users.Count == 0)
            {
                Console.WriteLine("No user found in the library.");
            }
            else
            {
                foreach (var user in _users)
                {

                    Console.WriteLine("User Id: {0}\nName: {1}\nAddress: {2}\nAge: {3}", user.UserID, user.Name,
                        user.Address, user.Age);
                }
            }
        }

        public void RemoveUser(int userId)
        //removes the user
        {
            var user = _users.Find(x => x.UserID == userId);
            if (user != null)
                //checks if user exist in _users list by using .Find method
            {
                _users.Remove(user);
                Console.WriteLine("User removed.");
            }
            else
            {
                Console.WriteLine("Users doesn't exists.");
            }
        }
        public void RemoveLoan(int itemId)
            //removes the user
        {
            var user = _loans.Find(x => x.Item.ItemId == itemId);
            if (user != null)
                //checks if loan exist in loan list by using .Find method
            {
                _loans.Remove(Loan);
                Console.WriteLine("Loan removed.");
                _items.Add(Item);
            }
            else
            {
                Console.WriteLine("Loan doesn't exists.");
            }
        }



        //GetUser and GetItem is required to create loan
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


        

        
        






    }
}
    


   



    



   

