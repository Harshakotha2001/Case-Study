using On_DemandCarWash.Interface;
using On_DemandCarWash.Model;

namespace On_DemandCarWash.Services
{
    public class AddressService
    {
        private IAddress _IAddress;
        public AddressService(IAddress Iaddress)
        {
            _IAddress = Iaddress;
        }
        public List<Address> GetAllAddress()
        {
            return _IAddress.GetAllAddress();
        }
        public Address GetAddress(int id)
        {
            return _IAddress.GetAddress(id);
        }
        public string AddAddress(Address address)
        {
            return _IAddress.AddAddress(address);
        }
        public string UpdateAddress(Address address)
        {
            return _IAddress.UpdateAddress(address);
        }
        public string DeleteAddress(int id)
        {
            return _IAddress.DeleteAddress(id);
        }
    }
}
