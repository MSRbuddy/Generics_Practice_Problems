namespace MinimumString
{
    internal class Program
    {
        static void Minimum(string x, string y, string z)
        {
            string min = x;
            if (x.Length <= y.Length && x.Length <= z.Length)
                min = x;
            else if (y.Length <= x.Length && y.Length <= z.Length)
                min = y;
            else
                min = z;
            Console.WriteLine("Given values are : " + x + " " +
                              y + " " + z);
            Console.WriteLine("Minimum value is : " + min + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Find Minimum String!*****\n");
            Minimum("PINEAPPLE", "ORANGE", "MANGO");
        }
    }
}