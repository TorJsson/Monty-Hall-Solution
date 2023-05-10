using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Monty_Hall___WF
{
    using System;

    namespace MontyHallSimulation
    {
        internal class Game
        {
            private int winningDoor;
            private int[] doors;



            //Constructor that initializes the game by randomly choosing a winning door.
            public Game()
            {
                Random random = new Random(3);
                doors = new int[3] { 0, 0, 0 };
                winningDoor = random.Next(1, 4);
                doors[winningDoor - 1] = 1;
            }


            //Generate a random loosing door to the player, dependent on the first door choice and what is the winning door.
            public int RandomizeLoosingDoor(int chosenDoor)
            {
                int loosingDoor = -1;
                for (int i = 0; i < 3; i++)
                {
                    if (i != chosenDoor && i != winningDoor)
                    {
                        loosingDoor = i;
                        break;
                    }
                }
                return loosingDoor;
            }

            public bool WinOrNot(int chosenDoor, bool changeDoor)
            {
                if (changeDoor)
                {
                    //Creates a sequence of integers (0, 1, 2). Looks for the index of the remaining door that is not the chosen door nor losing door
                    int newDoor = Enumerable.Range(0, 3)
                        .Where(i => i != chosenDoor && i != RandomizeLoosingDoor(chosenDoor))
                        .FirstOrDefault();

                    //Switch to the new door if one is found
                    if (newDoor >= 0 && newDoor < 3)
                    {
                        chosenDoor = newDoor;
                    }
                }
                //Determine if the chosen door is a winning door depending on if its a match
                return doors[chosenDoor - 1] == winningDoor;
            }

        }
    }
}