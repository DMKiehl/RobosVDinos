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


        //constructor



        //member methods

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
        //while()
        //Console.WriteLine("Please choose a robot to battle");
        //string robotInput = Console.ReadLine();
        //Console.WriteLine("Please choose a dinosaur to battle");
        //string dinoInput = Console.ReadLine();
    }
}
