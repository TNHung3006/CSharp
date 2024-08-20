//===================================================================================================\\

//Lớp String trong C#
//String là một kiểu dữ liệu tham chiếu được dùng để lưu trữ chuỗi ký tự. Vì là một kiểu dữ liệu nên cách khai báo và sử dụng hoàn toàn tương tự các kiểu dữ liệu khác

//Lưu ý:
//Các phương thức mà mình có ghi String phía trước là các phương thức gọi thông qua tên lớp. Các phương thức còn lại được gọi thông qua đối tượng.

//Lớp StringBuilder trong C#
//Đặc điểm
//Lớp StringBuilder được .NET xây dựng sẵn giúp chúng ta thao tác trực tiếp với chuỗi gốc và giúp tiết kiệm bộ nhớ hơn so với lớp String.

//Đặc điểm của StringBuilder là:
//Cho phép thao tác trực tiếp trên chuỗi ban đầu.
//Có khả năng tự mở rộng vùng nhớ khi cần thiết.
//Không cho phép lớp khác kế thừa (khái niệm về kế thừa sẽ được trình bày trong bài KẾ THỪA TRONG C#).

//Cách khởi tạo 1 đối tượng StringBuilder có đôi chút khác so với String.
//Cú pháp:
//Khởi tạo một đối tượng rỗng:
//StringBuilder < tên biến > = new StringBuilder();

//Khởi tạo một đối tượng chứa 1 chuỗi cho trước:
//StringBuilder < tên biến > = new StringBuilder(< chuỗi giá trị >);
//Trong lớp StringBuilder có các phương thức như: Remove, Insert, Replace được sử dụng hoàn toàn giống như lớp String.

//Lưu ý:

//Hãy nhớ đây là đối tượng kiểu StringBuilder nên thao tác với chuỗi như gán, nối chuỗi, . . . phải thông qua các phương thức chứ không thể thực hiện trực tiếp được.
//Giữa String và StringBuilder đều có cái hay riêng của nó. Tuỳ vào từng yêu cầu của bài toán mà nên sử dụng cho hợp lý, tránh lạm dụng quá nhiều 1 kiểu:
//Thông thường đối với các bài toán đòi hỏi thao tác nhiều với chuỗi gốc như cộng chuỗi, chèn chuỗi, xoá bỏ một số ký tự, . . . thì nên sử dụng StringBuilder để tối ưu bộ nhớ.
//Còn lại thì nên sử dụng String để việc thao tác thuận tiện hơn.

//===================================================================================================\\
using System.Text;

namespace lớp_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false
            //Các phương thức khi gọi sẽ tạo ra đối tượng mới rồi thao tác trên đối tượng đó chứ không thao tác trực tiếp với đối tượng đang xét.
            //Vì thế nếu như các bạn gọi thì biến a sau khi thực hiện lệnh Substring vẫn mang giá trị là “HowKteam”.
            //VD 
            string a = "tranngochung";
            a.Substring(3, 1);

            //Nếu muốn biến a mang giá trị mới khi thực hiện Substring thì bạn phải gán ngược lại giá trị mới đó cho biến a:
            a = a.Substring(2,1);
            Console.WriteLine(a);
            //ta có thể xem 1 chuỗi là 1 mảng các ký tự. Như vậy ta hoàn toàn có thể truy xuất đến từng ký tự như truy xuất đền phần tử của mảng.

            //VD để hiểu thêm phương thức
            //Để hiểu rõ cách sử dụng các phương thức. Chúng ta cùng thực hiện chuẩn hoá một chuỗi họ tên của người dùng với các yêu cầu:
            //Cắt bỏ hết các khoảng trắng dư ở đầu cuối chuỗi. Các từ cách nhau một khoảng trắng nếu phát hiện có nhiều hơn 1 khoảng trắng thì thực hiện cắt bỏ.
            //Viết hoa chữ cái đầu tiên của mỗi từ, các chữ cái tiếp theo thì viết thường.

            //Ý tưởng:
            //Cắt khoảng trắng dư ở đầu và cuối chuỗi thì ta có thể sử dụng phương thức Trim.
            //Khoảng trắng ở giữa thì ta sẽ duyệt cả chuỗi nếu phát hiện có 2 khoảng trắng thì thay thế nó bằng 1 một khoảng trắng. Để làm điều này ta có thể dùng:
            //IndexOf để phát hiện khoảng trắng.
            //Replace để thay thế 2 khoảng trắng thành 1 khoảng trắng.
            //Viết hoa chữ cái đầu và viết thường các chữ cái còn lại thì ta có thể cắt chuỗi họ tên ra thành các từ và ứng với mỗi từ ta thực hiện như yêu cầu đề bài. Để làm điều này ta có thể sử dụng:
            //Split để cắt ra các từ.
            //Substring để cắt ra các chữ cái mong muốn.
            //ToUpper để viết hoa và ToLower để viết thường.

            /*
             * Khai báo 1 biến kiểu chuỗi tên là FullName
             * Khai báo 1 biến Result chứa kết quả chuẩn hoá chuỗi.
             * Giá trị biến FullName được nhập từ bàn phím.
             */
            string FullName;
            string Result = "";

            Console.Write("Moi ban nhap ho va ten: ");
            FullName = Console.ReadLine();

            /* Cắt các khoảng trắng dư ở đầu và cuối chuỗi */
            FullName = FullName.Trim();
            
            /* 
             * Trong khi còn tìm thấy 2 khoảng trắng
             * thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
             */
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
            }

            //Cắt chuỗi họ tên ra thành mảng các từ.
            string[] SubName = FullName.Split(' ');
            //Sau đó duyệt mảng để chuẩn hoá từng từ một.
            for (int i = 0; i < SubName.Length; i++)
            {
                //Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
                string FirstChar = SubName[i].Substring(0, 1);
                //Cắt các chữ cái còn lại và lưu trong biến OtherChar.
                string OtherChar = SubName[i].Substring(1);
                //Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                //Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result
                Result += SubName[i] + " ";
            }
            //có thể viết gọn lại đoạn code trên = cách này
            for (int i = 0; i < SubName.Length; i++)
            {
                SubName[i] = SubName[i].Substring(0, 1).ToUpper() + SubName[i].Substring(1).ToLower();
                Result += SubName[i] + " ";
            }
            Console.WriteLine(" Ho ten cua ban la: " + Result);
#endif
#if true    //Lớp StringBuilder trong C#

            string Value = "How";
            Value = Value + "Kteam";

            //Ở 2 dòng lệnh ta có thể thấy bộ nhớ sẽ được lưu trữ như sau:
            //Đầu tiên tạo 1 vùng nhớ đối tượng kiểu string tên là Value.
            //Tạo 1 vùng nhớ chứa giá trị “Kteam”.
            //Khi thực hiện toán tử cộng trên 2 chuỗi sẽ tạo ra 1 vùng nhớ nữa để chứa giá trị chuỗi mới sau khi cộng.
            //Cuối cùng là phép gán sẽ thực hiện trỏ đối tượng Value sang vùng nhớ chứa chuỗi kết quả của phép cộng.
            //Như vậy ta thấy sẽ có 1 vùng nhớ không sử dụng nhưng vẫn còn nằm trong bộ nhớ, đó là vùng nhớ chứa giá trị “How” – giá trị ban đầu của biến Value.

            //Đối với StringBuilder thì khác:
            StringBuilder MutableValue = new StringBuilder("How");
            MutableValue.Append("Kteam");

            //Ở 2 câu lệnh trên bộ nhớ sẽ lưu trữ như sau:
            //Tạo một vùng nhớ cho đối tượng MutableValue chứa giá trị “How”.
            //Tạo một vùng nhớ chứa giá trị “Kteam”.
            //Mở rộng vùng nhớ của MutableValue để nối chuỗi “Kteam” vào sau chuỗi “How”.
            //Rõ ràng là ta không tạo ra quá nhiều vùng nhớ và cũng không lãng phí bất cứ vùng nhớ nào.

            Console.WriteLine(Value);
            Console.WriteLine(MutableValue.ToString());
            Console.ReadKey();
#endif
        }
    }
}