using System;
using System.Diagnostics;

namespace Projekt3
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateRandomTab(); // Using all sorting methods 
            CreateAscendingTab("InsertionSort");
            CreateAscendingTab("SelectionSort");
            CreateAscendingTab("HeapSort");
            CreateAscendingTab("CocktailSort");
            CreateDescendingTab("InsertionSort");
            CreateDescendingTab("SelectionSort");
            CreateDescendingTab("HeapSort");
            CreateDescendingTab("CocktailSort");
            CreateConstantTab("InsertionSort");
            CreateConstantTab("SelectionSort");
            CreateConstantTab("HeapSort");
            CreateConstantTab("CocktailSort");
            CreateVshapeTab("InsertionSort");
            CreateVshapeTab("SelectionSort");
            CreateVshapeTab("HeapSort");
            CreateVshapeTab("CocktailSort");
         
        }

        // Tab creating methods
        public static void CreateRandomTab()
        {
            string typ = "RandomTab";
            int iloscElementow = 5000;
            Random rnd = new Random();
            for (int i = 0; i <= 30; i++)
            {
                // Tworzenie tablicy
                int[] tablicaElementow = new int[iloscElementow];
                int[] forInsertionSort = new int[iloscElementow];
                int[] forSelectionSort = new int[iloscElementow];
                int[] forHeapSort = new int[iloscElementow];
                int[] forCocktailSort = new int[iloscElementow];
                Console.WriteLine("Tablica " + i + " ilosc elementow: " + iloscElementow);

                for (int j = 0; j < iloscElementow; j++)
                {
                    tablicaElementow[j] = rnd.Next(0, iloscElementow);
                    forInsertionSort[j] = tablicaElementow[j];
                    forSelectionSort[j] = tablicaElementow[j];
                    forHeapSort[j] = tablicaElementow[j];
                    forCocktailSort[j] = tablicaElementow[j];
                }
                //Sortowanie
                    InsertionSort(forInsertionSort, iloscElementow, typ);
                    SelectionSort(forSelectionSort, iloscElementow, typ);                          
                    HeapSort(forHeapSort, iloscElementow, typ);              
                    CocktailSort(forCocktailSort, iloscElementow, typ);

                iloscElementow += 5000;
            }

        }

        public static void CreateDescendingTab(string sortType)
        {
            string typ = "DescendingTab";
            int iloscElementow = 50000;
            for (int i = 0; i <= 30; i++)
            {
                // Tworzenie tablicy
                int[] tablicaElementow = new int[iloscElementow];
                Console.WriteLine("Tablica " + i + " ilosc elementow: " + iloscElementow);

                for (int j = 0; j < iloscElementow; j++)
                {
                    tablicaElementow[j] = iloscElementow - j;
                }
                //Sortowanie
                if (sortType == "InsertionSort")
                {
                    InsertionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "SelectionSort")
                {
                    SelectionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "HeapSort")
                {
                    HeapSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "CocktailSort")
                {
                    CocktailSort(tablicaElementow, iloscElementow, typ);
                }

                iloscElementow += 5000;
            }
        }

        public static void CreateAscendingTab(string sortType)
        {
            string typ = "AscendingTab";
            int iloscElementow = 50000;
            for (int i = 0; i <= 30; i++)
            {
                // Tworzenie tablicy
                int[] tablicaElementow = new int[iloscElementow];
                Console.WriteLine("Tablica " + i + " ilosc elementow: " + iloscElementow);

                for (int j = 0; j < iloscElementow; j++)
                {
                    tablicaElementow[j] = j + 1;
                }
                //Sortowanie
                if (sortType == "InsertionSort")
                {
                    InsertionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "SelectionSort")
                {
                    SelectionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "HeapSort")
                {
                    HeapSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "CocktailSort")
                {
                    CocktailSort(tablicaElementow, iloscElementow, typ);
                }

                iloscElementow += 5000;
            }
        }

        public static void CreateConstantTab(string sortType)
        {
            string typ = "ConstantTab";
            int iloscElementow = 50000;
            for (int i = 0; i <= 30; i++)
            {
                // Tworzenie tablicy
                int[] tablicaElementow = new int[iloscElementow];
                Console.WriteLine("Tablica " + i + " ilosc elementow: " + iloscElementow);

                for (int j = 0; j < iloscElementow; j++)
                {
                    tablicaElementow[j] = 5;
                }
                //Sortowanie
                if (sortType == "InsertionSort")
                {
                    InsertionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "SelectionSort")
                {
                    SelectionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "HeapSort")
                {
                    HeapSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "CocktailSort")
                {
                    CocktailSort(tablicaElementow, iloscElementow, typ);
                }

                iloscElementow += 5000;
            }
        }
        public static void CreateVshapeTab(string sortType)
        {
            string typ = "VshapeTab";
            int iloscElementow = 50000;
            
            for (int i = 0; i <= 30; i++)
            {
                // Tworzenie tablicy
                int[] tablicaElementow = new int[iloscElementow];
                Console.WriteLine("Tablica " + i + " ilosc elementow: " + iloscElementow);

                for (int j = 0; j < iloscElementow; j++)
                {
                    if (j < iloscElementow / 2)
                    {
                        tablicaElementow[j] = iloscElementow - j;
                        Console.WriteLine("Tablica " + j + "=" + tablicaElementow[j]);
                    }
                    if (j >= iloscElementow / 2)
                    {
                        tablicaElementow[j] = 1 + j;
                        Console.WriteLine("Tablica " + j + "=" + tablicaElementow[j]);
                    }
                    
                }
                //Sortowanie
                if (sortType == "InsertionSort")
                {
                    InsertionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "SelectionSort")
                {
                    SelectionSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "HeapSort")
                {
                    HeapSort(tablicaElementow, iloscElementow, typ);
                }
                if (sortType == "CocktailSort")
                {
                    CocktailSort(tablicaElementow, iloscElementow, typ);
                }

                iloscElementow += 5000;
            }
        }
        // Sorting methods Sorting methods                                                                                                                                  
        public static void InsertionSort(int[] tablica, int NastepnaIloscElementow, string rodzajTablicy)
        {
            Stopwatch czas = new Stopwatch();
            czas.Start();
            for (int i = 1; i < tablica.Length; i++)
            {
                int liczbaZPrzedzialu = i;
                int temp = tablica[liczbaZPrzedzialu];

                while ((liczbaZPrzedzialu > 0) && (tablica[liczbaZPrzedzialu - 1] > temp))
                {
                    tablica[liczbaZPrzedzialu] = tablica[liczbaZPrzedzialu - 1];
                    liczbaZPrzedzialu--;
                }
                tablica[liczbaZPrzedzialu] = temp;
            }
            czas.Stop();
            long pomiar = czas.ElapsedMilliseconds;
            string nazwaPliku = rodzajTablicy + " InsertionSort";
            AddRecord(NastepnaIloscElementow, pomiar, nazwaPliku);
        }


        public static void SelectionSort(int[] tablica, int NastepnaIloscElementow, string rodzajTablicy)
        {
            Stopwatch czas = new Stopwatch();
            czas.Start();
            int k;
            for (int i = 0; i < (tablica.Length - 1); i++)
            {
                int temp = tablica[i];
                k = i;
                for (int j = i + 1; j < tablica.Length; j++)
                    if (tablica[j] < temp)
                    {
                        k = j;
                        temp = tablica[j];
                    }

                tablica[k] = tablica[i];
                tablica[i] = temp;
            }
            czas.Stop();
            long pomiar = czas.ElapsedMilliseconds;
            string nazwaPliku = rodzajTablicy + " SelectionSort";
            AddRecord(NastepnaIloscElementow, pomiar, nazwaPliku);
        }

        public static void PreHeapSort(int[] tablica, uint left, uint right)
        {
            uint i = left, j = 2 * i + 1;
            int buf = tablica[i];

            while (j <= right)
            {
                if (j < right)
                    if (tablica[j] < tablica[j + 1])
                        j++;
                if (buf >= tablica[j]) break;

                tablica[i] = tablica[j];
                i = j;
                j = 2 * i + 1;
            }

            tablica[i] = buf;
        }
             public static void HeapSort(int[] tablica, int NastepnaIloscElementow, string rodzajTablicy)
            {
            Stopwatch czas = new Stopwatch();
            czas.Start();
            uint left = (uint)tablica.Length / 2;
            uint right = (uint)tablica.Length - 1;
            while (left > 0)
                {
                    left--;
                PreHeapSort(tablica, left, right);
                }

                while (right > 0)
                {
                    int buf = tablica[left];
                    tablica[left] = tablica[right];
                    tablica[right] = buf;
                    right--;
                PreHeapSort(tablica, left, right);
                }
            czas.Stop();
            long pomiar = czas.ElapsedMilliseconds;
            string nazwaPliku = rodzajTablicy + " HeapSort";
            AddRecord(NastepnaIloscElementow, pomiar, nazwaPliku);
        }
        

        public static void CocktailSort(int[] tablica, int NastepnaIloscElementow, string rodzajTablicy)
        {
            Stopwatch czas = new Stopwatch();
            czas.Start();
            int left = 1, right = tablica.Length - 1, k = tablica.Length - 1;
            do
            {
                for (int j = right; j >= left; j--)
                    if (tablica[j - 1] > tablica[j])
                    {
                        int temp = tablica[j - 1];
                        tablica[j - 1] = tablica[j];
                        tablica[j] = temp;
                        k = j;
                    }

                left = k + 1;

                for (int j = left; j <= right; j++)
                    if (tablica[j - 1] > tablica[j])
                    {
                        int temp = tablica[j - 1];
                        tablica[j - 1] = tablica[j];
                        tablica[j] = temp;
                        k = j;
                    }

                right = k - 1;
            }
            while
                (left <= right);
            
            czas.Stop();
            long pomiar = czas.ElapsedMilliseconds;
            string nazwaPliku = rodzajTablicy + " CocktailSort";
            AddRecord(NastepnaIloscElementow, pomiar, nazwaPliku);
        }

    


        public static void AddRecord(int tablica, long czas, string filepath)
        {
            filepath = filepath + ".csv";
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(tablica + "  " + czas);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("", ex);
            }
        }

    }
}
