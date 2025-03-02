using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Sponsor
    {
        [Key]
        public int SponsorID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public ICollection<SponsorComptiition> SponsorComptiition { get; set; }
    }
}
