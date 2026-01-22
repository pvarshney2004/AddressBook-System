using System;
namespace AddressBook
{
    class AddressBookMain
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Address Book Program");

            // ability to create a contact in AddressBook(UC1)
            Contact contact = new Contact
            {
                FirstName = "Prashant",
                LastName = "Varshney",
                Address = "Sadabad, Hathras, UP",
                City = "Hathras",
                State = "Uttar Pradesh",
                Zip = 281307,
                Phone = "95480*****",
                Email = "pv@gmail.com",
            };

            contact.Display();
        }
    }
}