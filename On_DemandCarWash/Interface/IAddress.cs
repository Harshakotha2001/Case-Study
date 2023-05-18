
using On_DemandCarWash.Model;

namespace On_DemandCarWash.Interface
{
    public interface IAddress
    {
        List<Address> GetAllAddress();
        Address GetAddress(int id);
        public string AddAddress(Address address);
        public string UpdateAddress(Address address);
        public string DeleteAddress(int id);
    }
}

