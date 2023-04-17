namespace MinimumInteger
{
    internal class Program
    { 
        static void Minimum(int x, int y, int z)
        {
            int min = x;
            if (x <= y && x <= z)
                min = x;
            else if (y <= x && y <= z)
                min = y;
           else
                min = z;
            Console.WriteLine("Given Values are : " + x + " " +
                              y + " " + z );
            Console.WriteLine("Minimum Value is : " + min + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Find Minimum Integer value!*****\n");
            Minimum(125, 25, 625);
        }
    }
}