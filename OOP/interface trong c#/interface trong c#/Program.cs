//=======================================================================================================\\

//Interface là gì? Tại sao lại sử dụng interface
//Interface(nhiều tài liệu gọi là giao diện hoặc lớp giao tiếp) là 1 tập các thành phần chỉ có khai báo
//mà không có phần định nghĩa (giống phương thức thuần ảo đã trình bày ở bài ĐA HÌNH TRONG C#).
//Các thành phần này có thể là:
//Phương thức.
//Property(đã trình bày trong bài CÁC LOẠI PHẠM VI TRUY CẬP TRONG C#).
//Event(sẽ được trình bày trong bài EVENT TRONG C#).
//Indexers(sẽ được trình bày trong series LẬP TRÌNH C# NÂNG CAO).
//Một interface được hiểu như là 1 khuôn mẫu mà mọi lớp thực thi nó đều phải tuân theo.
//Interface sẽ định nghĩa phần “làm gì” (khai báo) và những lớp thực thi interface này sẽ định nghĩa phần “làm như thế nào” (định nghĩa nội dung) tương ứng.

//Đặc điểm của interface
//Chỉ chứa khai báo không chứa phần định nghĩa (giống phương thức thuần ảo). Mặc dù giống phương thức thuần ảo nhưng bạn không cần phải khai báo từ khoá abstract.
//Việc ghi đè 1 thành phần trong interface cũng không cần từ khoá override.
//Không thể khai báo phạm vi truy cập cho các thành phần bên trong interface. Các thành phần này sẽ mặc định là public.
//Interface không chứa các thuộc tính (các biến) dù là hằng số hay biến tĩnh vẫn không được.
//Interface không có constructor cũng không có destructor.
//Các lớp có thể thực thi nhiều interface cùng lúc(ở 1 góc độ nào đó có thể nó là phương án thay thế đa kế thừa).
//Một interface có thể kế thừa nhiều interface khác nhưng không thể kế thừa bất kỳ lớp nào.
//Mục đích sử dụng interface
//Vì C# không hỗ trợ đa kế thừa nên interface ra đời như là 1 giải pháp cho việc đa kế thừa này.
//Trong 1 hệ thống việc trao đổi thông tin giữa các thành phần cần được đồng bộ và có những thống nhất chung.
//Vì thế dùng interface sẽ giúp đưa ra những quy tắc chung mà bắt buộc các thành phần trong hệ thống này phải làm theo mới có thể trao đổi với nhau được.

//Khai báo và sử dụng interface
//Cú pháp:
//interface <tên interface>
//    {
//        // Khai báo các thành phần bên trong interface
//    }

//Trong đó:
//Interface là từ khoá dùng để khai báo 1 interface.
//<tên interface> là tên do người dùng đặt và tuân theo các quy tắc đặt tên đã trình bày trong bài BIẾN TRONG C#.
//Lưu ý là để tránh nhầm lẫn với lớp kế thừa thì khi đặt tên interface người ta thường thêm tiền tố “I” để nhận dạng.
//Việc thực thi 1 interface hoàn toàn giống kế thừa từ 1 lớp (đã trình bày trong bài KẾ THỪA TRONG C#).

//=======================================================================================================\\
namespace interface_trong_c_
{
    interface Ianimal
    {
        void eat();
        void move();       
    }
    interface Imammal
    {
        void feed();
        bool HasBreast { get; set; }
    }
    class animal
    {
        protected int Weight { get ; set ; }
        protected int Height { get; set; }
    }
    class dog : animal, Ianimal, Imammal
    {
        private bool hasBreast;
        public void eat() 
        {
            Console.WriteLine("dog is eating");
        }
        public void move() 
        { 
            Console.WriteLine("dog is moving");
        }
        
        public void feed() 
        { 
            Console.WriteLine("dog is feeding");
        }
        public bool HasBreast 
        { 
            get 
            {
                Console.WriteLine("calling getter ...");
                return hasBreast; 
            }
            set 
            {
                Console.WriteLine("calling setter ...");
                hasBreast = value; 
            }        
        }
        //public void Weight(int x) 
        //{ 
        //    Console.WriteLine($"weight: {x}");
        //}
        //public void Height(int y) 
        //{
        //    Console.WriteLine($"height: {y}");
        //}
        //Hoặc
        public void Weight(int x)
        {
            Console.WriteLine("weight: "+ x);
        }
        public void Height(int y)
        {
            Console.WriteLine("height: "+ y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog dog = new dog();
            dog.eat();
            dog.move();
            dog.Weight(7);
            dog.Height(30);
            dog.HasBreast = true;
            Console.WriteLine($"dog.HasBreast = {dog.HasBreast}");
            
        }
    }
}