using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class ReportTheDice_UC6
    {
        public static void ReportingAboutDice()
        {
            int start = 0;
            const int noPlay = 1;
            const int snake = 2;
            const int ladder = 3;
            int position = 0;
            int dice, option;

            Random random = new Random();

            while (position <= 100)
            {
                dice = random.Next(1, 7);
                option = random.Next(1, 4);
                if (position < 0)
                {
                    position = 0;
                }
                switch (option)
                {
                    case noPlay:
                        position += 0;
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
}
