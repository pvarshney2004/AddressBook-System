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
        }
    }
}