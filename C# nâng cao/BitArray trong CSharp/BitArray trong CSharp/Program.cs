//=======================================================================================================\\

//BitArray là một Collections giúp quản lý, lưu trữ một danh sách các bit (0 hoặc 1), được biểu diễn như kiểu Boolean (kiểu luận lý). 
//Trong đó true biểu thị cho bit 1 và false biểu thị cho bit 0.
//Nó được sử dụng khi ta cần lưu trữ danh sách các bit mà chưa biết trước số lượng. Ta có thể truy cập đến các phần tử trong BitArray thông qua chỉ số như ArrayList.
//Sẽ có bạn thắc mắc sao không dùng mảng các đối tượng kiểu bool mà lại dùng BitArray?
//Thì câu trả lời là BitArray giúp tiết kiệm bộ nhớ hơn rất nhiều:
//Mặc dù kiểu bool chỉ lưu 2 giá trị true hoặc false nhưng lại tốn đến 1 bytes cho mỗi biến kiểu bool.
//Trong khi đó mỗi phần tử trong BitArray tốn đúng 1 bit để lưu trữ.
//Trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new.
//Lưu ý: là ta không thể khởi tạo 1 BitArray rỗng!

//Một số thuộc tính và phương thức hỗ trợ sẵn trong BitArray
//Một số thuộc tính thông dụng trong BitArray:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong BitArray.

//Length:Trả về 1 số nguyên là số phần tử hiện có trong BitArray. 
//Đồng thời có thể thay đổi kích thước của BitArray bằng cách gán giá trị mới cho thuộc tính này.

//Một số phương thức thông dụng trong BitArray:
//And(BitArrayValue):Thực hiện phép toán AND bit giữa dãy bit hiện tại với dãy bit Value
//và trả về 1 BitArray là kết quả của phép toán trên.

//Clone(): Tạo 1 bản sao từ BitArray hiện tại.

//CopyTo(Array array, int Index): Thực hiện sao chép tất cả phần tử trong BitArray sang
//mảng một chiều array từ vị trí Index của array.

//Get(int Index): Trả về giá trị của bit tại vị trí Index trong BitArray.

//Not(): Trả về 1 BitArray là kết quả của phép toán NOT trên dãy bit hiện tại.

//Or(BitArray Value): Trả về 1 BitArray là kết quả của phép toán OR giữa dãy bit hiện tại với dãy bit Value.

//Set(int Index, bool Value): Gán giá trị cho bit tại vị trí Index với giá trị mới là Value.

//SetAll(bool Value): Gán giá trị cho toàn bộ các bit trong BitArray với giá trị mới là Value.

//Xor(BitArray Value): Trả về 1 BitArray là kết quả của phép toán XOR giữa dãy bit hiện tại với dãy bit Value.

//Lưu ý:
//Các phép toán AND, OR, NOT, XOR đã được trình bày trong bài TOÁN TỬ TRONG C# các bạn có thể xem lại.
//Các phép toán AND, OR, NOT, XOR phải được thực hiện trên 2 BitArray có cùng độ dài nếu không sẽ báo lỗi.
//Các phép toán AND, OR, NOT, XOR sẽ làm thay đổi cả BitArray gọi nó.

//=======================================================================================================\\
using System.Collections;
namespace BitArray_trong_CSharp
{
    internal class Program
    {
        //tạo 1 hàm in true false thành 1 và 0.
        static void PrintBits(BitArray MyBa, int Width)
        {
            int i = Width;
            foreach (bool item in MyBa) 
            {
                if (i < 1)
                {
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode()); // in ra 0 và 1 thay vì true false.
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
#if false
            //Khởi tạo 10 phần tử, mỗi phần tử có giá trị mặc định là 0(false).
            BitArray mybit = new BitArray(10);

            //Nếu bạn không muốn giá trị mặc định là false thì bạn có thể chỉ định giá trị mặc định thông qua constructor:
            //Khởi tạo 10 phần tử, mỗi phần tử có giá trị mặc định là 1(true).
            BitArray mybit1 = new BitArray(10, true);

            //Khởi tạo 1 BitArray từ một mảng bool có sẵn.
            bool[] BoolArray = new bool[5] { true, false, true, false, true };
            BitArray MyBit = new BitArray(BoolArray);
            //foreach (bool i in MyBit)
            //{
            //    Console.WriteLine(i);
            //}

            //Khởi tạo 1 BitArray từ một mảng byte có sẵn.
            byte[] ByteArray = new byte[5] { 1, 2,3 ,4 ,5 };
            BitArray MyBit1 = new BitArray(ByteArray);
            PrintBits(MyBit1, 8);
            //Đối với trường hợp này ta có thể cách lưu trữ của nó như sau:
            //Đầu tiên ta đã biết 1 byte = 8 bits.
            //Khi đó trình biên dịch sẽ chuyển các số kiểu byte sang dạng 8 bits và lưu lần lượt vào BitArray. 
            //Như vậy trường hợp trên sẽ có 5 số kiểu byte tương đương với 40 bits sẽ được lưu vào BitArray.         

            //VD AND, OR, NOT, XOR
            BitArray A = new BitArray(5);
            BitArray B = new BitArray(5, true);
            A.And(B);
#endif

            //Một ví dụ đơn giản về sử dụng BitArray
            // Khởi tạo 1 BitArray từ mảng bool có sẵn
            bool[] MyBool2 = new bool[5] { true, false, true, true, false };
            BitArray MyBA6 = new BitArray(MyBool2);

            // Khởi tạo 1 BitArray có 2 phần tử và có giá trị mặc định là 1 (true)
            bool[] MyBool3 = new bool[] { false, true, true, false, false };
            BitArray MyBA7 = new BitArray(MyBool3);

            Console.Write("Gia tri cua MyBA6: ");
            PrintBits(MyBA6, 5);
            Console.Write("Gia tri cua MyBA7: ");
            PrintBits(MyBA7, 5);

            // thực hiện sao chép giá trị của MyBA6 ra để không làm thay đổi nó
            BitArray AndBit = MyBA6.Clone() as BitArray;
            AndBit.And(MyBA7);
            Console.Write(" Ket qua cua phep toan AND: ");
            PrintBits(AndBit, 5);

            BitArray OrBit = MyBA6.Clone() as BitArray;
            OrBit.Or(MyBA7);
            Console.Write(" Ket qua cua phep toan OR: ");
            PrintBits(OrBit, 5);

            BitArray XorBit = MyBA6.Clone() as BitArray;
            XorBit.Xor(MyBA7);
            Console.Write(" Ket qua cua phep toan XOR: ");
            PrintBits(XorBit, 5);

            BitArray NotBit = MyBA6.Clone() as BitArray;
            NotBit.Not();
            Console.Write(" Ket qua cua phep toan NOT tren MyBA6: ");
            PrintBits(NotBit, 5);

        }
    }
}