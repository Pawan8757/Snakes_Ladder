using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Dice_UC2
    {
        public static void FindingDiceValue()
        {
            int initialValue = 0, FinalValue = 0;
            
            Random random = new Random();
            int number = random.Next(1, 7);

            Console.WriteLine(number);
        }
    }
}
