//=======================================================================================================\\

//SortedList là gì?
//SortedList cũng là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value. Key đại diện cho 1 khoá giống như chỉ số phần tử của mảng và Value chính là giá trị tương ứng của khoá đó.

//Đặc điểm của SortedList
//Là 1 Hashtable nhưng các giá trị được sắp xếp theo Key. Việc sắp xếp này được thực hiện một cách tự động mỗi khi thêm 1 phần tử mới vào SortedList.
//Có thể truy xuất đến các phần tử trong SortedListthông qua Key(như Hashtable) hoặc thông qua chỉ số phần tử (như ArrayList).
//SortedList chính là sự kết hợp giữa ArrayList với Hashtable .
//Do SortedList cũng là 1 Collections nên để sử dụng ta cần thêm thư viện System.Collections bằng câu lệnh:
//using System.Collections;
//Trước khi sử dụng ta cần khởi tạo vùng nhớ bằng toán tử new:
//Bạn cũng có thể khởi tạo 1 SortedList chứa các phần tử được sao chép từ một SortedList khác:

//Vì các phần tử của SortedList được sắp xếp tự động theo Key nên ta cũng có thể chỉ ra cách sắp xếp do mình tự định nghĩa 
//(trong bài ARRAYLIST TRONG C# mình đã có trình bày về việc định nghĩa lại cách sắp xếp) thông qua constructor có sẵn:

//Vì SortedList là sự kết hợp giữa ArrayList và Hashtable nên nó sẽ mang các thuộc tính, phương thức giống 2 Collections trên và một vài phương thức mới. 
//Ở đây Kteam xin giới thiệu lại để những bạn nào chưa theo dõi những bài trước cũng có thể nắm.

//Một số thuộc tính thông dụng trong SortedList:
//Count: Trả về 1 số nguyên là số phần tử hiện có trong SortedList.

//Capacity: Trả về 1 số nguyên cho biết số phần tử mà SortedList có thể chứa (sức chứa).
//Nếu số phần tử được thêm vào chạm sức chứa này thì hệ thống sẽ tự động tăng lên.
//Ngoài ra ta có thể gán 1 sức chứa bất kỳ cho SortedList.

//Keys: Trả về 1 danh sách chứa các Key trong SortedList.

//Values: Trả về 1 danh sách chứa các Value trong SortedList.

//Một số phương thức thông dụng trong SortedList:
//Add(object Key, object Value): Thêm 1 cặp Key - Value vào SortedList.

//Clear(): Xoá tất cả các phần tử trong SortedList.

//Clone(): Tạo 1 bản sao từ SortedList hiện tại.

//ContainsKey(object Key): Kiểm tra đối tượng Key có tồn tại trong SortedList hay không.

//ContainsValue(object Value): Kiểm tra đối tượng Value có tồn tại trong SortedList hay không.

//CopyTo(Array array, int Index): Thực hiện sao chép tất cả phần tử trong SortedList sang mảng một chiều array từ vị trí Index của array.
//Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.

//GetByIndex(int Index): Trả về giá trị Value tại vị trí Index trong SortedList.

//GetKey(int Index): Trả về giá trị Key tại vị trí Index trong SortedList.

//GetKeyList(): Trả về 1 List các Key trong SortedList. (xem thêm LIST TRONG C#)

//GetValueList(): Trả về 1 List các Value trong SortedList.

//IndexOfKey(object Key): Trả về 1 số nguyên là chỉ số phần tử của 1 Key trong SortedList.

//Remove(object Key): Xoá đối tượng có Key xuất hiện đầu tiên trong SortedList.

//RemoveAt(int Index): Xoá đối tượng tại vị trí Index trong SortedList.

//SetByIndex(int Index, object Value): Gán giá trị Value mới tại vị trí Index trong SortedList.

//Về cách sử dụng thì bạn thao tác hoàn toàn giống với Hashtable.
//=======================================================================================================\\
using System;
using System.Collections;
namespace sortedlist_trong_c_
{
    class Program
    {

        static void Main()
        {
#if true
            // khởi tạo 1 SortedList rỗng
            SortedList MySL = new SortedList();

            // khởi tạo 1 SortedList và chỉ định Capacity ban đầu là 5
            SortedList MySL2 = new SortedList(5);

            //Khởi tạo 1 SortedList có kích thước bằng với MySL2.
            //Sao chép toàn độ phần tử trong MySL2 vào MySL3.
            SortedList MySL3 = new SortedList(MySL2);

            //Mình định nghĩa 1 lớp PersonComparer có thực thi 1 interface IComparer
            //Sau đó override lại phương thức Compare.
            //Sử dụng lớp trên để truyển vào constructor của SortedList.
            SortedList MySL4 = new SortedList(new PersonComparer());

            //Tạo 1 SortedList mới và sao chép các phần tử từ MySL3 đồng thời sắp xếp các phần tử lại
            //theo cách sắp xếp được định nghĩa trong lớp PersonComparer.
            SortedList MySL5 = new SortedList(MySL3, new PersonComparer());
#endif
            SortedList MySL6 = new SortedList(new PersonComparer());
            MySL6.Add(new Person("Hung", 20), 10);
            MySL6.Add(new Person("Tran Ngoc", 30), 17);

            foreach (DictionaryEntry item in MySL6) 
            {
                Console.WriteLine("key: " + item.Key + "\tvalue: " + item.Value);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Định nghĩa 1 lớp thực thi interface IComparer.
        /// override phương thức Comparer và định nghĩa cách sắp xếp trong đó.
        /// Chi tiết bạn có thể xem lại bài ArrayList trong C#.
        /// </summary>
        class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Person a = x as Person;
                Person b = y as Person;

                if (a == null || b == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (a.Age > b.Age)
                    {
                        return 1;
                    }
                    else if (a.Age == b.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }            
        }
    }
}