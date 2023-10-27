// If we list all the natural numbers below 10 that are multiples of 3 or 
// 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.
class Multiples_of_3_or_5
{
    public static void Run()
    {
        int total = 0;

        for (int i = 3; i < 1000; ++i)
        {
            if (i % 3 == 0 || i % 5 == 0)
                total += i;
        }

        Console.WriteLine(
            $"The sum of multiples of 3 and 5 less than 1000 is {total}"
            );
    }

}