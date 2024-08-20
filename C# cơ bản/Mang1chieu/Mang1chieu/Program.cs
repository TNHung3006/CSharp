//====================================================================================\\

//Khái niệm về mảng
//Mảng là Tập hợp các đối tượng có cùng kiểu dữ liệu.
//Mỗi đối tượng trong mảng được gọi là một phần tử.
//Các phần tử phân biệt với nhau bằng chỉ số phần tử. Trong C# chỉ số phần tử là các số nguyên không âm và bắt đầu từ 0 1 2 3…

//Đặc điểm của mảng:
//Các phần tử trong mảng dùng chung một tên và được truy xuất thông qua chỉ số phần tử.
//Một mảng cần có giới hạn số phần tử mà mảng có thể chứa.
//Phải cấp phát vùng nhớ mới có thể sử dụng mảng.
//Vị trí ô nhớ của các phần tử trong mảng được cấp phát liền kề nhau.

//Tại sao phải sử dụng mảng?
//Để trả lời câu hỏi này ta thử xét trường hợp chúng ta cần chứa họ tên của 10 sinh viên trong trường.

//Nếu sử dụng biến bình thường thì ta cần khai báo 10 biến kiểu string để chứa họ tên của 10 sinh viên. Đến đây vẫn chưa có vấn đề gì lớn!
//Nhưng thực tế thì một trường không phải chỉ có 10 sinh viên, nó có thể là 1000 sinh viên, 10000 sinh viên, 30000 sinh viên. Lúc này vấn đề đã xuất hiện, 
//chúng ta không thể khai báo vài nghìn biến kiểu string được như vậy code sẽ rất dài dòng, rất khó kiểm soát. Khi đó việc sử dụng mảng để lưu trữ là lựa chọn tốt nhất.

//Những lợi ích khi sử dụng mảng:
//Gom nhóm các đối tượng có chung tính chất lại với nhau giúp code gọn gàng hơn.
//Để thao tác, dễ quản lý, nâng cấp sửa chữa. Vì lúc này việc thay đổi số lượng sinh viên ta chỉ cần thay đổi số phần tử của mảng là được.
//Dễ dàng áp dụng các cấu trúc lặp vào để xử lý dữ liệu.

//Khai báo mảng 1 chiều
//Cú pháp:
//<kiểu dữ liệu> [] <tên mảng>;
//Chúng ta có thể khởi tạo giá trị khác mà chúng ta mong muốn ngay khi cấp phát vùng nhớ bằng cú pháp sau:
//<kiểu dữ liệu>[] <tên mảng> = new <kiểu dữ liệu>[số lượng phần tử trong mảng] {<giá trị 1>, …, <giá trị n>};

//Trong đó:
//<kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
//Cặp dấu [] là ký hiệu cho khai báo mảng 1 chiều.
//<tên mảng> là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến (quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).
//Để sử dụng được mảng ta phải khởi tạo giá trị hoặc cấp phát vùng nhớ cho mảng. Cấp phát vùng nhớ:

//Được thực hiện thông qua toán tử new(đã trình bày trong bài TOÁN TỬ TRONG C#).
//Lưu ý là khi cấp phát vùng nhớ cho mảng 1 chiều ta cần chỉ ra số phần tử tối đa của mảng.

//Sau khi mảng được cấp phát vùng nhớ thì các phần tử trong mảng sẽ mang giá trị mặc định:
//Đối với số nguyên là 0
//Đối với số thực là 0.0
//Đối với kiểu ký tự là "" (ký tự rỗng)
//Đối với kiểu tham chiếu là null

//Khởi tạo giá trị
//Cú pháp:
//<kiểu dữ liệu>[] <tên mảng> = { <giá trị 1>, …, <giá trị n> };

//Về bản chất thì cách này trình biên dịch vẫn xem xét số phần tử khởi tạo và cấp phát 
//vùng nhớ cho biến mảng sau đó thực khởi tạo giá trị cho các phần tử trong mảng. 
//Nhưng cách viết này có vẻ nhanh và gọn hơn so với cách cấp phát vùng nhớ rồi mới khởi tạo giá trị.

//Sử dụng mảng
//Kiểu mảng có thể dùng làm:
//Kiểu dữ liệu cho biến.
//Kiểu trả về cho hàm.
//Tham số truyền vào cho hàm.
//Các phần tử của mảng được truy xuất thông qua chỉ số phần tử và cặp dấu [].
//Có thể xem các phần tử của mảng như là các biến đơn và thao tác như thao tác với biến bình thường.

//Một số thuộc tính và phương thức đặc trưng của mảng 1 chiều:
//Length: Thuộc tính trả về số nguyên kiểu int là số phần tử tối đa của mảng.

//LongLength: Thuộc tính trả về số nguyên kiểu long là số phần tử tối đa của mảng.

//GetLength(<số chiều>): Trả về số nguyên kiểu int là số phần tử trong chiều đã xác định. 
//Lưu ý chiều của mảng là các số nguyên và được đánh số từ 0. Cho nên đối với mảng 1 chiều thì số chiều là 0.

//GetLongLength(<số chiều>): Tương tự GetLength nhưng trả về số nguyên kiểu long.

//Sort(): Phương thức thực hiện sắp xếp mảng theo một thứ tự.

//Clear(): Phương thức xóa hết dữ liệu trong mảng và đưa về giá trị mặc định của kiểu. Lưu ý là chỉ xóa giá trị,
//vùng nhớ vẫn còn đó và có thể tiếp tục sử dụng mà không cần cấp phát.

//Copy(): Thực hiện copy giá trị của mảng ra một vùng nhớ mới (phép gán thông thường thì 2 đối tượng sẽ dùng chung vùng nhớ 
//rất nguy hiểm vì đối tượng này thay đổi dẫn đến đối tượng kia cũng thay đổi).

//Reverse(): Phương thức thực hiện đảo ngược thứ tự của mảng 1 chiều.
//====================================================================================\\
namespace Mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if true
            // CÓ 3 cách khai báo khởi tạo mảng như sau sau:
            /* VD 
             * Khai báo mảng 1 chiều kiểu string và có tên là Dongvat.
             * Sau đó thực hiện cấp phát vùng nhớ với số phần tử tối đa của mảng là 3.
             */
            //C1: Cấp phát vùng nhớ cho mảng
            string[] Dongvat = new string[3];

            //C2: khởi tạo giá trị cho mảng      
            int[] songuyen = { 0, 1, 3, 6, 7, 10 };
          
            //C3: Khai báo cấp phát vùng nhớ và khởi tạo giá trị cho mảng.
            string[] Kteam = new string[] { "HowKteam", "Free Education" };

            /* Vì chỉ số phần tử được đánh số từ 0 nên muốn truy xuất đến phần tử thứ 2 của mảng
            thì chỉ số phần tử là 1.  */
            Console.WriteLine(songuyen[3]);
            Console.WriteLine(Kteam[1]);


            // NHẬP XUẤT MẢNG 1 CHIỀU

            string[] X = new string[5];
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = Console.ReadLine();   // NHẬP MẢNG
            }
            for (int i = 0; i < X.Length; i++)
            {                
                Console.Write(X[i] + "\t");    // XUẤT MẢNG
            }
#endif
#if false // VD tính tuổi âm

            int Year = 0;

            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

            Console.Write("nhap 1 nam ngau nhien: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            Year = int.Parse(Console.ReadLine());

            /*
             * Vì kết quả phép chia lấy dư của Year%10 hoặc Year%12 sẽ cho ra số nguyên
             * Nên ta sẽ dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương ứng. Thay vì dùng cách cũ là switch case
             * Như vậy cách này vừa đơn giản vừa dễ hiểu, code rất ít sẽ với cách dùng switch case
             */
            Console.WriteLine("nam {0} co tuoi am lich la: {1} {2}", Year, Can[Year%10], Chi[Year%12]);

#endif
            Console.ReadKey();
        }
    }
}