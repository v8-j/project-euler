// A palindromic number reads the same both ways. The largest palindrome made
// from the product of two 2-digit numbers is 9009 = 91 * 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

class Largest_Palindrome_Product
{
    static bool isPalindrome(int n)
    {
        string num = n.ToString();
        int left = 0;
        int right = num.Length - 1;

        while (left < right)
        {
            if (!num[left].Equals(num[right]))
                return false;
            
            ++left;
            --right;
        }

        return true;
    }

    public static void Run()
    {
        int greatestPalindrome = 0;
        int product;
        int operandA = 0, operandB = 0;

        for (int a = 999; a > 99; --a)
        {
            for (int b = 999; b > 99; --b)
            {

                product = a * b;

                if (product < greatestPalindrome)
                    break;

   
                if (isPalindrome(product)) 
                {
                    greatestPalindrome = product;
                    operandA = a;
                    operandB = b;
                }
            }
        }

        Console.WriteLine($"The largest palindrome as a product of two 3-digit "
        +$"numbers is {operandA} * {operandB} = {greatestPalindrome}");

    }
}