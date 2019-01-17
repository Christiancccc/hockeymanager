using HockeyManager.core.interfaces;
using HockeyManager.core.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.logic
{
    public class StatistiekBerekenaar : IStatistiekBerekenaar
    {
        //  Feeld
        Competitie competitie;

        //  Constructor
        public StatistiekBerekenaar(Competitie competitie)
        {
            this.competitie = competitie;

        }

        public string DefineerHandVerdeling(Team team)
        {
            int links = 0;
            int rechts = 0;
            int beide = 0;
            int totaal = 0;

            foreach (Speler speler in team.Spelers)
            {
                switch (speler.Hand)
                {
                    case Handvoorkeur.links:
                        links++;
                        break;
                    case Handvoorkeur.rechts:
                        rechts++;
                        break;
                    case Handvoorkeur.beide:
                        beide++;
                        break;
                }
                totaal = links + rechts + beide;
            }
            float perLinks = (float)links / (float)totaal * 100;
            float perRechts = (float)rechts / (float)totaal * 100;
            float perBeide = (float)beide / (float)totaal * 100;
            return "links: " + perLinks +
                " rechts: " + perRechts +
                " beide: " + perBeide;
        }

        public string DefineerPositieVerdeling(Team team)
        {
            throw new NotImplementedException();
        }

        public float GeefGemiddeldeLeeftijdVanTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
