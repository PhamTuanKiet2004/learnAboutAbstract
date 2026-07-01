namespace BaiTapTrenLop.Bai2;

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Moving car with speed is {Speed}");
    }
}