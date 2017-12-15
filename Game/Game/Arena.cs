using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Arena
    {
        static public void arena_menu()
        {
            Console.WriteLine("Witaj na arenie! Co chcesz zrobić?\n1 - walka\n2 - opis\n3 - wyjść");
        }
        static public void opis()
        {
            Console.WriteLine("To tutaj dzielni wojownicy walczą by udowodnić swą potęgę!\n1 - powrót.");
        }
    }
}
