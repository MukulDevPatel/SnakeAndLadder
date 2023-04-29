using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadderPlay
    {
        //Die show the number between 1 to 6
        int playerPosition = 0;
        Random random = new Random();
        public void RollDie()
        {
            int die = random.Next(1, 7);
            Console.WriteLine(die);
        }
    }
}
