//===========================================================================\\

//====== OBJECT =======\\
//Kiểu dữ liệu object:
    //Là một kiểu dữ liệu cơ bản của tất cả các kiểu dữ liệu trong .NET.
    //Mọi kiểu dữ liệu đều được kế thừa từ System.Object (khái niệm về kế thừa sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#).
    //Thuộc kiểu dữ liệu tham chiếu (đã trình bày ở bài KIỂU DỮ LIỆU TRONG C#).
    //Kiểu dữ liệu object cung cấp một số phương thức ảo cho phép mình overload để sử dụng (những khái niệm này sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#)

//Boxing và unboxing trong C#

//Boxing là quá trình chuyển dữ liệu từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu.
//Quá trình boxing:
    //Khởi tạo một đối tượng trong vùng nhớ Heap (đã được trình bày trong bài KIỂU DỮ LIỆU TRONG C#).
    //Copy giá trị của biến có kiểu dữ liệu giá trị vào đối tượng này.
    //Quá trình boxing được thực hiện ngầm định.

//Unboxing là quá trình ngược lại với boxing, tức là đưa dữ liệu từ kiểu dữ liệu tham chiếu về kiểu dữ liệu giá trị.
    //Unboxing được thực hiện tường minh và thông qua cách ép kiểu tường minh (đã được trình bày trong bài ÉP KIỂU TRONG C#).
    //Phải chắc chắn rằng đối tượng cần boxing thuộc đúng kiểu dữ liệu đưa ra. Nếu không việc unboxing sẽ báo lỗi chương trình.
    //Quá trình unboxing:
    //Kiểm tra xem đối tượng cần un-boxing có thuộc đúng kiểu dữ liệu đưa ra hay không.
    //Nếu đúng thì thực hiện copy giá trị của đối tượng sang biến dữ liệu kiểu giá trị. Ngược lại thì thông báo lỗi.

//====== VAR =======\\
//Từ khóa var trong C#
    //var là từ khóa hỗ trợ khai báo biến mà không cần kiểu dữ liệu, kiểu dữ liệu sẽ được xác định khi gán giá trị cho biến, lúc đó chương trình sẽ tự ép kiểu cho biến.

//Những lưu ý khi sử dụng từ khóa var:
    //Bắt buộc phải gán giá trị ngay khi khởi tạo biến và không thể khởi tạo giá trị null cho biến var.
    //var chỉ là từ khóa dùng để khai báo biến không phải là một kiểu dữ liệu.
//Khai báo biến bằng từ khóa var thường được ứng dụng trong:
    //Duyệt mảng bằng foreach (sẽ trình bày trong bài FOREACH TRONG C# ).
    //Truy vấn LinQ (sẽ trình bày trong bài LINQ TRONG C#).

//====== DYNAMIC =======\\
//Từ khóa dynamic trong C#
    //Từ khóa dynamic là từ khóa dùng để khai báo kiểu dynamic. Kiểu dynamic là một khái niệm mới được đưa vào trong C# 4.0.
        //Cú pháp khai báo kiểu dynamic hoàn toàn tương tự như khai báo biến bình thường:
        //dynamic <tên biến>;
//Trong đó:
    //dynamic là từ khóa.
    //<tên biến> là tên do người dùng đặt.
//Đặc điểm của kiểu dynamic:
    //Các đối tượng thuộc kiểu dynamic sẽ không xác định được kiểu cho đến khi chương trình được thực thi. 
    //Tức là trình biên dịch sẽ bỏ qua tất cả lỗi về cú pháp, việc kiểm tra này sẽ thực hiện khi chương trình thực thi.
//Phân biệt object, var và dynamic
//Về khái niệm thì:
    //Object là kiểu dữ liệu cơ bản của tất cả kiểu dữ liệu trong C#.
    //Var là một từ khóa để khai báo một cách ngầm định kiểu dữ liệu và kiểu anonymous (kiểu anonymous sẽ được trình bày ở những bài sau).
    //Dynamic là một từ khóa để khai báo kiểu dynamic. Kiểu dynamic cũng có thể tương tác với mọi kiểu dữ liệu nhưng khác object, 
    //biến kiểu dynamic chỉ được xác định kiểu dữ liệu khi chương trình thực thi.

//===========================================================================\\
namespace KDL_object__dynamic_và_từ_khoá_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //====== OBJECT =======\\
            int value = 730;

            //Boxing là quá trình chuyển dữ liệu từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu.
            object boxing = value;

            //Unboxing là quá trình ngược lại với boxing, tức là đưa dữ liệu từ kiểu dữ liệu tham chiếu về kiểu dữ liệu giá trị.
            int unboxing = (int)boxing;

            //====== VAR =======\\
            //VD khởi tạo var
            // Lỗi vì chưa khởi tạo giá trị cho biến varInt.
            var varInt;

            // Lỗi vì không được khởi tạo giá trị null cho biến varString.
            var varstring = null;

            // Lỗi vì phải khởi tạo giá trị ngay khi khai báo
            var varLong;
            varLong = 109;

            // Khai báo đúng!
            var varBool = true;
            var varint = 730;
            var t = "tran ngoc hung";
            //gettype dùng để láy ra kiểu dữ liệu của nó
            Console.WriteLine("t co kieu du lieu la: " + t.GetType());

            //VD
            /* Vì biến StringVariable được khởi tạo giá trị kiểu chuỗi 
             * nên trình biên dịch sẽ hiểu biến này như là biến kiểu string. */
            var StringVariable = "HowKteam";
            // Khai báo tường minh biến kiểu string
            string Content = "HowKteam";

            // In giá trị của biến StringVariable và biến Content
            Console.WriteLine(StringVariable);
            Console.WriteLine(Content);

            //====== DYNAMIC =======\\
            // Khai báo biến StringValue kiểu dynamic và khởi tạo giá trị là một chuỗi kiểu string
            dynamic StringValue = "HowKteam";
            /* 
            * Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++
            * Nhưng câu lệnh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu cho biến StringValue
            * Khi chạy chương trình thì lúc này C# mới phát hiện biến StringValue là kiểu string và không thể thực hiện toán tử ++ lúc đó sẽ xuất hiện lỗi
            */
            StringValue++;

            // Khai báo 2 biến Name và Mission kiểu string và khởi tạo giá trị.
            string Name = "HowKteam ";
            string Mission = "Free Education";
            /* 
             * Thực hiện gán 1 biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
             * Sau phép gán này thì biến DynamicValue chứa giá trị là "Free Education" nhưng kiểu dữ liệu của nó vẫn chưa được xác định.
            */
            dynamic DynamicName = Name;

            // Thực hiện cộng chuỗi và in ra màn hình bình thường
            Console.WriteLine("Mission of " + Name + " is " + Mission);
            Console.WriteLine("Mission of " + DynamicName + " is " + Mission);
            Console.ReadKey();
        }
    }
}