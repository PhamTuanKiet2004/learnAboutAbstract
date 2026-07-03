namespace BaiTapTrenLop.Bai1;

public class Dog : Animal
{
    public Dog()
    {
        Name = "Dog";
    }

    public override void Sound()
    {
        Console.WriteLine($"go go");
    }
}