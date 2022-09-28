using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Zad 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a*a + b*b);
            */
            /*
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());

                        if (x >= y && y >= z) Console.WriteLine($"{x} {y} {z}");
                        else if (x >= z && z >= y) Console.WriteLine($"{x} {z} {y}");
                        else if (y >= x && x >= z) Console.WriteLine($"{y} {x} {z}");
                        else if (y >= z && z >= x) Console.WriteLine($"{y} {z} {x}");
                        else if (z >= x && x >= y) Console.WriteLine($"{z} {x} {y}");
                        else if (z >= y && y >= x) Console.WriteLine($"{z} {y} {x}");*/

            /*int n = int.Parse(Console.ReadLine());
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }*/
            /*
                        for (int i = 2; i <= 486; i=i*3)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        int potega3 = 1;
                        for (int i = 1; i <= 6; i++)
                        {
                            Console.Write(2*potega3 + " ");
                            potega3 *= 3;
                        }*/

            /*Console.WriteLine(1423 / 10);
            Console.WriteLine(142 / 10);
            Console.WriteLine(14 / 10);
            Console.WriteLine(1 / 10);*/

            /*int x = int.Parse(Console.ReadLine());
            int licznik = 0, suma_cyfr = 0, cyfra;
            while (x > 0)
            {
                cyfra = x % 10;
                x = x / 10;
                licznik = licznik + 1;
                suma_cyfr += cyfra;
            }
            Console.WriteLine(licznik + " " + suma_cyfr);
*/

            /*int n = int.Parse(Console.ReadLine());
            bool flaga = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flaga = false;
                    break;
                }
            }
            if (flaga) Console.WriteLine("JEST PIERWSZA");
            else Console.WriteLine("NIE JEST PIERWSZA");

            bool sprawdz_czy_pierwsza(int n)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }*/

            Console.WriteLine(Math.Sqrt(25));

            int n = int.Parse(Console.ReadLine());
            int dzielniki = 0;
            for (int i = 1.5; i <= 3.5; i++)
            {
                if (n % i == 0)
                {
                    dzielniki += 1;
                }
            }
            if (dzielniki==2) Console.WriteLine("JEST PIERWSZA");
            else Console.WriteLine("NIE JEST PIERWSZA");
            
            Console.ReadKey();
        }
    }
}
