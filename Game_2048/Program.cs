using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_2048
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Game_Display t = new Game_Display();
            while(true)
            {
                t.Drow_Display();
                t.changeGD();               
            }
          

            Console.ReadKey();
           
           
        }

        

    }
}
