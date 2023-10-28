// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
// What is the sum of the digits of the number 2^1000?

// 2 to the 1000th power is huge. Might have to employ my huge string adding
// function from challenge 13. Or BigInteger?

using System.Numerics;

class Power_Digit_Sum
{
    static int toInt(char c)
    {
        return c - 48;
    }

    public static void Run()
    {
        BigInteger big = (BigInteger) Math.Pow(2, 1000);
        string bigString = big.ToString(); // 302 digits!!!!
        
        int sum = 0;
        for (int i = 0; i < bigString.Length; ++i)
        {
            sum += toInt(bigString[i]);
        }

        Console.WriteLine($"The sum of the digits of 2^1000 is {sum}");

    }
}