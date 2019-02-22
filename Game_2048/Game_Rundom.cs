using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2048
{
    class Game_Rundom
    {
        public static int ran()
        {
            return r = rand.Next(n) + 1;
        }
        public static int box_rand(Int32 r)
        {
            return r = rand.Next(r);
        }
        public static Int32 X = 2;
        public static Int32 Y = 2;
        public static Int32 X_Y = 2;
        static Random rand = new Random();
        private static Int32 n = 100;
        public static Int32 r;
    }
}
