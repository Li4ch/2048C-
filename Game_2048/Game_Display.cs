using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2048
{
    class Game_Display
    {
        public void Drow_Display() // Display the game
        {
           for(Int32 y = 0; y < Game_Logic.display_y; y ++)
            {
                for(Int32 x = 0; x < Game_Logic.display_x; x++)
                    Console.Write(GL.game_Score[x,y]);

                Console.WriteLine();
            }                      
        } // Display the game
        public void test()
        {
            GL.Game_Control();
        }
        public void changeGD()
        {
            GL.Game_Control();
        }
        Game_Logic GL = new Game_Logic();
        
    }
}
