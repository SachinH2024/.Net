

namespace Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nodee<int> node1 = new Nodee<int>(10);
            Nodee<int> node2 = new Nodee<int>(20);
            Nodee<int> node3 = new Nodee<int>(30);

            // Link the nodes together
            node1.Next = node2;
            node2.Next = node3;

            // Now you have a linked list: node1 -> node2 -> node3 -> null

            // Access data
            Console.WriteLine(node1.Data); // Output: 10
            Console.WriteLine(node2.Data); // Output: 20

            // Traverse the list
            Nodee<int> current = node1;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
