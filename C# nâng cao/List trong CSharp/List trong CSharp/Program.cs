﻿//===========================================================================================\\
using System;
using System.Collections;
using System.Collections.Generic;

//List là 1 Generic Collections đưa ra như một sự thay thế ArrayList vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList. 
//(bạn có thể tham khảo chi tiết trong bài ARRAYLIST TRONG C#)
//Ở đây mình chỉ trình bày lại một số ý để những bạn nào không theo dõi những bài trước vẫn có thể hiểu được.
//List trong C# là một Generic Collections giúp lưu trữ và quản lý một danh sách các đối tượng theo kiểu mảng (truy cập các phần tử bên trong thông qua chỉ số index).
//Để sử dụng các Collections trong .NET ta cần thêm thư viện System.Collections.Generic bằng câu lệnh:
//using System.Collections.Generic;

//Vì List là một lớp nên trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:
//Bạn cũng có chỉ định sức chứa (Capacity) ngay lúc khởi tạo bằng cách thông qua constructor được hỗ trợ sẵn:
//Ngoài ra bạn cũng có thể khởi tạo 1 List chứa các phần tử được sao chép từ một Generic Collections khác (lưu ý là có cùng kiểu dữ liệu truyền vào):

//Một số thuộc tính và phương thức hỗ trợ sẵn trong List
//Một số thuộc tính thông dụng trong List:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong List.

//Capacity: Trả về 1 số nguyên cho biết số phần tử mà List có thể chứa (sức chứa).
//Nếu số phần tử được thêm vào chạm sức chứa này thì hệ thống sẽ tự động tăng lên. Ngoài ra ta có thể gán 1 sức chứa bất kỳ cho List.

//Một số phương thức thông dụng trong List:
//Add(object Value): Thêm đối tượng Value vào cuối List.

//AddRange(ICollection ListObject): Thêm danh sách phần tử ListObject vào cuối List.

//BinarySearch(object Value): Tìm kiếm đối tượng Value trong List theo thuật toán tìm kiếm nhị phân.
//Nếu tìm thấy sẽ trả về vị trí của phần tử ngược lại trả về giá trị âm.
//Lưu ý: List phải được sắp xếp trước khi sử dụng hàm.

//Clear(): Xoá tất cả các phần tử trong List.

//Contains(T Value): Kiểm tra đối tượng Value có tồn tại trong List hay không.

//CopyTo(T[] array, int Index): Thực hiện sao chép tất cả phần tử trong List sang mảng một chiều array từ vị trí Index của array.
//Lưu ý: array phải là mảng kiểu T tương ứng.

//IndexOf(T Value): Trả về vị trí đầu tiên xuất hiện đối tượng Value trong List. Nếu không tìm thấy sẽ trả về -1.

//Insert(int Index, T Value): Chèn đối tượng Value vào vị trí Index trong List.

//InsertRange(int Index, IEnumerable < T > ListObject): Chèn danh sách phần tử ListObject vào vị trí Index trong List.

//LastIndexOf(T Value): Trả về vị trí xuất hiện cuối cùng của đối tượng Value trong List. Nếu không tìm thấy sẽ trả về -1.

//Remove(T Value): Xoá đối tượng Value xuất hiện đầu tiên trong List.

//Reverse(): Đảo ngược tất cả phần tử trong List.

//Sort(): Sắp xếp các phần tử trong List theo thứ tự tăng dần.

//ToArray(): Trả về 1 mảng kiểu T chứa các phần tử được sao chép từ List.

//===========================================================================================\\
namespace List_trong_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo 1 List các số nguyên rỗng
            List<int> MyList = new List<int>();

            //Bạn cũng có chỉ định sức chứa (Capacity) ngay lúc khởi tạo bằng cách thông qua constructor được hỗ trợ sẵn:
            // khởi tạo 1 List các số nguyên và chỉ định Capacity ban đầu là 5
            List<int> MyList2 = new List<int>(5);

            //Ngoài ra bạn cũng có thể khởi tạo 1 List chứa các phần tử được sao chép từ một Generic Collections khác (lưu ý là có cùng kiểu dữ liệu truyền vào)
            //Khởi tạo 1 List số nguyên có kích thước bằng với MyList2.
            //Sao chép toàn độ phần tử trong MyList2 vào MyList3.
            List<int> MyList3 = new List<int>(MyList2);

            //Sử dụng List hoàn toàn tượng tự như sử dụng ArrayList.Một ví dụ đơn giản về sử dụng List:
            //Tạo 1 List các kiểu string và thêm 2 phần tử vào List.
            List<string> MyList4 = new List<string>();
            MyList4.Add("Free");
            MyList4.Add("Education");

            // In giá trị các phần tử trong List
            Console.WriteLine(" List ban dau: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // Chèn 1 phần tử vào đầu List.
            MyList4.Insert(0, "HowKteam");

            // In lại giá trị các phần tử trong List để xem đã chèn được hay chưa
            Console.WriteLine(" List sau khi insert: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // Kiểm tra 1 phần tử có tồn tại trong List hay không.
            bool isExists = MyList4.Contains("HowKteam");
            if (isExists == false)
            {
                Console.WriteLine(" Khong tim thay chuoi trong List");
            }
            else
            {
                Console.WriteLine(" phan tu co trong List");
            }
        }
    }
}