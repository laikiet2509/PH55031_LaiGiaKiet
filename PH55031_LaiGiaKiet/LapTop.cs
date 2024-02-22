using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   
        internal class LapTop
        {
            int id;
            string maLaptop;
            double kichThuocMH;
            public LapTop()
            {

            }

            public LapTop(int id, string maLaptop, double kichThuocMH)
            {
                this.Id = id;
                this.MaLaptop = maLaptop;
                this.KichThuocMH = kichThuocMH;
            }

            public int Id { get => id; set => id = value; }
            public string MaLaptop { get => maLaptop; set => maLaptop = value; }
            public double KichThuocMH { get => kichThuocMH; set => kichThuocMH = value; }
            public void InThongTin()
            {
                Console.WriteLine($"| Id: {id} | Mã LapTop: {maLaptop} | Kích Thước MH: {kichThuocMH} |");
            }
        }
    
}
