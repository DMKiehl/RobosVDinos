using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {

        //member variables
        Random myRandom = new Random();

        //constructor
        public Battlefield()
        {

        }



        //Initiates the battle
        public void InitiateBattle()
        {

            Fleet fleet = new Fleet();
            Herd herd = new Herd();

            fleet.robotList = fleet.PullRobots();

            herd.dinoList = herd.PullDinos();

            Console.WriteLine(herd.dinoList);
            Console.ReadLine();

            

        }

        public string ChooseRobot()
        {
            Console.WriteLine("Please choose a robot to battle");
            string robotInput = Console.ReadLine();
            return robotInput;
            
        }

        public string ChooseDino()
        {
            Console.WriteLine("Please choose a dinosaur to battle");
            string dinoInput = Console.ReadLine();
            return dinoInput;
        }


        public void AttackBattle()
        {
            string chosenDino = ChooseDino();

            string chosenRobot = ChooseRobot();

            while(dinoHealth > 0 && robotHealth > 0)
            {
                //diceOne is Robot
                int DinoRoll = RollDice();
                //DiceTwo is Dino
                int RobotRoll = RollDice();
                //roll dice to determine random numbers

                RoundWinner(DinoRoll, RobotRoll);

            }
        }

        public int RollDice()
        {
            int min = 1;
            int max = 7;

            int result = myRandom.Next(min, max);

            return result;
        }

        public void RoundWinner(int DinoRoll, int RobotRoll)
        {

            if (DinoRoll > RobotRoll)
            {
                //    health -= attackPower;
            }
            else if (RobotRoll > DinoRoll)
            {

            }
            else
            {
                //fight again.
            }
        }

        public void DisplayWinner()
        {

        }
    }
}
