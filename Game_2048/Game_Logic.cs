using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2048
{
    class Game_Logic
    {
        public Game_Logic() //виводить на екран рандомні числа
        {
            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();

            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();
        }
        public void write_Box()
        {
            for (Int32 y = 0; y < Game_Logic.display_x; y++)
            {
                for (Int32 x = 0; x < Game_Logic.display_x; x++)
                {
                    if(game_Score[x, y] == 0)
                    {
                        if(count == choice_Box)
                        {
                            if (Game_Rundom.ran() > 10)
                            {
                                game_Score[x, y] = 2;
                            }
                            else
                            {
                                game_Score[x, y] = 4;
                            }
                        }
                        count++;
                    }
                }

            }
            count = 0;
        }
       
        public void Game_Control() // логіка нажаття кнопок
        {
            G_Control.game_butn_loop();
            if (G_Control.left_key)
            {
                move_Box_Left();
                G_Control.left_key = false;
            }
            if (G_Control.right_key)
            {
                move_Box_Right();
                G_Control.right_key = false;
            }
            if (G_Control.up_key)
            {
                move_Box_Up();
                G_Control.up_key = false;
            }
            if (G_Control.down_key)
            {
                move_Box_Down();
                G_Control.down_key = false;
            }

        }
        public void move_Box_Down() //реагування на зміщення
        {
            plas_Down_Buttn();
            for (int y = 3; y > 0; y--)
            {
                for (int x = 0; x < display_x; x++)
                {
                    if (game_Score[x, y] == 0 && y > 0)
                    {
                        if (game_Score[x , y - 1] == 0 && y > 1)
                        {
                            if (game_Score[x, y - 2] == 0 && y > 2)
                            {
                                if (game_Score[x, y - 3] != 0 && y == 3)
                                {
                                    game_Score[x, y] = game_Score[x , y - 3];
                                    game_Score[x , y - 3] = 0;
                                }
                            }
                            else
                            {
                                game_Score[x, y] = game_Score[x , y - 2];
                                game_Score[x , y - 2] = 0;
                            }
                        }
                        else
                        {
                            game_Score[x, y] = game_Score[x , y - 1];
                            game_Score[x , y - 1] = 0;
                        }

                    }

                }
            }
            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();
        }
        public void move_Box_Right() //реагування на зміщення
        {
            plas_Right_Buttn();
            for (int y = 0; y < display_x; y++)
            {
                for (int x = 3; x > 0; x--)
                {
                    if (game_Score[x, y] == 0 && x > 0)
                    {
                        if (game_Score[x - 1, y] == 0 && x > 1)
                        {
                            if (game_Score[x - 2, y] == 0 && x > 2)
                            {
                                if (game_Score[x - 3, y] != 0 && x == 3)
                                {
                                    game_Score[x, y] = game_Score[x - 3, y];
                                    game_Score[x - 3, y] = 0;
                                }
                            }
                            else
                            {
                                game_Score[x, y] = game_Score[x - 2, y];
                                game_Score[x - 2, y] = 0;
                            }
                        }
                        else
                        {
                            game_Score[x, y] = game_Score[x - 1, y];
                            game_Score[x - 1, y] = 0;
                        }

                    }

                }
            }
            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();
        }
        public void move_Box_Up() //реагування на зміщення
        {
            plas_Up_Buttn();
            for (int y = 0; y  < display_y; y++)
            {
                for (int x = 0; x < display_x; x++)
                {
                    if (game_Score[x, y] == 0 && y < 3)
                    {
                        if (game_Score[x, y + 1] == 0 && y + 1 < 3)
                        {
                            if (game_Score[x, y + 2] == 0 && y + 2 < 3)
                            {
                                if (game_Score[x, y + 3] != 0 && y == 0)
                                {
                                    game_Score[x, y] = game_Score[x, y + +3];
                                    game_Score[x, y + 3] = 0;
                                }
                            }
                            else
                            {
                                game_Score[x, y] = game_Score[x, y + 2];
                                game_Score[x, y + 2] = 0;
                            }
                        }
                        else
                        {
                            game_Score[x, y] = game_Score[x, y + 1];
                            game_Score[x, y + 1] = 0;
                        }

                    }

                }
            }
            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();
        }
        public void move_Box_Left() //реагування на зміщення
        {

            plas_Left_Buttn();
            for (int y = 0; y < display_x; y++)
            {
                for(int x = 0; x < display_y;x ++)
                {
                    if(game_Score[x, y] == 0 && x < 3)
                    {
                        if (game_Score[x + 1, y] == 0 && x + 1 < 3)
                        {
                            if (game_Score[x + 2, y] == 0 && x + 2 < 3)
                            {
                                if (game_Score[x + 3, y] != 0 && x == 0)
                                {
                                    game_Score[x, y] = game_Score[x + 3, y];
                                    game_Score[x + 3, y] = 0;
                                }
                            }
                            else
                            {
                                game_Score[x, y] = game_Score[x + 2, y];
                                game_Score[x + 2, y] = 0;
                            }
                        }
                        else
                        {
                            game_Score[x, y] = game_Score[x + 1, y];
                            game_Score[x + 1, y] = 0;
                        }

                    }               
                    
                }
            }

            
           
            choice_Box = Game_Rundom.box_rand(free_Box);
            free_Box--;
            write_Box();
        }
        private void plas_Down_Buttn()
        {
            for (int x = 0; x < display_x; x++)
            {
                for (int y = 3; y > 0; y--) 
                {
                    if (game_Score[x, y] == 0)
                    {
                        continue;
                    }
                    if (y > 0 && game_Score[x, y] == game_Score[x, y - 1])
                    {
                        game_Score[x, y] += game_Score[x, y - 1];
                        game_Score[x, y - 1] = 0;
                        free_Box++;
                        continue;
                    }
                    if (y > 1 && game_Score[x, y] == game_Score[x, y - 2])
                    {
                        game_Score[x, y] += game_Score[x, y - 2];
                        game_Score[x, y - 2] = 0;
                        free_Box++;
                        continue;
                    }
                    if (y == 0 && game_Score[x, y] == game_Score[x, y - 3])
                    {
                        game_Score[x, y] += game_Score[x, y - 3];
                        game_Score[x, y - 3] = 0;
                        free_Box++;
                    }
                }
            }
        }
        private void plas_Up_Buttn()
        {
            for (int y = 0; y < display_y; y++)
            {
                for (int x = 0; x < display_x; x++)
                {
                    if (game_Score[x, y] == 0)
                    {
                        continue;
                    }
                    if (y < 3 && game_Score[x, y] == game_Score[x , y + 1])
                    {
                        game_Score[x, y] += game_Score[x , y + 1];
                        game_Score[x , y + 1] = 0;
                        free_Box++;
                        continue;
                    }
                    if (y < 2 && game_Score[x, y] == game_Score[x, y + 2])
                    {
                        game_Score[x, y] += game_Score[x , y + 2];
                        game_Score[x , y + 2] = 0;
                        free_Box++;
                        continue;
                    }
                    if (y == 0 && game_Score[x, y] == game_Score[x , y + 3])
                    {
                        game_Score[x, y] += game_Score[x, y + 3];
                        game_Score[x, y + 3] = 0;
                        free_Box++;
                    }
                }
            }
        }
        private void plas_Right_Buttn()
        {
            for (int y = 0; y < display_y; y++)
            {
                for (int x = 3; x > 0; x--)
                {
                    if (game_Score[x, y] == 0)
                    {
                        continue;
                    }
                    if (x > 0 && game_Score[x, y] == game_Score[x - 1, y])
                    {
                        game_Score[x, y] += game_Score[x - 1, y];
                        game_Score[x - 1, y] = 0;
                        free_Box++;
                        continue;
                    }
                    if (x > 1 && game_Score[x, y] == game_Score[x - 2, y])
                    {
                        game_Score[x, y] += game_Score[x - 2, y];
                        game_Score[x - 2, y] = 0;
                        free_Box++;
                        continue;
                    }
                    if (x == 3 && game_Score[x, y] == game_Score[x - 3, y])
                    {
                        game_Score[x, y] += game_Score[x + 3, y];
                        game_Score[x - 3, y] = 0;
                        free_Box++;
                    }
                }
            }
        }
        private void plas_Left_Buttn()
        {
            for (int y = 0; y < display_y; y++)
            {
                for (int x = 0; x < display_x; x++)
                {
                    if (game_Score[x, y] == 0)
                    {
                        continue;
                    }
                    if( x < 3 && game_Score[x, y] == game_Score[x + 1, y] )
                    {
                        game_Score[x, y] += game_Score[x + 1, y];
                        game_Score[x + 1, y] = 0;
                        free_Box++;
                        continue;
                    }
                    if (x < 2 && game_Score[x, y] == game_Score[x + 2, y])
                    {
                        game_Score[x, y] += game_Score[x + 2, y];
                        game_Score[x + 2, y] = 0;
                        free_Box++;
                        continue;
                    }
                    if (x == 0 && game_Score[x, y] == game_Score[x + 3, y])
                    {
                        game_Score[x, y] += game_Score[x + 3, y];
                        game_Score[x + 3, y] = 0;
                        free_Box++;                        
                    }
                }
            }
        }
        Game_Controller G_Control = new Game_Controller();

        public Int32[,] game_Score = new Int32[display_x, display_y]; //двохмерный масив целочисленых 

        private Int32 count = 0;
        private Int32 choice_Box = 0;
        private Int32 free_Box = 16;

        public static Int32 display_x = 4;
        public static Int32 display_y = 4;

    }
}
