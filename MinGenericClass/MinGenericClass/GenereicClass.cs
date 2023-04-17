namespace MinGenericClass
{
    public class GenericMinimum<T> where T : IComparable<T>
    {
        private T firstValue;
        private T secondValue;
        private T thirdValue;
        public GenericMinimum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T Minimum(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) < 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) < 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) < 0)
            {
                return thirdValue;
            }
            else
            {
                throw new Exception("Given values are same");
            }

        }
    }
}
