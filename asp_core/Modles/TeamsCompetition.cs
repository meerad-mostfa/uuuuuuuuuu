using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class TeamsCompetition
    {
        public int TeamId { get; set; }
        public int CompetitionID { get; set; }
        public Teams Teams { get; set; }
        public Competition Competition { get; set; }
    }
}
