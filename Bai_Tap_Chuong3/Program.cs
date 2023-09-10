using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Chuong3
{
    internal class Program
    {

        class DaGiac
        {
            protected int soCanh;
            protected int[] kichThuocCanh;

            public DaGiac()
            {
                soCanh = 5;
                kichThuocCanh = new int[soCanh];
              }
            public DaGiac(int socanh, int[] kichthuoccanh)
            {
                soCanh = socanh;
                kichThuocCanh = kichthuoccanh;
            }

            public void Nhap()
            {
                Console.WriteLine("nhap so canh: ");
                soCanh = Convert.ToInt32(Console.ReadLine());

                if (soCanh > 2)
                {
                    kichThuocCanh = new int[soCanh];
                    for (int i = 0; i < soCanh; i++)
                    {
                        Console.WriteLine($"nhap kich thuoc canh thu {i + 1}: ");
                        kichThuocCanh[i] = Convert.ToInt32(Console.ReadLine());

                    }
                }
                else
                {
                    Console.Write("");
                }
               
            }

            public void Xuat()
            {
             
                if (soCanh > 2)
                {
                    Console.WriteLine($"so canh la: {soCanh}");
                    Console.WriteLine($"kich thuoc canh la: " + string.Join(", ", kichThuocCanh));
                    Console.WriteLine($"chu vi la: {chuVi()}");

                }
                else
                {
                    Console.WriteLine("khong phai da giac");
                }


            }
                    public float chuVi()
                    {
                       int tongKt = 0;
                        foreach (int kt in kichThuocCanh)
                        {
                                tongKt += kt;
                        }
                        return tongKt;


                    }

        }

        class HinhVuong:DaGiac
        {
            public HinhVuong():base()
            {

            }
            public HinhVuong(int socanh, int[] kichthuoccanh) : base( socanh,  kichthuoccanh)
            {

            }

            public void Nhap()
            {
                Console.WriteLine("nhap so canh hinh vuong: ");
                soCanh = Convert.ToInt32(Console.ReadLine());
                if (soCanh == 4)
                {
                    kichThuocCanh = new int[soCanh];
                    for (int i = 0; i < soCanh; i++)
                    {
                        Console.WriteLine($"nhap kich thuoc canh thu {i + 1}: ");
                        kichThuocCanh[i] = Convert.ToInt32(Console.ReadLine());

                    }
                }
                else
                {
                    Console.WriteLine("khong phai hinh vuong");
                }
            }

            public float Chuvi()
            {
               
                    int tongKT = 0;
                if (soCanh == 4) {
                    foreach (int kt in kichThuocCanh)
                    {
                        if (kichThuocCanh[0] == kt && kichThuocCanh[1]  == kt && kichThuocCanh[2] == kt && kichThuocCanh[3] == kt)
                        {
                            tongKT += kt;
                        }

                    };
                    return tongKT;
                }
                else
                {
                    
                    return 0;
                }

            }


            public void Xuat()
            {

                for (int i = 0; i < kichThuocCanh.Length; i++)
                {
                    if (soCanh == 4 && kichThuocCanh[i] != (kichThuocCanh[(i + 1) % 4]))
                    {

                        Console.WriteLine("khong phai hinh vuong");
                        break;
                    }
                    else
                    if (soCanh == 4 && kichThuocCanh[i] == (kichThuocCanh[(i + 1) % 4]))
                    {
                        float s = kichThuocCanh[i] * kichThuocCanh[i];
                        Console.WriteLine($"chu vi hinh vuong la: {Chuvi()}");
                        Console.WriteLine($"dien tich hinh vuong la: {s}");
                        break;
                    }

                  

                }
            }
  
        }

       
        class TamGiac: DaGiac
        {
            public TamGiac() : base()
            {

            }
            public TamGiac(int socanh, int[] kichthuoccanh): base(socanh, kichthuoccanh)
            {

            }

            public void Nhap()
            {
                Console.WriteLine("nhap so canh tam giac: ");
                soCanh = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < soCanh; i++)
                {
                Console.WriteLine($"nhap kich thuoc canh thu{i+1}: ");
                    kichThuocCanh[i] = Convert.ToInt32(Console.ReadLine());
                }
                
            }

           public void Xuat()
            {
                for(int i = 0; i < kichThuocCanh.Length; i++)
                {
                    if (soCanh == 3 && kichThuocCanh[0] >= (kichThuocCanh[1] + kichThuocCanh[2])  ||
                                       kichThuocCanh[1] >= (kichThuocCanh[0] + kichThuocCanh[2]) ||
                                       kichThuocCanh[2] >= (kichThuocCanh[1] + kichThuocCanh[0])
                                       )
                    {

                        Console.WriteLine("khong phai tam giac");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"chu vi tam giac la: {kichThuocCanh[0] + kichThuocCanh[1] + kichThuocCanh[2]}");
                        float p = ((kichThuocCanh[0] + kichThuocCanh[1] + kichThuocCanh[2]) / 2);
                        Console.WriteLine($"dien tich tam giac la:{Math.Sqrt(p * (p - kichThuocCanh[0])*(p - kichThuocCanh[1]) * (p - kichThuocCanh[2]))} ");
                        break;
                    }
                }
               

            }
        }
        static void Main(string[] args)
        {
            DaGiac dagiac = new DaGiac();
            dagiac.Nhap();
            dagiac.Xuat();

            HinhVuong hinhvuong = new HinhVuong();
            hinhvuong.Nhap();
            hinhvuong.Xuat();

            TamGiac tamgiac = new TamGiac();
            tamgiac.Nhap();
            tamgiac.Xuat();


            Console.ReadKey();

        }
    }
}
