// If the numbers 1 to 5 are written out in words: one, two, three, four, five,
// then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
// If all the numbers from 1 to 1000 (one thousand) inclusive were written out
// in words, how many letters would be used?
// Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) 
// contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
// The use of "and" when writing out numbers is in compliance with British usage.

class Number_Letter_Counts
{
    public static string[] sUnits = { "zero", "one", "two", "three", "four",
    "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", 
    "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

    public static string[] sTens = { "", "", "twenty", "thirty", "forty", "fifty",
    "sixty", "seventy", "eighty", "ninety"};
    
    static string ToWrittenNumber(int n)
    {
        string output = "";

        int thousands = n / 1000;
        int hundreds = (n - (thousands * 1000)) / 100;
        int tens = (n - (thousands * 1000) - (hundreds * 100) ) / 10;
        int units = n % 10;
                        
        if (thousands > 0)
        {
            output += sUnits[thousands];
            output += " thousand";

            if (hundreds > 0)
                output += ",";

            output += " ";
            
        }

        if (hundreds > 0)
        {
            output += sUnits[hundreds];
            output += " hundred ";
        }

        if (n > 99 && (tens > 0 || units > 0))
            output += "and ";

        if (tens > 1)
        {
            output += sTens[tens];

            if (units > 0)
                output += "-";
        }

        if (tens == 1 )
        {
            int idx = 10 + units;
            output += sUnits[idx];
        }
        else if (units > 0)
        {
            output += sUnits[units];
        }

    

        return output;
    }

    static int CountLetters(string str)
    {
        // A-Z = 65-90, a-z = 97-122
        int count = 0;

        for (int i = 0; i < str.Length; ++i)
        {
            int charAt = str[i];
            if ((charAt >= 65 && charAt <=90) || (charAt >= 97 && charAt <= 122))
                ++count;
        }


        return count;
    }
    

    public static void Run()
    {
        int total = 0;

        for (int i = 1; i <= 1000; ++i)
        {
            total += CountLetters(ToWrittenNumber(i));
        }    
           
        Console.WriteLine("The total number of letters used when the numbers "
        + $"1-1000 are written as words is {total}");
    }
}