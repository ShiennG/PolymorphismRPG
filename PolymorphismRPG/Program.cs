using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismRPG
{
    class Program
    {
        // useful tools
        static void ClearConsole(int amountOfLines)
        {
            Console.WriteLine(amountOfLines);
            Console.WriteLine("Cleared!");
        }


        static void Main(string[] args)
        {
            Player p1mage = new Mage();
            Player p2archer = new Archer();
            Player p3knight = new Knight();

            Enemy enemy = new Slime(); // slime atm has 30% dodge chance for demonstration


            p1mage.PrimaryAttack(enemy);
            Console.WriteLine();
            p2archer.SecondAttack(enemy);
            Console.WriteLine();
            p3knight.SecondAttack(enemy);
            Console.WriteLine("Knight doesnt have any skill yet so it uses Player class skills instead");



        }
    }
}
