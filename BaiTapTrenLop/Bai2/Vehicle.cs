namespace BaiTapTrenLop.Bai2;

public abstract class Vehicle
{
    private string Brand;
    protected int Speed;

    private void input()
    {
        string vehicleType = this.GetType().Name;
        Console.Write($"Enter brand {vehicleType}: ");
        Brand = Console.ReadLine();
        Console.Write("Enter speed: ");
        Speed = int.Parse(Console.ReadLine());
    }
    public void Start()
    {
        input();
        Console.WriteLine($"{Brand} is starting");
    }
    public void Stop()
    {
        Console.WriteLine("Stoping vehicle");
    }
    public abstract void Move();
}