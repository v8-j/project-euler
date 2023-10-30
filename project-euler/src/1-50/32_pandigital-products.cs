// We shall say that an n-digit number is pandigital if it makes use of all the
// digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1
// through 5 pandigital.
// 
// The product 7254 is unusual, as the identity, 39 * 186 = 7254, containing 
// multiplicand, multiplier, and product is 1 through 9 pandigital.
// 
// Find the sum of all products whose multiplicand/multiplier/product identity 
// can be written as a 1 through 9 pandigital.

// HINT: Some products can be obtained in more than one way so be sure to only
// include it once in your sum.

class Pandigital_Product
{
    static bool IsPandigital(int a, int b, int p)
    {
        // if the product contains repeating digits or zeros, return false
        if (!IsUniqueAndZeroless(p))
            return false;

        string sa = a.ToString();
        string sb = b.ToString();
        string sp = p.ToString();

        // there must be exactly 9 digits!
        if (sa.Length + sb.Length + sp.Length != 9)
            return false;

        List<char> digits = new List<char>();

        // we would have already checked if a and be are unique, so we can add
        // each digit (as char)
        foreach (char c in sa)
            digits.Add(c);

        foreach (char c in sb)
            digits.Add(c);

        // check digits from P are unique as we add them
        foreach (char c in sp)
        {
            if (c == '0')
                return false;
            if (digits.Contains(c))
                return false;
            else
                digits.Add(c);
        }
        return true;
    }

    // Check there are no repeating digits or zeros
    static bool IsUniqueAndZeroless(int a)
    {
        List<char> digits = new List<char>();
        string sa = a.ToString();

        foreach (char c in sa)
        {
            if (c == '0')
                return false;
            if (digits.Contains(c))
                return false;
            else
                digits.Add(c);
        }

        return true;
    }

    // check b against a, and for repeating digits in its self, and has no zeros!
    static bool AreUnique(int a, int b)
    {
        List<char> digits = new List<char>();

        // we already know a is comprised of unique digits
        string sa = a.ToString();
        foreach (char c in sa)
            digits.Add(c);

        string sb = b.ToString();
        foreach (char c in sb)
        {
            if (c == '0')
                return false;
            if (digits.Contains(c))
                return false;
            else
                digits.Add(c);
        }

        return true;
    }

    public static void Run()
    {

        List<int> products = new List<int>();

        for (int a = 2; a < 99; ++a)
        {
            // if a contains repeating digits or zeros, i.e "22" or "103", skip
            if (!IsUniqueAndZeroless(a))
                continue;

            for (int b = 123; b < 10000; ++b)
            {
                // easiest to check for 
                if (a == b)
                    continue;

                // check if digits in b are unique in self & to a, and zeroless
                if (!AreUnique(a, b))
                    continue;

                int p = a * b;

                if (IsPandigital(a, b, p))
                    if (!products.Contains(p))
                    {
                        products.Add(p);
                        Console.WriteLine($"{a} * {b} = {p}");
                    }
            }
        }

        int sum = 0;
        foreach (int p in products)
            sum += p;

        Console.WriteLine($"The sum of pandigital numbers is {sum}");
    }
}