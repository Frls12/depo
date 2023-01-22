using System;

namespace _200716080_Kemal_Sener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 depoya y");
            Console.WriteLine("2 depoda hacmi 300");
            Console.WriteLine("3 gıda dışı");
            Console.WriteLine("4 boş h");
            Console.WriteLine("5 cık");
            string g = "";
            depokont depoc = new depokont();
            while (g == "5")
            {
                g = Console.ReadLine();
                switch (g)
                {

                    case "1":
                        int[] hac = new int[3];
                        Console.WriteLine("boy");
                        hac[0] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("en ");
                        hac[1] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("yukseklik");
                        hac[2] = Convert.ToInt32(Console.ReadLine());
                        urunler yenu = new urunler() { boy = hac[0], en = hac[1], yuksek = hac[2] };
                        depoc.urunekle(yenu);

                        break;

                    case "2":
                        foreach (var item in depoc.buyuksıra())
                        {
                            Console.WriteLine(item.boy.ToString(), item.en, item.gıda, item.hacim);
                        }
                        break;

                    case "3":
                        foreach (var item in depoc.gıdadı_liste())
                        {
                            Console.WriteLine(item.boy.ToString(), item.en, item.gıda, item.hacim);
                        }
                        break;

                    case "4":
                        Console.WriteLine(depoc.bosluk());
                        break;
                }

            }
        }
    }
}
