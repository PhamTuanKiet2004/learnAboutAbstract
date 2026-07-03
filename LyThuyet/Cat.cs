namespace LyThuyet;

public class Cat : Animal
{
    
    // Thêm chữ ovveride, phương thức phải định nghĩa do nó là abs ở lop cha
    public override void Sound()
    {
        Console.WriteLine("Meo meo...");
    }
}