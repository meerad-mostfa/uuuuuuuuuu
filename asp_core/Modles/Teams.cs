using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Teams : IdentityUser

    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string UniversityName { get; set; }
        public string Coach { get; set; }

        // العلاقات
        public ICollection<TeamsCompetition> TeamsCompetitions { get; set; }
        public ICollection<TeamsParticipant> TeamsParticipant { get; set; }
    }
}
