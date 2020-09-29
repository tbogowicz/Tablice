using System;

namespace Tablice
{
    class Program
    {
        public class tablicowo
        {
            private int[,] tablica;
            private int liczba_kolumn;
            private int liczba_wierszy;

            public tablicowo(int wiersze, int kolumny)
            {
                this.liczba_wierszy = wiersze;
                this.liczba_kolumn = kolumny;
                tablica = new int[wiersze, kolumny];
            }

            public void wypelnianie()
            {
                Random rnd = new Random();
                for (int i = 0; i < liczba_wierszy; i++)
                {               
                    for (int j = 0; j < liczba_kolumn; j++)
                    {
                        tablica[i, j] = rnd.Next(1, 9);
                    }
                }
            }
            public void wyswiatlanie()
            {
                for (int i = 0; i < liczba_wierszy; i++)
                {
                    for (int j = 0; j < liczba_kolumn; j++)
                    {
                        Console.Write(tablica[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            public void transponowanie()
            {
                if (liczba_kolumn == liczba_wierszy)
                {
                    
                    int[,] temp = tablica;
                        for (int i = 0; i < liczba_wierszy ; i++)
                        {
                            for (int j = 0; j < liczba_kolumn; j++)
                            {
                                tablica[0, j] = temp[j, 0];
                            }
                       
                        }
                }
                else { Console.WriteLine("Niegotowe"); }

            }
        }
    

        static void Main(string[] args)
        {
            tablicowo tbl = new tablicowo(4, 4);
            tbl.wypelnianie();
            tbl.wyswiatlanie();
            Console.WriteLine();
            tbl.transponowanie();
            tbl.wyswiatlanie();
            Console.ReadKey();
        }
    }
}
