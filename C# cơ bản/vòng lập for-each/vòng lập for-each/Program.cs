//=====================================================================================\\

//Cấu trúc lặp foreach cho phép chúng ta duyệt 1 mảng hoặc 1 tập hợp (được trình bày trong bài TỔNG QUAN VỀ COLLECTION TRONG C#).

//Một số đặc trưng của foreach:
//Foreach không duyệt mảng hoặc tập hợp thông qua chỉ số phần tử như cấu trúc lặp for.
//Foreach duyệt tuần tự các phần tử trong mảng hoặc tập hợp.
//Foreach chỉ dùng để duyệt mảng hoặc tập hợp ngoài ra không thể làm gì khác.

//Cú pháp:
//foreach (<kiểu dữ liệu> <tên biến tạm> in <tên mảng hoặc tập hợp>)
//{
//    // Code xử lý        
//}

//Trong đó:
//Các từ khoá foreach, in là từ khoá bắt buộc.
//<kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng hoặc tập hợp.
//<tên biến tạm> là tên 1 biến tạm đại diện cho phần tử đang xét khi duyệt mảng hoặc tập hợp.
//<tên mảng hoặc tập hợp> là tên của mảng hoặc tập hợp cần duyệt.

//Nguyên tắc hoạt động
//Foreach cũng có nguyên tắc hoạt động tương tự như các cấu trúc lặp khác cụ thể như sau:
//Ở vòng lặp đầu tiên sẽ gán giá trị của phần tử đầu tiên trong mảng vào biến tạm.
//Thực hiện khối lệnh bên trong vòng lặp foreach.
//Qua mỗi vòng lặp tiếp theo sẽ thực hiện kiểm tra xem đã duyệt hết mảng hoặc tập hợp chưa.
//Nếu chưa thì tiếp gán giá trị của phần tử hiện tại vào biến tạm và tiếp tục thực hiện khối lệnh bên trong.
//Nếu đã duyệt qua hết các phần tử thì vòng lặp sẽ kết thúc.

//Qua nguyên tắc hoạt động trên ta có thể thấy:
//Biến tạm trong vòng lặp foreach sẽ tương đương với phần tử i trong cách duyệt của vòng lặp for.
//Qua mỗi bước lặp ta chỉ có thể thao tác với giá trị của phần tử đang xét
//mà không thể tương tác với các phần tử đứng trước nó hay đứng sau nó (trong CẤU TRÚC VÒNG LẶP FOR TRONG C# thì hoàn toàn được).
//Bằng cách duyệt của foreach ta không thể thay đổi giá trị của các phần tử vì lúc này giá trị của nó đã được sao chép ra một 1 biến tạm và ta chỉ có thể thao tác với biến tạm.
//Thậm chí việc thay đổi giá trị của biến tạm cũng không được phép. Nếu ta cố làm điều đó thì sẽ gặp lỗi sau:

//Trong C#, có những danh sách, tập hợp mà ta không thể truy xuất đến các phần tử của nó thông qua chỉ số phần tử được 
//(ví dụ như kiểu List – sẽ được trình bày trong bài LIST TRONG C# hoặc các collection, generic – sẽ được trình bày trong bài COLLECTION TRONG C# và bài GENERIC TRONG C#).
//Trong trường hợp như vậy, để duyệt các danh sách, tập hợp có tính chất như trên thì foreach là lựa chọn tốt nhất.

//Foreach mang trong mình một số ưu điểm như:
//Câu lệnh ngắn gọn, sẽ sử dụng.
//Rất có ích khi duyệt danh sách, tập hợp mà không thể truy xuất thông qua chỉ số phần tử.
//Duyệt các danh sách, tập hợp có số phần tử không xác định hoặc số phần tử thay đổi liên tục.

//=====================================================================================\\
using System.Diagnostics;

namespace vòng_lập_for_each
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false   //VD foreach
            /*VD 1:
             * Khai báo mảng 1 chiều IntArray và khởi tạo giá trị.
             * Các bạn có thể xem lại cú pháp này ở bài Mảng 1 chiều trong C#
             * Khai báo 1 biến Sum để chứa giá trị tổng các phần tử trong mảng IntArray.
             */
            int[] IntArray = { 1, 3, 6, 7 };

            /*
             * Sử dụng foreach để duyệt mảng và in giá trị của các phần tử trong mảng.
             * Đồng thời tận dụng vòng lặp để tính tổng các phần tử trong mảng.
             */
            int sum = 0;
            foreach (int i in IntArray)
            {
                Console.Write(i + "\t");
                sum = sum + i;
            }
            Console.WriteLine("\nSum = " + sum);

            //VD2: ta thử sử dụng foreach để duyệt mảng jagged
            /*
             * Khai báo 1 mảng jagged tên là JaggedArray và khởi tạo giá trị.
             * Các bạn có thể xem lại cú pháp khai báo này ở bài Mảng nhiều chiều trong C#.
             */
            int[][] JaggedArray =
                            {
                                new int[] { 1, 2, 3 },
                                new int[] { 5, 2, 4, 1, 6},
                                new int[] { 7, 3, 4, 2, 1, 5, 9, 8}
                            };

            /*
             * Tương tự như dùng for, ta cũng dùng 2 vòng foreach lồng vào nhau để duyệt mảng.
             */
            foreach (int[] Element in JaggedArray)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
#endif
#if false
            /* Kiểm tra tốc độ của for */

            /*
            * Sử dụng 1 cái đồng hồ để đo thời gian chạy của 2 vòng lặp for và foreach
            * Ở đây mình chỉ kiểm tra tốc độ chứ không tập trung giải thích cú pháp
            * Các bạn có thể tìm hiểu thêm.
            */
            //Đoạn chương trình thực hiện:
            //Khai báo 1 mảng 1 chiều có 20 triệu phần tử(khai báo số phần tử lớn để có thể thấy được sự chêch lệch về tốc độ)
            //Lần lượt dùng for, foreach để duyệt mảng đó và thực hiện 1 câu lệnh nào đó.
            //Cuối cùng là xuất ra thời gian thực thi của từng trường hợp dưới dạng giây và mili giây.

            Stopwatch start = new Stopwatch();
            start.Start();

            int[] IntArray = new int[Int32.MaxValue / 100];
            int s = 0;
            int Length = IntArray.Length;
            for (int i = 0; i < Length; i++)
            {
                s += IntArray[i];
            }

            start.Stop();
            Console.WriteLine(" Thoi gian chay cua for: {0} giay {1} mili giay", start.Elapsed.Seconds, start.Elapsed.Milliseconds);

            /* Kiểm tra tốc độ của foreach */
            Stopwatch start2 = new Stopwatch();
            start2.Start();

            int[] IntArray2 = new int[Int32.MaxValue / 100];
            int s2 = 0;

            foreach (int item in IntArray2)
            {
                s2 += item;
            }

            start2.Stop();
            Console.WriteLine(" Thoi gian chay cua foreach: {0} giay {1} mili giay", start2.Elapsed.Seconds, start2.Elapsed.Milliseconds);
#endif
#if true
            /*
             * Khai báo 1 LinkedList chưa các số nguyên int và khởi tạo giá trị cho nó.
             */
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }

            /* Kiểm tra tốc độ của for */
            Stopwatch st = new Stopwatch();
            int s1 = 0, length = list.Count;
            st.Start();
            for (int i = 0; i < length; i++)
            {
                /*
                 * Vì LinkedList không thể truy xuất thông qua chỉ số phần tử
                 * nên mình phải sử dụng 1 phương thức hỗ trợ làm điều này.
                 * Và đây chính là sự hạn chế của for đối với các cấu trúc dữ liệu tương tự như danh sách liên kết này.
                 */
                s1 += list.ElementAt(i);
            }
            st.Stop();

            /* Kiểm tra tốc độ của foreach */
            Stopwatch st2 = new Stopwatch();
            int s2 = 0;
            st2.Start();
            foreach (int item in list)
            {
                /*
                 * Vì foreach không quan tâm đến chỉ số phần tử nên code viết rất ngắn gọn
                 */
                s2 += item;
            }
            st2.Stop();

            /* In ra giá trị tính tổng giá trị các phần tử khi duyệt bằng for và foreach để chắc chắn rằng cả 2 đều chạy đúng */
            Console.WriteLine(" s1 = {0}   s2 = {1}", s1, s2);
            Console.WriteLine(" Thoi gian chay cua for = {0} giay {1} mili giay", st.Elapsed.Seconds, st.Elapsed.Milliseconds);
            Console.WriteLine(" Thoi gian chay cua foreach = {0} giay {1} mini giay", st2.Elapsed.Seconds, st2.Elapsed.Milliseconds);
#endif
        }
    }
}