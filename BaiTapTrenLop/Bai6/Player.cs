namespace BaiTapTrenLop.Bai6;

public class Player : IDamageable
{
    private int hp = 7000;
    public void TakeDamage(int damage)
    {
        if (hp <= 0)
        {
            Console.WriteLine("Player is already dead!");
            return;
        }

        hp -= damage;
        Console.WriteLine($"HP cua nguoi choi con: {hp}");
        if (hp <= 0)
        {
            Console.WriteLine("Dead");
        }
    }
}