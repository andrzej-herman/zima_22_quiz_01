using QuizConsole.Obiekty;


Console.ForegroundColor = ConsoleColor.White;
// PLANSZA POCZĄTKOWA
Console.WriteLine("WITAJ W QUIZIE WIEDZY");
Console.WriteLine("Spróbuj odpowiedzieć na 5 pytań");
Console.WriteLine("POWODZENIA !!!");
Console.WriteLine();

// TWORZYMY PYTANIE
Pytanie p = new Pytanie();
p.Odpowiedzi = new List<Odpowiedz>();
p.Id = 1;
p.Tresc = "Jak miał na imię Eintein?";
p.Kategoria = 100;

var odp1 = new Odpowiedz();
odp1.Id = 1;
odp1.Tresc = "Albert";
odp1.CzyPrawidlowa = true;
p.Odpowiedzi.Add(odp1);

var odp2 = new Odpowiedz();
odp2.Id = 2;
odp2.Tresc = "Aaron";
odp2.CzyPrawidlowa = false;
p.Odpowiedzi.Add(odp2);

var odp3 = new Odpowiedz();
odp3.Id = 3;
odp3.Tresc = "Andrew";
odp3.CzyPrawidlowa = false;
p.Odpowiedzi.Add(odp3);

var odp4 = new Odpowiedz();
odp4.Id = 4;
odp4.Tresc = "Anthony";
odp4.CzyPrawidlowa = false;
p.Odpowiedzi.Add(odp4);

// WYŚWIETLAMY PYTANIE
p.PokazPytanieGraczowi();
var odp = Console.ReadLine();
if (odp == "1" || odp == "2" || odp == "3" || odp == "4")
{
    // prawidłowy klawisz => sprawdzamy odpowiedź
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("OK");
}
else
{

    // nieprawidłowy klawisz => spróbuj jeszcze raz
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wcisnałeś nieprawidłowy klawisz ...");
    Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
    odp = Console.ReadLine();
}


Console.WriteLine();

