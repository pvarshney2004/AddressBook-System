using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        /*
        Ability to add a new
Contact to Address Book
- Use Console to add person details from
AddressBookMain class
- Use Object Oriented Concepts to manage
relationship between AddressBook and Contact
Person(uc-02)
        */

        private List<Contact> contacts;
        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact c)
        {
            contacts.Add(c);
            System.Console.WriteLine("\nContact added successfully.");
        }
        // Ability to edit existing contact person using their name(uc-03)
        public void EditContact(string name)
        {
            Console.WriteLine($"Searching for {name} in address book to update details....");
            //using lambda function
            Contact contact = contacts.Find(c => $"{c.FirstName} {c.LastName}".Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact != null)
            {
                Console.WriteLine($"{name} found. Updating details...");
                Edit(contact);
                Console.WriteLine("Contact details updated successfully.");
            }
            else
            {
                Console.WriteLine("This person contact is not available in address book.");
            }

        }

        public void Edit(Contact updated)
        {
            System.Console.WriteLine("Updating the details...");
            //Using Console to edit person details
            System.Console.WriteLine("Enter updated first name: ");
            updated.FirstName = Console.ReadLine();
            System.Console.WriteLine("Enter updated last name: ");
            updated.LastName = Console.ReadLine();
            System.Console.WriteLine("Enter updated Address: ");
            updated.Address = Console.ReadLine();
            System.Console.WriteLine("Enter updated City: ");
            updated.City = Console.ReadLine();
            System.Console.WriteLine("Enter updated State name: ");
            updated.State = Console.ReadLine();
            System.Console.WriteLine("Enter updated Zip code: ");
            updated.Zip = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter updated Phone: ");
            updated.Phone = Console.ReadLine();
            System.Console.WriteLine("Enter updated Email: ");
            updated.Email = Console.ReadLine();
        }

        public void DisplayContacts()
        {
            System.Console.WriteLine("\n--------Address Book--------");
            foreach (Contact c in contacts)
            {
                c.Display();
            }
        }
    }
}