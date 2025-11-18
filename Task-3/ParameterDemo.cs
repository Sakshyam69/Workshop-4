public class ParameterDemo
{
    // 1. Increase() using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. GetFullName() using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Sakshyam Timsina";   // Replace with your name if needed
    }

    // 3. SumAll() using params keyword
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
