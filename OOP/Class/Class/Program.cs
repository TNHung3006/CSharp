//======================================================================================\\
// @@@@@    Tổng quang oop trong c#    @@@@@

//Đầu tiên là lập trình không có cấu trúc:
//Là phương pháp xuất hiện đầu tiên. Phương pháp này đơn giản chỉ là viết tất cả mã lệnh vào 1 hàm main duy nhất và chạy.
//Ngôn ngữ sử dụng phương pháp này là Assembly (hợp ngữ).
//Nhược điểm của phương pháp này:
//Chỉ sử dụng biến toàn cục dẫn đến rất tốn bộ nhớ.
//Vì có những đoạn chương trình cần sử dụng lại nhiều lần nên dẫn đến lạm dụng lệnh goto.
//Khó hiểu, khó bảo trì, không thể tái sử dụng.
//Khó phát triển các ứng dụng lớn.

//Tiếp theo là lập trình có cấu trúc (lập trình thủ tục):
//Sau 1 thời gian tồn tại người ta dần nhận ra những nhược điểm của phương pháp trên và đưa ra giải pháp đó là chia chương trình lớn ra thành các chức năng,
//mỗi chức năng được đưa vào 1 hàm. Khi cần dùng đến chức năng nào thì ta sẽ gọi hàm tương ứng.
//Mỗi chương trình con lại có thể chia nhỏ ra nữa.
//Hầu hết các ngôn ngữ lập trình đều hỗ trợ phương pháp này.
//Ưu điểm:
//Chương trình được module hoá, dễ hiểu, dễ bảo trì.
//Dễ dàng tạo ra các thư viện phần mềm.
//Nhược điểm:
//Dữ liệu và xử lý tách rời.
//Khi cấu trúc dữ liệu thay đổi sẽ dẫn đến thuật toán bị thay đổi.
//Không tự động khởi tạo, giải phóng dữ liệu động.
//Không mô tả được đầy đủ, trung thực hệ thống trong thực tế.

//Khái niệm lập trình hướng đối tượng
//Với mong muốn xây dựng một phương pháp lập trình trực quan, mô tả trung thực hệ thống trong thực tế vì thế phương pháp lập trình hướng đối tượng ra đời.
//Lập trình hướng đối tượng là phương pháp lập trình lấy đối tượng làm nền tảng để xây dựng chương trình.
//Một định nghĩa khác về lập trình hướng đối tượng đó là phương pháp lập trình dựa trên kiến trúc lớp (class) và đối tượng (object).

//Một số khái niệm cơ bản trong lập trình hướng đối tượng
//Đối tượng:
//Trong lập trình hướng đối tượng, đối tượng được hiểu như là 1 thực thể: người, vật hoặc 1 bảng dữ liệu, . . .
//Một đối tượng bao gồm 2 thông tin: thuộc tính và phương thức.
//Thuộc tính chính là những thông tin, đặc điểm của đối tượng. Ví dụ: một người sẽ có họ tên, ngày sinh, màu da, kiểu tóc, . . .
//Phương thức là những thao tác, hành động mà đối tượng đó có thể thực hiện. Ví dụ: một người sẽ có thể thực hiện hành động nói, đi, ăn, uống, . . .

//Lớp:
//Các đối tượng có các đặc tính tương tự nhau được gom lại thành 1 lớp đối tượng.
//Bên trong lớp cũng có 2 thành phần chính đó là thuộc tính và phương thức.
//Ngoài ra, lớp còn được dùng để định nghĩa ra kiểu dữ liệu mới.
//Sự khác nhau giữa đối tượng và lớp
//Lớp là một khuôn mẫu còn đối tượng là một thể hiện cụ thể dựa trên khuôn mẫu đó.

//Để dễ hiểu hơn mình sẽ lấy một ví dụ thực tế:
//Nói về con mèo thì lớp chính là loài mèo. Loài mèo có:
//Các thông tin, đặc điểm như 4 chân, 2 mắt, có đuôi, có chiều cao, có cân nặng, màu lông . . .
//Các hành động như: kêu meo meo, đi, ăn, ngủ, . . .
//Như vậy mọi động vật thuộc loài mèo sẽ có những đặc điểm như trên.
//Đối tượng chính là một con mèo cụ thể nào đó như con mèo con đang nằm dưới chân mình.

//Lập trình hướng đối tượng có 4 đặc điểm chính: @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

//Tính đóng gói: Các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng.
//Ngoài ra, đóng gói còn để che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy.

//Tính trừu tượng: Khi viết chương trình theo phong cách hướng đối tượng, việc thiết kế các đối tượng ta cần rút tỉa ra những 
//đặc trưng chung của chúng rồi trừu tượng thành các interface (khái niệm interface sẽ được trình bày trong bài INTERFACE TRONG C#) 
//và thiết kế xem chúng sẽ tương tác với nhau như thế nào.

//Tính kế thừa: Lớp cha có thể chia sẽ dữ liệu và phương thức cho các lớp con, các lớp con khỏi phải định nghĩa lại, giúp chương trình ngắn gọn. 
//Chi tiết sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#.

//Tính đa hình: Là hiện tượng các đối tượng thuộc các lớp khác nhau có thể hiểu cùng một thông điệp theo các cách khác nhau. 
//Chi tiết sẽ được trình bày và giải thích trong bài TÍNH ĐA HÌNH TRONG C#.

// @@@@@    CLASS    @@@@@

//Class trong C# chính là cách thể hiện khái niệm về lớp trong lập trình hướng đối tượng.

//Một class trong C# có các thành phần như:
//Thuộc tính: là các thành phần dữ liệu hay còn gọi là các biến.
//Phương thức: là các hàm thành phần thể hiện các hành vi của một đối tượng thuộc lớp.
//Phương thức khởi tạo.
//Phương thức huỷ bỏ.

//Class trong C# thực chất là một kiểu dữ liệu mới do người dùng tự định nghĩa.
//Cú pháp:
//class <tên lớp>
//    {
//        < Phạm vi truy cập> <Các thành phần của lớp>;
//    }

//Trong đó:
//< tên lớp > là tên do người dùng đặt và tuân theo quy tắc đặt tên đã trình bày trong bài BIẾN TRONG C#.
//<Phạm vi truy cập> bao gồm các từ khoá như public, protected, private, static, . . . sẽ được trình bày trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C#.
//<Các thành phần của lớp> bao gồm các biến, phương thức của lớp.
//Các biến được khai báo như khai báo biến đã học trong bài BIẾN TRONG C#.
//Các phương thức (hàm) được khai báo như khai báo hàm đã học trong bài HÀM TRONG C#.

//Ví dụ:
//class Animal
//{

//    public double Weight;
//    public double Height;

//    public void Run()
//    {
//        Console.WriteLine(" Animal is running. . .");
//    }
//}
//Với khai báo trên ta đã có 1 kiểu dữ liệu mới tên là Animal. Và ta hoàn toàn có thể khai báo biến và sử dụng nó.
//Từ khoá public là chỉ phạm vi truy cập của các thành phần bên trong class (sẽ được trình bày chi tiết trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C#). 
//Hiện tại bạn chỉ cần hiểu ghi public là để khi sử dụng ta có thể truy cập các thành phần này.
//Lớp Animal có 2 thuộc tính là Weight, Height và 1 phương thức là Run. Như vậy mọi đối tượng thuộc lớp này đều có 3 thành phần trên.
//Nếu để ý các bạn sẽ nhận ra rằng mọi phương thức có sẵn trong C# đều được nằm trong lớp nào đó (khác hoàn toàn với phong cách lập trình hướng thủ tục – phương thức độc lập với dữ liệu). 
//Điều này có thể giải thích là do C# là ngôn ngữ thuần hướng đối tượng nên mọi thứ bên trong nó đều theo phong cách lập trình hương đối tượng.

//Khởi tạo:
//Bạn có thể khởi tạo 1 đối tượng thuộc lớp thông qua toán tử new.
//Ví dụ:
//Animal Dog = new Animal();

//Class là kiểu dữ liệu tham chiếu vì thế đối tượng dữ liệu thực sự được lưu trên heap.

//Sử dụng:
//Về cơ bản thì class được sử dụng tương tự như struct. Các bạn có thể tham khảo ví dụ ở bài STRUCT TRONG C#.
//Để gọi đến các thuộc tính bên trong lớp:
//< tên đối tượng>. <tên thuộc tính>;
//Để gọi đến các phương thức bên trong lớp:
//< tên đối tượng> . <tên phương thức> (<danh sách tham số nếu có>);

//Phương thức khởi tạo, phương thức huỷ bỏ
//Trong thế giới thực khi 1 sự vật nào đó được sinh ra thì nó sẽ mang sẵn trong mình những đặc điểm nhất định và mọi sự vật cùng loài với nó đều như vậy.

//Vì lập trình hướng đối tượng là phương pháp giúp ánh xạ thế giới thực vào thế giới lập trình một cách dễ dàng
//nên từ đó đã xuất hiện 2 khái niệm phương thức khởi tạo và phương thức huỷ bỏ để thể hiện ý trên.

/////////////  Phương thức khởi tạo  \\\\\\\\\\\\\\
//Phương thức khởi tạo (Constructor) là những phương thức đặc biệt được gọi đến ngay khi khởi tạo 1 đối tượng nào đó.

//Đặc điểm
//Có tên trùng với tên lớp.
//Không có kiểu trả về.
//Được tự động gọi khi 1 đối tượng thuộc lớp được khởi tạo.
//Nếu như bạn không khai báo bất kỳ phương thức khởi tạo nào thì hệ thống sẽ tự tạo ra phương thức khởi tạo mặc định không đối số và không có nội dung gì.
//Có thể có nhiều constructor bên trong 1 lớp.
//Có 2 loại phương thức khởi tạo:

//Phương thức khởi tạo không đối số:
//Là phương thức khởi tạo không có bất kỳ tham số truyền vào nào.
//Thường dùng để khởi tạo các giá trị mặc định cho các thuộc tính bên trong class khi khởi tạo đối tượng (giá trị mặc định này do người lập trình quyết định).
//Phương thức khởi tạo có đối số:
//Là phương thức khởi tạo có tham số truyền vào. Và khi khởi tạo đối tượng để phương thức này được gọi ta cần truyền đầy đủ các tham số.
//Thường dùng để khởi tạo các giá trị cho các thuộc thuộc tính bên trong class khi khởi tạo đối tượng (các giá trị này do người khởi tạo đối tượng truyền vào).

//Lưu ý
//Khi 1 đối tượng được khởi tạo chỉ có 1 constructor phù hợp nhất được gọi cho dù trong lớp có nhiều constructor.
//Các tham số của constructor thường sẽ mang các giá trị tương ứng cho các thuộc tính bên trong lớp vì thế bạn nên:
//Khai báo chúng có cùng kiểu dữ liệu với thuộc tính tương ứng.
//Đặt tên chúng gợi nhớ đến thuộc tính tương ứng để tránh nhầm lẫn.
//Không nên khai báo dư tham số sẽ dẫn đến khó hiểu cho người dùng.

/////////////  Phương thức huỷ bỏ  \\\\\\\\\\\\\\
//Phương thức huỷ bỏ (destructor) là phương thức đặc biệt được gọi đến trước khi 1 đối tượng bị thu hồi.

//Đặc điểm:
//Có tên trùng với tên lớp nhưng để phân biệt với constructor thì ta thêm dấu “~” vào trước tên lớp.
//Không có kiểu trả về.
//Được tự động gọi khi 1 đối tượng thuộc lớp kết thúc “vòng đời” của nó thông qua bộ thu dọn rác tự động GC (Garbage Collection).
//Nếu bạn không khai báo destructor thì C# sẽ tự động tạo ra 1 destructor mặc định và không có nội dung gì.
//Chỉ có 1 destructor duy nhất trong 1 lớp.
//Vì bộ GC của C# có cơ chế tự động phát hiện đối tượng không còn được sử dụng nữa và thực hiện thu hồi vùng nhớ của nó 
//nên bạn không cần phải viết tường minh việc huỷ vùng nhớ của nó. Việc bạn có thể làm viết những thứ bạn muốn làm khi đối tượng bị huỷ vào đây thôi!
//======================================================================================\\
namespace Class
{
#if false    //VD class
    //Ở đây mình muốn tập trung vào cách bạn khai báo và sử dụng phương thức bên trong lớp như thế nào.Xét bài toán đơn giản sau: 
    //Khởi tạo các đối tượng thuộc lớp Animal lần lượt gọi phương thức in ra chiều cao và cân nặng của các loài động vật.
    class animal
    {
        public double chieucao;
        public double cannang;

        public void info()
        {
            //Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức) trong lớp đó.
            //Giá trị của các thuộc tính này có thể được khởi tạo đâu đó trong lớp hoặc từ bên ngoài truyền vào.

            Console.WriteLine("chieu cao la: " + chieucao + "\ncan nang la: " + cannang);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo 2 đối tượng thuộc lớp Animal là:
            //+Dog có chiều cao 50cm và cân nặng 2kg.
            //+ Cat có chiều cao 30cm và cân nặng 1kg.
            animal dog = new animal();
            dog.chieucao = 50;
            dog.cannang = 2;
            Console.WriteLine("chi so cua dog:");
            dog.info();

            animal cat = new animal();
            cat.chieucao = 30;
            cat.cannang = 1;
            Console.WriteLine("chi so cua cat:");
            cat.info();

        }
    }
#endif
#if true    //VD phương thức khởi tạo
    class dog 
    {
        public double chieucao;
        public double Cannang;

        public dog()
        {
            chieucao = 70;
            Cannang = 5;
        }
        public dog(int h, int t)
        {
            chieucao = h;
            Cannang = t;
        }
        public void info()
        {
            //Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức) trong lớp đó.
            //Giá trị của các thuộc tính này có thể được khởi tạo đâu đó trong lớp hoặc từ bên ngoài truyền vào.
            Console.WriteLine("chieu cao la: " + chieucao + "\ncan nang la: " + Cannang);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Để ý khi bạn new Cat bạn không truyền tham số vào thì constructor mặc định(constructor không tham số)
            //sẽ tự động được gọi để khởi tạo các giá trị mặc định cho các thuộc tính của đối tượng BlackCat.
            Console.WriteLine("chi so cua cho den:");
            dog blackdog = new dog();
            blackdog.info();    // In ra thông tin Weight, Height có thực sự được khởi tạo giá trị chưa.

            //Lần này ta khởi tạo đối tượng và có truyền 2 tham số như vậy constructor có tham số sẽ được gọi.
            //Như vậy các thuộc tính Weight, Height sẽ không mang giá trị mặc định nữa mà sẽ được gán theo giá trị mà người dùng truyền vào.
            Console.WriteLine("chi so cua cho trang:");
            dog whitedog = new dog(60, 4);
            whitedog.info();    // In ra thông tin Weight, Height để xem có theo mong muốn chưa.
        }
    }
    //Qua ví dụ bạn có thể thấy cách ta truyền tham số khi khởi tạo đối tượng sẽ gian tiếp ám chỉ constructor nào được gọi vì thế bạn cần truyền đúng 
    //và truyền đủ các tham số để C# có thể gọi đúng constructor như ý muốn.
#endif
}