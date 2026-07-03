namespace BaiTapTrenLop.Bai9;

public class PayPal : IPayment
{
    public void Pay(decimal amount)
    {
        string Type = this.GetType().Name;
        Console.WriteLine($"Paying by {Type} with total: {amount}");
        Console.WriteLine("Thanh toan thanh cong");
    }
}