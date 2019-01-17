using HockeyManager.core.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.core.interfaces
{
    interface IStatistiekBerekenaar
    {
        float GeefGemiddeldeLeeftijdVanTeam(Team team);

        /// <summary>
        /// output should be:
        /// links: x%, rechts: y%, beide: z%
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        string DefineerHandVerdeling(Team team);

        /// <summary>
        /// output should be:
        /// aanvallers: x%, middenvelders: y%, verdedigers & keepers: z%
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        string DefineerPositieVerdeling(Team team);
    }
}
