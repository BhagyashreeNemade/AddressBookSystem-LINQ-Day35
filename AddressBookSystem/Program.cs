using System;
using System.Data;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System!\n");
            AddressBook addressBook = new AddressBook();
            DataTable table = addressBook.GetAddressBook();
            addressBook.SortDetailsByNameForGivenCity("New York", table);
        }
    }
}