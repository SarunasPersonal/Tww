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





            Library library = new Library();






            Console.WriteLine("--------------------------Welcome to TWW--------------------------\n");
            Console.WriteLine(@"            Press any key to Start to TWW application.");


            Console.ReadKey();
            Console.Clear();
            MainMenu();

            void MainMenu()
            {



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
                            library.DisplayItems();
                            break;
                        case 3:
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

                    Console.WriteLine("\n\nPress Enter to go back");
                    Console.ReadLine();
                    Console.Clear();
                }


            }


            
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
                                       Console.Clear();
                                       Console.WriteLine("Enter User Id: ");
                                       int id = Convert.ToInt32(Console.ReadLine());
                                       User? current = library.GetUser(id);
                                       if (current == null)
                                       {
                                           Console.WriteLine("User not found");
                                           return;
                                       }


                                       Console.WriteLine("Enter Item Id: ");
                                       int itemIdNum = Convert.ToInt32(Console.ReadLine());
                                       Item? item = library.GetItem(itemIdNum);
                                       if (item == null)
                                       {
                                           Console.WriteLine("Item not found");
                                           return;
                                       }
                                       else
                                       {
                                           Console.WriteLine("Item found");
                                       }

                                       Console.WriteLine("enter start date (mm/dd/yyyy): ");
                                       var startDate = DateTime.Parse(Console.ReadLine());
                                       Console.WriteLine("Enter Due date (mm/dd/yyyy): ");
                                       var dueDate = DateTime.Parse(Console.ReadLine());
                                       Loan loan = new Loan(startDate, dueDate);
                                       library.AddLoan(loan);
                                   }

                                       break;
                                   case 2:
                                       library.DisplayLoans();
                                       break;
                                   case 3:
                                       //Console.WriteLine("Enter loan Id: ");
                                       //int loanId = Convert.ToInt32(Console.ReadLine());
                                       //library.RemoveLoan(loanId);
                                       break;
                                   case 4:
                                       MainMenu();
                                       break;

                               }

                           }
                       }
            }
        }
    }






