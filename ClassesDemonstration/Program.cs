using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemonstration
{
    class Program
    {
        static Player player1 = new Player();
        static Player player2 = new Player();
        static void Main(string[] args)
        {
            Console.WriteLine("Classes Demonstration");            
            player1.DisplayHUD();
            Console.WriteLine("Player takes 50 dmg");
            player1.TakeDamge(50);
            player1.DisplayHUD();
            Console.WriteLine("Player move to (2,3)");
            player1.MovePlayer(2, 3);
            player1.DisplayHUD();
            Console.ReadKey(true);
        }
    }
}
