using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBooks
    {
        /*
        Refactor to add multiple Address Book to the System. Each Address Book has a unique Name 
        - Use Console to add new Address Book - Maintain Dictionary of Address Book Name to Address Book
        */

        private Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

        // method to add new address book
        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                System.Console.WriteLine("Address book already exists with this name. \nTry with diffrent one");
                return;
            }
            addressBooks[name] = new AddressBook();
            Console.WriteLine($"Address Book '{name}' created successfully.");
        }

        // method to get address book by name
        public AddressBook GetAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }
            else
            {
                Console.WriteLine("Address Book not found.");
                return null;
            }
        }

        // UC-08: Search persons by city across address books
        // public List<Contact> SearchPersonByCity(string city)
        // {
        //     List<Contact> result = new List<Contact>();
        //     foreach (var book in addressBooks.Values)
        //     {
        //         result.AddRange(book.SearchByCity(city));
        //     }
        //     return result;
        // }

        // UC-08: Search persons by state across address books
        // public List<Contact> SearchPersonByState(string state)
        // {
        //     List<Contact> result = new List<Contact>();
        //     foreach (var book in addressBooks.Values)
        //     {
        //         result.AddRange(book.SearchByState(state));
        //     }
        //     return result;
        // }

        // uc-09 Maintain Dictionary of City and Person as well as State and Person
        // uc-09 Dictionary City -> Persons
        public Dictionary<string, List<Contact>> GetContactsByCity()
        {
            Dictionary<string, List<Contact>> cityContacts = new Dictionary<string, List<Contact>>();
            foreach (var book in addressBooks.Values)
            {
                foreach (var contact in book.GetContacts())
                {
                    if (!cityContacts.ContainsKey(contact.City))
                    {
                        cityContacts[contact.City] = new List<Contact>();
                    }
                    cityContacts[contact.City].Add(contact);
                }
            }
            return cityContacts;
        }
        // uc-09 Dictionary State -> Persons
        public Dictionary<string, List<Contact>> GetContactsByState()
        {
            Dictionary<string, List<Contact>> stateContacts = new Dictionary<string, List<Contact>>();
            foreach (var book in addressBooks.Values)
            {
                foreach (var contact in book.GetContacts())
                {
                    if (!stateContacts.ContainsKey(contact.State))
                    {
                        stateContacts[contact.State] = new List<Contact>();
                    }
                    stateContacts[contact.State].Add(contact);
                }
            }
            return stateContacts;
        }

        // method to display all address books name
        public void DisplayAddressBooks()
        {
            Console.WriteLine("\nAvailable Address Books in the system:");
            foreach (var name in addressBooks.Keys)
            {
                Console.WriteLine($"- {name}");
            }
        }

    }
}