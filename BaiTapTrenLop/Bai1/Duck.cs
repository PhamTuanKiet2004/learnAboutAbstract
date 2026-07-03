namespace BaiTapTrenLop.Bai1;

public class Duck : Animal
{
    public Duck()
    {
        Name = "Duck";
    }

    public override void Sound()
    {
        Console.WriteLine($"quac quac");
    }
}