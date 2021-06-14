using System;
using System.Collections.Generic;
using System.Text;

namespace Progen
{
    public class HumanGenerator
    {
        Random rand = new Random();
        public int AssignGender()
        {
            return rand.Next(0, 1);
        }
    }
}
