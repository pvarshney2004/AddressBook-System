using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookFileIO
    {
        
        // UC 13 - Ability to Read or Write the Address Book with Persons Contact into a File using File IO Using C# File IO
        private static string filePath = "AddressBook.txt";

        // method to write the address book into a file
        public static void WriteToFile(List<Contact> contacts)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using(StreamWriter sw = new StreamWriter(filePath,false))
            {
                foreach (var contact in contacts)
                {
                    sw.WriteLine(contact);
                }
            }
            System.Console.WriteLine("Address book successfully written to a file.");
        }

        // method to read address book from file 
        public static void ReadFromFile()
        {
            if(!File.Exists(filePath)){
                System.Console.WriteLine("File does not exists.");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            System.Console.WriteLine("\nReading address book from file: ");
            foreach (string item in lines)
            {
                string[] data = item.Split(",");
                Console.WriteLine($"Name: {data[0]} {data[1]}, Address: {data[2]}, City: {data[3]}, State: {data[4]}, Zip: {data[5]}, Phone: {data[6]}, Email:{data[7]}");
            }
        }
    }
}