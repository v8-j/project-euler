// n! means n * (n - 1) * ... * 3 * 2 * 1.
// For example, 10! = 10 * 9 * ... * 3 * 2 * 1 = 3628800, and the sum of the
// digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
// Find the sum of the digits in the number 100!.

using System.Numerics;

class Factorial_Digit_Sum
{
    static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;

        BigInteger output = 1;
        int mult = 1;
        while (mult < n)
        {
            output *= ++mult;
        }
        return output;
    }

    static int ToInt(char c)
    {
        return c - 48;
    }

    public static void Run()
    {
        int factorial = 100;
        String str = Factorial(factorial).ToString();

        int sum = 0;
        for (int i = 0; i < str.Length; ++i)
        {
            sum += ToInt(str[i]);
        }

        Console.WriteLine($"The sum of the digits of {factorial}! is {sum}");
    }
}
