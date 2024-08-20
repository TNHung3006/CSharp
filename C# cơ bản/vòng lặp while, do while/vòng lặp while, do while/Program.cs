//===========================================================================\\

//Cấu trúc của một vòng lặp while trong C#
//Cú pháp:    
//       while (<Điều kiện lặp>)
//            {
//                // khối lệnh lặp lại
//            }

//Điều kiện lặp là một biểu thức logic bắt buộc phải có với kết quả trả về bắt buộc là true hoặc false.
//Từ khóa while biểu thị đây là một vòng lặp while.
//Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc vòng lặp while.
//Tiến trình:
    //Đầu tiên trình biên dịch sẽ đi vào dòng while (<Điều kiện lặp>). Kiểm tra điều kiện lặp có thỏa mãn hay không.
    //Nếu kết quả là true thì sẽ đi vào bên trong thực hiện khối code. Khi gặp ký tự } sẽ quay lên kiểm tra điều kiện lặp và tiếp tục thực hiện khối code.
    //Quá trình chỉ kết thúc khi điều kiện lặp là false.
    //Điều kiện lặp luôn bằng true thì vòng lặp while sẽ trở thành vòng lặp vô tận.
    //Điều kiện lặp luôn bằng false thì vòng lặp sẽ không được thực thi.

//Cấu trúc của một vòng lặp do while trong C#           
//Cú pháp:
    //do
    //    {
    //            // khối lệnh lặp lai
    //    } while (<Điều kiện lặp>);

//Điều kiện lặp là một biểu thức logic bắt buộc phải có với kết quả trả về bắt buộc là true hoặc false.
//Từ khóa do while biểu thị đây là một vòng lặp do while.
//Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc vòng lặp do while.
//Tiến trình:
    //Đầu tiên trình biên dịch sẽ đi vào dòng do và thực hiện khối lệnh bên trong. Sau đó khi gặp ký tự } sẽ kiểm tra điều kiện lặp có thỏa mãn hay không.
    //Nếu kết quả là true thì sẽ quay lại ký tự { thực hiện khối code. Quá trình chỉ kết thúc khi điều kiện lặp là false.
    //Điều kiện lặp luôn bằng true thì vòng lặp while sẽ trở thành vòng lặp vô tận.
    //Điều kiện lặp luôn bằng false thì vòng lặp sẽ không được thực thi.
    //Lưu ý: vòng lặp do while sẽ thực hiện câu lệnh trong khối code xong rồi mới kiểm tra điều kiện lặp. Cuối vòng lặp do while có dấu ; ở cuối.

//===========================================================================\\
namespace vòng_lặp_while__do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false   //VD vòng lặp while
            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 5;

            // Vẽ từ trên xuống LoopTime lần
            while (countLoopTime < loopTime)
            {
                // reset lại biến countLoop về 0 để viết lại từ đầu
                countLoop = 0;

                // vẽ từ trái qua valueNum lần
                while (countLoop < valueNum)
                {
                    // in ra giá trị của countLoop trong 8 vị trí
                    Console.Write("{0,7}", countLoop);

                    // tăng giá trị của biến countLoop lên một đơn vị
                    countLoop++;
                }

                // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                Console.WriteLine();

                // tăng giá trị countLoopTime lên một đơn vị
                countLoopTime++;
            }
#endif
#if false    //VD in ra ma trận số với giá trị ngẫu nhiên bằng cách sử dụng lớp Random = vòng lặp while. (Phần sử dụng lớp Random được hướng dẫn ở bài RANDOM TRONG C#)
            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 5;
            int minRandomValue = 0;
            int maxRandomValue = 100;

            Random rand = new Random();

            // Vẽ từ trên xuống LoopTime lần
            while (countLoopTime < loopTime)
            {
                // reset lại biến countLoop về 0 để viết lại từ đầu
                countLoop = 0;

                // vẽ từ trái qua valueNum lần
                while (countLoop < valueNum)
                {
                    // giá trị sinh ngẫu nhiên trong khoảng [minRandomValue . . maxRandomValue - 1]
                    int showValue = rand.Next(minRandomValue, maxRandomValue);

                    // in ra giá trị của showValue trong 8 vị trí
                    Console.Write("{0,8}", showValue);

                    // tăng giá trị của biến countLoop lên một đơn vị
                    countLoop++;
                }
                // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                Console.WriteLine();

                // tăng giá trị countLoopTime lên một đơn vị
                countLoopTime++;
            }
#endif
#if false    //VD vẽ hình chữ nhật rỗng = vòng lặp while

            int Vertical = 20;
            int Horizontal = 50;
            char drawChar = '*';
            char insideChar = ' ';
            int countLoopVertical = 0;
            int countLoopHorizontal = 0;


            // Vẽ từ trên xuống
            while (countLoopVertical < Vertical)
            {
                // khởi tạo lại giá trị countLoopHorizontal = 0 mỗi lần lặp mới
                countLoopHorizontal = 0;

                // Vẽ từ trái sang
                while (countLoopHorizontal < Horizontal)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */
                    if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
                    {
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                    // tăng giá trị của countLoopHorizontal lên 1 đơn vị
                    countLoopHorizontal++;
                }

                // mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();

                // tăng giá trị của countLoopVertical lên 1 đơn vị
                countLoopVertical++;
            }
#endif
#if true    //VD vòng lặp Do While
            int countLoop = 0;
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 5;


            // Vẽ từ trên xuống LoopTime lần
            do
            {
                // reset lại biến countLoop về 0 để viết lại từ đầu
                countLoop = 0;

                // vẽ từ trái qua valueNum lần
                while (countLoop < valueNum)
                {
                    // in ra giá trị của countLoop trong 8 vị trí
                    Console.Write("{0,7}", countLoop);

                    // tăng giá trị của biến countLoop lên một đơn vị
                    countLoop++;
                }
                // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
                Console.WriteLine();

                // tăng giá trị countLoopTime lên một đơn vị
                countLoopTime++;

            } while (countLoopTime < loopTime);
            Console.ReadKey();
#endif
            Console.ReadKey();
        }
    }
}