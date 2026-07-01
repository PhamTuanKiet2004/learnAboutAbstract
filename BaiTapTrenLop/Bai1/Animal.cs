namespace BaiTapTrenLop.Bai1;

public abstract class Animal
{
    public string Name;

    public void Eat()
    {
        Console.Write($"{Name} is eating");
    }

    public abstract void Sound();
}