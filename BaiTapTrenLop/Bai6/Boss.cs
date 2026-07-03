namespace BaiTapTrenLop.Bai6;

public class Boss : IDamageable
{
    private int hp = 70000;
    public void TakeDamage(int damage)
    {
        if (hp <= 0)
        {
            Console.WriteLine("Boss is already dead!");
            return;
        }

        hp -= damage;
        Console.WriteLine($"HP cua Boss con: {hp}");
        if (hp <= 0)
        {
            Console.WriteLine("Dead");
        }
    }
}