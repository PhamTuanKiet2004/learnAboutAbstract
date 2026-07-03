namespace BaiTapTrenLop.Bai4;

public class Duck : IFly, ISwim
{
    public void Fly()
    {
        Console.WriteLine("I'm a duck and I'm flying...");
    }

    public void Swim()
    {
        Console.WriteLine("I'm a duck and I'm swimming...");
    }
}