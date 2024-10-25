//=======================================================================================================================\\

//Tương tự như List, Dictionary chính là sự thay thế cho Collections Hashtable đã được học. Cho nên về khái niệm hay sử dụng thì Dictionary đều sẽ giống Hashtable.
//Dictionary trong C# là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
//Key đại diện cho 1 khoá giống như chỉ số phần tử của mảng và Value chính là giá trị tương ứng của khoá đó.
//Ta sẽ dử dụng Key để truy cập đến Value tương ứng.

//Do Dictionary là 1 Generic Collections nên để sử dụng ta cần thêm thư viện System.Collections.Generic bằng câu lệnh:
//using System.Collections.Generic;
//Vì Dictionary là một lớp nên trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:

//Một số thuộc tính và phương thức hỗ trợ sẵn trong Dictionary
//Một số thuộc tính thông dụng trong Dictionary:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong Dictionary.

//Keys: Trả về 1 danh sách chứa các Key trong Dictionary.

//Values: Trả về 1 danh sách chứa các Value trong Dictionary.

//Một số phương thức thông dụng trong Dictionary:
//Add(TKey Key, TValue Value): Thêm 1 cặp Key - Value vào Dictionary.

//Clear(): Xoá tất cả các phần tử trong Dictionary.

//ContainsKey(TKey Key): Kiểm tra đối tượng Key có tồn tại trong Dictionary hay không.

//ContainsValue(TValue Value): Kiểm tra đối tượng Value có tồn tại trong Dictionary hay không.

//Remove(TKey Key): Xoá đối tượng có Key xuất hiện đầu tiên trong Dictionary.

//TryGetValue(TKey Key, TValue Value): Kiểm tra Key có tồn tại hay không.
//Nếu có sẽ trả về true đồng thời trả về giá trị Value tương ứng qua biến Value. Ngược lại trả về false.

//Một số lưu ý về Dictionary:
//Mỗi một phần tử trong Dictionary (bao gồm 1 cặp Key - Value) được C# định nghĩa là 1 đối tượng có kiểu:
//KeyValuePair<TKey, TValue>

//Trong đó, có 2 thuộc tính chính:
//Key: trả về giá trị Key của phần tử hiện tại.
//Value: trả về giá trị Value của phần tử hiện tại.
//Điều này tương tự như DictionaryEntry trong Hashtable. Vì thế cách sử dụng cũng tương tự. Ví dụ mình thử dùng foreach duyệt 1 Dictionary và in ra giá trị Key – Value của mỗi phần tử:

//Việc truy xuất các phần tử trong Dictionary giống như truy xuất các phần tử mảng nhưng thông qua Key.
//VD
//Console.WriteLine(Mydic[<Key>]);

//Khác biệt giữa Dictionary và HashTable trong C# @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
//HASHTABLE 
//1. Threadsafe - Hỗ trợ multi threading không đụng độ tài nguyên.
//2. Cặp Key - Value lưu kiểu object.
//3. Truy xuất phần tử không tồn tại trong Hashtable sẽ không báo lỗi suy ra return null.
//4. Hiệu quả cho dữ liệu lớn.
//5. Các phần tử được sắp xếp lại mỗi khi thêm hoặc xóa các phần tử trong Hashtable. 
//6. Tìm kiếm nhanh hơn.

//DICTIONARY
//1. Threadsafe - Không hỗ trợ.
//2. Phải xác định cụ thể kiểu dữ liệu của cặp Key - value
//3. Truy xuất phần tử không tồn tại trong Dictionary sẽ báo lỗi
//4. Không hiệu quả cho dữ liệu lớn
//5. Các phần tử nằm theo thứ tự được thêm vào.
//6. Tìm kiếm chậm hơn.

//=======================================================================================================================\\
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Dictionary_trong_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khởi tạo 1 Dictionary rỗng với Key và Value đều có kiểu dữ liệu là chuỗi.
            Dictionary<string, string> MyHash = new Dictionary<string, string>();

            //Bạn cũng có chỉ định sức chứa(Capacity) ngay lúc khởi tạo bằng cách thông qua constructor được hỗ trợ sẵn:
            //khởi tạo 1 Dictionary với Key và Value có kiểu chuỗi 
            //đồng thời chỉ định Capacity ban đầu là 5
            Dictionary<string, string> MyDic2 = new Dictionary<string, string>(5);

            //Ngoài ra bạn cũng có thể khởi tạo 1 Dictionary chứa các phần tử được sao chép từ một Dictionary khác:
            //Khởi tạo 1 Dictionary có kích thước bằng với MyDic2.
            //Sao chép toàn độ phần tử trong MyDic2 vào MyDic3.
            Dictionary<string, string> MyDic3 = new Dictionary<string, string>(MyDic2);


            // Tạo 1 Dictionary đơn giản và thêm vào 3 phần tử.
            Dictionary<string, string> Mydic = new Dictionary<string, string>();
            Mydic.Add("T", "Tran");
            Mydic.Add("N", "Ngoc");
            Mydic.Add("H", "Hung");
            //Duyệt qua các phần tử trong Dictionary.
            //Vì mỗi phần tử là 1 KeyValuePair nên ta chỉ định kiểu dữ liệu cho item là KeyValuePair luôn.
            //Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
            foreach (KeyValuePair<string, string> item in Mydic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //Việc truy xuất các phần tử trong Dictionary giống như truy xuất các phần tử mảng nhưng thông qua Key.
            //VD
            Console.WriteLine(Mydic["T"]);
        }
    }
}