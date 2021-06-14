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
            for (int i = 0; (i < list.Length); i++)
            {
                Console.Write("[" + (i + 1) + "] ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(list[i].FName + " " + list[i].LName + "(" + list[i].Age + "), ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                if(list[i].Age < 20)
                {
                    Console.Write(list[i].Childhood);
                } else
                {
                    Console.Write(list[i].Adulthood);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        

        }

    }
}
