//=========================================================================================================\\

//ICollection là gì?
//ICollection là một interface trong bộ các interface được định nghĩa sẵn của .NET Framework.
//Về khái niệm interface cũng như cách sử dụng interface các bạn có thể xem lại bài INTERFACE TRONG C#.
//tại sao .NET lại định nghĩa sẵn nhiều interface đến như vậy?
//Đưa ra những chuẩn mực chung, mỗi interface thể hiện cho một hoặc một vài tính chất nào đó.
//Khi bạn muốn cấu trúc dữ liệu của mình có tính chất nào đó (ví dụ như bạn muốn cấu trúc dữ liệu mình là 1 dạng collection, 
//hay cấu trúc dữ liệu của mình có khả năng duyệt bằng từ khoá foreach,…) thì bạn chỉ cần thực thi đúng interface đã được cung cấp sẵn là được.
//Ngoài ra, việc định nghĩa sẵn các interface như là một cách để lập trình viên có thể tuỳ chỉnh một số chức năng bên trong .NET. 
//Nếu bạn để ý thì trong phần ví dụ của bài ARRAYLIST TRONG C# mình có thực thi 1 interface IComparer nhằm định nghĩa lại cách sắp xếp giữa các đối tượng.
//Phân tích 1 chút. Ban đầu hàm Sort trong lớp ArrayList chỉ thực hiện sắp xếp tăng dần (theo số hoặc theo bảng chữ cái) và để ý kỹ bạn sẽ thấy điều này:
//Hàm Sort có thể nhận vào 1 đối tượng có thực thi interface IComparer. Đây chính là chìa khoá để chúng ta có thể tuỳ chỉnh code.
//Để thực hiện sắp xếp cho dù là thuật toán nào thì người ta cũng cần so sánh 2 đối tượng xem đối tượng nào bé hơn thì đứng trước. 
//Và việc so sánh này được viết bên trong 1 hàm tên là Compare (ý nghĩa hàm này mình đã trình bày trong bài ARRAYLIST TRONG C# ).
//Trong hàm Sort mặc định thì hàm Compare chỉ so sánh được số hoặc chữ. Vậy nếu như ta có thể tuỳ chỉnh hàm Compare này 
//và đưa ra cách so sánh riêng của mình thì danh sách sẽ được sắp xếp theo ý của mình. 
//Và cách tuỳ chỉnh hàm Compare chính là tạo một đối tượng có thực thi interface IComaparer.
//Mình sẽ mô phỏng lại nội dung bên trong hàm Sort để các bạn hình dung được tại sao truyền vào 1
//đối tượng thực thi interface IComparer thì có thể thay đổi được cách sắp xếp:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
//public void Sort(IComparer comparer)
//{
//    /* Mình sử dụng thuật toán sắp xếp đơn giản nhất nhé. 
//    * Còn thực sự hàm Sort của .NET sử dụng thuật toán khác nha.
//    */
//    int count = array.Count;
//    for (int i = 0; i < count - 1; i++)
//    {
//        for (int j = i + 1; j < count; j++)
//        {
//            /* Nếu phần tử i bé hơn phần tử j thì thực hiện hoán đổi vị trí 2 phần tử này */
//            if (comparer.Compare(array[i], array[j]) > 0)
//            {
//                object tmp = array[i];
//                array[i] = array[j];
//                array[j] = tmp;
//            }
//        }
//    }
//}

//ICollection là 1 interface có ý nghĩa “xác định kích thước, enumerator (bộ liệt kê) và những phương thức đồng bộ cho những tập hợp 
//không phải kiểu generic” hay nói ngắn gọn đây là 1 interface thể hiện tính chất của 1 collection.
//Interface ICollection yêu cầu chúng ta thực thi những Property, phương thức sau:
//Count: trả về số lượng phần tử của tập hợp.
//IsSynchronized và SyncRoot: 2 property để làm cho thao tác đa luồng với tập hợp an toàn hơn.
//CopyTo(Array array, int index): phương thức thực hiện copy tập hợp ra 1 mảng, bắt đầu từ vị trí index trong tập hợp.
//GetEnumerator(): Trả về 1 đối tượng kiểu IEnumerator.
//Thực thi interface ICollection
//Chúng ta sẽ cùng tổ chức 1 Collection đơn giản giống ArrayList bằng cách thực thi các interface cần thiết.
//Ví dụ này sẽ được mình thực hiện xuyên suốt cho các bài sau về interface.

//=========================================================================================================\\
namespace ICollection_trong_CSharp
{
    internal class Program
    {
        public void Sort(IComparer comparer)
        {
            /* Mình sử dụng thuật toán sắp xếp đơn giản nhất nhé. 
            * Còn thực sự hàm Sort của .NET sử dụng thuật toán khác nha.
            */
            int count = array.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    /* Nếu phần tử i bé hơn phần tử j thì thực hiện hoán đổi vị trí 2 phần tử này */
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        object tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
        public class MyArrayList : ICollection
        {
            private object[] lstObj; // mảng giá trị
            private int count; // số lượng phần tử
            private const int MAXCOUNT = 100; // số lượng phần tử tối đa

            public MyArrayList()
            {
                count = -1;
                lstObj = new object[MAXCOUNT];
            }

            public MyArrayList(int count)
            {
                this.count = count;
                lstObj = new object[count];
            }

            public MyArrayList(Array array)
            {
                array.CopyTo(lstObj, 0);
                count = array.Length;
            }

            public void CopyTo(Array array, int index)
            {
                // thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng array.
                lstObj.CopyTo(array, index);
            }

            public int Count
            {
                get { return count; }
            }

            public bool IsSynchronized
            {
                get { throw new NotImplementedException(); }
            }

            public object SyncRoot
            {
                get { throw new NotImplementedException(); }
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        //Ở đây chúng ta sẽ tạo 1 lớp MyArrayList và thực thi interface ICollection. 
        //Trong lớp MyArrayList có 1 mảng các object và 1 biến lưu trữ số lượng phần tử của mảng.Sau đó thực hiện 
        //viết lại những property hoặc phương thức mà chúng ta biết bao gồm property Count, phương thức CopyTo() và một số constructor cơ bản.
        //Vì đây chưa phải là 1 collection hoàn thiện nên chúng ta không thể chạy chương trình xem thử được. Những bài tiếp theo 
        //chúng ta sẽ tiếp tục tìm hiểu về các interface có sẵn qua đó từng bước hoàn thiện MyArrayList hơn.

        static void Main(string[] args)
        {
            
        }
    }
}