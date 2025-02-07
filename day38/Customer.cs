namespace CustomerCommonLib
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Address> Addresses { get;   set; }

        public Customer() { 
          Addresses = new List<Address> { };
        }


        //public void AddAddress(Address address)
        //{
        //    //validate address fields
        //    Addresses.Add(address);

        //}

    }
}
