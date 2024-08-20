namespace tính_toán_2_phân_số
{
    class phanso
    {
        public int tuso;
        public int mauso;
        public phanso(int a =0, int b = 1)
        {
            this.tuso = a;
            this.mauso = b;
        }
        public phanso tong(phanso x)
        {
            phanso s;
            return s;
        }
        public void nhap()
        {
            Console.WriteLine("nhap tu so:");
            tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau so:");
            mauso = int.Parse(Console.ReadLine());
            
        }
        public void xuat()
        {
            if (tuso == 0) { Console.WriteLine(0); }
            else if (mauso == 0) Console.WriteLine("Loi");
            else
                if (tuso == mauso) Console.WriteLine(1);
            else
            {
                //this->rutgon();
                if (mauso == 1) cout << tuso << endl;
                else
                    if (tuso < 0 && mauso < 0)
                    cout << abs(tuso) << "/" << abs(mauso) << endl;
                else
                        if (tuso > 0 && mauso < 0)
                    cout << -1 * tuso << "/" << abs(mauso) << endl;
                else
                    cout << tuso << "/" << mauso << endl;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            phanso x, y;
            phanso t, h, n, c;
            Console.WriteLine("nhap phan so x: ");
            x.nhap();
            Console.WriteLine("nhap phan so y: ");
            y.nhap();
            Console.WriteLine("phan so x la: ");
            x.xuat();
            Console.WriteLine("phan so y la: ");
            y.xuat();

        }
    }
}