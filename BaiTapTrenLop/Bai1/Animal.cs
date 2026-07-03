namespace BaiTapTrenLop.Bai1;

public abstract class Animal
{
    public string Name;
    
    public void Eat()
    {
        Name = this.GetType().Name;
        Console.WriteLine($"{Name} is eating");
    }

    public abstract void Sound();
}