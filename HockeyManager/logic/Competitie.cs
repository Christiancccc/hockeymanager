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
           //Ik ben bezig met een competitie 
           //3 punten voor een win, 1 punt aan beide teams voor een gelijk 
           //ik zit na te denken over hoe ik geefwinnaar en geefverliezer ga gebruiken. 
           //in Wedstrijd.cs hebben we een soort gelijke code geschreven.
           //Daarin hebben we TeamUit en TeamThuis laten returnen. 
           //Hoe gebruik ik die hierin? Inprincipe kan je daar toch punten aan koppelen 
           //en zo kun je dan bepalen door een if statement welk team de meeste punten heeft
           //en ze op die volgorde displayen doormiddel van geschreven code in Program.cs
           
           
            foreach(Wedstrijd wedstrijd in Wedstrijden)
            {
                int PuntenThuis = 0;
                int PuntenUit = 0;



                if (wedstrijd.GoalsThuis > wedstrijd.GoalsUit)
                {
                     PuntenThuis = PuntenThuis + 3;
                }
                else if (wedstrijd.GoalsUit > wedstrijd.GoalsThuis)
                {
                    PuntenUit = PuntenUit + 3;
                }
                else
                {
                    PuntenUit++;
                    PuntenThuis++;
                }
                
                if (PuntenThuis > PuntenUit)
                {
                    
                }

                else 
                return "Winaars: " + wedstrijd.GeefWinnaar() + " Aantal goals: " + wedstrijd.
                   " Verliezer: " + wedstrijd.GeefVerliezer() + " Aantal goals: " + wedstrijd.
                  
            }
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
            //Hoe wil je een speler overzetten in een console applicatie? 
            //maak 2 teams aan. Laat ze de namenlijst opnoemen. 
            //Zorg ervoor dat de speler overgezet wordt
            //Ik snap niet goed hoe je het doet zonder dat je de speler aandrukt/selecteerd. 
            //je hebt de optie "selected" player niet. 
            //Anders kon je doormiddel van een foreach en een while uit de voeten komen 
            //Wat ik nu ga proberen: Voor elk team in de aangemaakte teams moet die gaan
            //kijken in welk team die naam zit. Hieruit verwijderd die de naam en voegt die 
            //de naam toe aan het nieuwe team. 

            foreach (Team team in Teams)
            {
                if (team.Naam == team.Naam)
                {

                }
            }
            
        }
    }
}
