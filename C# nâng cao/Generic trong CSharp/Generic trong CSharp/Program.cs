//=======================================================================================================\\
//Generic là gì?
//Template được dùng để tạo ra các lớp, các hàm mà không cần quan tâm đến đối số kiểu dữ liệu là gì. 
//Template được đưa ra với mục đích tăng tính tái sử dụng lại mã nguồn.
//Tượng tự Template của C++, Generic trong C# cho phép bạn định nghĩa một hàm, một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì. 
//Tuỳ vào kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó.

//Ví dụ: bạn muốn hàm hoán đổi giá trị 2 số nguyên ta sẽ viết như sau:
//public static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//Mọi thứ đều hoạt động tốt cho đến khi bạn hoán đổi 2 số thực. Khi đó bạn phải viết lại 1 hàm Swap mới với kiểu dữ liệu của tham số truyền vào là kiểu số thực.
//Mặc dù thao tác giống nhau nhưng ta phải viết hàm này 2 lần. Chính vì vậy mà Generic ra đời để giúp chúng ta giảm thiểu việc code và tăng tính tái sử dụng.

//Nếu sử dụng Generic ta sẽ viết như sau:
//public static void Swap<T>(ref T a, ref T b)
//{
//    T temp = a;
//    a = b;
//    b = temp;
//}

//Bạn chỉ cần đặt 1 chữ cái nào đó thay cho kiểu dữ liệu và khi gọi hàm bạn chỉ ra kiểu dữ liệu bạn đang thao tác là gì. Ví dụ:
//int a = 5, b = 7;
//double c = 1.2, d = 5.6;
//Swap<int>(ref a, ref b);
//Swap<double>(ref c, ref d);

//Đặc điểm của Generic
//Giúp định nghĩa một thao tác dữ liệu với kiểu dữ liệu chung nhất nhìn hạn chế viết code và tái sử dụng.
//Ứng dụng phổ biến nhất của Generic là tạo ra các Generic Collections.
//Ở những bài học trước ta đã tìm hiểu các Collections phổ biến thì nếu các bạn để ý giá trị lưu trữ bên trong đều là object.
//Điều này gây rất nhiều khó khăn nếu như ta muốn quản lý 1 danh sách có cùng kiểu. 
//Vì object có thể chứa được mọi kiểu dữ liệu nên ta khó kiểm soát rằng việc thêm phần tử có phải cùng kiểu dữ liệu ta mong muốn hay không.
//Từ đó Generic Collections ra đời để giúp ta vừa có thể sử dụng được các Collections vừa có thể hạn chế lỗi xảy ra trong quá trình thực thi.
//Ngoài ra, Generic còn giúp hạn chế truy cập nếu như không truyền đúng kiểu dữ liệu. Điều này sẽ được trình bày trong những bài học sau.

//Một số loại Generic Collections thông dụng
//Các Generic Collections đều được xây dựng bắt nguồn từ 1 Collections nào đó có sẵn. Vì thế với mỗi Collections đã học sẽ có một Generic tương ứng.

//Một số Generic Collections được sử dụng phổ biến:
//List < T >: Là một Collections giúp lưu trữ các phần tử liên tiếp (giống mảng) nhưng có khả năng tự mở rộng kích thước.
//Generic Collections này là sự thay thế cho ArrayList đã học.

//Dictionary < Tkey, TValue >: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key
//(thay vì thông qua chỉ số phần tử như mảng bình thường). Generic Collections này là sự thay thế cho Hashtable đã học.

//SortedDictionary < Tkey, TValue >: Là sự kêt hợp của List và Dictionary. Tức là dữ liệu sẽ lưu dưới dạng Key – Value.
//Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử.
//Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key.
//Generic Collections này là sự thay thế cho SortedList đã học.

//Stack < T >: Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).
//Generic Collections này là sự thay thế cho Stack đã học.

//Queue < T >:Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out).
//Generic Collections là sự thay thế cho Queue đã học.


//=======================================================================================================\\
namespace Generic_trong_CSharp
{  
    internal class Program
    {
        //VD sử dụng generic cho phương thức
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            double c = 1.2, d = 5.6;

            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);
            Console.WriteLine("cac so sau khi thuc hien swap");
            Console.WriteLine(a + "\t" + b + "\t" + c + "\t" + d);

            //VD sử dụng generic cho lớp
            //Khởi tạo 1 mảng số nguyên kiểu int có 5 phần tử
            MyGeneric<int> MyG = new MyGeneric<int>(5);
            MyG.SetItemValue(0, 10);
        }
    }
}