using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        /*
        Ability to create a Contacts in Address
Book with first and last names, address,
city, state, zip, phone number and
email…
        */
        public string? FirstName;
        public string? LastName;
        public string? Address;
        public string? City;
        public string? State;
        public int Zip;
        public string? Phone { get; set; }
        public string? Email;

        // UC-07: Override Equals to check duplicate person
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contact))
            {
                return false;
            }
            Contact other = (Contact)obj;

            // this is giving warning if FirstName or LastName is null
            // return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
            //     && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);

            return string.Equals(FirstName,other.FirstName,StringComparison.OrdinalIgnoreCase) && string.Equals(LastName,other.LastName,StringComparison.OrdinalIgnoreCase);

        }

        // method to display a contact
        public void Display()
        {
            System.Console.WriteLine($"Person Name: {FirstName} {LastName}");
            System.Console.WriteLine($"Address: {Address}");
            System.Console.WriteLine($"City: {City}");
            System.Console.WriteLine($"State: {State}");
            System.Console.WriteLine($"Zip: {Zip}");
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine($"Email: {Email}");
            System.Console.WriteLine("--------------------");
        }

        // uc-11 Override ToString() method
        // public override string ToString()
        // {
        //     return $"Person Name: {FirstName} {LastName}, City: {City}";
        // }

        // for uc-13
        public override string ToString()
        {
            return $"{FirstName},{LastName},{Address},{City},{State},{Zip},{Phone},{Email}";
        }
    }
}