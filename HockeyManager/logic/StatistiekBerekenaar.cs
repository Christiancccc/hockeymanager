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
            /// aanvallers: x%, middenvelders: y%, verdedigers & keepers: z%
            int aanvallers = 0;
            int middenvelders = 0;
            int verdedigers = 0;
            int keepers = 0;
            int verKeepTotaal = 0;
            int totaal = 0;

            foreach (Speler speler in team.Spelers)
            {
                switch (speler.Positie)
                {
                    case Positie.Keeper:
                        keepers++;
                        break;
                    case Positie.Verdediger:
                        verdedigers++;
                        break;
                    case Positie.Middenvelder:
                        middenvelders++;
                        break;
                    case Positie.Aanvaller:
                        aanvallers++;
                        break;
                }
                totaal = aanvallers + keepers + middenvelders + verdedigers;
                verKeepTotaal = verdedigers + keepers;
            }
            float PerAanvallers = (float)aanvallers / (float)totaal * 100;
            float PerMiddenvelder = (float)middenvelders / (float)totaal * 100;
            float PerVerKeepTotaal = (float)verKeepTotaal / (float)totaal * 100;
            return "Aanvallers: " + PerAanvallers +
                   " Middenvelders: " + PerMiddenvelder +
                   " Verdedigers en Keepers: " + PerVerKeepTotaal;

        }

        public float GeefGemiddeldeLeeftijdVanTeam(Team team)
        {
            TimeSpan TotaalAantalDagen;
            int AantalSpelers = 0;
            TimeSpan GemLeeftijd;
            throw new NotImplementedException();
            //Je wil voor elke speler in team kijken wat de gemiddelde leeftijd is
            //1. zorg ervoor dat de huidige leeftijd wordt berekent.
            //2. Tel het aantal spelers
            //3. Zorg ervoor dat het totaal aantal dagen/jaren gedeeld wordt door het aantal spelers
            //Wat voor type moet ik gebruiken? / Moet ik een cast ergens plaatsen of niet? 
            foreach (Speler speler in team.Spelers)
            {
                TotaalAantalDagen = TotaalAantalDagen + (speler.GeboorteDatum - DateTime.Now);
                AantalSpelers++;
            }
            GemLeeftijd = TotaalAantalDagen / AantalSpelers;
        }
    }
}
