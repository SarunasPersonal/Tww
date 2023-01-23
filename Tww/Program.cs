using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Tww
{
    class program
    {
        static void Main(string[] args)
        {
            Library library = new Library("TTT", "www.tww.tww");



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
                                Book book = new Book();
                                book.Type = itemType;
                                Console.WriteLine("Enter Book Id: ");
                                book.ItemId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter item title: ");
                                book.Title = Console.ReadLine();
                                Console.WriteLine("Enter Literary Genre");
                                book.LiteraryGenre = Console.ReadLine();
                                Console.WriteLine("Enter Author: ");
                                book.Author = Console.ReadLine();
                                Console.WriteLine("Enter total pages: ");
                                book.Pages = Convert.ToInt32(Console.ReadLine());

                                library.AddItem(book);
                                Console.WriteLine("Book added.");
                            }

                            else if (itemType == "CD")
                            {
                                CD cd = new CD();
                                cd.Type = itemType;
                                Console.WriteLine("Enter CD Id: ");
                                cd.ItemId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter CD title: ");
                                cd.Title = Console.ReadLine();
                                Console.WriteLine("Enter artist name: "); //artist,genre, tracks
                                cd.Artist = Console.ReadLine();
                                Console.WriteLine("Enter genre:");
                                cd.Genre = Console.ReadLine();
                                Console.WriteLine("Enter total tracks: ");
                                cd.Tracks = Convert.ToInt32(Console.ReadLine());

                                library.AddItem(cd);

                            }

                            else if (itemType == "DVD")
                            {
                                DVD dvd = new DVD();
                                dvd.Type = itemType;
                                Console.WriteLine("Enter DVD Id: ");
                                dvd.ItemId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter DVD title: ");
                                dvd.Title = Console.ReadLine();
                                Console.WriteLine("Enter director name: "); //artist,genre, tracks
                                dvd.Director = Console.ReadLine();
                                Console.WriteLine("Enter genre:");
                                dvd.MovieGenre = Console.ReadLine();
                                Console.WriteLine("Enter total length in minutes: ");
                                dvd.TotalLength = Convert.ToInt32(Console.ReadLine());

                                library.AddItem(dvd);
                                Console.WriteLine("DVD added.");

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



                    Console.WriteLine("1.Create an User");
                    Console.WriteLine("2.View an Users");
                    Console.WriteLine("3.Remove User");
                    Console.WriteLine("4.Main Menu");
                    int option = Convert.ToInt32(Console.ReadLine());


                    switch (option)
                    {


                        case 1:
                        {
                            var user = new User();
                            Console.WriteLine("Enter User Id: ");
                            user.UserID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter full user Name: ");
                            user.Name = Console.ReadLine();
                            Console.WriteLine("Enter User address");
                            user.Address = Console.ReadLine();
                            Console.WriteLine("Enter user age: ");
                            user.Age = Convert.ToInt32(Console.ReadLine());
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

            void AddLoan()
            {
                Console.WriteLine("Enter Start date (mm/dd/yyyy): ");
                var StartDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Due date (mm/dd/yyyy): ");
                var DueDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter User Id:");
                var UserId =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Item Id:");
                var ItemId = Convert.ToInt32(Console.ReadLine());




            }

            void LoanMenu()
            {

                while (true)
                {



                    Console.WriteLine("1.Create an Loan");
                    Console.WriteLine("2.View an Loans");
                    Console.WriteLine("3.Remove Loan");
                    Console.WriteLine("4.Main Menu");
                    int option = Convert.ToInt32(Console.ReadLine());


                    switch (option)
                    {


                        case 1:
                        {
                            var loan = new Loan();
                            Console.WriteLine("Enter Start date (mm/dd/yyyy): ");
                            loan.StartDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Due date (mm/dd/yyyy): ");
                            loan.DueDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter User Id:");
                            
                            Console.WriteLine("Enter user age: ");
                            user.Age = Convert.ToInt32(Console.ReadLine());
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


                }
        }

        }

        




        }
    }

