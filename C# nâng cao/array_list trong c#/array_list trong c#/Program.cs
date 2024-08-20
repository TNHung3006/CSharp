//========================================================================================================\\

//ArrayList là gì?
//ArrayList trong C#:
//Là một Collections giúp lưu trữ và quản lý một danh sách các đối tượng theo kiểu mảng (truy cập các phần tử bên trong thông qua chỉ số index).
//Rất giống mảng các object nhưng có thể thêm hoặc xoá các phần tử một cách linh hoạt và có thể tự điều chỉnh kích cỡ một cách tự động.

//Để sử dụng các Collections trong .NET ta cần thêm thư viện System.Collections bằng câu lệnh:
//using System.Collections;
//Vì ArrayList là một lớp nên trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:

//Một số thuộc tính và phương thức hỗ trợ sẵn trong ArrayList
//Tên THUỘC TÍNH và ý nghĩa:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong ArrayList.
//Capacity: Trả về 1 số nguyên cho biết số phần tử mà ArrayList có thể chứa (sức chứa).
//Nếu số phần tử được thêm vào chạm sức chứa này thì hệ thống sẽ tự động tăng lên.
//Ngoài ra ta có thể gán 1 sức chứa bất kỳ cho ArrayList.

//Một số phương thức thông dụng trong ArrayList:
//Add(object Value): Thêm đối tượng Value vào cuối ArrayList.

//AddRange(ICollection ListObject): Thêm danh sách phần tử ListObject vào cuối ArrayList.

//BinarySearch(object Value): Tìm kiếm đối tượng Value trong ArrayList theo thuật toán tìm kiếm nhị phân.
//Nếu tìm thấy sẽ trả về vị trí của phần tử ngược lại trả về giá trị âm..
//Lưu ý: là ArrayList phải được sắp xếp trước khi sử dụng hàm.

//Clear(): Xoá tất cả các phần tử trong ArrayList.

//Clone(): Tạo 1 bản sao từ ArrayList hiện tại.

//Contains(object Value): Kiểm tra đối tượng Value có tồn tại trong ArrayList hay không.

//GetRange(int StartIndex, int EndIndex): Trả về 1 ArrayList bao gồm các phần tử từ vị trí StartIndex đến EndIndex trong ArrayList ban đầu.

//IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện đối tượng Value trong ArrayList. Nếu không tìm thấy sẽ trả về -1.

//Insert(int Index, object Value): Chèn đối tượng Value vào vị trí Index trong ArrayList.

//InsertRange(int Index, ICollection ListObject): Chèn danh sách phần tử ListObject vào vị trí Index trong ArrayList.

//LastIndexOf(object Value): Trả về vị trí xuất hiện cuối cùng của đối tượng Value trong ArrayList. Nếu không tìm thấy sẽ trả về -1.

//Remove(object Value): Xoá đối tượng Value xuất hiện đầu tiên trong ArrayList.

//Reverse(): Đảo ngược tất cả phần tử trong ArrayList.

//Sort(): Sắp xếp các phần tử trong ArrayList theo thứ tự tăng dần.

//ToArray(): Trả về 1 mảng các object chứa các phần tử được sao chép từ ArrayList.


//Ở trên có giới thiệu phương thức Sort() sẽ thực hiện sắp xếp danh sách theo thứ tự tăng dần. 
//Vậy nếu danh sách của mình gồm các đối tượng mà mỗi đối tượng là 1 lớp có nhiều thuộc tính thì hàm Sort này biết sắp xếp tăng dần theo thuộc tính nào?
//Để trả lời câu hỏi này thì chúng ta cần biết thêm là còn 1 hàm Sort nữa được hỗ trợ sẵn trong ArrayList có cú pháp như sau:
//Sort ( IComparer comparer)
//Công dụng:
//Hàm này cho phép người dùng tự định nghĩa cách sắp xếp theo ý mình.
//Tham số truyền vào là 1 lớp có kế thừa từ interface IComparer .
//Interface IComparer chứa 1 phương thức duy nhất là: int Comparer (object x, object y).

//Phương thức này sẽ trả về 3 giá trị:
//Bé hơn 0 nếu x < y.
//Lớn hơn 0 nếu x > y.
//Bằng 0 nếu x = y.
//Từ những quy định về inferface này ta chỉ cần khai báo 1 lớp kế thừa interface IComparer và định nghĩa nội dụng cho phương thức Comparer có giá trị trả về theo những quy định trên.
//========================================================================================================\\
using System;
using System.Collections;

namespace array_list_trong_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false   //VD khởi tạo arraylist và gán value cho arraylist
            ArrayList Myarray1 = new ArrayList();    //khởi tạo 1 array list rỗng.
            ArrayList Myarray2 = new ArrayList(5);  //khởi tạo 1 array list và chỉ định dung tích(capacity) ban đàu là 5

            //khởi tạo 1 arraylist có kích thước bằng với myarray2.
            //sao chép toàn bộ phần tử trong myarray2 vào myarray3.

            ArrayList Myarray3 = new ArrayList(Myarray2); // khởi tạo như thế này thì myarrray 3 sẽ bằng 1 bản sao mới được tạo ra của myarray2
                                                          // và khi myarray 2 thay đổi thì ko ảnh hưởng tới myarray3.
            ArrayList Myarray4 = Myarray2;  // Nếu khởi tạo và gán như thế này thì khi Myarray2 thay đổi thì myarray4 cũng thay đổi theo và ngược lại.

            // Khởi tạo một ArrayList
            ArrayList numbers = new ArrayList();

            // Thêm các phần tử vào ArrayList
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add("Hello");

            // In ra các phần tử trong ArrayList
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
#endif

            //VD Một số thuộc tính và phương thức hỗ trợ sẵn trong ArrayList
            //VD tạo array list có 3 person và sắp xếp danh sách person theo tiêu chí đã được định nghĩa.

            //Tạo 1 array list kiểu rỗng
            ArrayList ArrPersons = new ArrayList();

            //thêm 3 person vào danh sách
            ArrPersons.Add(new Person("Vo Van A", 27));
            ArrPersons.Add(new Person("Vo Van B", 21));
            ArrPersons.Add(new Person("Vo Van C", 30));

            //In thử danh sách person ban đàu ra
            Console.WriteLine("Danh sach Person ban dau la: ");
            foreach (Person item in ArrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            //Sắp xếp danh sách person
            //Trong phương thức Compare của lớp SortPerson(tuổi tăng dần)
            ArrPersons.Sort(new SortPersons());

            //In danh sách Person đã được sắp xếp ra màng hình.
            Console.WriteLine();
            Console.WriteLine("Danh sach person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in ArrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();

        }
        public class SortPersons : IComparer
        {
            public int Compare(object x, object y)
            {
                //ép kiểu 2 opject truyền vào person.
                Person p1 = x as Person;
                Person p2 = y as Person;

                //Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
                //Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
                //Chi tiết về exception sẽ được trình bày ở những bài học sau.

                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    //Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 - 1 tương ứng lớn hơn, bằng, bé hơn.
                    if (p1.Age > p2.Age)
                    {
                        return 1;
                    }
                    else if (p1.Age == p2.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}