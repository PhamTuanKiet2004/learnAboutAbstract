namespace BaiTapTrenLop.Bai2;

public class Bike : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Moving bike with  speed is:  {Speed}");
    }
}