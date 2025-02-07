using System.Xml.Serialization;

namespace XMLSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Sachin",
                Addresses = new List<Address>
            {
                new Address { City = "Chennai", Country = "India" },
                new Address { City = "Mumbai", Country = "India" }
            }
            };

            // Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            using (TextWriter writer = new StringWriter()) 
            {
                serializer.Serialize(writer, customer);
                string xmlOutput = writer.ToString();
                Console.WriteLine("Serialized XML:");
                Console.WriteLine(xmlOutput);

                 
                 using (StreamWriter file = new StreamWriter("customer.xml"))
                 {
                     serializer.Serialize(file, customer);
                 }

            }

           
        }
    }
}
