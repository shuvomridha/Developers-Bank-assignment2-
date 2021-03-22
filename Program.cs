using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Program
    {

        public static bool flag = true;  //this flag is used for iteration and all exit the menu
        public static string choice;
        public static string choice2;

        private static void Main(string[] args)
        {
            Console.Title = "Developers Bank LTD";
            Bank theBank = new Bank("Developer's bank", 100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tWelcome to Developers Bank LTD");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            // While loop for 
            while (flag)
            {
                bool flag2 = true;
                bool flag3 = true;
                Console.WriteLine("\tPlease Enter a Command to Progress: \n");
                Console.WriteLine("\topen --> To Open an account\n\taccount --> To Perform transactions on an account\n\tquit --> To Exit the application\n");
                Console.ForegroundColor = ConsoleColor.Red;
                choice = Console.ReadLine();   //take input for menu
                Console.ForegroundColor = ConsoleColor.White;
                // Menu 
                switch (choice)
                {
                    case "open":

                        while (flag2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine(" \t  Create an Account with Developers Bank LTD");
                            Console.WriteLine("----------------------------------------------------------------\n");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\tName: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("\n\tDate of Birth \n");
                            Console.Write("\tDay: ");
                            string day = Console.ReadLine();
                            Console.Write("\tMonth: ");
                            string month = Console.ReadLine();
                            Console.Write("\tYear: ");
                            string year = Console.ReadLine();
                            string dob = day + month + year;

                            Console.Write("\tHouse no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\tRoad no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\tCity: ");
                            string city = Console.ReadLine();
                            Console.Write("\tCountry: ");
                            string country = Console.ReadLine();

                            Console.Write("\tStarting Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine("\n\tPlease Enter a Command to Progress: \n");
                            Console.WriteLine("\tsavings --> Open a savings account\n\tchecking --> Open a checking account\n\tquit --> Exit the application ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            choice2 = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (choice2)
                            {
                                case "savings":
                                    theBank.AddAccount(new Savings(name, dob, choice2, amount, new Address(houseNo, roadNo, city, country)));
                                    flag2 = false;
                                    break;

                                case "checking":
                                    theBank.AddAccount(new Checking(name, dob, choice2, amount, new Address(houseNo, roadNo, city, country)));
                                    flag2 = false;
                                    break;

                                case "quit":

                                    flag2 = false;

                                    break;
                                default:
                                    Console.WriteLine("\t--------------------------------");
                                    Console.WriteLine("\tWrong Input!\nPlease try Again.");
                                    Console.WriteLine("\t--------------------------------");
                                    break;
                            }

                        }

                        theBank.PrintAllAccounts();

                        break;

                    case "account":

                        while (flag3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine(" \t  Make a  Transactions  With Developers Bank LTD");
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tPlease Enter a Command to Progress: \n");
                            Console.Write("\tdeposit --> Make a deposit\n\twithdraw --> Make a withdrawal\n\ttransfer --> Make a transfer\n\tshow --> Show the number transactions and balance\n\tquit --> Exit the application\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            choice = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (choice)
                            {

                                case "deposit":

                                    Console.Write("\tPlease Enter a Account Number: ");
                                    string tempAccount = Console.ReadLine();

                                    Console.Write("\tPlease Enter Deposit Amount: ");
                                    double tempAmount = Convert.ToDouble(Console.ReadLine());

                                    theBank.Transaction(tempAmount, choice, tempAccount);
                                    Console.WriteLine("----------------------------------------------------------------");

                                    break;

                                case "withdraw":

                                    Console.Write("\tPlease Enter a Account Number: ");
                                    tempAccount = Console.ReadLine();

                                    Console.Write("\tPlease Enter Withdraw Amount: ");
                                    tempAmount = Convert.ToDouble(Console.ReadLine());

                                    theBank.Transaction(tempAmount, choice, tempAccount);

                                    Console.WriteLine("----------------------------------------------------------------");

                                    break;

                                case "transfer":
                                    Console.Write("\tPlease Enter Your Account Number: ");
                                    tempAccount = Console.ReadLine();

                                    Console.Write("\tPlease Enter Transfer Amount: ");
                                    tempAmount = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("\tReceiver Account Number: ");
                                    string receiver = Console.ReadLine();

                                    theBank.Transaction(tempAmount, choice, tempAccount, receiver);
                                    Console.WriteLine("----------------------------------------------------------------");
                                    break;
                                case "show":

                                    Account.Show();

                                    break;
                                case "quit":

                                    flag3 = false;
                                    Console.WriteLine("----------------------------------------------------------------");
                                    break;
                                default:
                                    Console.WriteLine("\t--------------------------------");
                                    Console.WriteLine("\tWrong Input!\nPlease try Again.");
                                    Console.WriteLine("\t--------------------------------");
                                    break;
                            }

                        }
                        Console.WriteLine("----------------------------------------------------------------");
                        break;

                    case "quit":

                        flag = false;
                        //Console.WriteLine("----------------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("\t--------------------------------");
                        Console.WriteLine("\tWrong Input!\nPlease try Again.");
                        Console.WriteLine("\t--------------------------------");
                        break;

                }

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(" \t\tThank you for staying with us!");
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadKey();
        }

    }
}