using System.Collections;

namespace AddressBook
{
    class ContactDetails
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
                                             +"                            " + "State: " + State + " Zip: " + ZIP + "\n"
                                             +"                            " + "Phone Number: " + Phone_Number + "\n"
                                             +"                            " + "Email: " + Email_Address;

        }

    }

    class program
    {
        private  ArrayList contactDetailslist;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        public program()
        {
            contactDetailslist = new ArrayList();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
        }

        public void AddDetails(string First_Name, string Last_Name, string Address, string City, string State, string ZIP, string Phone_Number, string Email_Address)
        {
            ContactDetails contactDetails = new ContactDetails(First_Name, Last_Name, Address, City, State, ZIP, Phone_Number, Email_Address);
            contactDetailslist.Add(contactDetails);
            contactDetailsMap.Add(First_Name,contactDetails);
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails contact in contactDetailslist)
            {
                Console.WriteLine(contact.tostring());
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            program details = new program();


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
            string ZIP =(Console.ReadLine());
            Console.WriteLine("Enter a Phone Number:");
            string Phone_Number =(Console.ReadLine());
            Console.WriteLine("Enter a Email_Address:");
            string Email_Address = Console.ReadLine();
            details.AddDetails(First_Name, Last_Name, Address, City, State, ZIP, Phone_Number, Email_Address);
            details.ComputeDetails();
        }

    }
}
    