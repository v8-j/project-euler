// The fraction 49/98 is a curious fraction, as an inexperienced mathematician 
// in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which
// is correct, is obtained by cancelling the 9s.
// We shall consider fractions like, 30/50 = 3/5, to be trivial examples.

// There are exactly four non-trivial examples of this type of fraction, less
// than one in value, and containing two digits in the numerator and denominator.
// If the product of these four fractions is given in its lowest common terms, 
// find the value of the denominator.

class Digit_Cancelling_Fractions
{
    public static void Run()
    {
        decimal product = 1.0m;

        for (int den = 11; den < 99; ++den)
        {
            for (int num = 11; num < 99; ++num)
            {
                // if value of fraction is >= one, go to next denom
                if (num >= den)
                    break;

                // seperate the digits of the numerator and denominator       
                int [] numDigits = { num/10, num%10 };
                int [] denDigits = { den/10, den%10 };

                // Avoid trivial examples, and div by zero!
                if (denDigits[1] == 0)
                    continue;

                // calculate value as decimal
                decimal value = 1.0m * num/den;

                // turns out this is unnecessary, as in all cases its always
                // the second digit of numerator, and first of denominator
                // I suspected this beforehand, but I did this anyway
                for (int i = 0; i < 2; ++i) 
                {
                    for (int j = 0; j < 2; ++j)
                    {
                        // if digits are the same, cancel them out and see if
                        // the value of the new fraction is equal to the decimal
                        // calculated previously 
                        if (numDigits[i] == denDigits[j])
                        {
                            decimal v = 1.0m * numDigits[1-i] / denDigits[1-j];
                            if (value == v)
                            {
                                Console.WriteLine($"\t{num} / {den}");
                                product *= v;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine($"Decimal value = {product}");
        Console.WriteLine($"As fraction = 1 / {1/product} ");
    }
}