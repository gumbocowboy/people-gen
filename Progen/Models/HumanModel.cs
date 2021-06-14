using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Progen.Models
{
    public class HumanModel
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public HumanModel[] Parents { get; set; }
        public HumanModel Spouse { get; set; }
        public HumanModel[] Children { get; set; }
        public string Childhood { get; set; }
        public string Adulthood { get; set; }


        Random rand = new Random();
        /// <summary>
        /// Randomly chooses between Male and Female
        /// </summary>
        /// <returns>Male or Female</returns>
        public string AssignGender()

        {
            int r = rand.Next(2);
            if (r == 0)
            {
                return "Female";
            }
            else {
                return "Male";
            }
        }

        /// <summary>
        /// Randomly selects a first name based on the gender.
        /// </summary>
        /// <param name="h">The Human to be named</param>
        /// <returns>Random Name</returns>
        public string AssignFirstName(HumanModel h)
        {
            string fName;
            //Obtaining Name Files
            var femaleNames = File.ReadAllLines("..\\..\\..\\Names\\fNames.txt");
            var maleNames = File.ReadAllLines("..\\..\\..\\Names\\mNames.txt");
           
            if (h.Gender == "Male")
            {
                var randName = rand.Next(0, maleNames.Length - 1);
                var mFirst = maleNames[randName];
                fName = mFirst.ToString();
                return fName;
            }
            else
            {
                var randName = rand.Next(0, femaleNames.Length - 1);
                var fFirst = femaleNames[randName];
                fName = fFirst.ToString();
                return fName;
             }

        }
        /// <summary>
        /// Generates a last name for a human
        /// </summary>
        /// <param name="h">Human to be given last name</param>
        /// <returns>Last name</returns>
        public string AssignLastName(HumanModel h)
        {
            var lastNames = File.ReadAllLines("..\\..\\..\\Names\\surnames.txt");
            var randName = rand.Next(0, lastNames.Length - 1);
            var finalLast = lastNames[randName];
            return finalLast.ToString();
        }
        /// <summary>
        /// Generates a random age.
        /// </summary>
        /// <returns>Age as int</returns>
        public int AssignAge()
        {
            int age;
            int grouping = rand.Next(1, 100);
            //Child
            if (grouping <= 15)
            {
                age = rand.Next(1, 12);

            }
            //Teen-ish
            else if (grouping <= 45)
            {
                age = rand.Next(13, 22);

            }
            //Adult
            else if (grouping <= 75)
            {
                age = rand.Next(23, 49);
            }
            //Senior
            else
            {
                age = rand.Next(50, 100);
            }

            return age;
        }

        public string AssignChildhood()
        {
            var bgs = File.ReadAllLines("..\\..\\..\\BGs\\childhood.txt");
            var r = rand.Next(0, bgs.Length - 1);
            var ret = bgs[r];
            return ret.ToString();

        }
        public string AssignAdulthood()
        {
            var bgs = File.ReadAllLines("..\\..\\..\\BGs\\adulthood.txt");
            var r = rand.Next(0, bgs.Length - 1);
            var ret = bgs[r];
            return ret.ToString();

        }

    }
}
