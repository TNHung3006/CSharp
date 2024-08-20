//===========================================================================\\

//Ép kiểu là gì?
    //Ép kiểu là biến đổi dữ liệu thuộc kiểu dữ liệu này thành kiểu dữ liệu khác.
//Tại sao phải ép kiểu?
    //Để chuyển dữ liệu sang một kiểu dữ liệu mong muốn phục vụ cho việc thao tác xử lý.
    //Đưa dữ liệu về định dạng mà mình mong muốn (ví dụ chuyển kiểu ngày tháng bên Mỹ sang dạng ngày tháng bên Việt Nam).

//Trong C#, ép kiểu có 4 loại:
    //Chuyển đổi kiểu ngầm định (implicit).
    //Chuyển đổi kiểu tường minh (explicit).
    //Sử dụng phương thức, lớp hỗ trợ sẵn:
    //Dùng phương thức Parse(), TryParse().
    //Dùng lớp hỗ trợ sẵn (Convert).
    //Người dùng tự định nghĩa kiểu chuyển đổi.

//Chuyển đổi kiểu ngầm định (implicit)
    //Việc chuyển đổi này được thực hiện bởi trình biên dịch và chúng ta không cần tác động gì.

//Được thực hiện khi chuyển kiểu từ
    //Kiểu dữ liệu nhỏ sang kiểu dữ liệu lớn hơn (xem lại bài KIỂU DỮ LIỆU TRONG C#)
    //Chuyển từ lớp con đến lớp cha (khái niệm lớp con lớp cha sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#).

//Chuyển đổi kiểu tường minh (explicit)
    //Chuyển đổi kiểu tường minh là việc chuyển kiểu một cách rõ ràng và dùng từ khóa chỉ định chứ không dùng phương thức.
    //Một số đặc điểm của chuyển đổi kiểu tường minh:
    //Thường được dùng để chuyển đổi giữa các kiểu dữ liệu có tính chất tương tự nhau (thường thì với số).
    //Hỗ trợ trong việc boxing và unboxing đối tượng (sẽ được trình bày trong bài KIỂU DỮ LIỆU OBJECT TRONG C#).
    //Cú pháp ngắn gọn do không sử dụng phương thức.
    //Chỉ khi chúng ta biết rõ biến đó thuộc kiểu dữ liệu nào mới thực hiện chuyển đổi. Ngược lại có thể lỗi khi chạy chương trình.
    //Ta có thực hiện ép kiểu dữ liệu lớn hơn về kiểu dữ liệu nhỏ hơn mà không báo lỗi.
    //Nếu dữ liệu cần ép kiểu vượt quá miền giá trị của kiểu dữ liệu muốn ép kiểu về thì 
    //chương trình sẽ tự cắt bit cho phù hợp với khả năng chứa kiểu dữ liệu đó (cắt từ bên trái qua).

//Sử dụng phương thức, lớp hỗ trợ sẵn
//Phương thức Parse(), TryParse()

//Cú pháp:Parse()
    //<kiểu dữ liệu>.Parse(<dữ liệu cần chuyển đổi>);
    //<kiểu dữ liệu> là kiểu dữ liệu cơ bản mình muốn chuyển đổi sang.
    //<dữ liệu cần chuyển đổi> là dữ liệu thuộc kiểu chuỗi, có thể là biến kiểu chuỗi hoặc giá trị hằng kiểu chuỗi (giá trị hằng đã giải thích trong bài HẰNG TRONG C#).
//Ý nghĩa:
    //Chuyển đổi một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
    //Phương thức trả về giá trị kết quả chuyển kiểu nếu chuyển kiểu thành công. Ngược lại sẽ báo lỗi chương trình.

//Cú pháp:TryParse()
    //<kiểu dữ liệu>.TryParse(<dữ liệu cần chuyển đổi>, out <biến chứa kết quả>);
    //<kiểu dữ liệu> là kiểu dữ liệu cơ bản mình muốn chuyển đổi sang.
    //<dữ liệu cần chuyển đổi> là dữ liệu thuộc kiểu chuỗi, có thể là biến kiểu chuỗi hoặc giá trị hằng kiểu chuỗi.
    //<biến chứa kết quả> là biến mà bạn muốn lưu giá trị kết quả sau khi chuyển kiểu thành công.
    //Từ khóa out là từ khóa bắt buộc phải có, ý nghĩa của từ khóa này sẽ được trình bày chi tiết trong bài HÀM TRONG C#.
//Ý nghĩa:
    //Chuyển một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
    //Phương thức sẽ trả về true nếu chuyển kiểu thành công và giá trị kết quả chuyển kiểu sẽ lưu vào <biến chứa kết quả>.
    //Ngược lại sẽ trả về false và <biến chứa kết quả> sẽ mang giá trị 0.
//===========================================================================\\

namespace epkieuc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false // ép kiểu ngầm định, tường minh
            // ép kiểu ngầm định
            int intValue = 10;
            long longValue = intValue; /* Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển từ int sang long.*/
            float floatValue = 10.9f;
            double doubleValue = floatValue; /* Tương tự vì kiểu double có miền giá trị lớn hơn kiểu float nên có thể chuyển từ float sang double.*/

            // ép kiểu tường minh
            int i = 300; // 300 có mã nhị phân là 100101100
            byte b = (byte)i;
            /* do kiểu byte có giới hạn đến giá trị 255 thôi nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 bytes tương đương 8 bit. 
             * Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được. Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit) 
             * tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.*/
            Console.WriteLine(" i = " + i);
            Console.WriteLine(" b = " + b);

            double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; // Ép kiểu số 2 từ kiểu nguyên sang kiểu số thực. Như vậy kết quả phép chia sẽ ra số thực
            double l = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với 2 mục đích để biến số 2 (số nguyên) thành 2.0 (số thực)
            Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d, k, l);

            //VD thêm
            int h = 5; 
            int t = 2;
            float m = h / t;
            float e = (float)h / t;
            float f = 1.0f*h / t;
            Console.WriteLine(" e = {0} \n f = {1} \n m = {2}", e, f, m);
#endif
#if true // ép kiểu Parse, TryParce

            // ép kiểu Parse
            string s = "10";
            int Value1 = int.Parse(s); // Chuyển chuỗi stringValue sang kiểu int và lưu giá trị vào biến intValue - Kết quả intValue = 10
            double HowKteam = double.Parse("10.9"); // Chuyển chuỗi giá trị hằng "10.9" sang kiểu double và lưu giá trị vào biến HowKteam - Kết quả HowKteam = 10.9
            Console.WriteLine( Value1 + HowKteam);

            // ép keieur TryParse
            int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
            bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
            string Data1 = "10", Data2 = "Kteam"; // Dữ liệu cần ép kiểu

            isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. 
                                                         // Ngược lại Result sẽ mang giá trị 0 và isSuccess mang giá trị false
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
            Console.WriteLine(" Result = " + Result); // In giá trị Result ra màn hình

            isSuccess = int.TryParse(Data2, out Result); // Tương tự như trên nhưng thao tác với Data2
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Tương tự như trên
            Console.WriteLine(" Result = " + Result); // Tương tự như trên

#endif
#if false   //VD bài tập
            int A, B; // Biến chứa giá trị 2 số vừa nhập vào (kiểu số)
            int Tong, Hieu, Tich; // Biến chứa kết quả tổng, hiệu, tích
            double Thuong; // Vì phép chia có thể cho ra số thập phân nên dùng biến kiểu double để chứa nó.
            string strA, strB; // Biến chứa giá trị 2 số nhập vào từ bàn phím (kiểu chuỗi)

            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*   Chuong trinh tinh tong, hieu, tich, thuong  *");
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");

            Console.Write("\nMoi ban nhap so A: ");
            strA = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số A
            Console.Write("Moi ban nhap so B: ");
            strB = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số B

            A = int.Parse(strA); // Ép kiểu giá trị nhập vào từ kiễu chuỗi sang kiểu số nguyên, sử dụng phương thức Parse()
            B = int.Parse(strB); // Tương tự

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B; // Ép kiểu số A về số thập phân để phép chia cho ra số thập phân

            Console.WriteLine("Tong = " + Tong);
            Console.WriteLine("Hieu = " + Hieu);
            Console.WriteLine("Tich = " + Tich);
            Console.WriteLine("Thuong = " + Thuong);
#endif
#if false // bài tập
            // tính tổng hiệu tích thương 
            int a, b;
            int tong, hieu, tich;
            float thuong;
            String stra, strb;

            Console.WriteLine("================================");
            Console.WriteLine("||   Chuong Trinh Tinh Toan   ||");
            Console.WriteLine("================================");

            Console.WriteLine("Nhap vao so nguyen a:");
            stra = Console.ReadLine();
            Console.WriteLine("Nhap vao so nguyen b:");
            strb = Console.ReadLine();

            a = int.Parse(stra);
            b = int.Parse(strb);

            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = a / b;
            Console.WriteLine("Tong = {0}\nHieu = {1}\nTich = {2}\nThuong = {3}", tong, hieu, tich, thuong);
#endif
        }
    }
}