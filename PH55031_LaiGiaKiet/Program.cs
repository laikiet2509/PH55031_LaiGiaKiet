using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55031_LaiGiaKiet
{
    internal class Program
    {
        public static string Menu()
        {
            Console.WriteLine("1.Nhập Ds");
            Console.WriteLine("2.Xuất Ds");
            Console.WriteLine("3.Xóa theo mã");
            Console.WriteLine("4.Xuất theo mảng");
            Console.WriteLine("5.Thoát...");
            Console.WriteLine("Nhập lựa chọn của bạn: ");
            string choose = Console.ReadLine();
            return choose;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Service sv = new Service(); // tạo ra để gọi các phương thức đã làm
                switch (Menu())
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        sv.XuatDS();
                        break;
                    case "3":
                        sv.Xoa();
                        break;
                    case "4":
                        sv.XuatKtTheoMang();
                        break;
                    case "5":
                        Environment.Exit(5);
                        break;

                    default:
                        Console.WriteLine("Nhập từ 1 đến 5 thôiiiiii");
                        break;
                }
            }
        }
    }
}
