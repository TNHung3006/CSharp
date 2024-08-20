//===========================================================================\\

//Cấu trúc rẽ nhánh là gì? Có mấy loại cấu trúc rẽ nhánh
//Xét 2 mệnh đề sau:
//Mệnh đề 1: “Nếu trời mưa thì đường trơn”.
//Mệnh đề 2: “Nếu bạn rảnh thì đi chơi ngược lại thì thôi”
//Các bạn để ý những chữ in đậm trong 2 mệnh đề trên. Cấu trúc Nếu. . . thì. . . hoặc Nếu. . . thì. . . ngược lại thì. . . được gọi là cấu trúc rẽ nhánh.

//Trong hầu hết các ngôn ngữ lập trình đều có loại cấu trúc rẽ nhánh:
//. . else. . .
//. . case. . . (sẽ nghiên cứu ở bài CẤU TRÚC RẼ NHÁNH SWITCH – CASE TRONG C#)
//Cấu trúc rẽ nhánh If. . . else. . .còn có tên gọi khác là “câu lệnh điều kiện”.

//Cấu trúc If else dạng thiếu và dạng đủ
//Dạng thiếu
    //Cú pháp:
    //If([Biểu thức điều kiện]) < Câu lệnh thực hiện>
        //If là từ khóa bắt buộc.
        //<Biểu thức điều kiện> là biểu trức dạng boolean (trả về true hoặc false).
        //< Câu lệnh thực hiện> là câu lệnh muốn thực hiện nếu <Biểu thức điều kiện> là đúng.
//Ý nghĩa:
//Nếu < Biểu thức điều kiện> trả về true thì thực hiện <Câu lệnh thực hiện> ngược lại thì không làm gì cả.

//Dạng đủ
//Cú pháp:
    //If <Biểu thức điều kiện>
    //              <Câu lệnh thực hiện 1>
    //else
    //              <Câu lệnh thực hiện 2>
        //If, else là từ khóa bắt buộc.
        //<Biểu thức điều kiện> là biểu trức dạng boolean (trả về true hoặc false).
        //<Câu lệnh thực hiện 1> là câu lệnh muốn thực hiện nếu <Biểu thức điều kiện> là đúng.
        //<Câu lệnh thực hiện 2> là câu lệnh muốn thực hiện nếu <Biểu thức điều kiện> là sai.
//Ý nghĩa:
//Nếu <Biểu thức điều kiện> trả về true thì thực hiện <Câu lệnh thực hiện 1> ngược lại thì thực hiện <Câu lệnh thực hiện 2>.

//===========================================================================\\
namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false //VD if-else
            String T = "Hung730T";
            if (T == "Hung")
            {
                Console.WriteLine("sai");
            }else 
            if(T == "Hung730T")
            {
                Console.WriteLine("dung");
            }
            else {
                Console.WriteLine("Error");
            }            
            

            string hung = "hung";
            bool hung730t = hung == "hung" ? true : false;

            if (hung730t)
            {
                Console.WriteLine(hung730t);
            }else
                Console.WriteLine("hung730t != hung");
                Console.ReadKey();
#endif
#if false // Ví dụ: Viết chương trình giải phương trình bậc 1: Ax + B = 0.

            Console.WriteLine("||============================================||");
            Console.WriteLine("||    Chuong trinh giai phuong trinh bac 1    ||");
            Console.WriteLine("||============================================||");

            int A, B;
            string strA, strB;
            double nghiem;

            Console.WriteLine("nhap vao gia tri A: ");
            strA = Console.ReadLine();
            Console.WriteLine("nhap vao gia tri B: ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Gia tri nhap vao khong hop le:");
                return;
            }else
                A = int.Parse(strA);
                B = int.Parse(strB);
            Console.WriteLine("phuong trinh bac 1 co dang {0}x + {1} = 0", A, B);

            if (A == 0)
            {
                if (B == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else 
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            else
            {
                nghiem = (double)-B / A;
                Console.WriteLine("Phuong trinh co nghiem la:" +  nghiem);
            }
            Console.ReadKey();
#endif
#if true // Ví dụ: Viết chương trình giải phương trình bậc 2: Ax^2 + Bx + c = 0.

            int a, b, c, delta;
            string stra, strb, strc;
            float x, x1, x2;

            Console.WriteLine("||========================================||");
            Console.WriteLine("||  chuong trinh giai phuong trinh bac 2  ||");
            Console.WriteLine("||========================================||");

            Console.WriteLine("\nnhap vao so nguyen a: ");
            stra = Console.ReadLine();
            Console.WriteLine("nhap vao so nguyen b: ");
            strb = Console.ReadLine();
            Console.WriteLine("nhap vao so nguyen c: ");
            strc = Console.ReadLine();

            if (int.TryParse(stra, out a) == false || int.TryParse(strb, out b) == false || int.TryParse(strc, out c) == false)
            {
                Console.WriteLine("gia tri nhap vao khong hop le!");
                return;
            }
            else
            {
                a = int.Parse(stra);
                b = int.Parse(strb);
                c = int.Parse(strc);
                Console.WriteLine("phuong trinh bac 2 co dang: {0}x*x +{1}x + {2} = 0", a, b, c);
                Console.WriteLine("Ket qua: ");
                if (a == 0) {
                    if (b == 0) { 
                        if(c == 0) 
                        { 
                            Console.WriteLine("phuong trinh co vo so nghiem"); 
                        } else 
                        { 
                            Console.WriteLine("phuong trinh vo nghiem"); 
                        }
                    }else
                    {
                        x = (float)-c / b;
                        Console.WriteLine("phuong trinh co 1 nghiem phan biet:" + x);
                    }
                    return;
                }
                else
                {
                    delta = b * b - 4 * a * c;
                    if(delta < 0)
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }else if (delta == 0)
                    {
                        x = (float)-b / 2 * a;
                        Console.WriteLine("phuong trinh co nghiem kep x1 = x2 = {0}", x);
                    }else
                    {
                        x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                        x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                        Console.WriteLine("phuong trinh co 2 nghiem phan biet: \nx1 = {0}, x2 = {1}", x1,x2);
                    }
                }
            }


#endif
#if false   // bài tập

            //1.Viết chương trình nhập vào một số tương ứng là năm.Xuất ra màn hình năm vừa nhập và tuổi của một người tương ứng với năm vừa nhập đó.

            //2.Từ câu 1.Thêm chức năng:
            //-Nếu tuổi người đó < 16 thì hiện thông báo theo format: Bạn<Tuổi>, tuổi vị thành niên.
            //-Nếu tuổi người đó >= 16 và < 18 thì hiện thông báo theo format: Bạn<Tuổi>, tuổi trưởng thành.
            //Nếu tuổi người đó >= 18 thì hiện thông báo theo format: Bạn<Tuổi>, già rồi.

            //3.Viết trò chơi Kéo Búa Bao với cách chơi: Người dùng sẽ nhập vào các số 1 hoặc 2 hoặc 3 tương ứng với kéo hoặc búa hoặc bao.
            //Máy sẽ ngẫu nhiên sinh ra một số trong 3 số và tính toán máy hoặc người chiến thắng.Nhớ phải in kết quả ra màn hình.
            Console.WriteLine("Welcome Kéo Búa Bao");
            Console.WriteLine("Kéo là 1");
            Console.WriteLine("Búa là 2");
            Console.WriteLine("Bao là 3");
            Console.Write("Enter option: ");
            String input = Console.ReadLine();
            int option;

            if (int.TryParse(input, out option) && (option == 1 || option == 2 || option == 3))
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 4);
                if (randomNumber == 1)
                {
                    Console.WriteLine("Kéo");
                }
                else if (randomNumber == 2)
                {
                    Console.WriteLine("Búa");
                }
                else if (randomNumber == 3)
                {
                    Console.WriteLine("Bao");
                }
                // xử lý logic thắng thua
                if (option == randomNumber)
                {
                    Console.WriteLine("hoà");
                }
                else if (
                            //bao va bua
                            (option == 1 && randomNumber == 3) ||
                            //bua va keo
                            (option == 2 && randomNumber == 1) ||
                            //keo va bao
                            (option == 3 && randomNumber == 2)
                          )
                {
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
            }
            else
            {
                Console.WriteLine("input error,Enter number");            
            }
            Console.ReadKey();
#endif
        }
    }
}