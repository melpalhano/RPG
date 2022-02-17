using System;
using rpg.src.Entities;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight"); 
            Wizard jennica = new Wizard("Jennica", 22, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 25, "Ninja");          

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(2));
            Console.WriteLine(wedge.Attack(3));
        }
    }
}
