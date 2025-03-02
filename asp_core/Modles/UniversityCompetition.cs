using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class UniversityCompetition
    {
        public int UniversityId { get; set; }
        public int CompetitionID { get; set; }
public University University { get; set; }
        public Competition Competition { get; set; }    

    }
}
