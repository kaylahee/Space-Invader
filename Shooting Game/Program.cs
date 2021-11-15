using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting
{
    class Player
    {
        private int x;
        private int y;

        public void SetLocation(int inX, int inY)
        {
            x = inX;
            y = inY;
        }
        public void Move()
        {
            
        }
    }

    class Shoot
    {
        private int x;
        private int y;

        public void SetLocation(int inX, int inY)
        {
            x = inX;
            y = inY;
        }

        public void shoot()
        {
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(64, 32);

            int x = 0, y = 62;
            ConsoleKeyInfo cki;
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("△");
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }

            ConsoleKeyInfo space;
            while (true)
            {
                Console.Clear();
                Console.Write("l");
                space = Console.ReadKey(true);
                switch (space.Key)
                {
                    case ConsoleKey.Spacebar:
                        for (byte i = 0; i < 20; i++)
                        {
                            Console.SetCursorPosition(x, i--);
                        }
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
