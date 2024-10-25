//===================================================================================================\\

//Tuple là một kiểu dữ liệu có cấu trúc, giúp lưu trữ các dữ liệu phức tạp mà không cần phải tạo ra một struct hay class mới
//(Nếu chưa nắm về kiểu dữ liệu có cấu trúc cũng như struct, class thì có thể xem lại bài STRUCT TRONG C# và CLASS TRONG C#).

//C# cung cấp cho chúng ta:
//8 lớp generic (khái niệm về generic đã được trình bày trong bài GENERIC TRONG C#) Tuple<>.
//public class Tuple<T1>
//public class Tuple<T1, T2>
//public class Tuple<T1, T2, T3>
//public class Tuple<T1, T2, T3, T4>
//public class Tuple<T1, T2, T3, T4, T5>
//public class Tuple<T1, T2, T3, T4, T5, T6>
//public class Tuple<T1, T2, T3, T4, T5, T6, T7>
//public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
//Mỗi lớp Tuple<> đã được định nghĩa sẵn các Property có tên Item1, Item2, Item3,… tương ứng với các kiểu dữ liệu T1, T2, T3,… được truyền vào. 

//Sử dụng Tuple như thế nào khi đã có struct và class?
//thắc mắc Tuple được sử dụng khi nào trong khi đã có struct và class?
//Trường hợp đầu tiên là khi bạn viết một phương thức và muốn trả về 1 lúc nhiều giá trị. Lúc này Tuple sẽ giúp bạn dễ dàng giải quyết mà không cần phải tạo thêm struct hay class.
//Trong nhiều trường hợp khác bạn chỉ muốn tạo nhanh 1 đối tượng với 1 vài thuộc tính
//và chỉ sử dụng 1 lần thôi thì việc dùng struct hoặc class là rất lãng phí, làm chương trình của bạn trở nên dài dòng hơn.
//Khi đó Tuple được sử dụng như một phương án thay thế tốt hơn vì có sẵn rồi giờ lấy ra dùng thôi không cần khai báo gì nữa.

//Ngoài ra, Tuple đã override sẵn:
//Phương thức Equals (phương thức dùng để so sánh 2 đối tượng).
//Phương thức ToString (Phương thức chuyển giá trị đối tượng sang chuỗi).
//Phương thức GetHashCode (Phương thức trả về mã băm của một đối tượng, dùng để hỗ trợ so sánh 2 đối tượng).
//Từ đó chúng ta chỉ việc sử dụng mà không cần phải viết lại những phương thức này.

//===================================================================================================\\
namespace Tuple_trong_CSharp
{
    internal class Program
    {
#if false
        static void Main(string[] args)
        {
            //Cách sử dụng Tuple
            //Đầu tiên là khởi tạo một đối tượng Tuplechúng ta có 2 cách:
            //Cách 1: Thông qua phương thức Create trong lớp Tuple:

            //Khởi tạo Tuple thông qua phương thức Create
            var MyTuple = Tuple.Create<int, string>(1, "HowKteam");
            //Ví dụ trên có nghĩa là tạo ra 1 đối tượng(Tuple) có 2 thuộc tính bên trong:
            //Thuộc tính thứ nhất(Item1) có kiểu dữ liệu là int và khởi tạo giá trị là 1.
            //Thuộc tính thứ hai(Item2) có kiểu dữ liệu là string và khởi tạo giá trị là “HowKteam”.

            //Cách 2: Thông qua Constructor của các lớp Generic:
            // Khởi tạo Tuple thông qua constructor của các lớp generic
            var MyTuple2 = new Tuple<int, string, string>(2, "Kteam", "Tran Ngoc Hung");
            //Ví dụ này cũng được hiểu tương tự như trên.
            //Khi bạn khởi tạo Tuple có bao nhiêu kiểu dữ liệu thì sẽ có bấy nhiêu thuộc tính Item tương ứng.Hình dưới đây là minh hoạ cho Tuple<T1, T2>:

            //Ví dụ: in ra giá trị các thuộc tính đã khởi tạo ở trên:
            // Lấy giá trị bên trong Tuple
            Console.WriteLine(" ID: {0}, Name: {1}", MyTuple.Item1, MyTuple.Item2);
            Console.WriteLine(" ID: {0}, Name1: {1}, Name2: {2}", MyTuple2.Item1, MyTuple2.Item2, MyTuple2.Item3);
            //Lúc này ta đã hiểu Tuple cũng chỉ là một lớp bình thường đã được định nghĩa sẵn thôi.
            //Vì vậy để giải quyết bài toán trả về nhiều giá trị cùng một lúc ta đơn giản chỉ cần khai báo kiểu trả về là 1 Tuple mà thôi.
        }
#endif
#if true
        //Xét ví dụ sau: Viết chương trình trả về 3 giá trị là ngày, tháng, năm hiện tại của hệ thống.
        //Đầu tiên viết phương thức trả về 3 giá trị ngày, tháng, năm:
        static Tuple<int, int, int> GetCurrentDayMonthYear()
        {
            DateTime now = DateTime.Now; // lấy ngày giờ hiện tại của hệ thống.
            /* Sử dụng Constructor của Tuple<> để trả về hoặc có thể sử dụng phương thức Create đã trình bày ở trên. */
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
        static void Main(string[] args)
        {
            var now = GetCurrentDayMonthYear();
            Console.WriteLine(" Day: {0}, Month: {1}, Year: {2}", now.Item1, now.Item2, now.Item3);
            Console.ReadKey();
        }
#endif
    }
}