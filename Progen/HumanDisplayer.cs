using System;
using System.Collections.Generic;
using System.Text;
using Progen.Models;


namespace Progen
{
    class HumanDisplayer
    {
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


        }



    }
}
