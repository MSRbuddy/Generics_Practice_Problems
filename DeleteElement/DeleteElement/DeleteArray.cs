namespace DeleteElement
{
    
    public class DeleteArray
    { 
        public static void DeleteInt(int[] n)
        {
            int i = 0, x;

            Console.WriteLine("\nElements before deletion:");
            for (i = 0; i < 7; i++)
            {
                Console.Write(intArr[i] + " ");
            }

            // Let's say the position to delete the item is 6 i.e. intArr[5]
            x = 6;
            // Shifting elements
            for (i = x - 1; i < 6; i++)
            {
                intArr[i] = intArr[i + 1];
            }
            Console.WriteLine("\nElements after deletion: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write(intArr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void DeleteDouble(double[] n)
        {
            int i = 0, x;

            Console.WriteLine("\nElements before deletion:");
            for (i = 0; i < 7; i++)
            {
                Console.Write(doubleArr[i] + " ");
            }

            // Let's say the position to delete the item is 3 i.e. doubleArr[2]
            x = 3;
            // Shifting elements
            for (i = x - 1; i < 6; i++)
            {
                doubleArr[i] = doubleArr[i + 1];
            }
            Console.WriteLine("\nElements after deletion: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write(doubleArr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void DeleteChar(char[] n)
        {
            int i = 0, x;

            Console.WriteLine("\nElements before deletion:");
            for (i = 0; i < 7; i++)
            {
                Console.Write(charArr[i] + " ");
            }

            // Let's say the position to delete the item is 5 i.e. charArr[4]
            x = 5;
            // Shifting elements
            for (i = x - 1; i < 6; i++)
            {
                charArr[i] = charArr[i + 1];
            }
            Console.WriteLine("\nElements after deletion: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write(charArr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
