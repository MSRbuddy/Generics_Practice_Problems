

namespace DeleteMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Delete an Elememt from the array using Generic-Method*****!");
            Console.WriteLine("-------------------------------------------------------------");

            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, };
            char[] charArr = { 'B', 'H', 'A', 'R', 'G', 'V', 'I' };

            GenDeleteArray.DeleteMethod(intArr);
            GenDeleteArray.DeleteMethod(doubleArr);
            GenDeleteArray.DeleteMethod(charArr);
        }
    }
}