using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.core.objects
{
    public class Team
    {
        public Team(string naam, List<Speler> spelers)
        {
            Naam = naam;
            Spelers = spelers;
        }

        public string Naam { get; private set; }
        public List<Speler> Spelers { get; private set; }

        public void AddSpeler(Speler speler)
        {
            Spelers.Add(speler);
            
        }
        public void RemoverSpeler(Speler speler)
        {
            Spelers.Remove(speler);
        }
    }
}
