﻿//============================================================================================\\

//Đặc điểm của thành viên tĩnh
//Bình thường các thuộc tính, phương thức sẽ có đặc điểm:
//Chỉ có thể sử dụng sau khi khởi tạo đối tượng.
//Dữ liệu thuộc về riêng mỗi đối tượng (xét cùng 1 thuộc tính thì các đối tượng khác nhau thì thuộc tính đó sẽ mang các giá trị khác nhau).
//Được gọi thông qua tên của đối tượng.
//Đôi lúc người lập trình mong muốn 1 thuộc tính nào đó được dùng chung cho mọi đối tượng (chỉ được cấp phát 1 vùng nhớ duy nhất). Từ đó khái niệm thành viên tĩnh ra đời.

//Đặc điểm của thành viên tĩnh:
//Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình.
//Có thể dùng chung cho mọi đối tượng.
//Được gọi thông qua tên lớp.
//Được huỷ khi kết thúc chương trình.

//Có 4 loại thành viên tĩnh chính:
//Biến tĩnh(static variable).
//Phương thức tĩnh (static method).
//Lớp tĩnh(static class).
//Phương thức khởi tạo tĩnh (static constructor).
//Để khai báo 1 thành viên tĩnh ta sử dụng từ khoá static đặt trước tên biên, tên phương thức hoặc tên lớp. Chi tiết sẽ được trình bày ngày sau đây.

//1. Biến tĩnh %%%%%%%%%%%%%%%%%%%%
//Cú pháp:
//<phạm vi truy cập> static < kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;

//Trong đó:
//<phạm vi truy cập> là các phạm vi đã trình bày trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C# OOP
//static là từ khoá để khai báo thành viên tĩnh.
//<kiểu dữ liệu> là kiểu dữ liệu của biến (đã được trình bày trong bài KIỂU DỮ LIỆU TRONG C#).
//<tên biến> là tên biến do người dùng đặt và tuân thủ các quy tắc đặt tên biến (các quy tắc đặt tên biến đã trình bày trong bài BIẾN TRONG C#).
//<giá trị khởi tạo> là giá trị ban đầu mà biến tĩnh này chứa. Nếu bạn không khai báo giá trị này thì C# thì tự gán giá trị mặc định và đưa ra 1 cảnh báo khi bạn biên dịch chương trình.

//Bạn có thể hiểu biến tĩnh là:
//Một biến dùng chung cho mọi đối tượng thuộc lớp.
//Nó được khởi tạo vùng nhớ 1 lần duy nhất ngay khi chương trình được nạp vào bộ nhớ để thực thi và huỷ khi kết thúc chương trình.
//Ngoài biến tĩnh ra thì hằng số cũng có thể được gọi thông qua tên lớp và không cần khởi tạo đối tượng nhưng biến tĩnh linh hoạt hơn đó là có thể thay đổi giá trị khi cần thiết.

//Về cách sử dụng thì bạn thao tác hoàn toàn giống 1 biến bình thường chỉ cần lưu ý là phải gọi biến này thông qua tên lớp.

//2. Phương thức tĩnh %%%%%%%%%%%%%%%%%%%%
//Cú pháp:
//<phạm vi truy cập> static < kiểu trả về> <tên phương thức>
//         {
//             // nội dung phương thức
//         }

//Trong đó:
//< phạm vi truy cập> là các phạm vi đã trình bày trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C# OOP.
//static là từ khoá để khai báo thành viên tĩnh.
//<kiểu trả về> là kiểu trả về của phương thức (đã được trình bày trong bài HÀM TRONG C#).
//<tên phương thức> là tên do người dùng đặt và tuân thủ các quy tắc đặt tên (các quy tắc đặt tên đã trình bày trong bài BIẾN TRONG C#).

//Hàm tĩnh được sử dụng với 2 mục đích chính:
//Hàm tĩnh là 1 hàm dùng chung của lớp. Được gọi thông qua tên lớp và không cần khởi tạo bất kỳ đối tượng nào, từ đó tránh việc lãng phí bộ nhớ.
//Hỗ trợ trong việc viết các hàm tiện ích để sử dụng lại.

//LƯU Ý:
//Về sử dụng thì bạn thao tác hoàn toàn giống 1 phương thức bình thường chỉ cần lưu ý là phải gọi phương thức này thông qua tên lớp.

//3. Lớp tĩnh %%%%%%%%%%%%%%%%%%%%
//Cú pháp:
//< phạm vi truy cập> static class <tên lớp>
//{
//    // các thành phần của lớp
//}

//Trong đó:
//<phạm vi truy cập> là các phạm vi đã trình bày trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C# OOP.
//static là từ khoá để khai báo thành viên tĩnh.
//class là từ khoá để khai báo lớp.
//<tên lớp> là tên do người dùng đặt và tuân thủ các quy tắc đặt tên (các quy tắc đặt tên đã trình bày trong bài BIẾN TRONG C#).
//Lớp tĩnh có các đặc điểm
//Chỉ chứa các thành phần tĩnh (biến tĩnh, phương thức tĩnh).
//Không thể khai báo, khởi tạo 1 đối tượng thuộc lớp tĩnh.

//Với 2 đặc điểm trên có thể thấy lớp tĩnh thường được dùng với mục đích khai báo 1 lớp tiện ích chứa các hàm tiện ích hoặc hằng số vì:
//Ràng buộc các thành phần bên trong lớp phải là static.
//Không cho phép tạo ra các đối tượng dư thừa làm lãng phí bộ nhớ.
//Mọi thứ đều được truy cập thông qua tên lớp.
//Xét lại ví dụ trong phần hàm tĩnh. Rõ ràng là người có thể vô ý tạo ra đối tượng thuộc TienIch. Đối tượng này khá vô nghĩa vì không có gì để sử dụng.
//Để tránh điều này ta thêm từ khoá static vào trước khai báo lớp.

//Trong C# có rất nhiều lớp tiện ích sử dụng lớp tĩnh, phương thức tĩnh để khai báo. Ví dụ điển hình đó là lớp Math.
//Lớp Math chứa:
//Các hằng số nhứ PI, E.
//Các phương thức hỗ trợ tính toán như: sin, cos, tan, sqrt, exp, . . .
//Bạn có thể tự khám phá chúng bằng cách gõ “Math.” để xem các thành phần của lớp Math.

//Phương thức khởi tạo tĩnh
//Cú pháp:
//static < tên lớp > ()
//{
//    // nội dung của constructor
//}

//Trong đó:
//static là từ khoá để khai báo thành viên tĩnh.
//<tên lớp> là tên của lớp chứa constructor này.

//Đặc điểm của constructor tĩnh
//Không được phép khai báo phạm vi truy cập. Nếu cố tình làm điều này C# sẽ báo lỗi khi biên dịch.
//Constructor tĩnh sẽ được gọi 1 lần duy nhất khi chương trình được nạp vào bộ nhớ để thực thi như là 1 cách để ta 
//thiết lập một số thông số theo ý muốn trước khi có bất kỳ đối tượng nào được tạo ra.
//Constructor tĩnh cũng giống phương thức tĩnh nên không thể gọi các thuộc tính không phải static.

//Ví dụ:
//Giả sử như bạn có 1 biến tĩnh chỉ định màu sắc chủ đạo của ngày và màu sắc chủ đạo này phụ thuộc vào hôm nay là thứ mấy.
//Thứ 2: màu xanh dương
//Thứ 3: màu đỏ
//Thứ 4: màu tím
//Thứ 5: màu hồng
//Thứ 6: màu đen
//Thứ 7: màu xanh lá
//Chủ nhật: màu vàng
//Rõ ràng là bạn mong muốn khởi tạo giá trị cho biến tĩnh này nhưng:

//Không thể khởi tạo bằng cách gán trực tiếp như thế này:
//    public static string MauChuDao = "Red";
//Vì ngoài màu đỏ ra thì còn có màu tím và màu này phụ thuộc vào ngày hiện tại.
//Không thể khởi tạo biến tĩnh này trong constructor bình thường được. Vì constructor bình thường chỉ được gọi khi có đối tượng được khởi tạo.

//============================================================================================\\

namespace từ_khoá_static_trong_oop
{
#if true    // VD biến tĩnh
    class Cat
    {   
        //field
        private int weight;
        private int height;
        //Khai báo property tương ứng với thuộc tính.
        //Mặc dù trong bài không sử dụng tới nhưng nhắc để nhớ tuân thủ tính đóng gói.
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

            //Khai báo 1 biến static tên Count để chứa số lượng mèo hiện tại.
            //Mỗi lần có 1 đối tượng được tạo ra thì ta sẽ tăng Count lên.
        public static int Count = 0;
        public Cat()
        {
            /* Vì constructor chỉ được gọi khi có đối tượng được tạo ra nên ta sẽ tăng Count ở đây */
            Count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // truy cập thuộc tính static thông qua tên lớp "Cat.Count" 
            Console.WriteLine(" So luong meo ban dau: " + Cat.Count);
            Cat BlackCat = new Cat(); // Tạo ra con mèo đầu tiên
            BlackCat.Weight = 7;
            BlackCat.Height = 10;
            Console.WriteLine(" chi so black cat\n Weight = {0}\n Height = {1}", BlackCat.Weight, BlackCat.Height );

            // truy cập thuộc tính static thông qua tên lớp "Cat.Count"
            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);            
            Cat WhiteCat = new Cat(); // Tạo ra con mèo thứ 2
            WhiteCat.Weight = 6;
            WhiteCat.Height = 30;
            Console.WriteLine(" chi so white cat\n Weight = {0}\n Height = {1}", WhiteCat.Weight, WhiteCat.Height);
            // truy cập thuộc tính static thông qua tên lớp "Cat.Count"
            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);
        }
    }
#endif
    // VD phương thức tĩnh
#if false   

    public class StringUtils
    {
        public static int CountCharacters(string t)
        {
            return t.Length;
        }
    }
    class program 
    {
        static void Main(string[] args) 
        { 
        // Gọi phương thức static thông qua tên lớp
        string input = "Hello, World!";
        int characterCount = StringUtils.CountCharacters(input);
        Console.WriteLine("Số ký tự trong chuỗi là: " + characterCount);
        }
    }
#endif
#if true    //VD đếm số lượng kí tự trong chuỗi
    public class tinhtoan
    {
        //Khai báo và định nghĩa 1 phương thức tính giai thừa 2 số nguyên.
        public static double Giaithua(int a) 
        {
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= i;
            }
            return b;
        }

        //Khai báo và định nghĩa 1 phương thức tính luỹ thừa 2 số nguyên.
        public static long LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 0; i < SoMu; i++)
            {
                KetQua *= CoSo;
            }
            return KetQua;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ket qua cua giai thua: ");
            Console.WriteLine(tinhtoan.Giaithua(int.Parse(Console.ReadLine())));
            Console.WriteLine("ket qua cua luy thua: ");
            Console.WriteLine(tinhtoan.LuyThua(3,3));
        }
    }
#endif
    //VD lớp tĩnh
#if false
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("[LOG]: " + message);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            // Gọi phương thức static của lớp static
            Logger.Log("Ghi log thông báo");
        }
    }
#endif
#if false
    //VD màu sắc
    class MauSac
    {
        /* Giả sử màu chủ đạo là 1 chuỗi ký tự lưu tên màu tương ứng */
        public static string MauChuDao;
        /* Dùng static constructor để kiểm tra ngày hiện tại và khởi tạo giá trị cho biến tĩnh MauChuDao */
        static MauSac()
        {
            /* Khai báo đối tượng ngày giờ và lấy ngày giờ hiện tại của hệ thống */
            DateTime now = DateTime.Now;
            /* lấy ra thứ của ngày hiện tại và so sánh với 7 ngày trong tuần */
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            /* In ra màn hình giá trị của thuộc tính màu chủ đạo */
            Console.WriteLine(" Mau chu dao cua hom nay: " + MauSac.MauChuDao);
        }
    }
#endif
}
