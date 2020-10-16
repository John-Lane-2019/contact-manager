using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLane_Assignment3
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoFilePath { get; set; }
        public string AddressType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }

        public override string ToString()
        {
            string returnString = FirstName + " " + LastName;
            return returnString;
        }

    }
}
