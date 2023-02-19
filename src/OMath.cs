public class OMath : IOMath
{
    public int Fact(int number)
    {
        if (number > 1)
            return number * Fact(number - 1)
            else
            return 1;
    }

    public int FactWithLoop(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }
        return result;
    }
}
