namespace MinGenericMethod
{
    internal class Program
    {      
        static void Main()
        {
            Console.WriteLine("*****Find Minimum value using Generic-Method*****");
            Console.WriteLine("----------------------------------------------------");

            int MinInt = GenericMinimum<int>.Minimum(21, 78, 93);
            Console.WriteLine($"\nMinimum Int value is: {MinInt}");
            
            float MinFloat = GenericMinimum<float>.Minimum(3.5f, 2.5f, 4.5f);
            Console.WriteLine($"\nMinimum Float value is: {MinFloat}");
            
            string MinString = GenericMinimum<string>.Minimum("Kanna", "Ananya", "Abhi");
            Console.WriteLine($"\nMinimum String value is: {MinString}");
        }
    }
}