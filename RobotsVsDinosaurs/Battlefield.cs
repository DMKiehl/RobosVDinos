﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {

        //member variables
        Fleet fleet = new Fleet();
        Herd herd = new Herd();
       

        //constructor
        public Battlefield()
        {
            fleet.robotList = fleet.PullRobots();

            herd.dinoList = herd.PullDinos();
            
        }


        public int ChooseRobot()
        {
            Console.WriteLine("Please choose the number of the robot to battle: \n");
            foreach (Robot robot in fleet.robotList)
            {
                Console.WriteLine(robot.RobotType);
            }
            int robotInput = Convert.ToInt32(Console.ReadLine());
            return robotInput;
            
        }

        public int ChooseDino()
        {
            Console.WriteLine("Please type the number of the dinosaur to battle:\n");
            foreach (Dino dino in herd.dinoList)
            {
                Console.WriteLine(dino.DinoType);
                
                
            }
            int dinoInput = Convert.ToInt32(Console.ReadLine());
            return dinoInput;
        }
             
            

        public void Battle()
        {
            while (fleet.robotList.Count > 0 && herd.dinoList.Count > 0)
            {
                DinoAttack();
                RobotAttack();
            }
            DeclareWinner();
        }

        public void DeclareWinner()
        {
            if(fleet.robotList == null)
            {
                Console.WriteLine("Dinosaurs win!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Robots win!");
                Console.ReadLine();
            }
        }

        public void DinoAttack()
        {
            
            for (int i = 0; i < herd.dinoList.Count; i++)
            {
                int chosenRobot = ChooseRobot();
                if (chosenRobot == 1)
                {
                    Robot myRobot = fleet.robotList[0];
                    if (fleet.robotList[0].RobotHealth <= 0)
                    {
                        Console.WriteLine("This robot is dead. Please choose another.");
                    }

                    else
                    {
                        herd.dinoList[i].AttackRobot(myRobot);
                        if(myRobot.RobotHealth <= 0)
                        {
                            Console.WriteLine(myRobot.RobotType + " is dead.");
                            fleet.robotList.Remove(myRobot);
                            
                        }
                    }

                }
                else if (chosenRobot == 2)
                {
                    Robot myRobot = fleet.robotList[1];
                    if (fleet.robotList[1].RobotHealth <= 0)
                    {
                        Console.WriteLine("This robot is dead. Please choose another.");
                    }

                    else
                    {
                        herd.dinoList[i].AttackRobot(myRobot);
                        if (myRobot.RobotHealth <= 0)
                        {
                            fleet.robotList.Remove(myRobot);
                            Console.WriteLine(myRobot.RobotType + " is dead.");
                        }
                    }

                    //return myRobot;
                }
                else
                {
                    Robot myRobot = fleet.robotList[2];
                    if (fleet.robotList[2].RobotHealth <= 0)
                    {
                        Console.WriteLine("This robot is dead. Please choose another.");
                    }

                    else
                    {
                        herd.dinoList[i].AttackRobot(myRobot);
                        if (myRobot.RobotHealth <= 0)
                        {
                            Console.WriteLine(myRobot.RobotType + " is dead.");
                            fleet.robotList.Remove(myRobot);
                        }
                    }
                    
                }

            }






        }
        
        public void RobotAttack()
        {
            for(int i = 0; i < fleet.robotList.Count; i++)
            {
                int chosenDino = ChooseDino();
                if (chosenDino == 1)
                {
                    Dino myDino = herd.dinoList[0];
                    if (herd.dinoList[0].DinoHealth <= 0)
                    {
                        Console.WriteLine("This dino is dead. Please choose another.");
                    }
                    else
                    {
                        fleet.robotList[i].AttackDino(myDino);
                        if (myDino.DinoHealth <= 0)
                        {
                            Console.WriteLine(myDino.DinoType + " is dead.");
                            herd.dinoList.Remove(myDino);
                        }
                    }
                }
                else if (chosenDino == 2)
                {
                    Dino myDino = herd.dinoList[1];
                    if (herd.dinoList[1].DinoHealth == 0)
                    {
                        Console.WriteLine("This dino is dead. Please choose another.");
                    }
                    else
                    {
                        fleet.robotList[i].AttackDino(myDino);
                        if (myDino.DinoHealth <= 0)
                        {
                            Console.WriteLine(myDino.DinoType + " is dead.");
                            herd.dinoList.Remove(myDino);
                        }
                    }
                }
                else
                {
                    Dino myDino = herd.dinoList[2];
                    if (herd.dinoList[2].DinoHealth == 0)
                    {
                        Console.WriteLine("This dino is dead. Please choose another.");
                    }
                    else
                    {
                        fleet.robotList[i].AttackDino(myDino);
                        if (myDino.DinoHealth <= 0)
                        {
                            Console.WriteLine(myDino.DinoType + " is dead.");
                            herd.dinoList.Remove(myDino);
                        }
                    }
                }

            }

        }

        

        //public void AttackBattle()
        //{
            
            

         

        //    while(DinoHealth > 0 && RobotHealth > 0)
        //    {
        //        ////diceOne is Robot
        //        //int DinoRoll = RollDice();
        //        ////DiceTwo is Dino
        //        //int RobotRoll = RollDice();
        //        ////roll dice to determine random numbers

        //        //RoundWinner(DinoRoll, RobotRoll);

        //    }

        //   // DisplayBattleWinner(DinoHealth, RobotHealth);
        //}

        //public int RollDice()
        //{
        //    int min = 1;
        //    int max = 7;

        //    int result = myRandom.Next(min, max);

        //    return result;
        //}

        //public void RoundWinner(int DinoRoll, int RobotRoll)
        //{

        //    if (DinoRoll > RobotRoll)
        //    {
        //        //RobotHealth -= DinoAttackPower;
        //        Console.WriteLine("Robot Health = " + RobotHealth);
        //        Console.WriteLine("DinoHealth = " + DinoHealth);
        //        Console.ReadLine(); 
        //    }
        //    else if (RobotRoll > DinoRoll)
        //    {
        //        //DinoHealth -= WeaponPower;
        //        Console.WriteLine("Robot Health = " + RobotHealth);
        //        Console.WriteLine("DinoHealth = " + DinoHealth);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("No winner, battle again!");
        //        Console.ReadLine();
        //    }
        //}

        //public void DisplayBattleWinner(int DinoHealth, int RobotHealth)
        //{
        //    if (DinoHealth == 0)
        //    {
        //        Console.WriteLine("Robot wins!");
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dino wins!");
        //        Console.ReadLine();
        //    }

        //}
    }
}
