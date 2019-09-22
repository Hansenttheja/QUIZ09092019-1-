using System;

namespace QUIZ09092019_2_{
    class BangunRuang{
        public void volume_balok(){
             Console.WriteLine("Menghitung Volume Balok");
             Console.WriteLine("-------------------");

             int p,l,t;

             Console.WriteLine("Masukkan Panjang ");
             p=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Masukkan Lebar ");
             l=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Masukkan Tinggi");
             t=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Nilai Volume Adalah " + p*l*t);
        }
        public void Volume_kubus(){
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("_________________________");

            int s;

            Console.WriteLine("Masukkan Sisi");
            s=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Volume Kubus adalah " + s*s*s);
        }
    }
}