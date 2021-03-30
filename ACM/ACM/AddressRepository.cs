using System;
using System.Collections.Generic;

namespace ACM
{
    public class AddressRepository
    { 
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            
            // hard-coded values to return
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street = "Bag End";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // hard-coded values to return
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                Street = "Bag End",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);
        }
    }
}