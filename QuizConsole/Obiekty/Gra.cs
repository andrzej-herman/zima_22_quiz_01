using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Gra
    {
        public Gra()
        {
            AktualnaKategoria = 100;
            Pytania = new List<Pytanie>();
        }


        public List<Pytanie> Pytania { get; set; }
        public int AktualnaKategoria { get; set; }
        public Pytanie AktualnePytanie { get; set; }




        // metoda wyświetlająca planszę początkową
        public void Powitanie()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WITAJ W QUIZIE WIEDZY");
            Console.WriteLine("Spróbuj odpowiedzieć na 5 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
        }

        // metoda tworząca całą bazę pytań
        public void UtworzPytania()
        {
            // tymczasowo utworzymy 2 pytania z "palca", jedno za 100 pkt,
            // a drugie za 200 pkt,
            // docelowo utworzymy prawdziwą bazę pytań w formie pliku json

          
            // pytanie 1 za 100 pkt
            Pytanie p = new Pytanie
            {
                Id = 1,
                Tresc = "Jak miał na imię Eintein?",
                Kategoria = 100,
                Odpowiedzi = new List<Odpowiedz>()
            };

            p.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 1,
                Tresc = "Albert",
                CzyPrawidlowa = true
            });

            p.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 2,
                Tresc = "Anthony",
                CzyPrawidlowa = false
            });

            p.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 3,
                Tresc = "Andrew",
                CzyPrawidlowa = false
            });

            p.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 4,
                Tresc = "Aaron",
                CzyPrawidlowa = false
            });

            // pytanie 2 za 200 pkt
            Pytanie p2 = new Pytanie
            {
                Id = 2,
                Tresc = "W którym roku wybuchła II wojna światowa?",
                Kategoria = 200,
                Odpowiedzi = new List<Odpowiedz>()
            };

            p2.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 1,
                Tresc = "1939",
                CzyPrawidlowa = true
            });

            p2.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 2,
                Tresc = "1940",
                CzyPrawidlowa = false
            });

            p2.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 3,
                Tresc = "1918",
                CzyPrawidlowa = false
            });

            p2.Odpowiedzi.Add(new Odpowiedz
            {
                Id = 4,
                Tresc = "1945",
                CzyPrawidlowa = false
            });


            Pytania.Add(p);
            Pytania.Add(p2);
        }

        // metoda losująca jedno pytanie ze wszystkich z aktualnej kategorii
        public void WylosujPytanie()
        {
            var wylosowanePytanie = new Pytanie();
            foreach (var pytanie in Pytania)
            {
                if (pytanie.Kategoria == AktualnaKategoria)
                {
                    wylosowanePytanie = pytanie;
                    break;
                }                
            }

            AktualnePytanie = wylosowanePytanie;
        }

        // metoda sprawdzająca czy odpowiedz Gracza jest poprawna
        public bool SprawdzCzyPoprawnaOdpowiedz(int odpowiedzGracza)
        {
            foreach (var odpowiedz in AktualnePytanie.Odpowiedzi)
            {
                if (odpowiedz.Id == odpowiedzGracza)
                {
                    return odpowiedz.CzyPrawidlowa;
                }
            }

            return false;
        }
    }
}
