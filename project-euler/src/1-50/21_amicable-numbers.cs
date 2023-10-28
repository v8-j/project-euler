// Let d(n) be defined as the sum of proper divisors of n (numbers less than n
// which divide evenly into n)
// If d(a) = b and d(b) = a, where a != b, then a and b are an amicable pair and
// each of a and b are called amicable numbers.
// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 
// 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 
// 71 and 142; so d(284) = 220.
// Evaluate the sum of all the amicable numbers under 10000.

class Amicable_Numbers
{
    static List<int> GetDivisors(int number)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= number / 2; ++i)
        {
            if (number % i == 0)
                divisors.Add(i);
        }
        return divisors;
    }

    static int SumList(List<int> numbers)
    {
        int total = 0;
        foreach (int n in numbers)
            total += n;
        return total;
    }

    public static void Run()
    {
        int total = 0;
        int max = 10_000;
        for (int a = 2; a <= max; ++a)
        {
            // Find the divisors and sum them
            int b = SumList(GetDivisors(a));

            // Find the divisors of the sum, and sum those. If equal to a, then 
            // we have found an amicable pair, so sum them and add to total
            int db = SumList(GetDivisors(b));

            if (db == a && db != b)
            {
                //Console.WriteLine($"Amicable pair {db} and {b}");
                total += (db + b);
            }
        }
        // half the total to get rid of repeats i.e. 220 & 284 -> 284 & 220
        total /= 2;

        Console.WriteLine($"The sum of the amicable numbers less than {max} is "
        + total);
    }
}