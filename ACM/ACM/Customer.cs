using System;
using System.Collections.Generic;

namespace ACM
{
    public class Customer
    {
        public Customer() : this(0)
         // constructor chaining: default constructor calls other constructor, passing in 0 as id
        {

        }
        public Customer(int customerId)
        // constructor - creates id
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public List<Address> AddressList { get; set; }
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
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            return isValid;
        }

    }
}
