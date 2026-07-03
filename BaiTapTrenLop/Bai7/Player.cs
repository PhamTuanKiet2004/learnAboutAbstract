namespace BaiTapTrenLop.Bai7;

public class Player : IDamageable, IInteractable
{
    private int hp = 10000;

    public void TakeDamage(int damage)
    {
        if (hp <= 0)
        {
            Console.WriteLine("[Player] Player is already dead!");
            return;
        }

        hp -= damage;
        Console.WriteLine($"[Player] Nhan {damage} sat thuong. HP con lai: {hp}");
        if (hp <= 0)
        {
            Console.WriteLine("[Player] Dead");
        }
    }

    public void Interact()
    {
        Console.WriteLine("[Player] Dang tuong tac...");
    }
}