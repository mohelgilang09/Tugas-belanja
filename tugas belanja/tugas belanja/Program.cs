using System;

namespace TugasBelanja
{
    class Home
    {
        static void Main(string[] args)
        {

            double buku1 = 100;
            int buku2 = 200;
            int buku3 = 300;
            int bulpen = 2;
            int hargabulpen = 500;
            double diskon = 0;
            int ketentuanDiskon = 700;
            int ketentuanDiskon2 = 1000;
            int ketentuanDiskon3 = 1500;
            double totalBeli = buku2 + buku3 + (bulpen * hargabulpen);
            double totalBarangDiskon = 4;
            double totalDiskon = diskon * totalBarangDiskon;

            if (totalBeli + buku1  > ketentuanDiskon3)
            {
                diskon = 70.0/100.0 ;
                totalBeli = totalBeli * diskon + buku1;
                
            }

            else if (totalBeli + buku1  > ketentuanDiskon2)
            {
                diskon = 80.0/100.0;
                totalBeli = totalBeli * diskon + buku1;
            }
            else if (totalBeli + buku1 > ketentuanDiskon)
            {
                diskon = 90.0/100.0;
                totalBeli = totalBeli * diskon + buku1;
            }
            else if (totalBeli < ketentuanDiskon)
            {
                diskon = 0;
            }


            Console.WriteLine("Total belanja anda adalah : "+totalBeli);
        }
    }
}




