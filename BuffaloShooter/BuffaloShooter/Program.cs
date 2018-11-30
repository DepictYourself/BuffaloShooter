using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffaloShooter
{
    class Game
    {
        private bool isOver = false;

        public static void Shoot(int x, int y)
        {
            //TODO
            
        }
    }

    class Field
    {
        public static int width = 5;
        public static int height = 5;

        private Buffalo[] buffaloes = new Buffalo[10];

        public Buffalo[] Buffaloes
        {
            get { return buffaloes; }
        }

        public Field()
        {
            for(int i = 0; i < buffaloes.Length; i++)
            {
                buffaloes[i] = new Buffalo();
            }
        }
    }

    class Buffalo
    {
        private int x, y;
        private bool alive;
        private static Random random = new Random();

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Buffalo()
        {
            alive = true;
            Move();
        }

        public void Move()
        {
            //The buffaloes can only move on the field to the
            //                      - right
            //                      - down 
            //                      - down and right

            int randomNum = random.Next(0, 3);
            
            if (randomNum == 0 && x + 1 < Field.width)
            {
                // move to the right
                x++;               
            } else if (randomNum == 1 && y + 1 < Field.height)
            {
                // move down
                y++;
            } else
            {
                // move diagonally right and down at the same time.
                if(x+1< Field.width && y+1 < Field.height)
                {
                    x++;
                    y++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game has started! Press enter to shoot");
            Console.WriteLine("X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            int y = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
