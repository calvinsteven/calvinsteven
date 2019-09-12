using System;

namespace QUIZ09092019
{
    class QUIZ09092019
    {
      public static void Main(string[] args)
        {

BangunDatar obj = new BangunDatar();

    Console.WriteLine("Menghitung Luas Persegi");
    Console.WriteLine("===========================");

        int s;
    Console.Write("Masukkan nilai sisi : ");
    s = Convert.ToInt32(Console.ReadLine());

    obj.luas_persegi(s);

    int a1, a2;

        Console.WriteLine("===========================");
        Console.WriteLine("Menghitung luas segitiga");
        Console.WriteLine("===========================");
    
   Console.Write("Masukkan alas : ");
   a1 = Convert.ToInt32(Console.ReadLine());

   Console.Write("Masukkan tinggi : ");
   a2 = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("luas segitiga adalah "+obj.luas_segitiga(a1,a2));

     Console.WriteLine("===========================");
        Console.WriteLine("menghitung luas lingkaran ");
        Console.WriteLine("===========================");

           int r;
    Console.Write("masukkan panjang jari-jari : ");
    r = Convert.ToInt32(Console.ReadLine());

    obj.luas_lingkaran(r);

    BangunRuang objt = new BangunRuang();
    

    Console.WriteLine("===========================");
    Console.WriteLine("Menghitung Volume Kubus");
    Console.WriteLine("===========================");

    int S;

    Console.Write("Masukkan nilai sisi : ");
    S = Convert.ToInt32(Console.ReadLine());

    objt.volume_kubus(S);


    int b1, b2, b3;

        Console.WriteLine("===========================");
        Console.WriteLine("Menghitung volume balok");
        Console.WriteLine("===========================");
    
   Console.Write("Masukkan panjang : ");
   b1 = Convert.ToInt32(Console.ReadLine());

   Console.Write("Masukkan tinggi : ");
   b2 = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Masukkan lebar adalah : ");
   b3 = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Volume Balok adalah " +objt.volume_balok(b1, b2, b3));

        }
    }
}

