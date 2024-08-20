//===================================================================================================\\

//Ngoài mảng 1 chiều và mảng 2 chiều ra thì C# còn hỗ trợ chúng ta khai báo và sử dụng mảng 3 chiều, 4 chiều thậm chí là n chiều tuỳ vào từng yêu cầu của bài toán.
//Trong phạm vi bài viết này mình chỉ trình bày về mảng 3 chiều, còn về mảng 4 chiều trở đi thì các bạn có thể tự nghiên cứu thêm.
//Về khái niệm của mảng cũng như các đặc trưng cơ bản của mảng đã trình bày trong bài MẢNG 1 CHIỀU TRONG C#.

//Mảng 3 chiều trong C#
//Nếu như mảng 2 chiều được hình dung như là một ma trận MxN thì mảng 3 chiều được hình dung như một hình hộp chữ nhật có kích thước MxNxP.

//Cú pháp:
//< kiểu dữ liệu> [ , , ] < tên mảng >;

//Trong đó:
//<kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
//Cặp dấu [ , , ] là ký hiệu cho khai báo mảng 3 chiều.
//<tên mảng> là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến (quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).

//Để sử dụng được mảng ta phải khởi tạo giá trị hoặc cấp phát vùng nhớ cho mảng.
//Cấp phát vùng nhớ
//Được thực hiện tương tự như mảng 2 chiều nhưng cần chỉ ra 3 chỉ số cho mảng.

//Chúng ta có thể xem mảng 3 chiều là một mảng 1 chiều mà mỗi phần tử là một mảng 2 chiều. Khi đó việc khởi tạo sẽ là:
//Khởi tạo một mảng 1 chiều.
//Ở mỗi phần tử ta khởi tạo một mảng 2 chiều.
//Các giá trị khởi tạo nằm trong cặp dấu ngoặc ngọn {} và cách nhau bởi dấu phẩy.
//Chúng ta không cần cung cấp các chỉ số tối đa mà trình biên dịch sẽ tự đếm số lượng phần tử bạn đã khởi tạo ở mỗi chiều và xem nó là chỉ số tối đa cho từng chiều.

// ============== Sử dụng mảng 3 chiều ================ \\
//Tương tự như mảng 2 chiều, kiểu mảng 3 chiều cũng có thể dùng làm:
//Kiểu dữ liệu cho biến.
//Kiểu trả về cho hàm.
//Tham số truyền vào cho hàm.
//Các phần tử của mảng được truy xuất thông qua 3 chỉ số ngăn cách nhau bởi dấu phẩy và nằm trong cặp dấu [].

//Cách duyệt mảng 3 chiều:
//Ý tưởng:
//Tương tự như ý tưởng duyệt mảng 2 chiều (đã trình bày trong bài MẢNG 2 CHIỀU TRONG C#)
//Nhưng do mảng 3 chiều có 3 chỉ số nên chúng ta cần 3 vòng lặp lồng vào nhau.

// ============== mảng jagged ================ \\
//Mảng jagged (hay còn gọi là mảng lởm chởm) là một mảng của các mảng. Nghe có vẻ giống mảng 2 chiều đã học nhưng thực ra là rất khác.

//Đặc điểm của mảng jagged cũng là điểm khác biệt giữa mảng này với mảng 2 chiều:
//Số phần tử của chiều thứ 2 có thể khác nhau (đối với mảng 2 chiều là bằng nhau).
//Các ô nhớ được cấp phát có thể không nằm liền kề nhau (đối với mảng 2 chiều là các ô nhớ sẽ được cấp phát liền kề nhau).
//Bản chất vẫn là mảng 1 chiều nhưng các phần tử có thể chứa 1 mảng khác.
//Ưu điểm lớn nhất của mảng jagged là tiết kiệm bộ nhớ. Bởi vì khi mình cần xài bao nhiêu thì mình cấp phát bấy nhiêu nên sẽ không bị thừa một ô nhớ nào.

//Khai báo mảng jagged
//Cú pháp:
//<kiểu dữ liệu> [ ][ ] <tên mảng>;

//Trong đó:
//< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
//Cặp dấu [ ][ ] là ký hiệu cho khai báo mảng jagged.
//<tên mảng> là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến.

//Cấp phát vùng nhớ
//Không giống như mảng 2 chiều, mảng jagged không cho phép cấp phát cùng lúc số dòng và số cột mà phải cấp phát số dòng trước sau đó ứng với mỗi dòng ta cấp phát số cột theo ý muốn.

//Khi sử dụng mảng jagged các bạn cần lưu ý:
//Đây không phải là mảng 2 chiều nên cách truy xuất đến 1 phần tử có chút thay đổi trong cú pháp. Đó là sử dụng <tên mảng>[i][j] thay vì<tên mảng>[i, j].
//Lúc này i, j không được xem là chỉ số dòng và chỉ số cột nữa mà có thể hiểu i là chỉ số chỉ vị trí phần tử trong mảng 1 chiều 
//(ở đây mỗi phần tử trong mảng 1 chiều này là 1 mảng 1 chiều), còn j là chỉ số phần tử của mảng 1 chiều nằm tại vị trí i trên.
//Chỉ có thể sử dụng phương thức GetLength(0) chứ không thể sử dụng GetLength(1) vì mảng jagged bản chất vẫn là mảng 1 chiều.
//Nếu ta truy xuất <tên mảng>[i] thì có thể xem đây là 1 mảng 1 chiều và có thể thao tác như một mảng 1 chiều bình thường.
//===================================================================================================\\
using System.Runtime.InteropServices;

namespace mảng_nhiều_chiều
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false   //Vd tính toán tổng các giá trị phần tử trong mảng 2 chiều = c#

            int row, col;
            String Rows, Cols;
            Console.Write("nhap vao so dong cua mang: ");
            Rows = Console.ReadLine();
            Console.Write("nhap vao so cot cua mang: ");
            Cols = Console.ReadLine();
            if (int.TryParse(Rows, out row) == false || int.TryParse(Cols, out col) == false)
            {
                Console.WriteLine("gia tri nhap vao khong phai so nguyen");
                return;
            }
            else
                row = int.Parse(Rows);
            col = int.Parse(Cols);
            int[,] array = new int[row, col];
            //nhap mang
            for(int i = 0; i < array.GetLength(0); i++){
                for(int j = 0; j < array.GetLength(1); j++){
                    Console.Write("Array[{0}, {1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int sum = 0;
            Console.WriteLine("Mang co dang:");
            for (int i = 0; i < array.GetLength(0); i++){
                for(int j = 0; j < array.GetLength(1); j++){                    
                    Console.Write(array[i, j] + "\t");
                    sum = sum + array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong gia tri cac phan tu trong mang la: " +sum);
#endif
#if false    //VD mảng 3 chiều
            /* Khai báo mảng 3 chiều kiểu string và có tên là Kteam.
             * Sau đó thực hiện cấp phát vùng nhớ với 3 chỉ số lần lượt là 2, 2, 3.
             */
            string[,,] Kteam = new string[2, 2, 3];

            //VD khởi tạo giá trị
            int[,,] Mang3Chieu = new int[,,]
            {
                {
                    {1, 2, 3},
                    {4, 5, 6}
                },
                {
                    {7, 8, 9},
                    {10, 11, 12}
                }
            };
            
            //Truy xuất đến phần tử có các chỉ số lần lượt là 1 1 2            
            Console.WriteLine(Mang3Chieu[1, 1, 2]);

            //VD duyệt mảng 3 chiều
            int[,,] IntArray = new int[3, 9, 10];

            /*
             * Sử dụng 3 vòng for lồng vào nhau để duyệt mảng 3 chiều
             * Vòng lặp đầu tiên là vòng lặp duyệt các phần tử của chiều đầu tiên.
             * Vòng lặp thứ 2 là vòng lặp duyệt các phần tử của chiều thứ 2.
             * Vòng lặp thứ 3 là vòng lặp duyệt các phần tử của chiều thứ 3.
             */

            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    for (int k = 0; k < IntArray.GetLength(2); k++)
                    {

                        /*
                        * Với cách duyệt này thì IntArray[i, j, k] sẽ là phần tử hiện tại mình đang xét
                        * Code xử lý sẽ viết ở đây
                        */                      
                    }
                }
            }           
#endif
#if true //VD mảng jagged
            //VD khai báo mảng jagged
            int[][] JaggedArray0;

            //VD cấp phát vùng nhớ mảng 
            int[][] JaggedArray = new int[3][];

            JaggedArray[0] = new int[3];
            JaggedArray[1] = new int[9];
            JaggedArray[2] = new int[10];
            //Từ ví dụ ta có thể thấy:
            //Vì mảng jagged là mảng 1 chiều nên đầu tiên cần cấp phát số phần tử cho mảng 1 chiều.
            //Sau đó ứng với mỗi phần tử của mảng 1 chiều đó ta cấp phát 1 mảng 1 chiều nữa.
            //Chính vì điểm này nên ta có thể linh động chọn số phần tử phù hợp cho từng dòng.

            //VD khởi tạo giá trị 
            //Cách khởi tạo giá trị của mảng jagged cũng có chút khác so với mảng 2 chiều.
            //Không thể khởi tạo trực tiếp giá trị từng vị trí như mảng 2 chiều được.
            //Ứng với mỗi dòng ta phải cấp phát vùng nhớ rồi mới khởi tạo giá trị được.

            //Khai báo 1 mảng jagged tên JArray và có 2 phần tử tương ứng với 2 mảng con.
            //Mảng con thứ nhất là mảng 1 chiều có 3 phần tử.
            //Mảng con thứ hai là mảng 1 chiều có 7 phần tử.
            int[][] JArray =
            {
                new int[] {1, 2, 3},

                new int[] {3, 4, 5, 6, 7, 8, 9}
            };
            //Cách duyệt mảng jagged
            //Các bạn hoàn toàn có thể duyệt mảng jagged bằng 2 vòng lặp for lồng vào nhau như mảng 2 chiều.
            //Nhưng chúng ta cần linh hoạt hơn ở vòng lặp thứ 2 để tránh chương trình bị lỗi.
            /*
             * Sử dụng 2 vòng lặp lồng vào nhau để duyệt mảng jagged này.
             * Vòng lặp đầu tiên là vòng lặp duyệt số phần tử của mảng 1 chiều.
             * Vì mỗi phần tử là 1 mảng 1 chiều nên vòng lặp thứ 2 là để duyệt mảng 1 chiều tại vị trí tương ứng.
             * Do các mảng 1 chiều có kích thước khác nhau nên ta dùng thuộc tính Length để xác định kích thước.
             */

            for (int i = 0; i < JArray.Length; i++)
            {
                for (int j = 0; j < JArray[i].Length; j++)
                {                  
                    //JArray[i][j] là cách truy xuất đến mảng 1 chiều thứ i và phần tử thứ j trong mảng đó.                    
                    Console.Write("\t" + JArray[i][j]);
                }
                Console.WriteLine();
            }
#endif
            Console.ReadKey();
        }
    }
}