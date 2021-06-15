using System;
using Progen.Models;

namespace Progen
{
    class Program
    {

        public static void Main(string[] args)
        {
            int GenAmt;
            
            Console.WriteLine("How many people would you like to generate?");

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

                list[i] = GenerateSingleHuman();
            }

            MainSelectorDisplay(list);

            





        }

        public static HumanModel GenerateSingleHuman()
        {
            //Creating models to be assigned values from Model Methods
            HumanModel gen = new HumanModel();
            Appear app = new Appear();

            //Assigning Generated information
            gen.Gender = gen.AssignGender();
            gen.FName = gen.AssignFirstName(gen);
            gen.LName = gen.AssignLastName(gen);
            gen.Age = gen.AssignAge();
            gen.Childhood = gen.AssignChildhood();
            if (gen.Age >= 20)
            {
                gen.Adulthood = gen.AssignAdulthood();
            }
            gen.Appear = app;
            gen.Appear = gen.Appear.GenerateAppear();

            return gen;
        }

        public static void MainSelectorDisplay(HumanModel[] list)
        {
            PrintList(list);
            SelectHuman(list);
        }
        
        /// <summary>
        /// Prints out a list of all generated humans.  Shows Name, Age and Background.
        /// </summary>
        /// <param name="list">Humans to be displayed</param>
        public static void PrintList(HumanModel[] list)
        {
             for (int i = 0; (i < list.Length); i++)
               {
                   Console.Write("[" + (i + 1) + "] ");
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.Write(list[i].FName + " " + list[i].LName + "(" + list[i].Age + "), ");
                   Console.ForegroundColor = ConsoleColor.Cyan;
                   if (list[i].Age < 20)
                    {
                        Console.Write(list[i].Childhood);
                    }
                    else
                    {
                        Console.Write(list[i].Adulthood);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
        }

        public static void SelectHuman(HumanModel[] list)
        {
            HumanDisplayer disp = new HumanDisplayer();
            int humanSelect;
            Console.WriteLine("Look at all these people! You want more info on them?");
            while (!int.TryParse(Console.ReadLine(), out humanSelect))
            {

                Console.Clear();
                Console.WriteLine("Invalid Number!");
                PrintList(list);
                Console.Write("Which person would you like to inspect?");
            }
            if(humanSelect > list.Length)
            {
                Console.Clear();
                Console.WriteLine("No such human.");
                PrintList(list);
                SelectHuman(list);
            }
            disp.FullDisplay(list[humanSelect - 1]);
            Console.WriteLine("Press R to return to the list, or anything else to exit.");
            if (Console.ReadLine() == "R" || Console.ReadLine() == "r")
            {
                Console.Clear();
                MainSelectorDisplay(list);
            }


        }

    }
}
