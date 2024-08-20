//============================================================================\\
/*
Biến là gì?

    - Là một giá trị dữ liệu có thể thay đổi được.
    - Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ.
    - Là thành phần cốt lõi của một ngôn ngữ lập trình.

Tại sao phải sử dụng biến?

    - Lưu trữ dữ liệu và tái sử dụng: ví dụ hãy tưởng tượng nếu bạn yêu cầu người nhập vào tuổi của họ,
    nhưng bạn không lưu trữ lại thì đến khi bạn muốn sử dụng thì chẳng biết lấy đâu ra để sử dụng cả.

Thao tác với bộ nhớ một cách dễ dàng:

    - Cấu trúc của bộ nhớ bao gồm nhiều ô nhớ liên tiếp nhau, mỗi ô nhớ có một địa chỉ riêng (địa chỉ ô nhớ thường mã hex (thập lục phân)).
    - Khi muốn sử dụng ô nhớ nào (cấp phát, hủy, lấy giá trị, . . .) bạn phải thông qua địa chỉ của chúng. Điều này làm cho việc lập trình trở nên khó khăn hơn.
    - Thay vào đó bạn có thể khai báo một biến và cho nó tham chiếu đến ô nhớ bạn cần quản lý rồi khi sử dụng bạn sẽ dùng 
    tên biến bạn đặt chứ không cần dùng địa chỉ của ô nhớ đó nữa. Rất tiện lợi phải không nào!
   
Cú pháp: 

    <Kiểu dữ liệu> <Tên biến>;

Quy tắc đặt tên biến:

    - Tên biến là một chuỗi ký tự liên kết (không có khoảng trắng) và không chứa ký tự đặc biệt.
    - Tên biến không được đặt bằng tiếng việt có dấu.
    - Tên không được bắt đầu bằng số.
    - Tên biến không được trùng nhau.
    - Tên biến không được trùng với từ khóa:DS từ khoá ở trong bài 4 c# cơ bản Howkteam
    - Nên viết thường từ đầu tiên và viết hoa chữ cái đầu tiên của những từ tiếp theo. (không bắt buộc)

Một số lưu ý khi đặt tên biến:

    - Nên đặt tên ngắn gọn dễ hiểu, thể hiện rõ mục đích của biến. Ví dụ như: Name, Tuoi, GioiTinh, . . .
    - Không nên đặt tên biến bằng một ký tự như i, k, m, . . . như vậy sau này khi xem lại code hoặc đưa code cho người khác 
    đọc thì chúng ta sẽ không hiểu biến này dùng để làm gì. Trừ những trường hợp đặc biệt (sẽ nói trong những bài học sau).
    - C# có phân biệt chữ hoa chữ thường. Ví dụ biến a khác biến A hoặc lệnh Console.WriteLine() khác lệnh Console.WRITELINE().
*/

namespace bien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kieusonguyen = 730;
            float kieusothuc = 7.6f;
            bool kieudungsai = false;
            string kieuchuoi = "tran ngoc hung - nam";
            char kieukitu    = 'a';

            int a = 6;
            float b = 7.3f;
            float c = a + b;

            Console.WriteLine("Kieu so nguyen co gia tri = {0}", kieusonguyen);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("c = " + c);
            Console.WriteLine("c = a + b : {0} = {1} + {2}", c, a, b);
            Console.ReadKey();

        }
    }
}