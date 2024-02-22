using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH55031_LaiGiaKiet
{
    internal class Service
    {
        List<LapTop> list = new List<LapTop>();
        public Service()
        {
            list = new List<LapTop>();
        }
        public void NhapDS()
        {
            // tạo ra 1 đối tượng để nhập mỗi lần lặp
            Console.WriteLine("Bạn muốn nhập bao nhiêu");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                LapTop lap = new LapTop();
                Console.WriteLine("Mời nhập id: ");
                lap.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập mã laptop: ");
                lap.MaLaptop = Console.ReadLine();
                Console.WriteLine("Mời nhập kích thước màn hình: ");
                lap.KichThuocMH = Convert.ToDouble(Console.ReadLine());
                list.Add(lap); // thêm ds vào list
            }
            Console.WriteLine("Bạn có muốn nhập tiếp hay không? y/n");
            string choose = Console.ReadLine();
            if (choose == "y" || choose == "Y")
            {
                NhapDS(); // gọi lại hàm để nhập tiếp
            }
        }
        public void XuatDS()
        {
            if (list.Count == 0)  // Kiểm tra xem list có đnag rỗng hay không, count là số phần tử
            {
                Console.WriteLine("Danh sach dang trong, hay nhap da");
                NhapDS();
                XuatDS();
            }
            else
            {
                Console.WriteLine("Danh sach la:");
                foreach (var item in list) // Với mỗi phần tử của List
                {
                    item.InThongTin();
                }
            }

        }

        public void Xoa()
        {
            Console.WriteLine("Nhập mã laptop cần xóa: ");
            int ma = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ma; i++)
            {
                if (list[i].Id == ma)
                {
                    list.RemoveAt(i); // xóa
                    i--; // cập nhật vị trí check vì đã xóa
                }
            }
        }
        public void XuatKtTheoMang()
        {
            Console.WriteLine("Nhập số đầu: ");
            int so1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số hai: ");
            int so2 = Convert.ToInt32(Console.ReadLine());
            if (so1 < )
        }
    }
}
