// The decimal number 585 = 1001001001_2 (binary), is palindromic in both bases.
// Find the sum of all numbers, less than one million, which are palindromic in 
// base 10 and base 2.
// (Please note that the palindromic number, in either base, may not include 
// leading zeros.)

class Double_Base_Palindrome
{

    static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            ++left;
            --right;
        }
        return true;
    }

    public static void Run()
    {
        int sum = 0;
        int max = 1_000_000;
        for (int n = 1; n < max; ++n)
        {
            string str = n.ToString();

            if (!IsPalindrome(str))
                continue;

            string bin = Convert.ToString(n, 2);

            if (!IsPalindrome(bin))
                continue;

            //Console.WriteLine($"{n} = {bin}");
            sum += n;
        }
        
        Console.WriteLine($"Sum of palindromic numbers < {max} = {sum}");
    }
}
