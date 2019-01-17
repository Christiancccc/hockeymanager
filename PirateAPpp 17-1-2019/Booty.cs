using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateAPpp_17_1_2019
{
    public class Booty
    {
        public Booty(BountyType bounty, int value)
        {
            Bounty = bounty;
            Value = value;
        }

        public BountyType Bounty { get; private set; }
        public int Value { get; private set; }
    }
}
