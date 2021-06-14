using System;
using Progen.Models;

namespace Progen
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("How many people would you like to generate?");
            int GenAmt;
            while(!int.TryParse(Console.ReadLine(), out GenAmt))
            {
                Console.Clear();
                Console.WriteLine("Invalid Number!");
                Console.Write("How many people would you like to generate?");
            }
            HumanModel[] list = new HumanModel[GenAmt];

            // HUMAN GENERATION ASSIGNED HERE
            //----------------------------------------------------------
            for (int i = 0; i < GenAmt; i++)
            {
                HumanModel gen = new HumanModel();
                gen.Gender = gen.AssignGender();
                gen.FName = gen.AssignFirstName(gen);
                gen.LName = gen.AssignLastName(gen);
                gen.Age = gen.AssignAge();
                gen.Childhood = gen.AssignChildhood();
                if (gen.Age >= 20)
                {
                    gen.Adulthood = gen.AssignAdulthood();
                }
                list[i] = gen;

            }

            //PRINTING GENERATED HUMANS
            for (int i = 0; (i < list.Length ); i++)
            {
                Console.WriteLine("[" + (i+ 1) + "]" + list[i].FName + " " + list[i].LName + " " + list[i].Gender + " " + list[i].Age + ", " + "Childhood: " + list[i].Childhood + " Adulthood:" + list[i].Adulthood);
            }
        

        }

    }
}
