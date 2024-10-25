﻿//======================================================================================\\

//Phạm vi truy cập và ý nghĩa:
//public: Khong hạn chế. Thanh phan mang thuộc tính nay co thể
//được truy cập ở bất kỳ nơi nào.

//private: Thành phần mang thuộc tính nay la thanh phần rieng tư chỉ
//có nội bộ bên trong lớp chứa nó mới có quyền truy cập.

//protected: Tương tự như private ngoài ra còn có thể truy cập từ lớp dẫr
//xuất lớp chứa nó.(sẽ được trình bày trong bài KẾ THỪA TRONG C#)

//internal: Chỉ được truy cập trong cùng 1 Assembly (nói cách khác là
//cùng project). Thuộc tính này thường được dùng cho class.

//protected internal: Tương tự như internal ngoài ra còn có thể truy cập từ lớp
//dẫn xuất lớp chứa nó (lớp dẫn xuất sẽ được trình bày trong
//bài KẾ THỪA TRONG C#)

//Lưu ý:
//Nếu khai báo lớp mà không chỉ ra phạm vi cụ thể thì phạm vi mặc định là internal.
//Nếu khai báo thành phần bên trong lớp mà không chỉ ra phạm vi cụ thể thì phạm vi mặc định là private.

//Trong tính đóng gói có 2 ý chính:
//Các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng. Điều này được thể hiện qua cách ta xây dựng 1 class.
//Đóng gói còn để che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy. Điều này được thể hiện qua các phạm vi truy cập đã trình bày ở trên. 
//Cụ thể:
//Các thuộc tính thường sẽ có phạm vi là private. Vì đây chính là các thông tin nội bộ của lớp không thể để truy cập 1 cách tuỳ tiện được (che giấu thông tin).
//Các phương thức thường sẽ có phạm vi là public. Vì đây chính là các hành vi (thao tác) mà lớp hỗ trợ cho chúng ta thực hiện những
//công việc nhất định nên cần phải cho phép mọi người có thể sử dụng được.

//Phương thức truy vấn, phương thức cập nhật:
//Một vấn đề đặt ra là nếu như mọi thuộc tính bên trong lớp đều là private thì khi người dùng bên ngoài muốn xem hoặc thay đổi giá trị thì phải làm sao?
//Đến đây đòi hỏi người lập trình phải viết ra 1 cách nào đó để hỗ trợ người dùng làm điều này. Và cách để người dùng có thể xem
//hoặc thay đổi giá trị cho các thuộc tính bên trong lớp đó chính là thông qua các phương thức truy vấn, phương thức cập nhật.
//Phương thức truy vấn là phương thức giúp người dùng có thể xem được dữ liệu của 1 thuộc tính nào đó. Cụ thể, phương thức truy
//vấn chỉ cần trả về giá trị của thuộc tính tương ứng là đủ.
//Phương thức cập nhật là phương thức giúp người dùng có thể thay đổi giá trị cho 1 thuộc tính nào đó. Cụ thể, phương thức cập nhật
//chỉ cần thực hiện cập nhật giá trị mới cho thuộc tính tương ứng (có thể kiểm tra tính đúng đắn của dữ liệu trước khi truyền vào).
//Thực ra, phương thức truy vấn hay phương thức cập nhật chỉ là một phương thức bình thường. Về khai báo và sử dụng hoàn toàn như phương thức bình thường.

//Một số quy ước nhỏ về cách đặt tên các phương thức này:
//Những phương thức truy vấn nên bắt đầu bằng từ khoá get và kèm theo sau là tên thuộc tính tương ứng. Ví dụ: getHoTen(), getDiemToan(), . . .
//Những phương thức cập nhật nên bắt đầu bằng từ khoá set và kèm theo sau là tên thuộc tính tương ứng. Ví dụ: setDiemToan(), setHoTen(), . . .
//Nếu thuộc tính kiểu luận lý (bool) thì tên phương thức truy vấn nên bắt đầu bằng từ khoá is và kèm theo sau là tên thuộc tính tương ứng.
//Phương thức truy vấn sẽ có kiểu trả về trùng với kiểu dữ liệu của thuộc tính tương ứng và không có tham số truyền vào.
//Phương thức cập nhật sẽ có kiểu trả về là void và có 1 tham số truyền vào có kiểu dữ liệu trùng với kiểu dữ liệu của thuộc tính tương ứng.

//Từ khoá get và set
//Trong C#, phương thức truy xuất và phương thức cập nhật đã được nâng cấp lên thành 1 cấu trúc mới ngắn gọn hơn và tiện dụng hơn đó là property.
//Sử dụng property giúp ta có thể thao tác dữ liệu tự nhiên hơn nhưng vẫn đảm bảo tính đóng gói của lập trình hướng đối tượng.

//Cú pháp:
//< kiểu dữ liệu> <tên property>
//        {
//            get { return <tên thuộc tính>; }
//            set { <tên thuộc tính> = value; }
//        }
//Trong đó:
//<kiểu dữ liệu> là kiểu dữ liệu của property. Thường sẽ trùng với kiểu dữ liệu của thuộc tính private tương ứng bên trong lớp.
//<tên property> là tên do người dùng đặt và tuân theo quy tắc đặt tên đã trình bày trong bài BIẾN TRONG C#.
//get, set, value là từ khoá có ý nghĩa:
//Từ khoá get tương đương với phương thức truy vấn.
//Từ khoá set tương đương với phương thức cập nhật.
//Từ khoá value đại diện cho giá trị mà người gán vào property (tương đương với tham số truyền vào của phương thức cập nhật).
//<tên thuộc tính> là tên thuộc tính thực sự bên trong lớp.

//Lưu ý:
//Người ta dùng Property thay cho phương thức truy vấn, phương thức cập nhật vì thế tên property thường phải làm gợi nhớ đến tên thuộc tính private bên trong lớp.
//Tuỳ theo nhu cầu và tính bảo mật mà người lập trình có thể ngăn không cho gán giá trị hoặc ngăn không cho lấy dữ liệu bằng cách bỏ đi từ khoá tương ứng.


//======================================================================================\\
namespace Các_phạm_vi_truy_cập
{
#if false //VD tính đóng gói
        //Vì không chỉ định từ khoá cụ thể nên class SinhVien sẽ có phạm vi là internal.
    class SinhVien
    {        
            //Các thuộc tính đều mang phạm vi là private. Vì thế chỉ được sử dụng nội bộ trong class
            //Ra bên ngoài sẽ không truy cập được.     
        private string MASV;
        private string HoTen;
        private double DiemToan = 100;
        private double DiemVan = 200;
        
            //Phương thức này có phạm vi là public nên có sử dụng từ bên ngoài.
            //Và vì phương thức này nằm trong lớp nên có thể sử dụng các thuộc tính private ở trên.       
        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;
            Console.WriteLine(" Sinh vien " + HoTen + " co diem TB la: " + DTB);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SinhVien sinhVien1 = new SinhVien();
            sinhVien1.InThongTinDiemTB();
        }
    }
#endif
#if false // VD Phương thức truy vấn, phương thức cập nhật:
    class SinhVien
    {
        private string MASV = "64103783";
        private string HoTen;
        private double DiemToan;
        private double DiemVan;
        
            //Đây là phương thức truy vấn giá trị của thuộc tính MASV
            //Vì thế phương thức sẽ trả về string (trùng với kiểu dữ liệu của thuộc tính MASV)         
        public string getMASV()
        {
            return MASV;
               
        }       
            //Đây là phương thức cập nhật giá trị cho thuộc tính DiemToan
            //Vì thế phương thức có 1 tham số truyền vào kiểu double trùng với kiểu của DiemToan.        
        public void setDiemToan(int diemtoan)
        {
            DiemToan = diemtoan;
            Console.WriteLine(DiemToan);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.setDiemToan(50);
            sinhVien.getMASV();
        }
    }
#endif
#if true //VD Từ khoá get và set
        //Ví dụ: ta có 1 thuộc tính diemLy cần được đóng gói.Khi đó ta sẽ có 1 property tương ứng để thực hiện điều này:
    class SinhVien
    {
        private double diemLy;
        private double diemLy1;
        //VD get-set
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }
        //Bạn hoàn toàn có thể viết những kiểm tra nếu muốn vào bên trong get, set.
        public double DiemLy1
        {
            get { return diemLy1; }
            set
            {
                /*
                 Kiểm tra điểm lý có thoả mãn hay không
                 Nếu có sẽ thực hiện gán vào thuộc tính private.
                 Nếu không sẽ không làm gì cả.
                 Điều này nhằm đảm bào tính đúng đắn của dữ liệu.
                */
                if (value <= 10 || value >= 0)
                {
                    diemLy1 = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();

            SV1.DiemLy = 8; // khi gán giá trị cho property thì các câu lệnh bên trong set sẽ được thực hiện
            SV1.DiemLy1 = 7; // giá trị sẽ được truyền vào value trong set.

            Console.WriteLine(" Diem ly: " + SV1.DiemLy); // khi lấy giá trị của property thì các câu lệnh bên trong get sẽ được thực hiện.
            Console.WriteLine(" Diem ly: " + SV1.DiemLy1);
        }
    }
#endif
}