namespace nhapxuatcoban
{
    class Program
    {
        static void Main(string[] args)
        {
#if false   // write in ra nhưng không xuống dòng
            // muốn xuống dòng ta có thể đặt \n sau kí tự trong ngoặc
            // VD
            Console.Write("ABC \n");

            Console.Write("Hello"); // in ra chữ Hello
            Console.Write(10);      // in ra màng hình số 10
            Console.Write(10.9f);   // in ra màng hình số 10.9, chữ f là biểu thị cho kiễu dữ liệu float
            Console.Write(true);    // in ra màng hình chữ true của kiểu dữ liệu bool
#endif
#if false    // writeline in ra và xuống dòng
            Console.Write("ABC \n");    // sử dụng kí tự đặc biệt để xuống dòng
            Console.Write("Hello");     // in ra chữ Hello nhưng không xuống dòng
            Console.Write(1234.5f);     // in ra và không xuống dòng
            Console.Write(Environment.NewLine); // lệnh xuống dòng
            Console.WriteLine(true);    // in ra và xuống dòng
            Console.WriteLine(false);   // in ra và xuống dòng

#endif
#if true   // VD in b = gia tri a
            // C1
            int a = 1;
            Console.Write("b = ");  // in ra màng hình b = 
            Console.WriteLine(a);   // in ra màng hình giá trị của kí tự a
            // C2
            Console.WriteLine("b = " + a);  // in ra màng hình kí tự b = giá trị a
            
#endif
#if true   // in ra nhiều giá trị tương ứng theo từng vị trí
            int b = 7;
            Console.WriteLine("a = {0}", b);  // in ra màng hình kí tự a = giá trị b
            Console.Write("{0} {1} {2}", 7, 3, 0); // in ra màng hình giá trị tương ứng bắt đàu từ vị trí 0
#endif
#if false    // Console.Read();
            // đọc 1 kí tự nhập từ bàn phím từ lệnh console.read sau đó in ra kí tự vừa đọc
            // console.read chỉ in ra 1 giá trị

            // trả ra 1 con số của kí tự đàu tiên mình nhập vào, và láy số từ bảng mã ascii 
            // VD kí tự 'a' trong bảng mã ascii là 97 thì khi mình đọc kí tự từ bàn phím là 'anh long' thì sẽ in ra màng hình số 97

            Console.WriteLine(Console.Read());  // đọc 1 kí tự nhập từ bàn phím từ lệnh console.read sau đó in ra kí tự đàu tiên vừa đọc
            Console.ReadKey();  // sử dụng để khi chạy chương trình chỉ in ra những cái cần in. đợi người dùng nhấn phím enter
#endif
#if false   // Console.Readline();
            // đọc kí tự nhập từ bàn phím từ lệnh Console.ReadLine sau đó in ra các kí tự vừa đọc
            // in ra giá trị đã nhập ra màng hình

            Console.WriteLine(Console.ReadLine());  // đọc kí tự nhập từ bàn phím từ lệnh console.readline sau đó in ra các kí tự vừa nhập

            // VD
            Console.Write("Nhap ho ten cua ban: ");
            Console.WriteLine("Ho ten cua ban la :" + Console.ReadLine());
            // Quy tắc chung trong thực hiện lệnh là thực hiện lệnh bên trong trước rồi mới lệnh bên ngoài chứa nó 
            Console.ReadKey();
#endif
#if false    // Console.ReadKey();

            Console.WriteLine("Tran Ngoc Hung");  

            Console.ReadKey();      // không truyền tham số vào thì mặc định là false
            Console.ReadKey(false);  // hiển thị phím ẩn trên màng hình
            Console.ReadKey(true); // không hiển thị phím ẩn trên màng hình
#endif
        }
    }
}