//===============================================================================================\\

//Hashtable trong C#:
//Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
//Key đại diện cho 1 khoá giống như chỉ số phần tử của mảng và Value chính là giá trị tương ứng của khoá đó.
//Ta sẽ dử dụng Key để truy cập đến Value tương ứng.
//Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu từ những kiểu cơ sở đến kiểu phức tạp (class).

//Nếu các Key của Hashtable là các số nguyên tăng dần từ 0 thì Hashtable nhìn trông giống ArrayList (chỉ là giống về bề ngoài thôi chứ bên trong rất khác nhau).

//Do Hashtable là 1 Collections nên để sử dụng ta cần thêm thư viện System.Collections bằng câu lệnh:
//using System.Collections;
//Vì Hashtable là một lớp nên trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:

//Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
//TÊN THUỘC TÍNH VÀ Ý NGHĨA:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.

//Keys: Trả về 1 danh sách chứa các Key trong Hashtable.

//Values: Trả về 1 danh sách chứa các Value trong Hashtable.

//TÊN PHƯƠNG THỨC VÀ Ý NGHĨA:
//Add(object Key, object Value): Thêm 1 cặp Key - Value vào Hashtable.

//Clear(): Xoá tất cả các phần tử trong Hashtable.

//Clone(): Tạo 1 bản sao từ Hashtable hiện tại.

//ContainsKey(object Key): Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.

//ContainsValue(object Value): Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.

//CopyTo(Array array, int Index): Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array.
//Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.

//Remove(object Key): Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.

//Một số lưu ý về Hashtable:
//Mỗi một phần tử trong Hashtable (bao gồm 1 cặp Key - Value) được C# định nghĩa là 1 đối tượng có kiểu DictionaryEntry.
//Trong DictionaryEntry có 2 thuộc tính chính:
//Key: trả về giá trị Key của phần tử hiện tại.
//Value: trả về giá trị Value của phần tử hiện tại.
//giá trị sẽ nằm xáo trộn khi in hashtable.

//Việc truy xuất các phần tử trong Hashtable giống như truy xuất các phần tử mảng nhưng thông qua Key.
//Ví dụ:
//Console.WriteLine(MyHash["One"]);
//Trong đó:
//MyHash là tên của Hashtable.
//One là tên Key cần truy xuất.
//MyHash["One"] sẽ lấy ra giá trị Value tương ứng với Key trên.

//Ta nên cẩn thận khi truy xuất các phần tử trong Hashtable thông qua Key:
//Nếu ta thực hiện lấy giá trị 1 phần tử trong Hashtable với Key không tồn tại thì sẽ ra giá trị null và không báo lỗi.
//Nếu ta thực hiện gán giá trị cho 1 phần tử trong Hashtable tại vị trí Key không tồn tại thì Hashtable sẽ tự thêm 1 phần tử mới với Key và Value như trên ở vị trí bất kì. 
//Điều này có thể làm phát sinh thêm các phần tử không mong muốn trong danh sách.

//===============================================================================================\\

using System.Collections;

namespace HashTable_trong_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if false   //VD khởi tạo Hashtable
            //Vì Hashtable là một lớp nên trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:
            //khởi tạo 1 hashtable rỗng
            Hashtable ht = new Hashtable();

            //khởi tạo 1 hashtable và chỉ định capacity ban đàu là 5
            Hashtable ht2 = new Hashtable(5);

            //khởi tạo 1 hashtable bằng kích thước ht2 và sao chép toàn bộ dữ liệu của ht2
            Hashtable ht3 = new Hashtable(ht2);
#endif
            //Ví dụ: mình thử dùng foreach duyệt 1 Hashtable và in ra giá trị Key – Value của mỗi phần tử:
            // Tạo một Hashtable đơn giản với 3 phần tử:
            Hashtable hash = new Hashtable();
            hash.Add("H", "Hung");
            hash.Add("T", "Tran");
            hash.Add("N", "Ngoc");

            //VD in giá trị hash ra màng hình
            Console.WriteLine(hash["H"]); // int ra gia tri "Hung"

            //Duyệt qua các phần tử trong Hashtable.
            //Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
            //Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value );
            }       

            // In ra màn hình giá trị Value trong 1 Key không tồn tại.
            // Vẫn chạy được nhưng giá trị sẽ là null.
            Console.WriteLine(hash["KT"]);

            // Để chắc chắn là null ta thử kiểm tra bằng điều kiện if.
            if (hash["KT"] == null)
            {
                Console.WriteLine("Key 'KT' is not exists");
            }

            // Thử in ra số phần tử ban đầu của Hashtable
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            // thực hiện gán giá trị cho 1 Key không tồn tại.
            hash["Kt"] = "Kter";
            hash["TNH"] = "Tran Ngoc Hung";

            // thực hiện in lại số phần tử của Hashtable để thấy sự thay đổi.
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.ReadKey();
        }
    }
}