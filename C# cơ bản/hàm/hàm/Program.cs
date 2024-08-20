//========================================================================================\\

//Cú pháp khai báo hàm:          
//[Từ khóa 1][Từ khóa 2][Từ khóa n]  < Kiểu dữ liệu trả về> <Tên hàm>([Parameter]){ }
    //Trong đó:
        //- [Từ khóa 1], [Từ khóa 2], [Từ khóa n] là các từ khóa như: public, static, read only … và có thể không điền.
        //- Kiểu dữ liệu trả về như: từ khóa void, hay mọi kiểu dữ liệu như int, long, bool, SinhVien…

//Tên hàm:
    //Là tên gọi của hàm.
    //Tên bạn có thể đặt tùy ý nhưng nên đặt tên theo quy tắc đặt tên để có sự đồng bộ ngầm định giữa các lập trình viên và dễ tìm, dễ nhớ (xem lại quy tắc đặt tên ở bài BIẾN TRONG C#).
    //Hãy xem cách khởi tạo hàm giống khởi tạo một biến ở chỗ. Đều cần kiểu dữ liệu và tên. Có thể có các từ khóa. Tên để tái sử dụng hàm ở nơi mong muốn.
    //Parameter là tham số truyền vào để sử dụng nội bộ trong hàm. Cấu trúc khởi tạo như một biến bình thường. Có thể không điền.
    //Hàm chỉ được khai báo bên trong class.
//Lưu ý:
    //Mọi hàm đều phải có cặp ngoặc nhọn { } biểu thị là một khối lệnh. Mọi dòng code xử lý của hàm đều được viết bên trong cặp ngoặc nhọn { } này.
    //Không thể khai báo một hàm trong một hàm khác theo cách thông thường.

//Một hàm cơ bản hay thấy với cấu trúc bắt buộc phải có trong lập trình C# console hàm Main
//    static void Main(string[] args)
//            {
//                       }

//Trong đó:
    //- static là từ khóa static. Có thể không sử dụng cũng được. Nhưng ở trường hợp hàm Main của console C# thì phải có.
    //- void là kiểu trả về. Với hàm có kiểu trả về là void thì sẽ không cần từ khóa return trong hàm. Hoặc có nhưng chỉ đơn giản là ghi return;
    //- Main là tên hàm. Có thể đặt tùy ý. Nhưng ở trường hợp này là bắt buộc phải là Main vì mỗi chương trình console C# đều cần hàm Main.
    //- string[] args là parameter truyền từ bên ngoài vào để sử dụng hàm. Có thể không có cũng được. 
    //nhưng ở trường hợp hàm Main của console C# là bắt buộc phải có. Ở đây có thể thay thế tên args bằng bất cứ tên nào khác như đặt tên một biến bình thường.

//========================================================================================\\
namespace hàm
{
    internal class Program
    {
#if false
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                testham();
            }
            Console.WriteLine(ReturnANumber());
            Console.ReadKey();
        }
        //VD hàm void
        static void testham()
        {
            Console.WriteLine("tran ngoc hung");
        }
        //VD hàm khác
        // <summary>
        // Hàm trả về giá trị số nguyên 5 thông qua tên hàm
        // Lưu ý giá trị trả về phải cùng kiểu dữ liệu với kiểu trả về của hàm
        // Ở đây là kiểu int
        // </summary>
        // <returns></returns>

        static int ReturnANumber()
        {
            // bắt buộc phải có cấu trúc return trong thân hàm
            return 5;
        }
#endif
#if false    //VD dùng biến toàn cục và Parametter trong hàm
        //Parametter:
        // khi sử dụng hàm phải truyền đúng số lượng, thứ tự parameter vào như khai báo của hàm
        // đồng thời kiểu dữ liệu truyền vào của parameter phải trùng khớp với khai báo của hàm
        static void Main(string[] args)
        {
            Console.WriteLine(SumTwoNumber());

            //Parametter
            Console.WriteLine(SumTwoNumber1(7, 10));
            Console.ReadKey();
        }
        /// <summary>
        ///  hai biến firstNumber và secondNumber hiện là biến toàn cục của các hàm nằm bên trong class Program nhưng lại là biến cục bộ của class Program
        ///  Cần có từ khóa static vì các hàm sử dụng nó đều có từ khóa static
        /// </summary>

        // Biến toàn cục
        static int firstNumber = 5;
        static int secondNumber = 10;
        /// <summary>
        /// hàm trả ra kết quả tổng của 2 số firstNumber và secondNumber
        /// </summary>
        /// <returns></returns>

        static int SumTwoNumber()
        {
            return firstNumber + secondNumber;
        }

        static int SumTwoNumber1(int firstNumber1, int secondNumber1)
        {
            return firstNumber1 + secondNumber1;
        }
#endif
#if false //VD tính toán bằng hàm
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            for (int i = 1; i < 10; i++)
            {
                // in ra màn hình tổng của 2 số
                inketqua(a, b);

                // tính toán để tạo ra 2 số mới. Không quan trọng lắm
                a += i;
                b += i * 2 % 5;
            }
        }
        static void inketqua(int A, int B)
        {
            int S = 0; 
            S = A + B;
            Console.WriteLine("{0} + {1} = {2}", A, B, tinhtoan(A, B));
        }
        static int tinhtoan(int A1, int B1)
        {
            return A1 + B1;
        }
#endif
#if true //Ví dụ về các parameter với kiểu dữ liệu khác nhau
        static void Main(string[] args)
        {
            PrintSomeThing("K9", 22);
            PrintSomeThing("HowKteam.com", 1);
            Console.ReadKey();
        }


        static void PrintSomeThing(string name, int age)
        {
            // in ra màn hình tên và tuổi được truyền vào
            Console.WriteLine("This is {0}, {1} years old.", name, age);
        }
#endif
    }
}