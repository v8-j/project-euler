// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
// Find the sum of all numbers which are equal to the sum of the factorial of 
// their digits.
// Note: As 1! = 1 and 2! = 2 are not sums they are not included.


// How to rewrite this so outer loop is nrTerms? I need some sleep :)

class Digit_Factorials
{
    static long Factorial(int n)
    {
        if (n == 0) return 1;

        long output = 1;
        int mult = 1;
        while (mult < n)
        {
            output *= ++mult;
        }
        return output;
    }

    public static void Run()
    {
        // cache the values of f_n 0! -> 9! I dont think we even need > 5!
        int[] f = new int[10];
        for (int i = 0; i < 10; ++i)
            f[i] = (int)Factorial(i);

        int a, b, c, d, e;
        a = b = c = 0;

        long total = 0;
        int iterations = 0;

        // 3 terms
        while (a < 10)
        {
            while (b < 10)
            {
                while (c < 10)
                {
                    long sum = f[a] + f[b] + f[c];
                    string fString = sum.ToString();
                    string nString = a.ToString() + b.ToString() + c.ToString();

                    if (fString == nString)
                    {
                        total += sum;
                        Console.WriteLine($"{a}! + {b}! + {c}! = {sum}");
                    }
                    ++iterations;
                    ++c;
                }
                ++b;
                c = 0;
            }
            ++a;
            b = 0;
        }

        a = b = c = d = 0;

        // 4 terms
        while (a < 10)
        {
            while (b < 10)
            {
                while (c < 10)
                {
                    while (d < 10)
                    {
                        long sum = f[a] + f[b] + f[c] + f[d];
                        string fString = sum.ToString();
                        string nString = a.ToString() + b.ToString() + c.ToString() + d.ToString(); ;

                        if (fString == nString)
                        {
                            total += sum;
                            Console.WriteLine($"{a}! + {b}! + {c}! + {d}! = {sum}");
                        }
                        ++iterations;
                        ++d;
                    }
                    ++c;
                    d = 0;
                }
                ++b;
                c = 0;
            }
            ++a;
            b = 0;
        }

        a = b = c = d = e = 0;

        // 5 terms
        while (a < 10)
        {
            while (b < 10)
            {
                while (c < 10)
                {
                    while (d < 10)
                    {
                        while (e < 10)
                        {
                            long sum = f[a] + f[b] + f[c] + f[d] + f[e];
                            string fString = sum.ToString();
                            string nString = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString(); 

                            if (fString == nString)
                            {
                                total += sum;
                                Console.WriteLine($"{a}! + {b}! + {c}! + {d}! + {e}! = {sum}");
                            }
                            ++iterations;
                            ++e;
                        }
                        ++d;
                        e = 0;
                    }
                    ++c;
                    d = 0;
                }
                ++b;
                c = 0;
            }
            ++a;
            b = 0;
        }

        Console.WriteLine($"{iterations} iterations.");


    }


}