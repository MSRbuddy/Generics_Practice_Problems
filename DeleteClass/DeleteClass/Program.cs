namespace DeleteClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Delete an Elememt from the array using Generic-Class*****!");
            Console.WriteLine("-------------------------------------------------------------");

            int[] intArr = { 11, 23, 35, 47, 59, 61, 75, };
            double[] doubleArr = { 9.5, 8.4, 7.3, 6.2, 7.1, 4.6, 3.8, };
            char[] charArr = { 'A', 'E', 'I', 'O', 'U', 'B', 'M', };

            GenDeleteClass<int>.DeleteMethod(intArr);
            GenDeleteClass<double>.DeleteMethod(doubleArr);
            GenDeleteClass<char>.DeleteMethod(charArr);
        }
    }
}