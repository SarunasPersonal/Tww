using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tww
{
    internal static class Gui
    {
        static List<Item> items = new List<Item>();
        public static Library Library { get; set; }
        public static void Menu()
        {

            Console.WriteLine("--------------------------Welcome to TWW--------------------------\n");
            Console.WriteLine(@"            Press any key to Start to TWW application.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TWW Managing system. Choose an option by typing a number");
            MainMenu();


            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ItemManager();
                    break;
                case "2":
                    CustomerManager();
                    break;
                case "3":
                    LoanManager();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    return;



            }

            static void MainMenu()
            {

                Console.WriteLine("1. Items manager");
                Console.WriteLine("2. Customers manger");
                Console.WriteLine("3. Loan manager");
                Console.WriteLine("4. Back to Main menu");
                
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ItemManager();
                    break;
                case "2":
                    CustomerManager();
                    break;
                case "3":
                    LoanManager();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    return;



            }
            }

            static void ItemManager()
            {
                Console.Clear();
                Console.WriteLine("Welcome to Items Manager");
                Console.WriteLine("Select an operation");
                Console.WriteLine("1. Add an Item");
                Console.WriteLine("2. View Item");
                Console.WriteLine("3. Remove Item");

                var options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter Item Id:");
                        var itemId = Console.ReadLine();
                        Console.WriteLine("Enter Title: ");
                        var title = Console.ReadLine();
                        Console.WriteLine("Enter Type: ");
                        var type = Console.ReadLine();

                        Item item = new Item(itemId, title, type);
                        items.Add(item);

                        Console.Clear();
                        Console.WriteLine($"Item added: {item}");
                        Console.WriteLine("\n\n\nPress Enter to go back to Main Menu");
                        Console.ReadLine();
                        Console.Clear();
                        ItemManager();
                        break;
                    case "2":
                        ViewItem();


                        break;
                    case "3":
                        
                        break;
                    case "4":
                        MainMenu();
                        return;


                       
                }



            }
            static void AddItem()
            {
                Console.WriteLine("Enter Item Id:");
                var itemNumber = Console.ReadLine();
                Console.WriteLine("Enter Title: ");
                var title = Console.ReadLine();
                Console.WriteLine("Enter Type: ");
                var type = Console.ReadLine();

                Item item = new Item(itemNumber, title, type);
                if (type == "book")
                {
                    Console.WriteLine("Enter Total page number: ");
                    Console.ReadLine();
                }
                Library.Items.Add(item);


                Console.WriteLine("\nItem added.");
                Console.WriteLine("Press any key to go back to Items Manager menu.");
                Console.ReadKey();
                ItemManager();


            }

            static void ViewItem()
            {
                Console.WriteLine("View Items");
                Console.Clear();
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("===");
                }

                Console.ReadLine();
                Console.WriteLine("Press any key to go back to Items Manager menu.");
                Console.ReadKey();
                ItemManager();
                


                }


            }
        
    
        

            static void CustomerManager()
            {
                Console.Clear();
                Console.WriteLine("Welcome to Customers Manager");
                Console.WriteLine("Select an operation");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customer");
                Console.WriteLine("3. Remove Customer");
        }

        static void LoanManager()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Loans Manager");
            Console.WriteLine("Select an operation");
            Console.WriteLine("2. View Loan");
            Console.WriteLine("3. Remove Loan");

        }

        static void Fine()
        {

        }
              }
        }
    
