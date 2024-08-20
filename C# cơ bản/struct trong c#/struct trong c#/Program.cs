//=============================================================================================================\\

//Struct là gì? Đặc điểm của Struct
//Struct là một kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thuỷ do người lập trình định nghĩa để thuận tiện trong việc quản lý dữ liệu và lập trình.

//Xét bài toán sau:
//Ta cần lưu trữ thông tin của 10 sinh viên với mỗi sinh viên gồm có các thông tin như: Mã số, Họ tên, Nơi sinh, CMND.
//Khi đó, để lưu thông tin của 1 sinh viên ta cần 4 biến chứa 4 thông tin trên. Nếu muốn lưu thông tin 10 sinh viên thì cần 40 biến. 
//Chắc không quá nhiều, nhưng nếu muốn lưu thông tin của 1000, 10000 sinh viên thì sao?

//Số lượng biến lúc này rất nhiều khiến cho code dài dòng khó thao tác, khó kiểm soát.
//Từ đó người ta mới đưa ra khái niệm kiểu dữ liệu có cấu trúc để giải quyết vấn đề trên.

//Ý tưởng là đóng gói các thông tin đó vào 1 đối tượng duy nhất. 
//Như vậy thay vì phải khai báo 40 biến thì ta chỉ cần khai báo 1 mảng 10 phần tử mà mỗi phần tử có kiểu dữ liệu ta đã định nghĩa.

//Đặc điểm của struct:
//Là một kiểu dữ liệu tham trị (kiểu dữ liệu tham trị đã được trình bày trong bài KIỂU DỮ LIỆU )
//Dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau.
//Bên trong struct ngoài các biến có kiểu dữ liệu cơ bản còn có các phương thức, các struct khác.
//Muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán tử new.
//Struct không được phép kế thừa (khái niệm về kế thừa sẽ trình bày trong bài KẾ THỪA TRONG C# ).

//Cú pháp: khai báo
    //struct <tên struct>
    //{
    //    public <danh sách các biến>;
    //}
//Trong đó:
//<tên struct> là tên kiểu dữ liệu do mình tự đặt và tuân thủ theo quy tắc đặt tên (đã trình bày trong bài BIẾN TRONG C#).
//<danh sách các biến> là danh sách các biến thành phần được khai báo như khai báo biến bình thường (đã trình bày trong bài BIẾN TRONG C#).
//Từ khoá public là từ khoá chỉ định phạm vi truy cập (sẽ trình bày trong bài TÍNH ĐÓNG GÓI). 
//Trong ngữ cảnh hiện tại thì có thể hiểu từ khoá này giúp cho người khác có thể truy xuất được để sử dụng.
//=============================================================================================================\\
namespace struct_trong_c_
{
    internal class Program
    {
#if false        //VD struct
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }
        //Với khai báo này ta đã có 1 kiểu dữ liệu mới tên là SinhVien. Và có thể khai báo biến, sử dụng nó như sử dụng các kiểu dữ liệu khác.
        //Nếu như kiểu int có thể chứa số nguyên, kiểu double có thể chứa số thực thì kiểu SinhVien 
        //vừa khai báo có thể chứa 5 trường thông tin con là MaSo, HoTen, DiemToan, DiemLy, DiemVan. 
        //
#endif
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }
        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine());
        }
        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo);
            Console.WriteLine(" Ho ten: " + SV.HoTen);
            Console.WriteLine(" Diem toan: " + SV.DiemToan);
            Console.WriteLine(" Diem ly: " + SV.DiemLy);
            Console.WriteLine(" Diem van: " + SV.DiemVan);
        }
        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }
        static void Main(string[] args)
        {
            /*
             * Khai báo 1 kiểu dữ liệu SinhVien với các trường thông tin như đề bài.
             * Khai báo và khởi tạo 1 đối tượng SV1 kiểu SinhVien.
             */
            SinhVien SV1;
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            /*
             * Đây là hàm hỗ trợ nhập thông tin sinh viên.
             * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
             * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
             */
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine(" *********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }
    }
}