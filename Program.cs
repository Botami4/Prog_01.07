using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Otthoni
{
    internal class Program
    {

        public static List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static List<int> szorzottLista = Szorzott(lista);
        public static List<int> lista2 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        public static List<string> nevek = new List<string> { "JÓZSIKA", "pista", "GÉZA", "BARNABÁS" };
        public static List<int> forditottLista = Forditott(lista);
        static void Main(string[] args)
        {
            Console.WriteLine("Elemek: " + string.Join(", ", Elemek()));
            Console.WriteLine("Négyzet: " + Negyzet());
            Console.WriteLine("Négyzetlista: " + string.Join(", ", Negyzetre(lista)));
            Console.WriteLine("Összeg: " + Osszeg(lista));
            Console.WriteLine("Párosak: " + string.Join(", ", Parosak(lista)));
            Console.WriteLine("Megsokszorozott lista: " + string.Join(", ", szorzottLista));
            Console.WriteLine("Összefésült lista: " + string.Join(", ", FesultLista(lista, lista2)));
            Console.WriteLine("Legkisebb: " + Legkisebb(lista));
            Console.WriteLine("Páros-e a lista: " + Paros(lista2));
            Console.WriteLine("Minden második elem: " + string.Join(", ", MindenMasodikElem(lista)));
            Console.WriteLine("Fordított lista: " + string.Join(", ", forditottLista));
            Console.WriteLine("Nagybetűs nevek: " + string.Join(", ", Nagybetus(nevek)));
            Console.WriteLine("Több mint öt betűs nevek: " + string.Join(", ", OtBetus(nevek)));

        }

        static void Ures()
        {
            List<int> ures = new List<int>();
        }

        static List<int> Elemek()
        {
            List<int> szamok = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int szam in szamok)
                Console.Write(szam);
            return szamok;
        }

        static int Negyzet()
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int negyzet = szam * szam;
            return negyzet;
        }

        static List<int> Negyzetre(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            List<int> negyzetLista = new List<int>();
            foreach (int szam in lista)
            {
                int negyzet = szam * szam;
                negyzetLista.Add(negyzet);
            }
            return negyzetLista;
        }

        static int Osszeg(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista.Sum();
        }

        static List<int> Parosak(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista.Where(x => x % 2 == 0).ToList();
        }

        static List<int> Szorzott(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }

            Console.WriteLine("Adj meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());

            List<int> eredmeny = new List<int>();
            foreach (int szam in lista)
            {
                eredmeny.Add(szam * a);
            }

            return eredmeny;
        }

        static List<int> FesultLista(List<int> lista, List<int> lista2)
        {
            if (lista == null || lista2 == null)
            {
                throw new ArgumentException("A listák nem lehetnek nullák");
            }

            List<int> eredmeny = new List<int>();
            int maxLength = Math.Max(lista.Count, lista2.Count);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < lista.Count)
                {
                    eredmeny.Add(lista[i]);
                }
                if (i < lista2.Count)
                {
                    eredmeny.Add(lista2[i]);
                }
            }

            return eredmeny;
        }


        static int Legnagyobb(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista.Max();
        }
        static int Legkisebb(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista.Min();
        }

        static bool Paros(List<int> lista2)
        {
            if (lista2 == null || lista2.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista2.All(x => x % 2 == 0);

        }

        static List<int> MindenMasodikElem(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            return lista.Where((x, index) => index % 2 == 1).ToList();
        }

        static List<int> Forditott(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            List<int> ujLista = new List<int>(lista);
            ujLista.Reverse();
            return ujLista;
        }

        static List<string> Nagybetus(List<string> nevek)
        {
            if (nevek == null || nevek.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            List<string> formazottNevek = new List<string>();
            foreach (string nev in nevek)
            {
                if (!string.IsNullOrWhiteSpace(nev))
                {
                    string formazottNev = nev.Substring(0, 1).ToUpper() + nev.Substring(1).ToLower();
                    formazottNevek.Add(formazottNev);
                }
            }
            return formazottNevek;
        }

        static List<string> OtBetus(List<string> nevek)
        {
            if (nevek == null || nevek.Count == 0)
            {
                throw new ArgumentException("A lista nem lehet üres");
            }
            List<string> otbetusNevek = new List<string>();
            foreach (string nev in nevek)
            {
                if (!string.IsNullOrWhiteSpace(nev) && nev.Length > 5)
                {
                    otbetusNevek.Add(nev);
                }
            }
            return otbetusNevek;
        }
    }
}
