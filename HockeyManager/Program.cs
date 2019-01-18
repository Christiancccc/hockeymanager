using HockeyManager.core.interfaces;
using HockeyManager.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    class Program
    {
        static Competitie competitie;
        static StatistiekBerekenaar statistiekBerekenaar;

        static void Main(string[] args)
        {
            competitie = new Competitie();
            competitie = CompetitieMaker.MaakCompetitie();
            statistiekBerekenaar = new StatistiekBerekenaar(competitie);

            Console.WriteLine("Ik ben de hockey manager");

            string command = "";

            while (command != "Close")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "Show all teams":
                        competitie.PrintTeamNamen();
                        break;
                    case "Show klassement":
                        competitie.PrintKlassement();
                        break;
                    case "Show handvoorkeur":
                        Console.WriteLine(
                        statistiekBerekenaar.DefineerHandVerdeling(competitie.Teams[0]));
                        break;
                    case "Show positie":
                        Console.WriteLine(statistiekBerekenaar.DefineerPositieVerdeling(competitie.Teams[0]));
                        break;
                    default:
                        Console.WriteLine("I dont recognize that command");
                        break;
                }
            }
        }
    }
}
