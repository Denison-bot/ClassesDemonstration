using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemonstration
{
    class Player
    {
        public int x = 0;
        public int y = 0;
        public int health = 100;

        public void TakeDamge(int dmg)
        {
            health = health - dmg;
        }

        public void MovePlayer(int moveX, int moveY)
        {
            
            x = x + moveX;
            y = y + moveY;
        }

        public void DisplayHUD()
        {
            Console.WriteLine();
            Console.WriteLine("------------HUD-----------");
            Console.WriteLine("Player Cords: (" + x + ", " + y + ")");
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }

}
