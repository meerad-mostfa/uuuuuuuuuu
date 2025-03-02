using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; }
      //  public int TeamId { get; set; }

        // العلاقة مع الفريق
        public ICollection<TeamsParticipant> TeamsParticipant { get; set; }
    }
}
