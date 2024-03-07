using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SonayoBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("Welcome to SonayoBank");

            Console.WriteLine("press 1 to create account:");
            Console.WriteLine("press 2 to withdraw money");
            Console.Write("press 3  to send money");
            string reply = Console.ReadLine();
        
            if (reply == "1")
            {
                Consumer consumer = CreateFromUserInput();

                Console.WriteLine("Customer details created successfully:");
                Console.WriteLine("First name: " + consumer.Firstname);
                Console.WriteLine("Second name: " + consumer.Secondname);
                Console.WriteLine("Other names: " + consumer.Othernames);
                Console.WriteLine("Phone number: " + consumer.PhoneNumber);
                Console.WriteLine("Next of kin: " + consumer.Nextofkin);
                Console.WriteLine("Address: " + consumer.Address);
                Console.WriteLine("Date of birth: " + consumer.DateOfBirth.ToString("yyyy-MM-dd"));
                Console.WriteLine("Gender: " + consumer.Gender);
                Console.WriteLine("BVN: " + consumer.Bvn);
                Console.WriteLine("Account number: " + consumer.AccountNumber);
                Console.WriteLine("ATM PIN: " + consumer.AtmPin);
                Console.WriteLine("Transfer PIN: " + consumer.TransferPin);
                Console.WriteLine("NIN: " + consumer.Nin);
                Console.WriteLine("Account balance: " + consumer.AccountBalance);

            }
            else if (reply == "2")
            {
                Withdraw();
            }
        
            else if (reply == "3")
            {
                transfer();
            }
            else
            {
                Console.WriteLine("invalid input! please try again");
                goto Start;
            }

            Console.ReadKey();
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


        public static void Withdraw()
        {
            try
            {
                Console.Write("please enter your pin:");


            }
            catch (Exception e)
            {
                Console.WriteLine("");
            }
        }



        public static void transfer(int accountBalance)
        {
     transferL:
            try
            {
                Console.Write("please enter account number to transfer money to:");
             string accountNum =  Console.ReadLine();
                Console.Write("please enter amount to transfer:");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > accountBalance)
                {
                    Console.Write("your account balance is too low to make this transaction");
                }






            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                goto transferL;
            }
        }



        public static void changetransferpin()
        {
            try
            {
                Console.Write("please enter old pin:");

                Console.Write("please enter new pin:");
                Console.Write("please confirm the pin:");
            }
            catch (Exception e)
            {
                Console.WriteLine("");
            }
        }
    }



}
