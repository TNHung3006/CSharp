//===========================================================================\\
//Khái niệm về hằng:
    //Là một biến những giá trị không thay đổi trong suốt chương trình.
    //Bắt buộc phải khởi tạo giá trị khi khai báo.

//Tại sao phải có hằng?
    //Để ngăn chặn việc gán giá trị khác vào biến.
    //Hằng làm cho chương trình dễ đọc hơn bằng cách biến những con số vô cảm thành những tên có nghĩa.
    //Hằng giúp cho chương trình dễ nâng cấp, dễ sửa chữa hơn.
    //Hằng giúp cho việc tránh lỗi dễ dàng hơn. Nếu bạn vô ý gán giá trị cho một biến hằng ở đâu thì trình biên dịch sẽ báo lỗi ngay lập tức.

//Có mấy loại hằng? Ý nghĩa và cách sử dụng từng hằng
//Trong C#, hằng được chia làm 3 loại:
    //Giá trị hằng.
    //Biểu tượng hằng.
    //Kiểu liệt kê.

//Giá trị hằng
    //Ta có câu lệnh gán sau:const int x = 10;
    //Giá trị 10 là giá trị hằng. Giá trị 10 luôn là 10 và ta không thể gán giá trị khác cho 10 được.

//Biểu tượng hằng
    //Việc gán một tên cho giá trị hằng được xem là một biểu tượng hằng.
    //Xét lại câu lệnh: x = 10; thì x được xem là biểu tượng hằng.
//Kiểu liệt kê
    //Kiểu liệt kê là tập hợp các tên hằng có giá trị không thay đổi, sẽ được trình bày chi tiết trong bài ENUM TRONG C#.

//Cú pháp để tạo một biểu tượng hằng:
    //const <kiểu dữ liệu> <tên biến> = <giá trị hằng>;

//Một số lưu ý khi sử dụng hằng:
    //Hằng bắt buộc phải được khởi tạo giá trị ngay khi khai báo và không được thay đổi giá trị trong suốt chương trình.
    //Giá trị của hằng được tính toán vào lúc biên dịch nên không thể gán trực tiếp giá trị của biến vào hằng.
    //Nếu muốn làm điều đó thì phải sử dụng từ khóa readonly trước khai báo biến (readonly là từ khóa chỉ cho trình
    //biên dịch biết rằng biến này chỉ được đọc, lấy giá trị chứ không được gán giá trị)
    //Hằng bao giờ cũng static nhưng ta không được đưa từ khóa này vào khai báo hằng
    //(chi tiết về từ khóa static sẽ được trình bày trong bài  TỪ KHÓA STATIC TRONG C#)

//===========================================================================\\
namespace hang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int x = 10; const int y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}