using BmesRestApi.Models.Shared;
using BmesRestApi.Models.Address;

namespace BmesRestApi.Models.Customer
{
    using Order;
    using Address; //Because this "using BmesRestApi.Models.Address;" won't work up there.
    public class Customer : BaseObject
	{
        
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Oders { get; set; }
        public IEnumerable<Address> Addresses { get; set; }

    }
}

