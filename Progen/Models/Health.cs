using System;
using System.Collections.Generic;
using System.Text;

namespace Progen.Models
{
    public class Health
    {
        public int Head { get; set; }
        public int Torso { get; set; }
        public int LArm { get; set; }
        public int RArm { get; set; }
        public int LLeg { get; set; }
        public int RLeg { get; set; }


        public Health InitHealth()
        {
            Health h = new Health();
            h.Head = 100;
            h.Torso = 100;
            h.LLeg = 100;
            h.LArm = 100;
            h.RLeg = 100;
            h.RArm = 100;

            return h;
        }

    }
}
