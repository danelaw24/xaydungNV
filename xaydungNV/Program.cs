using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xaydungNV
{
    public class NhanVien

    {

        protected string HoTen, diachi;

        protected int namsinh;

        public NhanVien()

        {

            HoTen = ""; namsinh = 0; diachi = "";

        }

        public NhanVien(string HoTen, int namsinh, string diachi)

        {

            this.HoTen = HoTen; this.namsinh = namsinh; this.diachi = diachi;

        }

        public void Nhap()

        {

            Console.Write("Nhap Ho va ten :"); HoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: "); namsinh = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap dia chi: "); diachi = Console.ReadLine();

        }

        public void Xuat()

        {

            Console.WriteLine("Ho va ten: {0}", HoTen);

            Console.WriteLine("nam sinh: {0}", namsinh);

            Console.WriteLine("dia chi: {0}", diachi);

        }

    }

    public class BienChe : NhanVien

    {

        double heso, LuongCoBan;

        public BienChe() : base()

        {

            heso = 0; LuongCoBan = 0;

        }

        public BienChe(string HoTen, int namsinh, string diachi, double heso, double LuongCoBan) : base(HoTen, namsinh, diachi)

        {

            this.heso = heso; this.LuongCoBan = LuongCoBan;

        }

        public new void Nhap()

        {

            base.Nhap();

            Console.Write("Nhap he so: "); heso = Double.Parse(Console.ReadLine());

            Console.Write("Nhap Luong co ban: "); LuongCoBan = Double.Parse(Console.ReadLine());

        }

        public new void Xuat()

        {

            double Luong;

            Luong = (heso * LuongCoBan);



            Console.WriteLine("Luong cua nhan vien {0} la : {1}", HoTen, Luong);

        }

        public double tong()

        {

            double s;

            s = (LuongCoBan * heso);

            return (s);

        }

    }

    

    class Program

    {

        static void Main(string[] args)

        {

            int n, p;

            Console.Write("Nhap vao so nhan vien: "); n = Int32.Parse(Console.ReadLine());
         
            BienChe[] bc = new BienChe[n];

            {

                Console.WriteLine("Moi nhap du lieu cho nhan vien Bien Che");

                for (int i = 0; i < n; i++)

                {

                    bc[i] = new BienChe();

                    bc[i].Nhap();

                }

            }

            {

                Console.WriteLine();

            }

            Console.Clear();

            double m;

            m = 0;

            for (int i = 0; i < n; i++) bc[i].Xuat();

            for (int i = 0; i < n; i++) m = m + bc[i].tong();


            Console.WriteLine();

            Console.WriteLine("Tong luong cua nhan vien  {0}", m);

            Console.ReadKey();

        }

    }

}
