//===============================================================================\\

//Khai báo mảng 2 chiều %%%%%%%%%%%% có 3 cách khai  báo tương tự như mảng 1 chiều
//Cú pháp:
//<kiểu dữ liệu> [ , ] <tên mảng>;

//Trong đó:
//<kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
//Cặp dấu [ ,] là ký hiệu cho khai báo mảng 2 chiều.
//<tên mảng> là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến (quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).

//Để sử dụng được mảng ta phải khởi tạo giá trị hoặc cấp phát vùng nhớ cho mảng.

//Cấp phát vùng nhớ
//Được thực hiện thông qua toán tử new. 
//Lưu ý là khi cấp phát vùng nhớ cho mảng 2 chiều ta cần chỉ ra số dòng và số cột tối đa của mảng.

//Sau khi mảng được cấp phát vùng nhớ thì các phần tử trong mảng sẽ mang giá trị mặc định:    
//Đối với số nguyên là 0.
//Đối với số thực là 0.0.
//Đối với kiểu ký tự là ‘’ (ký tự rỗng).
//Đối với kiểu tham chiếu là null.

//Khởi tạo giá trị
//Cú pháp:
//< kiểu dữ liệu>[,] < tên mảng > =
//{
//    { < giá trị dòng 1 cột 1 >, …, < giá trị dòng 1 cột n> },
//            …
//    { < giá trị dòng m cột 1 >, …, < giá trị dòng m cột n > }
//};
//===============================================================================\\
using System.Diagnostics.Metrics;

namespace mang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if true
            /* VD cấp phát vùng nhớ mảng 2 chiều
             * Khai báo mảng 2 chiều kiểu string và có tên là Kteam.
             * Sau đó thực hiện cấp phát vùng nhớ với số dòng là 2 và số cột là 3.
             */
            string[,] Kteam = new string[2, 3];

            //Khai báo, cấp phát và khởi tạo giá trị cho mảng
            string[,] Kteam1 = new string[,]
            {
            { "HowKteam", "Free Education" },
            { "HowKteam.com", "Share to be better" }
            };
            //VD khởi tạo giá trị         
            int[,] Intarray =
                    {
                        {1, 2},
                        {3, 4},
                        {5, 6}
                    };
            /*
             * Duyệt mảng 2 chiều theo cột
             * Các bạn để ý sự thay đổi trong 2 vòng lặp
             */
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    /* 
                     * Lưu ý là các phần tử được truy xuất là IntArray[j, i] thay vì IntArray[i, j]
                     * Code xử lý 
                     */
                }
            }
            /*
             * Như đã trình bày ở phần trước thì:
             * GetLength(0) sẽ trả về số dòng của mảng 2 chiều
             * GetLength(1) sẽ trả về số cột của mảng 2 chiều
             */
            for (int i = 0; i < Intarray.GetLength(0); i++)
            {
                for (int j = 0; j < Intarray.GetLength(1); j++)
                {
                    // Code xử lý
                }
            }
#endif
#if true   // BÀI TẬP
            //VD bài tập
            string strrow, strcol;
            int Rows, Cols;
            Console.Write(" Moi ban nhap so dong cua mang: ");
            strrow = Console.ReadLine();
            Console.Write(" Moi ban nhap so cot cua mang: ");
            strcol = Console.ReadLine();

            if(int.TryParse(strrow, out Rows) == false || int.TryParse(strcol, out Cols) == false)
            {
                Console.WriteLine("Gia tri nhap vao khong dung");
            }else

            Rows = int.Parse(strrow);
            Cols = int.Parse(strcol);

            // Tạo 1 mảng 2 chiều với số dòng và số cột đã nhập
            int[,] IntArray = new int[Rows, Cols];
            /* 
             * Duyệt mảng để nhập giá trị cho các phần tử
             * Ở đây mình muốn minh họa cách sử dụng mảng nên mình bỏ qua các bước kiểm tra dữ liệu mà ép kiểu trực tiếp
             * Điều này có thể gây lỗi khi nhập sai nên các bạn hãy cải tiến chương trình này cho đầy đủ nhé!
             */
            //Nhập mảng 2 chiều
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            /*
             * In mảng 2 chiều đã nhập ra màn hình
             * Để tính tổng các giá trị trong mảng ta chỉ cần duyệt qua các phần tử và cộng chúng lại với nhau
             * Tận dụng lúc duyệt mảng để in giá trị ta sẽ thực hiện tính tổng luôn để tránh phải duyệt lại mảng thêm lần nữa.
             */
            int Sum = 0;

            //xuất mảng 2 chiều
            Console.WriteLine("\n Mang ban vua nhap la: ");
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(IntArray[i, j] + " ");
                    Sum = Sum + IntArray[i, j];
                }
                // Sau khi in xong mỗi dòng ta thực hiện xuống dòng rồi mới in tiếp
                Console.WriteLine();
            }
            Console.WriteLine(" Tong cac gia tri trong mang: " + Sum);
#endif
            Console.ReadKey();
        }
    }
}