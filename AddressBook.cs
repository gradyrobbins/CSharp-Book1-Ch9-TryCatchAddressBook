using System;
using System.Collections.Generic;

namespace tryCatchAddressBook

{
public class AddressBook {

// HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
Dictionary<string, int> AddressBookContacts = new Dictionary<string, int>() {
    {"grady@22.com", 1},
    {"dolly@22.com", 2},
    {"zac@22.com", 3},
    {"colleen@22.com", 4}
};


// You can also use the Add() method to add more key/value pairs to a dictionary.
// AddressBookContacts.Add("hannah@22.com", 5);




foreach(KeyValuePair<string, int> kvp in AddressBookContacts)
{
    Console.WriteLine($"Email address:  {kvp.EmailAddress} for contact #: {kvp.FirstName}   ");
}





}
}