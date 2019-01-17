using HockeyManager.core.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.core.interfaces
{
    interface ICompetitie
    {
        void AddTeam(Team team);
        void RemoveTeam(Team team);
        void AddWedstrijd(Wedstrijd wedstrijd);
        void RemoveWedstrijd(Wedstrijd wedstrijd);
        void SpelerTransfer(Speler speler, Team newTeam);
        void PrintKlassement();
        void PrintTeamNamen();
    }
}
