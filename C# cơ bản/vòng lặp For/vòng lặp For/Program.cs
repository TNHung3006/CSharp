//===========================================================================\\

//Cú pháp:
    //for ([Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại])
    //{
    //// Khối lệnh được lặp lại. Có thể bỏ trống
    //}

//Trong đó:
    //Các phần [Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại] hoàn toàn có thể để trống như ví dụ sau.
    //Mỗi đoạn [Khởi tạo]; hay [Điều kiện lặp]; hay [Bước lặp lại] là một câu lệnh riêng.
//Tiến trình:
    //Ban đầu trình biên dịch sẽ di vào phần khởi tạo chạy đoạn lệnh khởi tạo.
    //Tiếp theo kiểm tra điều kiện lặp. Rồi thực hiện khối code bên trong vòng lặp for. Khi đến ký hiệu } thì sẽ quay lên bước lặp lại.
    //Sau đó lại kiểm tra điều kiện lặp rồi tiếp tục thực hiện đoạn code trong khối lệnh. Đến khi điều kiện lặp không còn thõa mãn thì sẽ kết thúc vòng lặp for.
//Trường hợp khác:
//    for (; ;)   // lưu ý dấu ;
//    {
//    // Khối lệnh được lặp lại. Có thể bỏ trống
//    }
//Trong đó:
    //Vòng lặp for này trở thành vòng lặp vô tận.
    //Lưu ý dấu ; vẫn phải có.



//===========================================================================\\

namespace vòng_lặp_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false
            ////VD VÒNG LẶP FOR
            int i;
            ////VD 1
            //// i sẽ được khởi tạo lần đầu tiên tại vòng lặp for
            //// khi vòng đời của vòng lặp for kết thúc bộ nhớ của biến i sẽ được giải phóng
            //// hay nói cách khác i là biến cục bộ của vòng lặp for
            //for (i = 0; ;)
            //{
            //    Console.WriteLine(i);
            //}
            ////VD 2          
            //// vòng lặp for này vẫn lặp vô tận vì không bao giờ thỏa mãn điều kiên dừng
            //// i luôn == 0
            //// Điều kiện lặp luôn là true
            //for (i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //}
            ////thêm bước lặp lại để không bị lặp vô tận
            //for (i = 0; i < 10; )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            ////có thể đặt true false vào điều kiện lặp. 
            //for (i = 0; true; i++)
            //{
            //    Console.WriteLine(i);              
            //    if (i == 7) break;
            //}
            ////Hoặc một biểu thức logic phức tạp nhưng kết quả cuối cùng trả về là true hoặc false.
            //for (i = 0; (i % 3 == 0) && (i < 10); i++)
            //{
            //    Console.WriteLine(i);               
            //}
            //Chúng ta có thể thực hiện nhiều đoạn lệnh trong bước lặp.
            int j = 0;
            for (i = 0; i < 10; i++, j += 3)
            {
                Console.WriteLine("{0} | {1}", i, j);
            }
#endif
#if true    //VD Vẽ hình chữ nhật bằng vòng lặp for

            int N = 10;
            int M = 20;

            char drawChar = '*';
            char insideChar = ' ';
            
            // Vẽ từ trên xuống
            for (int i = 0; i < N; i++)
            {
                // Vẽ từ trái sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */
                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
                //mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();
            }
#endif
            Console.ReadKey();
        }
    }
}