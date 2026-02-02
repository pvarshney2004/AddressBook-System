using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace AddressBook
{
    public class AddressBookCsvIO
    {
        private static string filePath = "AddressBook.csv";

        //method to write address book to csv file
        public static void WriteToCsv(List<Contact> contacts)
        {
            // If file does not exist → create automatically
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }

            Console.WriteLine("Contacts written to CSV file successfully.\n");
        }

        // method to read from csv file
        public static void ReadFromCsv()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file does not exist.");
                return;
            }
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Console.WriteLine("Contacts read from CSV file successfully.");
                List<Contact> contacts = csv.GetRecords<Contact>().ToList();
                foreach (Contact item in contacts)
                {
                    System.Console.WriteLine(" -" + item);
                }
            }
        }
    }
}