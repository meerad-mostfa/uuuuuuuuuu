using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class TeamsParticipant
    {
        public int TeamId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime Year { get; set; }
        public Teams Teams { get; set; }
        public Participant Participant { get; set; }
    }
}
