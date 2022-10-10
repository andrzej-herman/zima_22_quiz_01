using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Pytanie
    {
        public int Id { get; set; }
        public int Kategoria { get; set; }
        public string Tresc { get; set; }
        public string Odpowiedz_01 { get; set; }
        public string Odpowiedz_02 { get; set; }
        public string Odpowiedz_03 { get; set; }
        public string Odpowiedz_04 { get; set; }
    }
}




// 100, 200, 500, 1000, 5000