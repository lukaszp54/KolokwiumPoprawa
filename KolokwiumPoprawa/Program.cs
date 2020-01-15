using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumPoprawa
{
    class Program
    {
        public static void Zadanie1(uint n)
        {
            double[] y = new double[n + 1];
            y[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                y[i] = 1.5 * y[i - 1] - 1;
            }
            Console.WriteLine($"y[{n}] wynosi: {y[n]}");
        }


        public static void Zadanie2(uint n)
        {
            int licznik = 0;
            int[] tab = new int[200];
            Console.WriteLine("Liczby podzielne przez {0}: ", n);
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = ++licznik;
                if (tab[i] % n == 0)
                {
                    Console.WriteLine(tab[i]);
                }
                else
                {

                }
            }

        }


        public static void Zadanie3(uint a, uint b, uint c, uint d)
        {
            double[,] tab1 = new double[a, b];
            double[,] tab2 = new double[c, d];
            double[,] tab = new double[Math.Max(tab1.GetLength(0), tab2.GetLength(0)), Math.Max(tab1.GetLength(1), tab2.GetLength(1))];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tab1[i, j] = 1;
                }
            }

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tab2[i, j] = 1;
                }
            }


            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tab[i, j] = tab1[i, j];
                }
            }


            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tab[i, j] += tab2[i, j];
                }
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j]);
                }
                Console.WriteLine();
            }

        }


        public static void Zadanie4(int[,] tab)
        {
            Random los = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = los.Next(1, 20);
                    Console.Write($"{tab[i, j]} ");
                }
                Console.WriteLine();
            }

            int min = int.MaxValue;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                   if (tab[i, j] < min)
                    {
                        min = tab[i, j];
                    }
                    
                }
               
            }
            Console.WriteLine("Najmniejszy element jest równy: {0}", min);


        }

        public static void Zadanie4(int [][] tab)
        {

        }




        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsze zadanie: ");
            Zadanie1(8);
            Console.WriteLine();

            Console.WriteLine("Drugie zadanie: ");
            Zadanie2(5);
            Console.WriteLine();

            Console.WriteLine("Trzecie zadanie: ");
            Zadanie3(2, 10, 4, 5);
            Console.WriteLine();

            Console.WriteLine("Czwarte zadanie: ");
            int[,] tab = new int[4, 5];
            Zadanie4(tab);
            Console.WriteLine();

            Console.Write("Piate zadanie: ");
            EBook ksiazka = new EBook("Mickiewicz", "Pan Tadeusz", new DateTime(1834, 06, 28), new DateTime(2020, 1, 1), -3, -3);
            Console.WriteLine($"Cena aktualna: {ksiazka.AktualnaCena}");  
        }
    }
}
