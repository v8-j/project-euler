// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which
// a^2 + b^2 = c^2.
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
// There exists exactly one Pythagorean triplet for which a + b + c = 1000
// Find the product abc

class Special_Pythagorean_Triples 
{
    static int squared(int n)
    {
        return n * n;
    }

    public static void Run()
    {
        int _A = 0, _B = 0, _C = 0;
        bool breakout = false;

        // Brute force again
        for (int a = 2; a < 300; ++a) 
        {
            if (breakout)
                break;

            for (int b = 3; b < 400; ++b)
            {
                if (breakout)
                    break;

                for (int c = 4; c < 500; ++c)
                {
                    int a2 = squared(a);
                    int b2 = squared(b);
                    int c2 = squared(c);

                    if (a2 + b2 == c2)
                    {
                        if (a + b + c == 1000)
                        {
                            _A = a;
                            _B = b;
                            _C = c;
                            breakout = true;
                            break;
                        }
                    }

                }
            }
        }
        
        long product = _A * _B * _C;
        Console.WriteLine($"{_A} + {_B} + {_C} is a Pythagorean triplet with "
        + $"a sum of 1000! The product of abc is {product}");



    }
}
