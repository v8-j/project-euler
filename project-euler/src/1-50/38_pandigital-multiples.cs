// Take the number 192 and multiply it by each of 1, 2, and 3:

// 192 * 1 = 192
// 192 * 2 = 384
// 192 * 3 = 576

// By concatenating each product we get the 1 to 9 pandigital, 192384576. We 
// will call 192384576 the concatenated product of 192 and (1,2,3).
// The same can be achieved by starting with 9 and multiplying by  1, 2, 3, 4, 
// and 5, giving the pandigital, 918273645, which is the concatenated product of
// 9 and (1,2,3,4,5).

// What is the largest 1 to 9 pandigital 9-digit number that can be formed as
// the concatenated product of an integer with (1,2, ..., n) where n > 1?

class Pandigital_Multiple
{
static bool NoRepeats(string str)
{
    List<char> digits = new List<char>();

    // check digits from P are unique as we add them
    foreach (char c in str)
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
    int longest = 100_000_000;

    for (int i = 1; i < 10_000; ++i)
    {
        int multiplier = 0;
        string asString = "";

        while (asString.Length < 10)
        {
            asString += (i * ++multiplier).ToString();

            if (multiplier > 1 && asString.Length == 9)
            {
                if (NoRepeats(asString))
                {
                    int val = int.Parse(asString);

                    if (val > longest)
                    {
                        longest = val;
                        Console.WriteLine(
                            $"sum({i}*1...{multiplier})= {longest}");
                    }
                }
            }

        }
    }
}
}