
namespace Constructor_Inheritance_Homework
{
    internal class CustomMath
    {
        public int SumOfOddNumsInArray(int[] numbers)
        {
            return numbers.Where(m => m % 2 != 0).Sum();
        }

        public string FindEvenOrOddNum(int n)
        {
            if (n % 2 == 0)
            {
                return $"{n} is even number";
            }

            return $"{n} is odd number";
        }

        public int SquareOfSumOfEvenNums(int[] numbers)
        {
            int sum = numbers.Where(m => m % 2 == 0).Sum();

            return sum * sum;
        }


        public int ProductInInterval(int n)
        {
            int product = 1;

            for (int i = 2; i < n; i++)
            {
                product *= i;
            }

            return product;
        }

    }
}
