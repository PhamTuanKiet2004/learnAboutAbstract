namespace BaiTapTrenLop.Bai2;

public class Boat : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Moving boat with speed is:  {Speed}");
    }
}