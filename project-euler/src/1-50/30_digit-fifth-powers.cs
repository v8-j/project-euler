// Surprisingly there are only three numbers that can be written as the sum of 
// fourth powers of their digits:

// 1634 = 1^4 + 6^4 + 3^4 + 4^4
// 8208 = 8^4 + 2^4 + 0^4 + 8^4
// 9474 = 9^4 + 4^4 + 7^4 + 4^4

// As 1 = 1^4 is not a sum it is not included.
// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
// Find the sum of all the numbers that can be written as the sum of fifth
// powers of their digits.

class Digit_Fifth_Power
{
    public static void Run()
    {
        int power = 5;

        int total = 0;
        
        for (int i = 2; i < 1_000_000; ++i)
        {
            int sum = 0;

            string asString = i.ToString();

            for (int j = 0; j < asString.Length; ++j)
            {
                int digit = asString[j] - 48;
                int exp = (int) Math.Pow(digit, power);
                sum += exp;
            }

            if (sum == i)
                total += i;
        }

        Console.WriteLine($"The sum of all numbers that can be written as the "
        + $"fifth power of their digits is {total}");
    }
}
