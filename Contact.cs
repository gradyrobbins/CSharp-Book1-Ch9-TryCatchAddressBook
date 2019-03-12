using System;

namespace tryCatchAddressBook

{

public class Contact
    {
        // Properties
            // First name
            // Last name
            // Email Address
        public string FirstName {get ; set; }
        public string LastName {get; set; }

        public string Address {get; set;}
        public string EmailAddress {get; set;}

        public string FullName {
           get
           {
            return $"{FirstName} {LastName}";
           }

        }

        //Constructor:
         public Contact(string firstName, string lastName, string emailAddress) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }


    }

}
