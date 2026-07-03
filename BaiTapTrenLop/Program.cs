using BaiTapTrenLop.Bai2;
using BaiTapTrenLop.Bai3;
using BaiTapTrenLop.Bai4;
using BaiTapTrenLop.Bai5;
using BaiTapTrenLop.Bai6;
using BaiTapTrenLop.Bai8;
using BaiTapTrenLop.Bai9;
using Duck1 = BaiTapTrenLop.Bai4.Duck;
using Duck = BaiTapTrenLop.Bai1.Duck;



/*Console.WriteLine("Bai 1");
Animal dog = new Dog();
dog.Eat();
dog.Sound();
Animal cat = new Cat();
cat.Eat();
cat.Sound();
Animal duck = new Duck();
duck.Eat();
duck.Sound();

Console.WriteLine("Bai 2");
Vehicle car = new Car();
car.Start();
car.Stop();
car.Move();
Vehicle bike = new Bike();
bike.Start();
bike.Move();
bike.Stop();
Vehicle boat =  new Boat();
boat.Start();
boat.Stop();
boat.Move();*/

/*Console.WriteLine("Bai 3");
Bird chim = new Bird();
chim.Fly();
Superman  superman = new Superman();
superman.Fly();
Airplane airplane = new Airplane();
airplane.Fly();

Console.WriteLine("Bai 4");
Duck1 duck1 = new Duck1();
duck1.Fly();
duck1.Swim();
Eagle eagle = new Eagle();
eagle.Fly();
Fish fish = new Fish();
fish.Swim();

Console.WriteLine("Bai 5");
Character archer = new Archer();
archer.Attack();
Character mage = new Mage();
mage.Attack();
Character warrior = new Warrior();
warrior.Attack();*/

/*
Console.WriteLine("Bai 6");
int enemyDamage = 1000;
int bossDamage = 2000;
int playerDamage = 1000;
Player player = new Player();
player.TakeDamage(enemyDamage);
player.TakeDamage(bossDamage);
player.TakeDamage(5000); // Gây thêm sát thương để hiển thị trạng thái Dead

Boss boss = new Boss();
boss.TakeDamage(playerDamage);

Enemy enemy = new Enemy();
enemy.TakeDamage(playerDamage);
enemy.TakeDamage(4000); // Gây thêm sát thương để hiển thị trạng thái Dead

Console.WriteLine("\nBai 7");
var player7 = new BaiTapTrenLop.Bai7.Player();
var enemy7 = new BaiTapTrenLop.Bai7.Enemy();
var coin7 = new BaiTapTrenLop.Bai7.Coin();
var chest7 = new BaiTapTrenLop.Bai7.Chest();

Console.WriteLine("--- Tuong tac ---");
player7.Interact();
chest7.Interact();

Console.WriteLine("--- Thu thap ---");
coin7.Collect();

Console.WriteLine("--- Chien dau ---");
enemy7.TakeDamage(1000);
enemy7.TakeDamage(2500); // Sát thương vượt quá HP (3000) -> Dead

player7.TakeDamage(5000);
player7.TakeDamage(6000); // Sát thương vượt quá HP (10000) -> Dead


Console.WriteLine("Bai 8");
Employee employee = new FullTimeEmployee();
employee.CalculateSalary();
Employee employeeParttime = new PartTimeEmployee();
employeeParttime.CalculateSalary();
*/


Console.WriteLine("Bai 9");
Console.Write("Nhap so tien can thanh toan: ");
if (decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    Console.WriteLine("Chon phuong thuc thanh toan:");
    Console.WriteLine("1. PayPal");
    Console.WriteLine("2. Bank Transfer");
    Console.WriteLine("3. Credit Card");
    Console.Write("Lua chon cua ban (1-3): ");
    string choice = Console.ReadLine();

    IPayment paymentMethod = null;

    switch (choice)
    {
        case "1":
            paymentMethod = new PayPal();
            break;
        case "2":
            paymentMethod = new BankTransfer();
            break;
        case "3":
            paymentMethod = new CreditCard();
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }

    if (paymentMethod != null)
    {
        paymentMethod.Pay(amount);
    }
}
else
{
    Console.WriteLine("So tien nhap vao khong hop le!");
}

Console.WriteLine("\nBai 10");
var warrior10 = new BaiTapTrenLop.Bai10.Warrior("Thor", 100);
var mage10 = new BaiTapTrenLop.Bai10.Mage("Gandalf", 80);
var healer10 = new BaiTapTrenLop.Bai10.Healer("Mercy", 90);

warrior10.Move();
mage10.Move();
healer10.Move();

warrior10.Attack(mage10);
mage10.Attack(warrior10);
healer10.CastHeal(warrior10);

Console.WriteLine("\nChallenge");
var gameObjects = new System.Collections.Generic.List<object>
{
    new BaiTapTrenLop.Challenge.Player("Arthur", 120),
    new BaiTapTrenLop.Challenge.Enemy("Goblin 1", 30),
    new BaiTapTrenLop.Challenge.Enemy("Goblin 2", 30),
    new BaiTapTrenLop.Challenge.Enemy("Goblin 3", 30),
    new BaiTapTrenLop.Challenge.Boss("Dragon Lord", 250),
    new BaiTapTrenLop.Challenge.Coin("Golden Coin 1"),
    new BaiTapTrenLop.Challenge.Coin("Golden Coin 2"),
    new BaiTapTrenLop.Challenge.Coin("Golden Coin 3"),
    new BaiTapTrenLop.Challenge.Coin("Golden Coin 4"),
    new BaiTapTrenLop.Challenge.Coin("Golden Coin 5"),
    new BaiTapTrenLop.Challenge.Chest("Ancient Chest 1"),
    new BaiTapTrenLop.Challenge.Chest("Ancient Chest 2")
};

foreach (var obj in gameObjects)
{
    if (obj is BaiTapTrenLop.Challenge.IDamageable damageable)
    {
        damageable.TakeDamage(20);
    }
    else if (obj is BaiTapTrenLop.Challenge.ICollectable collectable)
    {
        collectable.Collect();
    }
    else if (obj is BaiTapTrenLop.Challenge.IInteractable interactable)
    {
        interactable.Interact();
    }
}

