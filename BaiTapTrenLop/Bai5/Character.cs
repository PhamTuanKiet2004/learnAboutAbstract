namespace BaiTapTrenLop.Bai5;

public abstract class Character
{
    private string Name;
    private int HP;
    public abstract void Attack();

    public void Move()
    {
     Console.WriteLine("I'm moving ");   
    }
}