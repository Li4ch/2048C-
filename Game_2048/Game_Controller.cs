using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2048
{
    
    class Game_Controller
    {
        enum butns { LEFT, RIGHT, UP, DOWN }
        public void game_butn_loop() //перевірка нажаття клавіш
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.WriteLine(key.Key + " клавиша была нажата");
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    left_key = true;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    right_key = true;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    up_key = true;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine(10);
                    down_key = true;
                }
            }
            while (key.Key != ConsoleKey.Escape && left_key != true && right_key != true && up_key != true && down_key != true );
            
        }
        public Game_Controller()
        {
            left_key = false;
            right_key = false;
            up_key = false;
            down_key = false;
        }
        public  bool left_key;
        public  bool right_key;
        public  bool up_key;
        public  bool down_key;
    }
       
    

    

}
