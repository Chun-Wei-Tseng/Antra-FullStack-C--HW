namespace ArraysAndStrings;

public class CalculatePrimes
{
    public void Execute()
    {
        int startNum = 10;
        int endNum = 50;
        int[] primes = FindPrimesInRange(startNum, endNum);
        Console.WriteLine("Primes in range: " + string.Join(", ", primes));
    }
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }
        return primes.ToArray();
    }
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}