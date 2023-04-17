namespace DeleteClass
{
    internal class GenDeleteClass<T>
    {
        public static void DeleteMethod(T[] n)
        {
            int i = 0, x;
            Console.WriteLine("\nElements before deletion:");
            for (i = 0; i < 7; i++)
            {
                Console.Write(n[i] + " ");
            }

            // Let's say the position to delete the item is 4 i.e. intArr[5]
            x = 1;
            // Shifting elements
            for (i = x - 1; i < 6; i++)
            {
                n[i] = n[i + 1];
            }
            Console.WriteLine("\nElements after deletion: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
