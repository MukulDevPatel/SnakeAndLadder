using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadderPlay
    {
        //Check No play, Snake, Ladder condotion

        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        
        int playerPosition = 0;
        
        Random random = new Random();
        public int RollDie()
        {
            return new Random().Next(1,7);
        }
        public void Play()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("No player for game");
                    break;
                case LADDER:
                    this.playerPosition += RollDie();
                    Console.WriteLine("Ladder - moved ahead " + RollDie());
                    break;
                case SNAKE:
                    this.playerPosition -= RollDie();
                    Console.WriteLine("Snake - move behind " + RollDie());
                    break;
            }
        }
    }
}
