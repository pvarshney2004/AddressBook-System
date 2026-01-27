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
            // Duplicate Check is done on Person Name while adding person to Address Book using collection methods.(uc-07). 
            if (contacts.Contains(c))
            {
                System.Console.WriteLine($"\nContact already exists with name '{c.FirstName} {c.LastName}'.");
                return;
            }
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

        // Ability to delete a person using person's name - Use Console to delete a person(uc-04)
        public void DeleteContact(string name)
        {
            Contact contact = contacts.Find(c => $"{c.FirstName} {c.LastName}".Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine($"Contact '{name}' deleted successfully.");
            }
            else
            {
                System.Console.WriteLine("This person's contact details not available in address book.");
            }
        }

        // UC-08: Ability to search Person in a City or State across the multiple Address Book
        public List<Contact> SearchByCity(string city)
        {
            return contacts
                .Where(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<Contact> SearchByState(string state)
        {
            return contacts
                .Where(c => c.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // method to get all contacts
        public List<Contact> GetContacts()
        {
            return contacts;
        }

        // UC-11: Sort alphabetically by name
        public List<Contact> GetContactsSortedByName()
        {
            return contacts
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.LastName)
                .ToList();
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                System.Console.WriteLine("No contacts available.");
                return;
            }
            System.Console.WriteLine("\n--------Address Book--------");
            foreach (Contact c in contacts)
            {
                c.Display();
            }
        }
    }
}