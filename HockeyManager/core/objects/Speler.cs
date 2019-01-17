using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.core.objects
{
    public class Speler
    {
        public Speler(string naam, DateTime geboorteDatum, Positie positie, Handvoorkeur hand)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Positie = positie;
            Hand = hand;
        }

        public string Naam { get; private set; }
        public DateTime GeboorteDatum { get; private set; }
        public Positie Positie { get; private set; }
        public Handvoorkeur Hand { get; private set; }
    }
}
