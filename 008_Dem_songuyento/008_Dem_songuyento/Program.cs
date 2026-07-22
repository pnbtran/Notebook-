using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Dem_songuyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH DEM SO NGUYEN TO");

            Console.Write(" Nhap so nguyen duong BAT DAU: ");
            int batDau = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen duong KET THUC");
            int ketThuc = int.Parse(Console.ReadLine());

            // neu nhap nguoc --> hoan doi
            if (batDau > ketThuc)
            {
                int temp = batDau; batDau = ketThuc; ketThuc = temp;
                Console.WriteLine($" Da dao khoan: {batDau} den {ketThuc}");
            }

            int dem = 0;
            Console.WriteLine($"\n Cac so nguyen to tu {batDau} den {ketThuc}");

            for (int i = batDau; i <= ketThuc; i++)
            {
                if (SoNguyenTo(i))
                {
                    Console.Write(i + " ");
                    dem++;
                }
            }
            Console.WriteLine($"\n\n Tong cong co: {dem} la so nguyen to.");
           
        }

        //Kiem tra so nguyen to 
        static bool SoNguyenTo (int n)
        {
            if (n < 2) return false;        // 0,1 va so am khong phai la so nguyen to
            if (n == 2) return true;        // 2 la so nguyen to
            if (n % 2 == 0) return false;   // so chia het cho 2

            // Kiem tra cac so le tu 3 den can bac 2 cua n
            int can = (int)Math.Sqrt(n);

            for (int i = 3; i <= can; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;

        }
    }
}
