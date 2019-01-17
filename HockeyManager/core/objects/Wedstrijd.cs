using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.core.objects
{
    public class Wedstrijd
    {
        public Wedstrijd(Team teamThuis, Team teamUit, int goalsThuis, int goalsUit)
        {
            TeamUit = teamUit;
            TeamThuis = teamThuis;
            GoalsUit = goalsUit;
            GoalsThuis = goalsThuis;
        }

        public Team TeamUit { get; private set; }
        public Team TeamThuis { get; private set; }
        public int GoalsUit { get; private set; }
        public int GoalsThuis { get; private set; }

        public Team GeefWinnaar()
        {
            if (GoalsThuis > GoalsUit)
            {
                return TeamThuis;
            }
            else if (GoalsUit > GoalsThuis)
            {
                return TeamUit;
            }
            else
            {
                return null;
            }
        }

        public Team GeefVerliezer()
        {
            if (GoalsThuis < GoalsUit)
            {
                return TeamThuis;
            }
            else if (GoalsUit < GoalsThuis)
            {
                return TeamUit;
            }
            else
            {
                return null;
            }
        }
    }
}
