//========================================================================================================\\

//Stack là gì?
//Stack (hay còn gọi là ngăn xếp) là một cấu trúc dữ liệu hoạt động theo nguyên lý LIFO (Last In First Out). 
//Người ta hay gọi nó là ngăn xếp bởi vì nó hoạt động giống như ngăn xếp trong thực tế vậy.

//Giả sử bạn xếp chồng các chiếc đĩa lên nhau:
//Khi đó chiếc đĩa được xếp đầu tiên sẽ nằm dưới cùng và chiếc đĩa được xếp sau cùng sẽ nằm trên đầu. 
//Nếu bạn muốn lấy đĩa ra sử dụng chắc chắn bạn sẽ lấy chiếc đĩa nằm trên cùng ra. Đây chính là nguyên lý Last In First Out (vào cuối ra đầu) của Stack.

//Quay lại vấn đề lập trình, bạn tưởng tượng cả chồng đĩa đó chính là 1 danh sách (Stack), các chiếc đĩa là các phần tử của danh sách. 
//Thế là ta đã có cấu trúc dữ liệu Stack trong lập trình rồi đó.
//Trong C#, Stack là một Collections đại diện cho một danh sách hoạt động theo nguyên lý LIFO đã trình bày ở trên.

//Vì C# đã hỗ trợ sẵn cấu trúc dữ liệu Stack rồi nên chúng ta chỉ tìm hiểu cách sử dụng nó thôi. 
//Còn cách tổ chức nó như thế nào sẽ được trình bày trong serial về CẤU TRÚC DỮ LIỆU & GIẢI THUẬT.

//Đặc điểm của Stack
//Là một danh sách lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
//Hành động thêm phần tử vào Stack được gọi là Push (đẩy vào).
//Hành động lấy phần tử ra khỏi Stack được gọi là Pop (đẩy ra). Và luôn luôn lấy ra phần tử được thêm vào cuối cùng.

//Do Stack cũng là 1 Collections nên để sử dụng ta cần thêm thư viện System.Collections bằng câu lệnh:
//using System.Collections;

//Trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:

//Một số thuộc tính và phương thức hỗ trợ sẵn trong Stack
//Một số thuộc tính thông dụng trong Stack:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong Stack.

//Một số phương thức thông dụng trong Stack:
//Clear(): Xoá tất cả các phần tử trong Stack.

//Clone(): Tạo 1 bản sao từ  Stack hiện tại.

//Contains(object Value): Kiểm tra đối tượng Value có tồn tại trong Stack hay không.

//CopyTo(Array array, int Index): Thực hiện sao chép tất cả phần tử trong Stack sang mảng một chiều array từ vị trí Index của array.

//Peek(): Trả về giá trị của đối tượng tại vị trí trên cùng trong Stack (phần tử thêm vào cuối cùng) nhưng không xoá phần tử khỏi Stack.

//Pop(): Trả về giá trị của đối tượng tại vị trí trên cùng trong Stack(phần tử thêm vào cuối cùng) đồng thời xoá phần tử khỏi Stack.

//Push(object Value): Thêm một phần tử có giá trị Value vào vị trí trên cùng trong Stack.

//ToArray(): Tạo ra 1 mảng các object chứa tất cả các phần tử trong Stack và trả về mảng đó.
//========================================================================================================\\
using System.Collections;

namespace Stack_trong_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Khởi tạo 1 stack rỗng.
            Stack mystack = new Stack();

            //Khởi tạo 1 stack và chỉ định sức chứa ban đàu là 5.
            Stack mystack2 = new Stack(5);

            //Bạn cũng có thể khởi tạo 1 Stack chứa các phần tử được sao chép từ một danh sách khác:
            //khởi tạo 1 mảng bất kì.
            ArrayList myarray = new ArrayList();
            myarray.Add(1);
            myarray.Add(3);
            myarray.Add(6);
            myarray.Add(7);

            //Khởi tạo 1 stack và sao chép giá trị của các phần tử từ myarray vào stack.
            Stack mystack3 = new Stack(myarray);

            // Tạo 1 Stack rỗng
            Stack MyStack4 = new Stack();

            // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
            MyStack4.Push("Hung");
            MyStack4.Push("Ngoc");
            MyStack4.Push("Tran");

            // Thử sử dụng các phương thức của Stack.
            //Đếm số phần tử trong stack.
            Console.WriteLine("So phan tu hien tai trong stack:" + MyStack4.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị đàu mà không muốn nó xoá khỏi Stack thì ta sẽ dùng Peek.
            Console.WriteLine($"Gia tri duoc lay ra dau tien trong stack: {MyStack4.Peek()}");

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
            Console.WriteLine("So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack4.Count);

            // Thực hiện xoá các phần tử ra khỏi Stack.
            Console.WriteLine("Popping...");
            int Length = MyStack4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(MyStack4.Pop());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Stack sau khi Pop
            Console.WriteLine("So phan tu cua Stack sau khi Pop la: {0}", MyStack4.Count);

            Console.ReadKey();
        }
    }
}