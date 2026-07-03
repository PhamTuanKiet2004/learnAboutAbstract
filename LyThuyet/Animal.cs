namespace LyThuyet;

// Để các lớp con tuân thủ theo quy tắc của lớp cha (tức là báo lỗi khi thiếu hàm gì đó thì phải khởi tạo abs class
// Đây là 1 lớp truu tượng, lớp đại diện cho 1 cái khung    
public abstract class Animal
{
    private string Name{get;set;}
    public string Gender{get;set;}
    public void Sleep()
    {
        Console.WriteLine($"I'm is sleeping");
    }

    public void Eat()
    {
        Console.WriteLine($"I'm eating");
    }

    // Nhưng neu định nghĩa kêu cho animal thì nó không hop lí, vì mỗi con có tiếng kêu khác
    // => lớp abstract được sinh ra để giải quyết
    // Nếu khong co abs thì phải nhớ trong đầu rằng mỗi lớp mới khi kế thừa animal đều phai khoi tao hàm sounding bên trong nó
    // Nếu có quá nhiều ham mới mà kế thừa animal, khi quên khởi tạo => không có gì xảy ra cả => thiếu chuc năng
    // Có lớp abs thì khi quên khởi tao ở hàm con thì sẽ báo lỗi => như 1 lời nhắc nho 
    // Lớp abs vừa là lời nhắc nhở vừa là 1 khung để xây dựng => Rất quan trọng
    /*public void Sound()
    {
        Console.WriteLine($"I'm sounding");
    }*/
    // không de sound là public void nữa => biến nó thành 1 lớp trừu tượng, vì mỗi động vat kêu khác nhau
    // Biến nó thành 1 phương thức trừu tượng để nhắc nho các class con phai khai bao 1 ham Sound vì ở lớp cha có 1 thằng trừu tượng là sound
    
    // Phương thức trừu tượng, chỉ có tên không có phần thân, animal thì phải có tiếng kêu nhưng kêu như nào thì chưa quy định
    // Chỉ quy định khi lớp con kế thua 
    public abstract void Sound();
    
    
    // Bây giờ tạo 1 phương thức bay cho Animal thì sẽ co vấn đề => mèo, chó,.... không thể bay
    // => sinh ra lớp interface để giải quyết vấn đề
    // Nó co tác dụng như abs để nhắc nho rằng lớp nào thì cần phương thức nào
    // interface sinh ra để giải quyet các vấn đề nay, để co thể khai báo thuộc tính một cách linh hoạt hơn
}