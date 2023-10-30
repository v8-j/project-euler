// A unit fraction contains 1 in the numerator. The decimal representation of 
// the unit fractions with denominators 2 to 10 are given:

// 1/2 = 0.5
// 1/3 =0.(3)
// 1/4 =0.25
// 1/5 = 0.2
// 1/6 = 0.1(6)
// 1/7 = 0.(142857)
// 1/8 = 0.125
// 1/9 = 0.(1)
// 1/10 = 0.1

// Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be 
// seen that 1/7 has a 6-digit recurring cycle.
// Find the value of d < 1000 for which 1/d contains the longest recurring cycle
// in its decimal fraction part.

// ********************
// This doesnt work :(
// *********************

class Reciprocal_Cycles
{
    static string LongestRepeatingSegment(Decimal d, int div)
    {
        string output = "";

        // convert number to string, and stip the zero and decimal point
        string asString = d.ToString().Substring(2);

        // outer loop evaluates first character of potential string
        for (int i = 0; i < asString.Length; ++i)
        {
            char term = asString[i];
            int len = 0;
            for (int j = 1; i+j < asString.Length; ++j)
            {
                // if character is the same as the terminator, breakout
                if (asString[i+j] == term)
                    break;
                
                ++len;
            }

            // check if segment repeats
            string sub = asString.Substring(i, len);
            int firstOf = asString.IndexOf(sub);
            // substring, with the sub part removed
            string subsub = asString.Substring(firstOf + len);
            if (subsub.Contains(sub))
            {
                if (sub.Length > output.Length)
                {
                    output = sub;
                }
            }

            
        }
        if (output.Length > 10)
        Console.WriteLine($"1/{div} = {output} in {asString} ({output.Length} digits)");
        return output;
    }

    public static void Run()
    {
       
        int maxLen = 0;
        int indexOfMaxLen = 0;
        for (int i = 1; i < 1000; ++i)
        {
            Decimal d = 1.0m / i;
            string s = LongestRepeatingSegment(d, i);

            if (s.Length > maxLen)
            {
                maxLen = s.Length;
                indexOfMaxLen = i;
            }
           
        }

        Console.WriteLine($"The longest recurring cycle occured with 1/{indexOfMaxLen}");
    }
}
