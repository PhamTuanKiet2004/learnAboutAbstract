namespace LyThuyet;

// Lớp này cần bơi nên thêm interface bơi vào để nhắc nhở
public class Dog : Animal, ISwim
{
    public override void Sound()
    {
        Console.WriteLine("Gok Gok...");
    }

    public void Swim()
    {
        Console.WriteLine("I'm Swimming!");
    }
}