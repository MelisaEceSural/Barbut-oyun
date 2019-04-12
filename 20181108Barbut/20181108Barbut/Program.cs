using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20181108Barbut
{
    class Program
    {
        static void Main(string[] args)
        {
            int o1kasa = 100, o2kasa = 100, zar1, zar2, oyuncu1puan, oyuncu2puan, oyun = 0;
            Random salla = new Random();
            while (o1kasa != 0 && o2kasa != 0)
            {
                oyun++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{oyun}. Oyun Oynanıyor...\n");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. oyuncu zar atıyor...");
                Thread.Sleep(1000);
                zar1 = salla.Next(1, 7);
                zar2 = salla.Next(1, 7);

                if (zar1 == zar2)
                    oyuncu1puan = zar1 * 4;
                else
                    oyuncu1puan = zar1 + zar2;

                Console.WriteLine($"1. oyuncu\t\t{zar1}  {zar2}\t{oyuncu1puan}");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2. oyuncu zar atıyor...");
                Thread.Sleep(1000);
                zar1 = salla.Next(1, 7);
                zar2 = salla.Next(1, 7);

                if (zar1 == zar2)
                    oyuncu2puan = zar1 * 4;
                else
                    oyuncu2puan = zar1 + zar2;

                Console.WriteLine($"2. oyuncu\t\t{zar1}  {zar2}\t{oyuncu2puan}");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                if (oyuncu1puan>oyuncu2puan)
                {
                    Console.WriteLine("1. Oyuncu eli aldı.");
                    o1kasa += 10;
                    o2kasa -= 10;
                }
                else if (oyuncu1puan<oyuncu2puan)
                {
                    Console.WriteLine("2. Oyuncu eli aldı.");
                    o1kasa -= 10;
                    o2kasa += 10;
                }
                else
                {
                    Console.WriteLine($"Oyun berabere. {oyun}. oyun tekrar oynanıyor.");
                    oyun--;
                }

                Console.WriteLine($"1. Oyuncu cüzdan = {o1kasa}\t2. Oyuncu cüzdan = {o2kasa}");
            }

            Console.ReadKey();
        }
    }
}
