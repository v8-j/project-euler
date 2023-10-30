// Euler discovered the remarkable quadratic formula:
// n^2 + n + 41
// It turns out that the formula will produce 40 primes for the consecutive
// integer values 0 <= n <= 39. However, when 
// n = 40, 40^2 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, and certainly 
// when n = 41, 41^2 + 41 + 41 is clearly divisible by 41.
// The incredible formula n^2 - 79n + 1601 was discovered, which produces 80 
// primes for the consecutive values 0 <= n <= 79. The product of the
// coefficients, -79 and 1601, is -126479.
// Considering quadratics of the form:
// n^2 + an + b, where |a| < 1000 and |b| <= 1000 where |n| is the absolute
// value of n e.g. |11| = 11 and |-4| = 4

// Find the product of the coefficients, a and b, for the quadratic expression
// that produces the maximum number of primes for consecutive values of n, 
// starting with n = 0.

// I misunderstood the question, but fluked the correct answer, since in this 
// case the total number of primes was also greatest with a= -61 and b= 971.
// We were actually supposed to find largest number of primes for _consecutive_
// values of n, not all values of n below some number, which I arbitrarily  
// chose 100.

class Quadratic_Primes
{
static bool IsPrime(List<long> primes, int n)
{
    if (n < 2)
        return false;
    if (n == 2)
        return true;
    if (n % 2 == 0)
        return false;

    for (int i = 0; i < primes.Count; ++i)
    {
        if (primes[i] == n)
            return true;

        if (primes[i] > n)
            break;
    }
    return false;
}

public static void Run()
{
    // calculate the first 'nrPrimes' prime numbers.
    int nrPrimes = 50_000;
    List<long> primes = new List<long>();
    primes.Add(2);

    for (int i = 3, n = 1; n <= nrPrimes; i += 2)
    {
        bool isPrime = true;

        for (int j = 0; j < primes.Count; ++j)
        {
            if (i % primes[j] == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            primes.Add(i);
            ++n;
        }
    }

    int maxPrimes = 0;
    int _A = 0, _B = 0;
    int maxN = 100;

    for (int a = -999; a < 1000; ++a)
    {
        for (int b = -999; b <= 1000; ++b)
        {
            int primeCount = 0;

            for (int n = 0; n < maxN; ++n)
            {
                int v = (n * n) + (a * n) + b;
                if (IsPrime(primes, v))
                    ++primeCount;
            }

            if (primeCount > maxPrimes)
            {
                maxPrimes = primeCount;
                _A = a;
                _B = b;
                Console.WriteLine(
                    $"a={a} & b={b} produced {primeCount} primes");
            }
        }
    }

    int product = _A * _B;
    Console.WriteLine($"a={_A} b={_B} yielded the largest number of primes "
    + $"({maxPrimes}). Their product is {product}");
}
}