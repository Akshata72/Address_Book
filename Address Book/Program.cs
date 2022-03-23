﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AddressBook
{
    public class ContactDetails
    {
        public String First_Name;
        public String Last_Name;
        public String Address;
        public String City;
        public String State;
        public String ZIP;
        public String Phone_Number;
        public String Email_Address;
        public ContactDetails(string First_Name, string Last_Name, string Address, string City, string State, string ZIP, string Phone_Number, string Email_Address)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZIP = ZIP;
            this.Phone_Number = Phone_Number;
            this.Email_Address = Email_Address;
        }
        public string tostring()
        {
            return " Details of  " + First_Name + " " + Last_Name + " are: " + "Address: " + Address + " city: " + City + "\n"
                                             + "                            " + "State: " + State + " Zip: " + ZIP + "\n"
                                             + "                            " + "Phone Number: " + Phone_Number + "\n"
                                             + "                            " + "Email: " + Email_Address;

        }
    }
    class program
    {
        private ArrayList contactDetailslist;
        private Dictionary<string, ContactDetails> contactDetailsMap = new Dictionary<string, ContactDetails>();
        public program()
        {
            contactDetailslist = new ArrayList();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
        }
        public void AddDetails()
        {
            Console.WriteLine("Enter a First Name:");
            string First_Name = Console.ReadLine();
            Console.WriteLine("Enter a Last Name:");
            string Last_Name = Console.ReadLine();
            Console.WriteLine("Enter a Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter a City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter a State:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter a ZIP:");
            string ZIP = (Console.ReadLine());
            Console.WriteLine("Enter a Phone Number:");
            string Phone_Number = (Console.ReadLine());
            Console.WriteLine("Enter a Email_Address:");
            string Email_Address = Console.ReadLine();
            ContactDetails contactDetails = new ContactDetails(First_Name, Last_Name, Address, City, State, ZIP, Phone_Number, Email_Address);
            contactDetailslist.Add(contactDetails);
            contactDetailsMap.Add(First_Name, contactDetails);
        }
        public void EditDetails(string key)
        {
            if (contactDetailsMap.ContainsKey(key))
            {
                Console.WriteLine("Enter a New First Name:");
                string First_Name = Console.ReadLine();
                Console.WriteLine("Enter a New Last Name:");
                string Last_Name = Console.ReadLine();
                Console.WriteLine("Enter a New Address:");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter a New City:");
                string City = Console.ReadLine();
                Console.WriteLine("Enter a New State:");
                string State = Console.ReadLine();
                Console.WriteLine("Enter a New ZIP:");
                string ZIP = (Console.ReadLine());
                Console.WriteLine("Enter a New Phone Number:");
                string Phone_Number = (Console.ReadLine());
                Console.WriteLine("Enter a New Email_Address:");
                string Email_Address = Console.ReadLine();
                ContactDetails contactDetails = new ContactDetails(First_Name, Last_Name, Address, City, State, ZIP, Phone_Number, Email_Address);
                contactDetailslist.Add(contactDetails);
                contactDetailsMap[key] = contactDetails;
            }
            else
            {
                Console.WriteLine("Key Not Found.");
            }
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails contact in contactDetailslist)
            {
                Console.WriteLine(contact.tostring());
            }
        }
        public static void Main(string[] args)
        {
            int Option = 0;
            Console.WriteLine("Welcome To Address Book");
            program details = new program();
            do
            {
                Console.WriteLine("1: To Add a Contact Details.");
                Console.WriteLine("2: To Compute Details.");
                Console.WriteLine("3: To Edit a Contact Details.");
                Console.WriteLine("0: To Exit");
                try
                {
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            details.AddDetails();
                            continue;
                        case 2:
                            details.ComputeDetails();
                            continue;
                        case 3:
                            Console.WriteLine("Enter a First Name to Edit");
                            string key = Console.ReadLine();
                            details.EditDetails(key);
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Wrong key");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose option");
                }
            }
            while (Option != 0);
        }
    }
}