namespace vd1
{
    internal class Program
    {
        //Tính số lần swap tối thiểu 1 mảng gồm 8 số ngẫu nhiên của 2 số 0 và 1 sao cho mảng output ta nhận được có toàn bộ các số 1 nằm bên trái
        //vd: 
        //input: 1 0 0 0 1 0 1 0
        //mảng sau khi swap: 1 1 1 0 0 0 0 0.
        //output số lần swap tối thiểu: 2

        static void swap(ref int a, ref int b) {
        int x = a;
            a = b;
            b = x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("||=======================================||");
            Console.WriteLine("||            bai tap swap               ||");
            Console.WriteLine("||=======================================||");
            int[] array = new int[8];
            Console.WriteLine("nhap 8 phan tu ngau nhien cua 2 so 0 va 1 vao mang:");
            for(int i = 0; i < 8; i++)
            {
                Console.Write("Array[" + i + "]: ");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] != 1 && array[i] != 0)
                {
                    Console.WriteLine("gia tri nhap vao khong hop le");
                    break;
                }
            }
            int h = 0, t = 0;
            for (int i = 0; i < 8; i++)
            {
                if (array[i] == 1)               
                    h++;                
            }
            int index = h;
            for (int i = 0;i < h; i++) 
            {
                if (array[i] == 0)
                {
                    t++;
                    while (array[index] == 0)
                    {
                        index++;
                    }
                    swap(ref array[i], ref array[index]);
                }
            }
            Console.WriteLine("mang sau khi swap la:");
            for (int i = 0; i < 8; i++) {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine("so lan swap toi thieu la: " + t);
            Console.ReadKey();
        }
    }
}