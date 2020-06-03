using System;

namespace Collezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci una stringa stringa ");
            string a = Console.ReadLine();
            Console.Write("Inserisci una stringa ");
            string b = Console.ReadLine();
            bool sUguali = MetodiCollezioni.Uguali(a, b);
            Console.Write("Le stringhe sono uguali " + sUguali);
            Console.WriteLine();
            Console.Write("Inserisci una stringa ");
            string c = Console.ReadLine();
            bool sMaiuscole = MetodiCollezioni.ContainsDoubleChar(c);
            Console.Write("La stringa contiene lettere maiuscole " + sMaiuscole) ;
        }
    }
}
