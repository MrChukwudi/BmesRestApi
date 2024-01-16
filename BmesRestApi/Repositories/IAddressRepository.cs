using System;
using BmesRestApi.Models.Address;

namespace BmesRestApi.Repositories
{
	public interface IAddressRepository
    {
        Address FindAddressById(long id);

        IEnumerable<Address> GetAllAddresses();

        void SaveAddress(Address address);

        void UpdateAddress(Address address);

        void DeleteAddress(Address address);
    }
}

