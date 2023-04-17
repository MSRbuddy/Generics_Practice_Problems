namespace DeleteElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Delete an Elememt from the array*****!");
            Console.WriteLine("--------------------------------------------------");
            
            int[] intArr = { 10, 20, 30, 40, 50, 60, 70 };
            double[] doubleArr = { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5 };
            char[] charArr = { 'M', 'E', 'G', 'H', 'A', 'N', 'A' };

            DeleteArray.DeleteInt(intArr);
            DeleteArray.DeleteDouble(doubleArr);
            DeleteArray.DeleteChar(charArr);
        }
    }
}
