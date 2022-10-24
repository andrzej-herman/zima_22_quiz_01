using QuizConsole.Obiekty;


// TWORZYMY OBIEKT TYPU (KLASY) GRA
var gra = new Gra();
// WYŚWIETLAMY POWITANIE
gra.Powitanie();
// TWORZYMY BAZE PYTAŃ
gra.UtworzPytania();
// LOSUJEMY PYTANIE
gra.WylosujPytanie();
// WYŚWIETLAMY PYTANIE
var odpowiedzGracza = gra.AktualnePytanie.Pokaz();
var czyPoprawnaOdpowiedz = gra.SprawdzCzyPoprawnaOdpowiedz(odpowiedzGracza);


//if (odp == "1" || odp == "2" || odp == "3" || odp == "4")
//{
//    // prawidłowy klawisz => sprawdzamy odpowiedź
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("OK");
//}
//else
//{

//    // nieprawidłowy klawisz => spróbuj jeszcze raz
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Wcisnałeś nieprawidłowy klawisz ...");
//    Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
//    odp = Console.ReadLine();
//}


Console.WriteLine();

