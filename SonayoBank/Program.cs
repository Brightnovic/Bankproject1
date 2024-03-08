using System;
using System.Net;

namespace SonayoBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SonayoBank. Thanks for choosing us. Please sign up.");

            // Create a new Consumer object from user input
            Consumer consumer = CreateFromUserInput();

            // Main menu
            MainMenu(consumer);
        }

        public static void MainMenu(Consumer consumer)
        {
        Start:
            Console.WriteLine("Welcome to SonayoBank. Thanks for choosing us.");
            Console.WriteLine("Press 0 to change transfer pin");
            Console.WriteLine("Press 1 to withdraw money");
            Console.WriteLine("Press 2 to check your account balance");
            Console.WriteLine("Press 3 to send money");
            Console.WriteLine("Press 4 to exit");
            Console.WriteLine("Press 5 to deposit");

            string reply = Console.ReadLine();

            switch (reply)
            {
                case "0":
                    ChangeTransferPin(consumer.AtmPin);
                    break;
                case "1":
                    Withdraw(consumer.AtmPin, consumer.AtmPin);
                    break;
                case "2":
                    CheckBalance(consumer.AccountBalance);
                    break;
                case "3":
                    Transfer(consumer.AccountBalance);
                    break;
                case "4":
                    deposit(consumer.AccountNumber, consumer.AccountBalance);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input! Please try again.");
                    goto Start;
            }

            // Return to main menu after completing an action
            MainMenu(consumer);
        }

        public static Consumer CreateFromUserInput()
        {
            try
            {
                Console.WriteLine("Enter customer details:");

                Console.Write("First name: ");
                string firstname = Console.ReadLine();

                Console.Write("Second name: ");
                string secondname = Console.ReadLine();

                Console.Write("Other names: ");
                string othernames = Console.ReadLine();

                Console.Write("Phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Next of kin: ");
                string nextofkin = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Date of birth (yyyy-MM-dd): ");
                DateTime dateOfBirth;
                while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
                {
                    Console.WriteLine("Invalid date format. Please enter in the format yyyy-MM-dd.");
                    Console.Write("Date of birth (yyyy-MM-dd): ");
                }

                Console.Write("Gender: ");
                string gender = Console.ReadLine();

                Console.Write("BVN: ");
                int bvn;
                while (!int.TryParse(Console.ReadLine(), out bvn))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("BVN: ");
                }

                Console.Write("Account number: ");
                int accountNumber;
                while (!int.TryParse(Console.ReadLine(), out accountNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Account number: ");
                }

                Console.Write("ATM PIN: ");
                int atmPin;
                while (!int.TryParse(Console.ReadLine(), out atmPin))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("ATM PIN: ");
                }

                Console.Write("Transfer PIN: ");
                int transferPin;
                while (!int.TryParse(Console.ReadLine(), out transferPin))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Transfer PIN: ");
                }

                Console.Write("NIN: ");
                int nin;
                while (!int.TryParse(Console.ReadLine(), out nin))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("NIN: ");
                }

                Console.Write("Account balance: ");
                int accountBalance;
                while (!int.TryParse(Console.ReadLine(), out accountBalance))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Account balance: ");
                }

                return new Consumer(firstname, secondname, othernames, phoneNumber, nextofkin, address, dateOfBirth,
                                    gender, bvn, accountNumber, atmPin, transferPin, nin, accountBalance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public static void Banned()
        {
       
            Console.WriteLine("your account had been supended");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Environment.Exit(0);

        }

        public static void Withdraw( int accountBalance, int Atmpin)
        {
            int attempt = 0;
    

        withdraw:
                try
                {
                Console.Write("Please enter your pin:");
                int atmpin = Convert.ToInt32(Console.ReadLine());
                if (atmpin != Atmpin)
                {
                    Console.WriteLine("wrong pin please try again");
                    attempt++;

                    if (attempt <=2)
                    {
                        goto withdraw;
                     
                    }
                    else
                    {
                        Banned();
                    }

                     
                    
                }
                else
                {

                    Console.Write("please enter amout  to  withdraw");
 
 
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > accountBalance)
                    {
                        Console.Write("your account balance is too low to make this transaction");
                        goto withdraw;
                    }
                    else
                    {
                        accountBalance = accountBalance - amount;
                        Console.WriteLine("you have successfully withdrawed");
                        Console.Write(amount);
                        Console.WriteLine("you have");
                        Console.Write(accountBalance);
                        Console.WriteLine("remaining");
                    }
                }
            




                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    goto withdraw;
                }
            }
            
        public static void CheckBalance(int accountBalance)
        {
            Console.WriteLine("Your balance is: " + accountBalance);
        }



        public static void deposit(int AccountNumber, int accountBalance)
        {
            depositL:
            Console.Write("plese enter your account number:");
         int  ActNum = Convert.ToInt32(Console.ReadLine());
            if (ActNum != AccountNumber)
            {
                Console.WriteLine("this is not your account number please  try again");
                goto depositL;
            }
            else
            {
                Console.WriteLine(" please enter amount you want to deposit");
                int amount = Convert.ToInt32(Console.ReadLine());
                accountBalance = accountBalance + amount;
                Console.Write(" you have successfully deposited ");
                Console.Write(amount);
                Console.Write(" your total balance is:");
                Console.WriteLine(accountBalance);

            }

        }

        public static void Transfer(int accountBalance)
        {
        transferL:
            try
            {
                Console.Write("please enter account number to transfer money to:");
                string accountNum = Console.ReadLine();
                Console.Write("please enter amount to transfer:");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > accountBalance)
                {
                    Console.Write("your account balance is too low to make this transaction");
                    goto transferL;
                }
                else
                {
                    accountBalance = accountBalance - amount;
                    Console.WriteLine("you have successfully transfered");
                    Console.Write(amount);
                    Console.Write("to");
                    Console.Write(accountNum);
                    Console.WriteLine("you have");
                    Console.Write(accountBalance);
                    Console.WriteLine("remaining");
                }






            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                goto transferL;
            }

        }

        public static void ChangeTransferPin(int AtmPin)
        {
            try
            {
                Console.Write("Please enter old pin:");
                int oldpin = Convert.ToInt32(Console.ReadLine());
                if (oldpin != AtmPin)
                {
                    Console.WriteLine("Wrong ATM pin!");
                    ChangeTransferPin(AtmPin); // Retry
                }
                else
                {
                    Console.Write("Please enter new pin:");
                    int newPin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please confirm the pin:");
                    int confirmPin = Convert.ToInt32(Console.ReadLine());
                    // Check and update pin...
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                ChangeTransferPin(AtmPin); // Retry
            }
        }
    }
}
