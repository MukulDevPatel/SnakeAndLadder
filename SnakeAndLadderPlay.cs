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

        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int count = 0;
        int playerPosition = 0;

        //Random Die value
        Random random = new Random();
        public int RollDie()
        {
            int die = random.Next(1, 7); ;
            Console.WriteLine("Die value: " + die);
            count++;
            return die;
        }


        //Player get random die value amd move Snake and Ladder position 
        public void Play()
        {
            while (this.playerPosition < WINNING_POSITION)
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
                if (this.playerPosition == 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("You went zero. So restart game from 0");
                }
                if (this.playerPosition == WINNING_POSITION)
                {
                    Console.WriteLine("Player position: " + playerPosition);
                }
            }
        }
    }
}
