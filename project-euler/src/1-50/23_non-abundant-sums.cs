// A perfect number is a number for which the sum of its proper divisors is 
// exactly equal to the number. For example, the sum of the proper divisors of 
// 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
// A number n is called deficient if the sum of its proper divisors is less than
// n and it is called abundant if this sum exceeds n.
// 
// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest
// number that can be written as the sum of two abundant numbers is 24. By
// mathematical analysis, it can be shown that all integers greater than 28123
// can be written as the sum of two abundant numbers. However, this upper limit
// cannot be reduced any further by analysis even though it is known that the
// greatest number that cannot be expressed as the sum of two abundant numbers
// is less than this limit.
// Find the sum of all the positive integers which cannot be written as the sum
// of two abundant numbers.

class Non_Abundant_Sums
{
    static List<int> GetDivisors(int n)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= n / 2; ++i)
            if (n % i == 0)
                divisors.Add(i);
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

        // find all abundant numbers
        List<int> abundantNrs = new List<int>();
        for (int i = 12; i < 28123; ++i)
        {
            int sum = SumList(GetDivisors(i));

            if (sum > i)
                abundantNrs.Add(i);
        }

        // find all numbers which cannot be expressed as a sum
        // of any two abudant numbers and add them to the total
        int total = 0;
        for (int i = 1; i < 28123; ++i)
        {
            bool found = false;

            for (int l = 0; l < abundantNrs.Count; ++l)
            {
                if (abundantNrs[l] > i || found)
                    break;

                for (int r = 0; r < abundantNrs.Count; ++r)
                {
                    if (abundantNrs[r] > i)
                    {
                        Console.WriteLine("Breakout condition 1");
                        break;
                    }

                    int sum = abundantNrs[l] + abundantNrs[r];

                    if (sum == i)
                    {
                        found = true;
                        break;
                    }

                    if (sum > i)
                    {
                        break;
                    }
                }
            }
            if (!found)
            {
                total += i;
            }
        }

        Console.WriteLine("sum of all the positive integers which cannot be "
        + $"written as the sum of two abundant numbers is {total}");
    }
}
