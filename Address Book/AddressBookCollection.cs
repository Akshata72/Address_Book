//using CsvHelper;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.IO;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCollection
{
    class AddressBookCollection
    {
        public Dictionary<string, AddressBook> addressBookDictionary;//Dictionary collection
        public AddressBookCollection()
        {
            addressBookDictionary = new Dictionary<string, AddressBook>();
        }
        public void PrintAllAddressBookNames()
        {
            foreach (var AddressBookItem in addressBookDictionary)
            {
                Console.WriteLine(AddressBookItem.Key);
            }
        }
        public void SearchPersonInCityOrState(string firstName, string lastName)
        {
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> PersonInCitiesOrStates = addressBookEntry.Value.addressBook.FindAll(i => (i.firstName == firstName) && (i.lastName == lastName));
                foreach (Person person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.firstName} {person.lastName} is in {person.city} {person.state}");
                }
            }
        }
    }
}









//namespace AddressBook
//{
//    public class AddressBookCollection
//    {
//        public void ImplementCsv()
//        {
//            string improtFilePath = @"C:\Users\Admin\Desktop\programs\Address_Book\CsvFile.txt";
//            string exportFilePath = @"C:\Users\Admin\Desktop\programs\Address_Book\CsvFile.txt";
//            // writing csv file
//            var write = new StreamWriter(exportFilePath);
//            var csvexport = new CsvWriter(write, CultureInfo.InvariantCulture);
//            {
//                List<ContactDetails> sortedlist = SortByFirstName();
//                csvexport.WriteRecords(sortedlist);
//            }
//            // reading csv file
//            TextReader reader = new StreamReader(improtFilePath);
//            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
//            {
//                var records = csv.GetRecords<ContactDetails>().ToList();
//                Console.WriteLine("Read data successfully from multipleAddressbook.csv here are code");
//                foreach(ContactDetails contactdetails in records)
//                {
//                    Console.WriteLine("\t" + contactdetails.First_Name);
//                }
//            }
//        }
//    }
//}
