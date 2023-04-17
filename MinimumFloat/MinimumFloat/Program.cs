namespace MinimumFloat
{
    internal class Program
    {
        static void Minimum(double x, double y, double z)
        {
            double min = x;
            if (x <= y && x <= z)
                min = x;
            else if (y <= x && y <= z)
                min = y;
            else
                min = z;
            Console.WriteLine("Given values are : " + x + " " +
                              y + " " + z);
            Console.WriteLine("Minimum value is : " + min + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Find Minimum Float/Double value!*****\n");
            Minimum(6.9, 3.7, 4.8);
        }
    }
}