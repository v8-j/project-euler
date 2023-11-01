// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
// Find the sum of all numbers which are equal to the sum of the factorial of 
// their digits.
// Note: As 1! = 1 and 2! = 2 are not sums they are not included.


// How to rewrite this so outer loop is nrTerms? I need some sleep :)

// Turns out only 3 and 5 terms needed to be checked, each yeilding 1 hit.
// So thats two numbers total... 145 and 40585. Maybe I'll revisit this...

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
        // cache the values of f_n 0! -> 9!
        int[] f = new int[10];
        for (int i = 0; i < 10; ++i)
            f[i] = (int)Factorial(i);

        int a, b, c, d, e;

        long total = 0;
        
        // 3 terms
        a = b = c = 0;
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
                    ++c;
                }
                ++b;
                c = 0;
            }
            ++a;
            b = 0;
        }

        // 4 terms
        a = b = c = d = 0;
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

        // 5 terms
        a = b = c = d = e = 0;
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

    }


}