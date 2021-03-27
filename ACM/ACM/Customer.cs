using System;

namespace ACM
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                { // first name exists
                    if (!string.IsNullOrWhiteSpace(fullName))
                    { // last name exists
                        // add comma and space after last name
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
    }
}
