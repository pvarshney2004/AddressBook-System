using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookJsonIO
    {
        public static string filePath = "AddressBook.json";

        // method to write to json file
        public static void WriteToJson(List<Contact> contacts)
        {
            string jsonData = JsonSerializer.Serialize(contacts);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Contacts written to JSON file successfully.\n");
        }
        // method to read from json file
        public static void ReadFromJson()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file does not exist.");
                return;
            }
            string jsonData = File.ReadAllText(filePath);
            List<Contact> ans = JsonSerializer.Deserialize<List<Contact>>(jsonData)
                   ?? new List<Contact>();
            foreach (Contact item in ans)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Data from json file read successfully.");
        }
    }
}