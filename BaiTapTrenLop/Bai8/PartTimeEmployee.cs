namespace BaiTapTrenLop.Bai8;

public class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.Write("Nhap gio lam parttime = ");
        double time = double.Parse(Console.ReadLine());
        double Luong = time * 25000;
        Console.WriteLine($"Luong cua nhan vien parttime = {Luong}");
    }
}