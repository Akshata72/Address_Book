namespace AddressBook
{
    class AddressBook
    {
        public String First_Name;
        public String Last_Name;
        public String Address;
        public String City;
        public String State;
        public String ZIP;
        public String Phone_Number;
        public String Email_Address;
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();
            

            Console.WriteLine("Enter a First Name:");
            addressbook.First_Name = Console.ReadLine(); 
            Console.WriteLine("Enter a Last Name:");
            addressbook.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter a Address:");
            addressbook.Address = Console.ReadLine();
            Console.WriteLine("Enter a City:");
            addressbook.City = Console.ReadLine();
            Console.WriteLine("Enter a State:");
            addressbook.State = Console.ReadLine();
            Console.WriteLine("Enter a ZIP:");
            addressbook.ZIP = Console.ReadLine();
            Console.WriteLine("Enter a Phone Number:");
            addressbook.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter a Email_Address:");
            addressbook.Email_Address = Console.ReadLine();
        }
    }

}
    