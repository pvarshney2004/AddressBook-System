using System;
namespace AddressBook
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Address Book Program");

            // uc-02
            // AddressBook addressBook = new AddressBook(); // address book
            // Contact contact = new Contact();
            // // taking details from console
            // System.Console.WriteLine("Enter first name: ");
            // contact.FirstName = Console.ReadLine();
            // System.Console.WriteLine("Enter last name: ");
            // contact.LastName = Console.ReadLine();
            // System.Console.WriteLine("Enter Address: ");
            // contact.Address = Console.ReadLine();
            // System.Console.WriteLine("Enter City: ");
            // contact.City = Console.ReadLine();
            // System.Console.WriteLine("Enter State name: ");
            // contact.State = Console.ReadLine();
            // System.Console.WriteLine("Enter Zip code: ");
            // contact.Zip = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Enter Phone: ");
            // contact.Phone = Console.ReadLine();
            // System.Console.WriteLine("Enter Email: ");
            // contact.Email = Console.ReadLine();
            // addressBook.AddContact(contact);
            // addressBook.DisplayContacts(); // displaying contacts

            // uc-03
            // string personName = "Prashant Varshney";
            // addressBook.EditContact(personName);

            // uc-04
            // System.Console.WriteLine("Enter the person's name for which you want to delete the contact details: ");
            // string? person = Console.ReadLine();
            // addressBook.DeleteContact(person);
            // addressBook.DisplayContacts();


            // UC-05 -> Ability to add multiple person to Address Book
            // AddressBook addressBook = new AddressBook();
            // bool addMore = true;
            // while (addMore)
            // {
            //     Contact contact = new Contact();
            //     System.Console.WriteLine("Enter first name: ");
            //     contact.FirstName = Console.ReadLine();
            //     System.Console.WriteLine("Enter last name: ");
            //     contact.LastName = Console.ReadLine();
            //     System.Console.WriteLine("Enter Address: ");
            //     contact.Address = Console.ReadLine();
            //     System.Console.WriteLine("Enter City: ");
            //     contact.City = Console.ReadLine();
            //     System.Console.WriteLine("Enter State name: ");
            //     contact.State = Console.ReadLine();
            //     System.Console.WriteLine("Enter Zip code: ");
            //     contact.Zip = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Enter Phone: ");
            //     contact.Phone = Console.ReadLine();
            //     System.Console.WriteLine("Enter Email: ");
            //     contact.Email = Console.ReadLine();

            //     addressBook.AddContact(contact);

            //     Console.WriteLine("Would you like to add more contact in address book: (yes/no)");
            //     string choice = Console.ReadLine();
            //     addMore = choice.Equals("yes");
            // }
            // addressBook.DisplayContacts();



            // uc-06 (adding multiple address books to the system)
            // AddressBooks system = new AddressBooks();
            // bool addMore = true;
            // while (addMore)
            // {
            //     Console.Write("Enter Address Book Name: ");
            //     string? name = Console.ReadLine();
            //     system.AddAddressBook(name);
            //     Console.WriteLine("Would you like to add more contact in address book: (yes/no)");
            //     string? choice = Console.ReadLine();
            //     addMore = choice.Equals("yes");
            // }
            // system.DisplayAddressBooks();


            /*
            // uc-07 (duplicate contact check while adding person to address book)
            AddressBook addressBook = new AddressBook();
            Contact contact1 = new Contact
            {
                FirstName = "Prashant",
                LastName = "Varshney",
                Address = "123 Main",
                City = "CityA",
                State = "StateA",
                Zip = 12345,
                Phone = "123-456-7890",
                Email = "prashant.varshney@example.com"
            };
            addressBook.AddContact(contact1);
            // Attempting to add duplicate contact
            Contact contact2 = new Contact
            {
                FirstName = "Prashant",
                LastName = "Varshney",
                Address = "456 Elm",
                City = "CityB",
                State = "StateB",
                Zip = 67890,
                Phone = "098-765-4321",
                Email = "pc@gmail.com",
            };
            addressBook.AddContact(contact2); // adding duplicate
            */

            /*
            // designing Address Book System to add multiple Address Books to the System
            AddressBooks system = new AddressBooks();
            system.AddAddressBook("Friends");
            system.AddAddressBook("Family");
            // Adding contacts to Friends Address Book
            var friendsBook = system.GetAddressBook("Friends");
            friendsBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Smith",
                City = "Agra",
                State = "UP"
            });
            friendsBook.AddContact(new Contact
            {
                FirstName = "Bob",
                LastName = "Johnson",
                City = "Delhi",
                State = "UK"
            });
            // Adding contacts to Family Address Book
            var familyBook = system.GetAddressBook("Family");
            familyBook.AddContact(new Contact
            {
                FirstName = "Charlie",
                LastName = "Brown",
                City = "Delhi",
                State = "UK"
            });
            familyBook.AddContact(new Contact
            {
                FirstName = "David",
                LastName = "Wilson",
                City = "Agra",
                State = "UP"
            });
            */

            /*
            // uc-08: Searching persons by city or state across address books                                                           
            // Searching persons by city
            string searchCity = "Agra";
            var personsInCity = system.SearchPersonByCity(searchCity);
            Console.WriteLine($"\nPersons in city '{searchCity}':");
            foreach (var person in personsInCity)
            {
                System.Console.WriteLine($"- {person.FirstName} {person.LastName} ({person.City}, {person.State})");
            }
            // Searching persons by state
            string searchState = "UK";
            var personsInState = system.SearchPersonByState(searchState);
            Console.WriteLine($"\nPersons in state '{searchState}':");
            foreach (var person in personsInState)
            {
                System.Console.WriteLine($"- {person.FirstName} {person.LastName} ({person.City}, {person.State})");
            }
            */

            // // UC-09: Maintain Dictionary of City and Person as well as State and Person
            // Dictionary<string, List<Contact>> cityDictionary = system.GetContactsByCity();
            // Console.WriteLine("\nContacts by City:");
            // foreach (var entry in cityDictionary)
            // {
            //     Console.WriteLine($"City: {entry.Key}");
            //     foreach (var contact in entry.Value)
            //     {
            //         Console.WriteLine($"- {contact.FirstName} {contact.LastName}");
            //     }
            // }

            // Dictionary<string, List<Contact>> stateDictionary = system.GetContactsByState();
            // Console.WriteLine("\nContacts by State:");
            // foreach (var entry in stateDictionary)
            // {
            //     Console.WriteLine($"State: {entry.Key}");
            //     foreach (var contact in entry.Value)
            //     {
            //         Console.WriteLine($"- {contact.FirstName} {contact.LastName}");
            //     }
            // }


            // UC-10: Ability to get number of contact persons i.e. count by City or State
            // Dictionary<string, List<Contact>> cityDictionary = system.GetContactsByCity();
            // Console.WriteLine("\nContacts by City:");
            // foreach (var entry in cityDictionary)
            // {
            //     Console.WriteLine($"City: {entry.Key}");
            //     System.Console.WriteLine($"Number of Contacts: {entry.Value.Count}");
            // }

            // Dictionary<string, List<Contact>> stateDictionary = system.GetContactsByState();
            // Console.WriteLine("\nContacts by State:");
            // foreach (var entry in stateDictionary)
            // {
            //     Console.WriteLine($"State: {entry.Key}");
            //     System.Console.WriteLine($"Number of Contacts: {entry.Value.Count}");
            // }


            /*
            // uc-11: Ability to sort entries alphabetically by Person's Name
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(new Contact
            {
                FirstName = "Charlie",
                LastName = "Brown",
                City = "Delhi",
                State = "UK"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "David",
                LastName = "Wilson",
                City = "Agra",
                State = "UP"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Smith",
                City = "Agra",
                State = "UP"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Johnson",
                City = "Delhi",
                State = "UK"
            });

            Console.WriteLine("\nContacts sorted by Name:");
            var sortedContacts = addressBook.GetContactsSortedByName();
            foreach (var contact in sortedContacts)
            {
                Console.WriteLine(contact);
            }

            */


            /*
            // uc-12: Ability to sort entries by City, State, or Zip
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(new Contact
            {
                FirstName = "Charlie",
                LastName = "Brown",
                City = "Delhi",
                State = "UK",
                Zip = 110001
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "David",
                LastName = "Wilson",
                City = "Agra",
                State = "UP",
                Zip = 282001
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Smith",
                City = "Agra",
                State = "UP",
                Zip = 282002
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Johnson",
                City = "Delhi",
                State = "UK",
                Zip = 110002
            });

            Console.WriteLine("\nContacts sorted by City:");
            var sortedByCity = addressBook.SortByCity();
            foreach (var contact in sortedByCity)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} - {contact.City} - {contact.State} - {contact.Zip}");
            }
            Console.WriteLine("\nContacts sorted by State:");
            var sortedByState = addressBook.SortByState();
            foreach (var contact in sortedByState)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} - {contact.City} - {contact.State} - {contact.Zip}");
            }
            Console.WriteLine("\nContacts sorted by Zip:");
            var sortedByZip = addressBook.SortByZip();
            foreach (var contact in sortedByZip)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} - {contact.City} - {contact.State} - {contact.Zip}");
            }
            */


            // Address book for file read/write operations
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(new Contact
            {
                FirstName = "Charlie",
                LastName = "Brown",
                Address = "212 street",
                City = "Delhi",
                State = "UK",
                Zip = 110001,
                Phone = "987654321",
                Email = "charlie@gmail.com"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "David",
                LastName = "Wilson",
                Address = "265 street",
                City = "Agra",
                State = "UP",
                Zip = 282001,
                Phone = "1234567890",
                Email = "david@gmail.com"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Smith",
                Address = "232 street",
                City = "Agra",
                State = "UP",
                Zip = 282002,
                Phone = "987654321",
                Email = "alice@gmail.com"
            });
            addressBook.AddContact(new Contact
            {
                FirstName = "Alice",
                LastName = "Johnson",
                Address = "222 street",
                City = "Delhi",
                State = "UK",
                Zip = 110002,
                Phone = "987654321",
                Email = "johnson@gmail.com"
            });

            // UC-13 -> ability to read/write AddressBook into File
            // List<Contact> contacts = addressBook.GetContacts();
            // AddressBookFileIO.WriteToFile(contacts);
            // AddressBookFileIO.ReadFromFile();

            // UC-14 -> ability to read/write address book from/to csv file
            List<Contact> contacts = addressBook.GetContacts();
            AddressBookCsvIO.WriteToCsv(contacts);
            AddressBookCsvIO.ReadFromCsv();

        }
    }
}