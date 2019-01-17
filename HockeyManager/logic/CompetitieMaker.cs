using HockeyManager.core.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.logic
{
    public static class CompetitieMaker
    {
        public static Competitie MaakCompetitie()
        {
            Competitie competitie = new Competitie();
            List<Speler> spelers = new List<Speler>() {
                new Speler("Lloyd", new DateTime(1999, 1, 8), Positie.Middenvelder, Handvoorkeur.beide),
                new Speler("Christian", new DateTime(2000, 7, 7), Positie.Middenvelder, Handvoorkeur.links),
                new Speler("Piet", new DateTime(2002, 1, 8), Positie.Keeper, Handvoorkeur.rechts),
                new Speler("Henk", new DateTime(2030, 1, 8), Positie.Middenvelder, Handvoorkeur.beide)


           };
            Team[] teams = {
                new Team("team 1", spelers),
                new Team("team 2", new List<Speler>())
            };
            Wedstrijd[] wedstrijden = {
                new Wedstrijd(teams[0], teams[1], 2, 0)
            };
            foreach (Team team in teams)
                competitie.AddTeam(team);

            foreach (Wedstrijd wedstrijd in wedstrijden)
                competitie.AddWedstrijd(wedstrijd);

            return competitie;
        }
    }
}
