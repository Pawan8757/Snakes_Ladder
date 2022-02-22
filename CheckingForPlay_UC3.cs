using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class CheckingForPlay_UC3
    {
        public static void CheckingForPlay()
        {
            int initialValue = 0;
            const int noPlay = 1;
            const int snake = 2;
            const int ladder = 3;
            int position = 0;

            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(1, 4);

            switch (option)
            {
                case noPlay:
                    position = 0;
                    break;
                case snake:
                    position -= dice;
                    break;
                case ladder:
                    position += dice;
                    break;
            }
            Console.WriteLine(position);
        }
    }
}
