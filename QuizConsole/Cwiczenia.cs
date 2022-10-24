using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole
{
    internal class Cwiczenia
    {
        public int DodajLiczby(int x, int y)
        {
            return x + y;
        }

        void Cwicz()
        {
            var lista = new List<string>();
            lista.Add("Zosia");
            lista.Add("Wacek");
            lista.Add("Tomek");

            var imie = lista[2];


            var iloscElementow = lista.Count;

            for (int i = 0; i < iloscElementow; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();
            foreach (var element in lista)
            {
                Console.WriteLine(element);
            }
        }
    }
}
