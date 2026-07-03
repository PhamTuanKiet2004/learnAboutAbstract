namespace BaiTapTrenLop.Bai8;

public class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        int luong = 25000 * 8;
        Console.WriteLine($"Luong cua nhan vien full time = {luong}");
    }
}