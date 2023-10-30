// The Fibonacci sequence is defined by the recurrence relation:
// F_n = F_{n - 1} + F_{n - 2}, where F_1 = 1 and F_2 = 1.
// Hence the first 12 terms will be:

// F_1 = 1
// F_2 = 1
// F_3 = 2
// F_4 = 3
// F_5 = 5
// F_6 = 8
// F_7 = 13
// F_8 = 21
// F_9 = 34
// F_10 = 55
// F_11 = 89
// F_12 = 144

// The 12th term, F_12, is the first term to contain three digits.
// What is the index of the first term in the Fibonacci sequence to contain 
// 1000 digits?

using System.Numerics;

class _1000_Digit_Fibonacci_Number
{
    public static void Run()
    {
        BigInteger next = 1;
        BigInteger current = 0;
        BigInteger temp;
        int index = 0;  
        string asString = "";    

        while (asString.Length < 1000)
        {
            ++index;            
            temp = next;
            next += current;
            current = temp;
            asString = current.ToString();
        }

        Console.WriteLine($"The F_{index} fibonnaci number is the first to "
        + "contain 1000 digits");

    }
}
