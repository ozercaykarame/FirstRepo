public class OMath : IOMath
{
  public int Fact(int number)
  {
    if(number > 1)
      return number * Fact(number -1)
        else
          return 1;
  }
}
