using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactapp.Models
{
    public class WestBracketModel
    {
        public WestBracketModel()
        {
            WestTeams = new List<TeamModel>
            {
                new TeamModel {Id = 1, SchoolName = "Gonzaga", Seed = 1},
                new TeamModel {Id = 2, SchoolName = "FDU", Seed = 16},
                new TeamModel {Id = 3, SchoolName = "Syracuse", Seed = 8},
                new TeamModel {Id = 4, SchoolName = "Baylor", Seed = 9},
                new TeamModel {Id = 5, SchoolName = "Marquette", Seed = 5},
                new TeamModel {Id = 6, SchoolName = "Murray State", Seed = 12},
                new TeamModel {Id = 7, SchoolName = "Florida State", Seed = 4},
                new TeamModel {Id = 8, SchoolName = "Vermont", Seed = 13},
                new TeamModel {Id = 9, SchoolName = "Buffalo", Seed = 6},
                new TeamModel {Id = 10, SchoolName = "St.Johns", Seed = 11}
            };
        }

        public List<TeamModel> WestTeams { get; set; }
    }
}
