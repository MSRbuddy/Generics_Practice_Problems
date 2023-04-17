namespace MinGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Find Minimum value using Generic-Method*****");
            Console.WriteLine("----------------------------------------------------");

            int MinInt = GenericMinimum<int>.Minimum(57, 83, 19);
            Console.WriteLine($"\nMinimum Int value is: {MinInt}");

            float MinFloat = GenericMinimum<float>.Minimum(46.9f, 11.7f, 21.3f);
            Console.WriteLine($"\nMinimum Float value is: {MinFloat}");

            string MinString = GenericMinimum<string>.Minimum("Keerthi", "Bhargavi", "Bharath");
            Console.WriteLine($"\nMinimum String value is: {MinString}");
        }
    }
}