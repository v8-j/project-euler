// Each new term in the Fibonacci sequence is generated by adding the previous 
// two terms. By starting with 1 and 2, the first 10 terms will be:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
// By considering the terms in the Fibonacci sequence whose values do not exceed
// four million, find the sum of the even-valued terms.

class Even_Fibonacci_Numbers
{
    public static void Run()
    {
        int current = 2;
        int last = 1;
        int temp;

        int total = 2;

        while (current <= 4_000_000)
        {
            temp = current;
            current += last;
            last = temp;

            if (current % 2 == 0)
                total += current;
        }

        Console.WriteLine(
            $"The total of the even fibonacci numbers not exceeding 4,000,000 is {total}"
        );
    }
}