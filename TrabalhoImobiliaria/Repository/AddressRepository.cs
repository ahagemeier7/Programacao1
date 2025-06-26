using Modelo;

namespace Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            address.Id = AddressData.Addresses.Count + 1;
            AddressData.Addresses.Add(address);
        }
        public bool Delete(Address address)
        {
            return AddressData.Addresses.Remove(address);
        }

        public bool DeleteById(int id)
        {
            foreach (Address address in AddressData.Addresses)
            {
                if (address.Id == id)
                {
                    return AddressData.Addresses.Remove(address);
                }
            }
            return false;
        }
    }
}
