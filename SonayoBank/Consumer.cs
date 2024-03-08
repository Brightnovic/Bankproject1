using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonayoBank
{
    internal class Consumer
    {
        // Properties representing consumer fields
        public string Firstname { get; set;  }
        public string Secondname { get; set; }
        public string Othernames { get; set; }
        public string PhoneNumber { get; set; }
        public string Nextofkin { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Bvn { get; set; }
        public int AccountNumber { get; set; }
        public int AtmPin { get; set; }
        public int TransferPin { get; set; }
        public int Nin { get; set; }
        public int AccountBalance { get; set; }

        // Constructor
        public Consumer(string firstname, string secondname, string othernames, string phoneNumber, string nextofkin,
                        string address, DateTime dateOfBirth, string gender, int bvn, int accountNumber,
                        int atmPin, int transferPin, int nin, int accountBalance)
        {
            Firstname = firstname;
            Secondname = secondname;
            Othernames = othernames;
            PhoneNumber = phoneNumber;
            Nextofkin = nextofkin;
            Address = address;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Bvn = bvn;
            AccountNumber = accountNumber;
            AtmPin = atmPin;
            TransferPin = transferPin;
            Nin = nin;
            AccountBalance = accountBalance;
        }
    }
}
