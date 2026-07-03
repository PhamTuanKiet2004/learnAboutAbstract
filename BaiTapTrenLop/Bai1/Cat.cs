namespace BaiTapTrenLop.Bai1;

public class Cat : Animal
{
    public Cat()
    {
        Name = "Cat";
    }

    public override void Sound()
    {
        Console.WriteLine($"meo meo");
    }
}