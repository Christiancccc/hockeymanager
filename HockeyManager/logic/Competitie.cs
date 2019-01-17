using HockeyManager.core.interfaces;
using HockeyManager.core.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.logic
{
    public class Competitie : ICompetitie
    {
        public List<Team> Teams;
        public List<Wedstrijd> Wedstrijden;
        public Competitie()
        {
            Teams = new List<Team>();
            Wedstrijden = new List<Wedstrijd>();
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void AddWedstrijd(Wedstrijd wedstrijd)
        {
            Wedstrijden.Add(wedstrijd);
        }

        public void PrintKlassement()
        {
            throw new NotImplementedException();
        }

        public void PrintTeamNamen()
        {
            foreach (Team team in Teams)
            {
                Console.WriteLine(team.Naam);
            }
        }


        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }

        public void RemoveWedstrijd(Wedstrijd wedstrijd)
        {
            Wedstrijden.Remove(wedstrijd);
        }

        public void SpelerTransfer(Speler speler, Team newTeam)
        {
            throw new NotImplementedException();
        }
    }
}
