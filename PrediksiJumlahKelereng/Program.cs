using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrediksiJumlahKelereng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan jumlah kelereg kuning : ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan jumlah kelereng biru : ");
            double y = Convert.ToInt32(Console.ReadLine());

            double z = x + y;
            Console.WriteLine("cek z {0}", z);
            for(int i=0; i < z; i++)
            {
                Console.Write("masukkan warna yang keluar (K/B): ");
                string keluar = Console.ReadLine().ToLower();
                
                if (keluar.Equals("k"))
                {
                    x -= 1;
                }
                else
                {
                    y -= 1;                   
                }
                double outputK = x / z * 100;
                double outputB = y / z * 100;
                Console.WriteLine("Prediksi jumlah kelereng kuning : {0}", outputK);
                Console.WriteLine("Prediksi jumlah kelereng biru : {0}", outputB);
            }
            Console.ReadKey();
        }
    }
}
