//===========================================================================\\

//Cú pháp:
//switch (< biểu thức >)
//{
//case < giá trị thứ 1 >: < câu lệnh thứ 1 >;
//        break;
//    case < giá trị thứ 2 >: < câu lệnh thứ 2 >;
//        break;
//. . .
//case < giá trị thứ n >: < câu lệnh thứ n >;
//        break;
//    default: < câu lệnh mặc định >;
//        break;
//    }

//Trong đó: 
//switch, case, default là từ khóa bắt buộc.
//< biểu thức > phải là biểu thức trả về kết quả kiểu:
//Số nguyên(int, long, byte, . . .)
//Ký tự hoặc chuỗi(char, string)
//Kiểu liệt kê(enum, sẽ được trình bày trong bài ENUM TRONG LẬP TRÌNH C#)
//<giá trị thứ i> với i = 1..n là giá trị muốn so sánh với giá trị của <biểu thức>.
//<câu lệnh thứ i> với i = 1..n là câu lệnh muốn thực hiện khi <giá trị thứ i> tương ứng bằng với giá trị của <biểu thức>.
//<câu lệnh mặc định> là câu lệnh sẽ được thực hiện nếu giá trị <biểu thức> không bằng với <giá trị thứ i> nào.

//Ý nghĩa: Duyệt lần lượt từ trên xuống dưới và kiểm tra xem giá trị của <biểu thức> có bằng với <giá trị thứ i> đang xét hay không. 
//Nếu bằng thì thực hiện <câu lệnh thứ i> tương ứng. Nếu không bằng tất cả các <giá trị thứ i> thì sẽ thực hiện <câu lệnh mặc định>.

//===========================================================================\\
namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false // vd switch case         
            int k = 8;
            switch (k)
            {
                case 3:
                    Console.WriteLine("HowKteam");
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break 
                case 9: // case này rỗng (không có lệnh thực hiện) nên không cần lệnh break
                case 10:
                    Console.WriteLine("Free Education");
                    break;
            }

            int k1 = 10;
            switch (k1) // giá trị biểu thức là giá trị của biến k (kiểu số nguyên)
            {
                case 3: // các giá trị so sánh cũng là kiểu số nguyên
                    Console.WriteLine("HowKteam"); // lệnh thực hiện nếu k = 3
                    break; // lệnh thoát ra khỏi cấu trúc
                case 9:
                    Console.WriteLine("Kteam"); // tương tự
                    break;
                case 10:
                    Console.WriteLine("Free Education"); // tương tự
                    break;
            }

            int k2 = 8;
            switch (k2)
            {
                case 3:
                    Console.WriteLine("HowKteam");
                    break;
                case 9:
                    Console.WriteLine("Kteam");
                    break;
                case 10:
                    Console.WriteLine("Free Education");
                    break;
                default: // Nếu không thỏa các trường hợp trên sẽ thực hiện lệnh sau đây
                    Console.WriteLine("Connecting to HowKteam. . .");
                    break;
            }
#endif
#if true    //vd bài tập
            //Ví dụ: Viết chương trình tính năm âm lịch từ năm dương lịch đã nhập.

            //Thuật toán tính năm âm lịch:
            //Năm âm lịch = Can + Chi.Vì thế cần tính được Can và Chi sau đó ghép lại là xong.

            //Tính Can bằng cách:
            //Tìm phần dư của phép chia năm dương lịch cho 10.
            //Tra bảng sau để tìm ra Can tương ứng
            //Can: Canh(0) Tân(1) Nhâm(2) Quý(3) Giáp(4) Ất(5) Binh(6) Đinh(7) Mậu(8) Kỷ(9)

            //Tìm Chi bằng cách:
            //Tìm phần dư của phép chia năm dương lịch cho 12.
            //Tra bảng sau để tìm ra Chi tương ứng:
            //Chi: Thân(0) Dậu(1) Tuất(2) Hợi(3) Tý(4) Sửu(5) Dần(6) Mẹo(7) Thìn(8) Tỵ(9) Ngọ(10) Mùi(11)

            int Year;
            string Chi = "", Can = "";

            Console.WriteLine("Nhap vao so nam bat ki:");
            Year = int.Parse(Console.ReadLine());

            switch(Year % 10)
            {
                case 0:
                    Can = "Canh";
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Dinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;
            }
            switch(Year % 12) {
                case 0:
                    Chi = "Than";
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ty";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ty";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;
            }
            Console.WriteLine("Nam {0} co tuoi am lich la: {1} {2}", Year,Can, Chi);
#endif
        }
    }
}