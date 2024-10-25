//==========================================================================================================\\

//Delegate trong C# tương tự như con trỏ hàm trong C hoặc C++.
//Delegate là một biến kiểu tham chiếu(references) chứa tham chiếu tới một phương thức.
//Tham chiếu của Delegate có thể thay đổi runtime (khi chương trình đang thực thi).
//Delegate thường được dùng để triển khai các phương thức hoặc sự kiện call-back.
//Bạn cứ hiểu Delegate là một biến bình thường, biến này chứa hàm mà bạn cần gọi. Sau này lôi ra sài như hàm bình thường. 
//Giá trị của biến Delegate lúc này là tham chiếu đến hàm. Có thể thay đổi runtime khi chương trình đang chạy.
//Delegate được dẫn xuất từ lớp System.Delegate trong C#.

//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
//Tóm lại delegate chỉ là 1 biến thay thế cho hàm và sử dụng như hàm bình thường

//Khai báo Delegate trong C#
//Khai báo Delegate trong C# sẽ tương tự như khai báo một biến. Nhưng cần thêm từ khóa Delegate để xác định đây là một Delegate. 
//Đồng thời vì Delegate là để tham chiếu đến một hàm, nên cũng cần khai báo kèm kiểu dữ liệu trả về của 
//và tham số đầu vào của Delegate tương ứng với hàm tham chiếu.

//Công thức:
//delegate <kiểu trả về> <tên delegate> (<danh sách tham số nếu có>);
//VD: delegate int MyDelegate(string s);
//Lúc này chúng ta đã tạo một Delegate có tên là MyDelegate. MyDelegate có kiểu trả về là int, một tham số đầu vào là string.
//MyDelegate lúc này có thể dùng làm kiểu dữ liệu cho mọi Delegate tới hàm tương ứng kiểu trả về và tham số đầu vào. 

//Khởi tạo và sử dụng Delegate trong C#
//Khi kiểu Delegate được khai báo, đối tượng Delegate phải được tạo với từ khóa new và được tham chiếu đến một phương thức cụ thể. 
//Phương thức này phải cùng kiểu trả về và tham số đầu vào với Delegate đã tạo.
//Khi tạo một Delegate, tham số được truyền với biểu thức new được viết tương tự như một lời gọi phương thức, 
//nhưng không có tham số tới phương thức đó. Tức là chỉ truyền tên hàm vào thôi. 
//Delegate sẽ tự nhận định hàm được đưa vào có cùng kiểu dữ liệu trả ra và cùng tham số đầu vào hay không.





//==========================================================================================================\\
using System.Text;

namespace Delegate_trong_CSharp
{
    internal class Program
    {
#if true
        delegate int MyDelegate(string s);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;  //dùng để viết có dấu

            MyDelegate convertToInt = new MyDelegate(ConvertStringToInt); // tạo 1 biến bằng tên delegate và new đưa tên hàm vào trong tên delegate
                                                                          // sau đó sử dụng như hàm bình thường bằng tên delegate
            MyDelegate showstring = new MyDelegate(ShowString);
            MyDelegate multicast = convertToInt + showstring;

            string numberSTR = "35";

            int valueConverted = convertToInt(numberSTR);

            Console.WriteLine("Giá trị đã convert thành int: " + valueConverted);

            Console.WriteLine("kết quả sau khi gọi Multicast");
            multicast(numberSTR);         

            Console.ReadLine();
        }
        
        static int ConvertStringToInt(string stringValue)   //kiểu dữ liệu trả về và kiểu tham số đàu vào phải như delegate đã khai báo thì mới sử dụng được
        {
            int valueInt = 0;

            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Đã ép kiểu dữ liệu thành công");

            return valueInt;
        }
        static int ShowString(string stringValue)
        {
            Console.WriteLine(stringValue);
            return 0;
        }
#endif
#if false
        delegate int MyDelegate(string s);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;  //dùng để viết có dấu
            MyDelegate showstring = new MyDelegate(ShowString);

            nhapvashowten(showstring);

            Console.ReadLine();
        }
        static void nhapvashowten(MyDelegate Showten)
        {
            Console.WriteLine("moi nhap ho va ten cua ban:");
            string ten = Console.ReadLine();
            Showten(ten);
        }
        static int ShowString(string stringValue)
        {
            Console.WriteLine("ho ten cua ban la: " + stringValue);
            return 0;
        }
#endif
    }
}