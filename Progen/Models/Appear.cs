using System;
using System.Collections.Generic;
using System.Text;

namespace Progen.Models
{
    public class Appear
    {
        Random rand = new Random();

        public string[] hairColors = new[] { "Blonde", "Blue", "Red", "Black", "Bald", "Brown", "Green", "Orange" };
        public string[] eyeColors = new[] { "Blue", "Hazel", "Red", "Black", "Brown", "Green" };
        public string[] heights = new[] { "Very Short", "Short", "Average", "Tall", "Very Tall" };
        public string[] weights = new[] { "Very Thin", "Thin", "Average Weight", "Chubby", "Overweight", "Obese" };
        public string hair { get; set; }
        public string eyes { get; set; }
        public string height { get; set; }
        public string weight { get; set; }

        public Appear GenerateAppear()
        {
            Appear a = new Appear();
            a.hair = a.PickHair();
            a.eyes = a.PickEyes();
            a.height = a.PickHeight();
            a.weight = a.PickWeight();
            return a;
        }

        public string PickHair()
        {
            string hair = hairColors[rand.Next(0, hairColors.Length - 1)];
            return hair;
        }

        public string PickEyes()
        {
            string e = eyeColors[rand.Next(0, eyeColors.Length - 1)];
            return e;
        }
        public string PickHeight()
        {
            string h = heights[rand.Next(0, heights.Length - 1)];
            return h;
        }
        public string PickWeight()
        {
            string w = weights[rand.Next(0, weights.Length - 1)];
            return w;
        }



    }

}

