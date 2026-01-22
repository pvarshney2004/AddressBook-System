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
Person
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