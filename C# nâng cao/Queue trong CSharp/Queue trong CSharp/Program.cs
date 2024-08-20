//===================================================================================================\\

//Queue là gì?
//Queue (hay còn gọi là hàng đợi) là một cấu trúc dữ liệu hoạt động theo nguyên lý FIFO (First In First Out).
//Người ta hay gọi nó là hàng đợi bởi vì nó hoạt động giống như việc xếp hàng đợi chờ gì đó trong thực tế vậy.

//Giả sử ta đến xếp hàng để mua vé như hình dưới:
//Khi đó người xếp hàng đầu tiên sẽ là người mua được vé đầu tiên. Đây chính là nguyên lý First In First Out (vào trước ra trước) của Queue.
//Hãy tưởng tượng những người đứng xếp hàng đó chính là 1 danh sách (Queue), mỗi người là 1 phần tử của danh sách.
//Thế là ta đã có cấu trúc dữ liệu Queue trong lập trình rồi đó.
//Trong C#,  Queue là một Collections đại diện cho một danh sách hoạt động theo nguyên lý FIFO đã trình bày ở trên.

//Vì C# đã hỗ trợ sẵn cấu trúc dữ liệu Queue rồi nên chúng ta chỉ tìm hiểu cách sử dụng nó thôi.
//Còn cách tổ chức nó như thế nào sẽ được trình bày trong series về CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT.

//Đặc điểm của Queue
//Là một danh sách lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
//Hành động thêm phần tử vào Queue  được gọi là Enqueue (xếp hàng).
//Hành động lấy phần tử ra khỏi Queue được gọi là Dequeue (ra khỏi hàng). Và luôn luôn lấy ra phần tử được thêm vào đầu tiên.
//Queue rất giống Stack chỉ khác ở nguyên lý hoạt động thôi nên Stack có gì Queue sẽ có cái tương tự như vậy.

//Do Queue cũng là 1 Collections nên để sử dụng ta cần thêm thư viện System.Collections bằng câu lệnh:
//using System.Collections;

//Trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:

//Một số thuộc tính và phương thức hỗ trợ sẵn trong Queue
//Một số thuộc tính thông dụng trong Queue:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong Queue.

//Một số phương thức thông dụng trong Queue:
//Clear(): Xoá tất cả các phần tử trong Queue .

//Clone(): Tạo 1 bản sao từ Queue hiện tại.

//Contains(object Value): Kiểm tra đối tượng Value có tồn tại trong Queue hay không.

//CopyTo(Array array, int Index): Thực hiện sao chép tất cả phần tử trong Queue sang mảng một chiều array từ vị trí Index của array.

//Peek(): Trả về giá trị của đối tượng tại vị trí đầu trong Queue (phần tử thêm vào đầu tiên) nhưng không xoá phần tử khỏi Queue.

//Dequeue(): Trả về giá trị của đối tượng tại vị trí đầu trong Queue(phần tử thêm vào đầu tiên) đồng thời xoá phần tử khỏi Queue.

//Enqueue(object Value): Thêm một phần tử có giá trị Value vào đầu Queue.

//ToArray(): Tạo ra 1 mảng các object  chứa tất cả các phần tử trong Queue và trả về mảng đó.

//===================================================================================================\\
using System.Collections;
namespace Queue_trong_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo 1 Queue rỗng
            Queue MyQueue = new Queue();

            // khởi tạo 1 Queue và chỉ định sức chứa ban đầu là 5
            Queue MyQueue2 = new Queue(5);

            // khởi tạo 1 mảng bất kỳ
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);

            // Khởi tạo 1 Queue và sao chép giá trị của các phần tử từ MyArray vào Queue.
            Queue MyQueue3 = new Queue(MyArray);

            // Tạo 1 Queue rỗng
            Queue MyQueue4 = new Queue();

            // Thực hiện thêm vài phần tử vào Queue thông qua hàm Enqueue.
            MyQueue4.Enqueue("Tran");
            MyQueue4.Enqueue("Ngoc");
            MyQueue4.Enqueue("Hung");

            // Thử sử dụng các phương thức của Queue.
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue4.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue4.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Queue.
            Console.WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", MyQueue4.Count);

            // Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue.
            Console.WriteLine(" Popping...");
            int Length = MyQueue4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + MyQueue4.Dequeue());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Queue sau khi Pop
            Console.WriteLine(" So phan tu cua Queue sau khi Pop la: {0}", MyQueue4.Count);


            Console.ReadKey();
        }
    }
}