using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public DataTable GetAddressBook()
        {
            DataTable table = new DataTable();
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("last_name", typeof(string));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("city", typeof(string));
            table.Columns.Add("state", typeof(string));
            table.Columns.Add("zip", typeof(string));
            table.Columns.Add("phone_number", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Rows.Add("Rachel", "Green", "90 Bedford St", "New York", "NYC", "10014", "NA", "rach@green.co");
            table.Rows.Add("Joey", "Tribbiani", "90 Bedford St", "New York", "NYC", "10014", "NA", "joe@tribbiani.co");
            table.Rows.Add("Monica", "Geller", "90 Bedford St", "New York", "NYC", "10014", "NA", "mon@geller.co");
            table.Rows.Add("Ross", "Geller", "90 Bedford St", "New York", "NYC", "10014", "NA", "ross@geller.co");
            table.Rows.Add("Phoebe", "Buffay", "90 Bedford St", "New York", "NYC", "10014", "NA", "phoebe@buffay.co");
            table.Rows.Add("Chandler", "Bing", "90 Bedford St", "New York", "NYC", "10014", "NA", "chandler@bing.co");
            return table;
        }

        public void PrintDataTable(DataTable table)
        {
            Console.Write("{0,-15}", "first_name");
            Console.Write("{0,-15}", "last_name");
            Console.Write("{0,-15}", "address");
            Console.Write("{0,-15}", "city");
            Console.Write("{0,-15}", "state");
            Console.Write("{0,-15}", "zip");
            Console.Write("{0,-15}", "phone_number");
            Console.Write("{0,-15}", "email");
            Console.WriteLine();
            foreach (DataRow contact in table.AsEnumerable())
            {
                Console.Write("{0,-15}", contact.Field<string>("first_name"));
                Console.Write("{0,-15}", contact.Field<string>("last_name"));
                Console.Write("{0,-15}", contact.Field<string>("address"));
                Console.Write("{0,-15}", contact.Field<string>("city"));
                Console.Write("{0,-15}", contact.Field<string>("state"));
                Console.Write("{0,-15}", contact.Field<string>("zip"));
                Console.Write("{0,-15}", contact.Field<string>("phone_number"));
                Console.Write("{0,-15}", contact.Field<string>("email"));
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// UC4
        /// Edits the name of the contact with.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public DataTable EditContactWithName(string firstName, string lastName, DataTable table)
        {
            var record = table.AsEnumerable().Where(r => (r.Field<string>("first_name") == firstName && r.Field<string>("last_name") == lastName)).FirstOrDefault();
            if (record != null)
                record["phone_number"] = "8989XXXXXX";
            return table;
        }

        /// <summary>
        /// UC5
        /// Deletes the name of the contact with.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public DataTable DeleteContactWithName(string firstName, string lastName, DataTable table)
        {
            var record = table.AsEnumerable().Where(r => (r.Field<string>("first_name") == firstName && r.Field<string>("last_name") == lastName)).FirstOrDefault();
            if (record != null)
                record.Delete();
            return table;
        }
    }
}