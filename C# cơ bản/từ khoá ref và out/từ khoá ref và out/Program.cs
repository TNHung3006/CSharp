//================================================================================\\

//TỪ KHOÁ ref
    //Với mong muốn giá trị của value sẽ thay đổi sau khi kết thúc lời gọi hàm thì chúng ta sẽ thêm từ khóa ref phía trước kiểu dữ liệu 
    //của parameter mong muốn thay đổi giá trị khi khai báo hàm. Đồng thời phải thêm từ khóa ref ngay trước biến parameter truyền vào khi sử dụng hàm.
//Lưu ý:
    //Từ khóa ref phải có trước tên parametter của hàm và trước tên biến truyền vào khi gọi hàm sử dụng.
    //Truyền parameter có từ khóa ref bắt buộc phải là một biến (không thể truyền vào một hằng vì hằng là giá trị không thay đổi).
    //Có thể có một hoặc nhiều parameter với từ khóa ref trong lời khai báo hàm.
    //Biến truyền vào có từ khóa ref thì phải được khởi tạo giá trị trước khi truyền vào.
    //Hàm sử dụng sẽ thao tác trực tiếp với vùng nhớ của các parameter trên RAM. Cho nên kết thúc lời gọi hàm giá trị các parameter sẽ bị thay đổi.
//Từ khóa out
//Từ khóa out cũng tương tự từ khóa ref. Đó là:
    //Vùng nhớ của các parameter sẽ được hàm sử dụng thao tác trực tiếp, dẫn đến khi kết thúc lời gọi hàm giá trị của các parametter có thể bị thay đổi.
    //Phải có từ khóa out trước tên parameter của hàm và trước tên biến truyền vào khi gọi hàm sử dụng.
//Nhưng có một sự khác biệt đó là:
    //Biến truyền vào có từ khóa out sẽ không cần khởi tạo giá trị ban đầu.
    //Parameter đó chỉ như một thùng chứa kết quả trả về khi kết thúc gọi hàm.
    //Đồng thời parameter đó phải được khởi tạo ngay bên trong lời gọi hàm.
//================================================================================\\
namespace từ_khoá_ref_và_out
{
    internal class Program
    {
#if false //VD ref
        //giá trị sẽ giữ nguyên khi gọi hàm
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine("Value before increase: {0}", value);

            IncreaseValue(value);   // giá trị vẫn không thay đổi

            Console.WriteLine("Value after increase: {0}", value);

            Console.ReadKey();
        }
        static void IncreaseValue(int value)    // giá trị sẽ không thay đổi khi chuyển hàm
        {
            value++;
        }
#endif
#if false // giá trị thay đổi khi gọi hàm
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine("Value before increase: {0}", value);

            IncreaseValue(ref value);   // giá trị đã thay đổi

            Console.WriteLine("Value after increase: {0}", value);

            Console.ReadKey();
        }
        static void IncreaseValue(ref int value)
        {
            value++;
        }
#endif
#if true    //Từ khoá out
            //VD giá trị thay đổi theo hàm
        static void Main(string[] args)
        {
            int value = 5;

            Console.WriteLine("Value before increase: {0}", value);

            IncreaseValue(out value);   // giá trị thay đổi theo hàm

            Console.WriteLine("Value after increase: {0}", value);

            Console.ReadKey();
        }
        static void IncreaseValue(out int value)    
        {
            value = 1;
            value++;
        }
#endif
    }
}