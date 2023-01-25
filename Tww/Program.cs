using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata;
using Tww;

namespace Tww
{
    class program
    {
        static void Main(string[] args)
        {




            //Creating a new library
            Library library = new Library();
            //Creating new users 
            User user1 = new User(1, "John", "123 Main Street", 20);
            User user2 = new User(2, "Mary", "456 Main Street", 25);
            User user3 = new User(3, "Bob", "789 Main Street", 30);
            //Creating new items
            Book book1 = new Book(1, "Harry Potter", "Book", "J.K. Rowling", "Fantasy", 250);
            Book book2 = new Book(2, "Lord of the Rings", "Book", "J.R.R. Tolkien", "Fantasy", 500);
            Book book3 = new Book(3, "The Hobbit", "Book", "J.R.R. Tolkien", "Fantasy", 300);
            //adding users and items to the library
            library.AddItem(book1);
            library.AddItem(book2);
            library.AddItem(book3);
            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            



            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("--------------------------Welcome to TWW--------------------------\n");
            Console.WriteLine(@"            Press any key to Start to TWW application.");


            Console.ReadKey();
            Console.Clear();
            MainMenu();

            void MainMenu()
            {


                //Tww management system Main Menu
                while (true)
                {
                    Console.WriteLine("1.Item Manager.");
                    Console.WriteLine("2.Customer Manager.");
                    Console.WriteLine("3.Loan Manager.");
                    Console.WriteLine("Enter your option.");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            ItemMenu();
                            break;
                        case 2:
                            UserMenu();
                            break;
                        case 3:
                            LoanMenu();
                            break;
                        default:
                            break;

                    }

                }
            }

            //Item Menu
            void ItemMenu()
            {

                Console.WriteLine("TWW Managing system. Choose an option by typing a number");
                while (true)
                {

                    Console.WriteLine("1.Add an item");
                    Console.WriteLine("2.View an items");
                    Console.WriteLine("3.Remove item");
                    Console.WriteLine("4. Main Menu");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Item item;
                    switch (option)
                    {
                        //Asks user to enter item type
                        //Items can be add removed and viewed
                        //All working
                        case 1:
                            Console.WriteLine("Enter Item type (Book/DVD/CD): ");
                            string itemType = Console.ReadLine();





                            if (itemType == "Book")
                            {

                                {
                                    Console.Write("Enter Book Id: ");
                                    int itemId = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Enter item title: ");
                                    string title = Console.ReadLine();


                                    string type = itemType;

                                    Console.Write("Enter Literary Genre: ");
                                    string literaryGenre = Console.ReadLine();

                                    Console.Write("Enter Author: ");
                                    string author = Console.ReadLine();

                                    Console.Write("Enter total pages: ");
                                    int pages = Convert.ToInt32(Console.ReadLine());

                                    Book book = new Book(itemId, title, type, author, literaryGenre, pages);
                                    library.AddItem(book);

                                    Console.WriteLine("Book added.");


                                }
                            }
                            else if (itemType == "CD")
                            {
                                Console.Write("Enter CD Id: ");
                                int itemId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter item title: ");
                                string title = Console.ReadLine();
                                string type = itemType;
                                Console.Write("Enter Artist: ");
                                string artist = Console.ReadLine();
                                Console.Write("Enter Genre: ");
                                string genre = Console.ReadLine();
                                Console.Write("Enter total tracks: ");
                                int tracks = Convert.ToInt32(Console.ReadLine());

                                CD cd = new CD(itemId, title, type, artist, genre, tracks);

                                library.AddItem(cd);
                            }
                            else if (itemType == "DVD")
                            {
                                Console.Write("Enter DVD Id: ");
                                int itemId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter item title: ");
                                string title = Console.ReadLine();
                                string type = itemType;
                                Console.Write("Enter Director: ");
                                string director = Console.ReadLine();
                                Console.Write("Enter Genre: ");
                                string genre = Console.ReadLine();
                                Console.Write("Enter total tracks: ");
                                int tracks = Convert.ToInt32(Console.ReadLine());

                                DVD dvd = new DVD(itemId, title, type, director, genre, tracks);

                                library.AddItem(dvd);
                            }
                            else
                            {
                                Console.WriteLine("Please enter item type: Book, CD, DVD");
                            }



                            break;
                        case 2:
                            //item in _items list can be displayed
                            library.DisplayItems();
                            break;
                        case 3:
                            //reads item id to remove item
                            Console.WriteLine("Enter Item Id: ");
                            int itemNumber = Convert.ToInt32(Console.ReadLine());
                            library.RemoveItem(itemNumber);
                            break;
                        case 4:
                            MainMenu();
                            break;


                    }

                    Console.WriteLine("\n\nPress Enter to go back");
                    Console.ReadLine();
                    Console.Clear();
                }
            }


            void UserMenu()
            {
                while (true)
                {

                    Console.WriteLine("TWW Managing system. Choose an option by typing a number");

                    Console.WriteLine("1.Create an User");
                    Console.WriteLine("2.View an Users");
                    Console.WriteLine("3.Remove User");
                    Console.WriteLine("4.Main Menu");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();


                    switch (option)
                    {


                        case 1:
                        {

                            Console.WriteLine("Enter User Id: ");
                            int userID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter full user Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter User address");
                            var address = Console.ReadLine();
                            Console.WriteLine("Enter user age: ");
                            var age = Convert.ToInt32(Console.ReadLine());
                            User user = new User(userID, name, address, age);

                            library.AddUser(user);
                            Console.WriteLine("User added.");
                                Console.Clear();


                        }

                            break;
                        case 2:
                            library.DisplayUsers();
                            break;
                        case 3:
                            Console.WriteLine("Enter Users Id: ");
                            int userId = Convert.ToInt32(Console.ReadLine());
                            library.RemoveUser(userId);
                            break;
                        case 4:
                            MainMenu();
                            break;

                    }

                    Console.WriteLine("Press Enter to go back");
                    Console.ReadLine();
                    Console.Clear();
                    UserMenu();
                }


            }


            //Loan Menu
            //User can create a loan and add items to loan
            //User can view all loans
            // User Should be able to able to return an item. 
            //Return/Remove loan doesnt work and triggers an error

            void LoanMenu()
            {
                while (true)
                {


                    Console.WriteLine("TWW Managing system. Choose an option by typing a number");
                    Console.WriteLine("1.Create an Loan");
                    Console.WriteLine("2.View an Loans");
                    Console.WriteLine("3.Remove Loan");
                    Console.WriteLine("4.Main Menu");
                    int option = Convert.ToInt32(Console.ReadLine());


                    switch (option)
                    {


                        case 1:
                        {
                            //uses User id to confirm if it's exists
                            Console.Clear();
                            Console.WriteLine("Enter User Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            User? current = library.GetUser(id);
                            if (current == null)
                            { Console.WriteLine("User not found"); return;
                            }

                            //uses item id to confirm if it's exists
                            Console.WriteLine("Enter Item Id: ");
                            int itemIdNum = Convert.ToInt32(Console.ReadLine());
                            Item? item = library.GetItem(itemIdNum);
                            if (item == null)
                            {
                                Console.WriteLine("Item not found");
                                return;
                            }
                            
                                       

                            Console.WriteLine("Enter start date (dd/mm/yyyy): ");
                            var startDate = DateTime.Parse(Console.ReadLine());
                            //adds 7 days to the start date for return date
                            var returnDate = startDate.AddDays(7);
                            //Creates new loan and adds to the library
                            Loan loan = new Loan(current,item,startDate, returnDate);
                            library.AddLoan(loan);
                                       
                            Console.WriteLine("Press Enter to go back");
                            Console.ReadLine();
                            Console.Clear();

                        }

                            break;
                        case 2: 
                            //displays all loans
                            library.DisplayLoans(); 
                            Console.WriteLine("Press Enter to go back"); 
                            Console.ReadLine(); 
                            Console.Clear();


                            break;
                        case 3:
                            //Doesnt removes loan or item from the list
                            Console.WriteLine("Enter Item id: ");
                            int itemId = Convert.ToInt32(Console.ReadLine());
                            library.RemoveLoan(itemId);
                            break;
                        case 4:
                            Console.WriteLine("Press Enter to go back");
                            Console.ReadLine();
                            Console.Clear();
                            UserMenu();
                            break;

                    }

                }
            }
        }
    }
}






