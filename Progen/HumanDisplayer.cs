using System;
using System.Collections.Generic;
using System.Text;
using Progen.Models;


namespace Progen
{
    class HumanDisplayer
    {
        /// <summary>
        /// Displays all information on a single Human
        /// </summary>
        /// <param name="h">Human to be displayed</param>
        public void FullDisplay(HumanModel h)
        {
            string gSingular;
            string g3rdPerson;
            string gPossess;

            Console.Clear();
            if(h.Gender == "Male")
            {
                gSingular = "He";
                g3rdPerson = "Him";
                gPossess = "His";
            }
            else
            {
                gSingular = "She";
                g3rdPerson = "Her";
                gPossess = "Her";
            }

            Console.WriteLine(h.FName + " " + h.LName + " " + h.Age + " years old. " +
                h.Gender + ".");
            Console.WriteLine();
            Console.WriteLine(h.FName + " has " + h.Appear.eyes + " eyes and " +
                h.Appear.hair + " hair. " + gSingular + " is " + h.Appear.weight +
                " and " + h.Appear.height);
            Console.WriteLine();
            Console.WriteLine("As a child, " + h.FName + " was a " + h.Childhood);

            if(h.Age >= 20)
            {
                Console.WriteLine(gSingular + " would become a " + h.Adulthood +
                    " later in life.");
            }
            Console.WriteLine("Health");
            Console.WriteLine("Head: " + h.Health.Head);
            Console.WriteLine("Torso: " + h.Health.Torso);
            Console.WriteLine("Left Arm: " + h.Health.LArm);
            Console.WriteLine("Right Arm : " + h.Health.RArm);
            Console.WriteLine("Left Leg: " + h.Health.LLeg);
            Console.WriteLine("Right Leg: " + h.Health.RLeg);


        }



    }
}
