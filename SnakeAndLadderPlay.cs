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
        //This game are played by two player

        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int count = 0;
        int playerPosition1 = 0;
        int playerPosition2 = 0;
        int currentPlayer = 1;
        bool ladder = false;

        //Random Die value
        Random random = new Random();
        public int RollDie()
        {
            int die = random.Next(1, 7); 
            Console.WriteLine("Die value: " + die);
            count++;
            return die;
        }


        //Player get random die value amd move Snake and Ladder position
        //If player get number over the 100, They are stay in same postion
        public void Play()
        {
            while (this.playerPosition1 < WINNING_POSITION && this.playerPosition2 < WINNING_POSITION)
            {
                ladder = false;
                int option = random.Next(1, 3);

                //Assign current player position to players position 
                int currentPlayerPosition;
                if (currentPlayer == 1)
                {
                    currentPlayerPosition = this.playerPosition1;
                }
                else
                {
                    currentPlayerPosition = this.playerPosition2;
                }

                //Both player get their die value one by one
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No player for game");
                        break;
                    case LADDER:
                        currentPlayerPosition += RollDie();
                        Console.WriteLine("Ladder - moved ahead " + RollDie());
                        break;
                    case SNAKE:
                        currentPlayerPosition = RollDie();
                        if (currentPlayerPosition - RollDie() > 0)
                            currentPlayerPosition -= RollDie();
                        else
                            currentPlayerPosition = 0;
                        Console.WriteLine("Snake - move behind " + RollDie());
                        break;
                }

                if (currentPlayerPosition < 0)
                {
                    Console.WriteLine("You {0} went zero. So restart game from 0",currentPlayer);
                    Console.WriteLine("Player position:  " + currentPlayer);
                    //Console.WriteLine("Die count: " + count);

                }
                else if (currentPlayerPosition > 100)
                {
                    currentPlayerPosition -= RollDie();
                    Console.WriteLine("You get number over to 100, So stay in same position "+currentPlayer);
                }
                if (currentPlayer == 1)
                {
                    playerPosition1 = currentPlayerPosition;
                }else
                {
                    playerPosition2 = currentPlayerPosition;
                }
                Console.WriteLine("Player 1: " + playerPosition1);
                Console.WriteLine("Player 2: " + playerPosition2);
                
                if (currentPlayerPosition == 100)
                {
                    Console.WriteLine("Congrats! "+currentPlayer+ ", You have reached winning position 100");
                    break;
                }

                //If ladder is not obtained, switch to other player
                if (!ladder)
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }
            
            //Check which player in case game did not end while loop
            if (playerPosition1 == 100 && playerPosition2 == 100)
            {
                Console.WriteLine("It is tie");
            }else if(playerPosition1 == 100)
            {
                Console.WriteLine("Player 1 won the game");
            }
            else
            {
                Console.WriteLine("Player 2 won the game");
            }
            Console.WriteLine("Number of die roll to win: " + count);
        }
    }
}
