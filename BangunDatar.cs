using System;

namespace QUIZ09092019_2_
{

    class BangunDatar
    {
        public void Luas_persegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("---------------------------");

            int s;
            Console.WriteLine("Masukkan Sisi");
            s=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai luas Adalah: " + s*s);
        }
        public void Luas_segitiga(){
            Console.WriteLine("Menghitung Nilai Luas Segitiga");
            Console.WriteLine("-------------------------");

            int alas, tinggi;

            Console.WriteLine("Masukkan Tinggi");
            tinggi=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Alas");
            alas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Luas segitiga adalah  "+ alas*tinggi/2);
        }
        public void luas_lingkaran(){

            Console.WriteLine("Menghitung Luas LIngkaran");
            Console.WriteLine("-------------------------");

            int r;

            Console.WriteLine("Masukkan jari-jari");
            r=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai Luas Segitiga Adalah "+ r*r*3.14);
        }
    }
}