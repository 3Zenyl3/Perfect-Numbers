public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        int res = 0;
        List<int> nums = new List<int>();
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                nums.Add(i);
            }
        }
        foreach (int i in nums)
        {
            res += i;
        }
        if (res == number)
            return Classification.Perfect;
        else if (res > number) return Classification.Abundant;
        else return Classification.Deficient;
    }
}
