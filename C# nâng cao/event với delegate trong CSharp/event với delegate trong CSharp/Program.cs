//======================================================================================================================\\

//Event là gì?
//Event là Delegate với mục đích để cho lớp khác hoặc đối tượng cha của đối tượng hiện tại ủy thác(định nghĩa) hàm vào trong đó.
//Mục đích chính của chuyện này là để thông báo lên cho đối tượng cha biết mà xử lý.

//Công thức:
//event <Kiểu delegate> <tên event>;

using event_với_delegate_trong_CSharp;
using System.Text;

//Lưu ý: Chữ event viết thường
//Mục đích là mình mong muốn mỗi khi Name của class HocSinh thay đổi mình sẽ biết và có thể code xử lý tương ứng.

//Ta tạo một class HocSinh có filed là _Name kiểu dữ liệu là string. Được đóng gói thành property Name.(Bạn để ý rằng mình cố ý tạo property 
//và filed cùng tên nhưng khác nhau là filed có dấu _ phía trước tên. Như vậy vừa dễ quản lý vừa tiện cho việc code)
//Lúc này chúng ta đã tạo một Delegate có tên là UpdateNameHandler cùng cấp với class Program và class HocSinh . 
//UpdateNameHandler có kiểu trả về là void, một tham số đầu vào là string. Ta cần tạo Delegate ở phạm vi này là vì muốn 
//có thể được dùng cả trong class HocSinh và class Program.

//Ta tạo event NameChanged thuộc class HocSinh lúc này có kiểu dữ liệu là Delegate UpdateNameHandler . 
//Lưu ý cách đặt tên event thể hiện được tính chất là Name Changed(đã thay đổi)
//Lưu ý: event phải public.



//======================================================================================================================\\
namespace event_với_delegate_trong_CSharp
{
    
    public delegate void UpdateNameHandler(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            HocSinh hs = new HocSinh();

            hs.NameChanged += Hs_NameChanged;   //uỷ thác delegate NameChanged thành Hs_NameChanged

            hs.Name = "Hung";   // khi gán giá trị thì sẽ chạy tới dòng set trong class học sinh
            Console.WriteLine("Tên trong class: " + hs.Name);
            hs.Name = "Trần Ngọc Hùng"; // khi gán giá trị thì sẽ chạy tới dòng set trong class học sinh
            Console.WriteLine("Tên trong class: " + hs.Name);
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Tên mới: " + name);
        }

        public class HocSinh
        {
            //Ví dụ khai báo event
            public event UpdateNameHandler NameChanged;

            private string _Name;            
            public string Name
            {
                get => _Name;
                set
                {
                    _Name = value;
                    if (NameChanged != null)    // kiểm tra có uỷ thác hay không
                    {
                        NameChanged(Name);
                    }
                }
            }
        }
    }
}