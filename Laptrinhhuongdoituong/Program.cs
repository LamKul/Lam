using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Laptrinhhuongdoituong
{
    class Program
    {
        static void Main(string[] args)
        {

            Sinhvien[] sv = new Sinhvien[10000];
            for (int i = 2000; i < 2100; i++)
            {
                sv[i] = new Sinhvien();
                sv[i].laygiatri(i);
                sv[i].tinhtoan();
                for (int j = 0; j < 4; j++)
                    if (sv[i].Ketqua[j] > 0)
                    {
                        int k = j + 1;
                        string sql = "INSERT INTO nvxt VALUES('" + sv[i].SBd + "','" + k + "','" + sv[i].Nguyenvong[j, 0] + "','" + sv[i].Ketqua[j] + "')";
                        sv[i].Getdata(sql);
                        Console.Write("{0} {1} {2} {3}", sv[i].SBd, k, sv[i].Nguyenvong[j, 0], sv[i].Ketqua[j]);
                        Console.WriteLine();
                    }
            }
            Console.WriteLine("Processed");
            Console.ReadKey();
        }
    }
}
