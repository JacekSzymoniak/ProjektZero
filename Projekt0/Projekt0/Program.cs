using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt0
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            int KontrolerMenu;
            var ListaAdresow = new List<Adres>();
            bool KontrolerPetli = true;
            while (KontrolerPetli)
            {
                Console.Clear();
                var adres = new Adres();
                Console.WriteLine("Menu: \n1 - Dodaj adres\n2 - Wyświetl według \n3 - Wyświetl wszystkie \n4 - Zakończ działanie programu");

                if (!int.TryParse(Console.ReadLine(), out KontrolerMenu))
                    Console.WriteLine("Niepoprawna wartość!");

                switch (KontrolerMenu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Podaj kod pocztowy: ");
                        adres.KodPocztowy = Console.ReadLine();

                        Console.WriteLine("Podaj miasto: ");
                        adres.Miasto = Console.ReadLine();

                        Console.WriteLine("Podaj ulicę:  ");
                        adres.Ulica = Console.ReadLine();

                        Console.WriteLine("Podaj numer domu: ");
                        adres.NrDomu = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj numer mieszkania: ");
                        adres.NrMieszkania = int.Parse(Console.ReadLine());

                        Console.Clear();
                        ListaAdresow.Add(adres);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2 - Wyświetl według \n\t1 - Kodu pocztowego \n\t2 - Miasta \n\t3 - Ulicy \n\t4 - Ulicy, nr domu, \n\t5 - Ulicy, nr domu, nr mieszkania");

                        if (!int.TryParse(Console.ReadLine(), out KontrolerMenu))
                            Console.WriteLine("Niepoprawna wartość!");
                        switch (KontrolerMenu)
                        {
                            case 1:

                                Console.Clear();
                                Console.WriteLine("Podaj kod pocztowy: ");
                                string KodPodcztowy = Console.ReadLine();
                                List<Adres> ListaKodow = ListaAdresow.FindAll(x => x.KodPocztowy == KodPodcztowy);
                                foreach (var WyswietlaneKody in ListaKodow)
                                    Console.WriteLine(WyswietlaneKody);
                                Console.ReadKey();
                                break;


                            case 2:

                                Console.Clear();
                                Console.WriteLine("Podaj nazwe miasta: ");
                                string Miasto = Console.ReadLine();
                                List<Adres> ListaMiast = ListaAdresow.FindAll(x => x.Miasto == Miasto);
                                foreach (var WyswietlaneMiasta in ListaMiast)
                                    Console.WriteLine(WyswietlaneMiasta);
                                Console.ReadKey();
                                break;

                            case 3:

                                Console.Clear();
                                Console.WriteLine("Podaj nazwe ulicy: ");
                                string Ulica = Console.ReadLine();
                                List<Adres> ListaUlic = ListaAdresow.FindAll(x => x.Ulica == Ulica);
                                foreach (var WyswietlaneUlice in ListaUlic)
                                    Console.WriteLine(WyswietlaneUlice);
                                Console.ReadKey();
                                break;

                            case 4:

                                Console.Clear();
                                Console.WriteLine("Podaj nazwe ulicy: ");
                                Ulica = Console.ReadLine();
                                Console.WriteLine("Podaj numer domu: ");
                                int NrDomu = int.Parse(Console.ReadLine());
                                List<Adres> ListaUlicINumerow = ListaAdresow.FindAll(x => x.Ulica == Ulica && x.NrDomu == NrDomu);
                                foreach (var WyswietlaneUliceINumery in ListaUlicINumerow)
                                    Console.WriteLine(WyswietlaneUliceINumery);
                                Console.ReadKey();
                                break;

                            case 5:

                                Console.Clear();
                                Console.WriteLine("Podaj nazwe ulicy: ");
                                Ulica = Console.ReadLine();
                                Console.WriteLine("Podaj numer domu: ");
                                NrDomu = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj numer mieszkania: ");
                                int NrMieszkania = int.Parse(Console.ReadLine());
                                Console.WriteLine(ListaAdresow.FindAll(x => x.Ulica == Ulica && x.NrDomu == NrDomu && x.NrMieszkania == NrMieszkania));
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case 3:

                        Console.Clear();
                        if (!ListaAdresow.Any())
                        {
                            Console.WriteLine("Lista adresów jest pusta");
                        }
                        else
                        {
                            foreach (var Adresy in ListaAdresow)
                                Console.WriteLine(Adresy.ToString());
                        }
                        Console.ReadKey();
                        break;

                    case 4:

                        Console.Clear();
                        KontrolerPetli = false;
                        break;


                }
            }
        }
    }
}
