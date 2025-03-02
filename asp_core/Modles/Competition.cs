using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Competition
    {
        [Key]
        public int CompetitionID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public int SponsorID { get; set; }
        public string Image { get; set; }
        public ICollection<UniversityCompetition> universityCompetitions { get; set; }
        public ICollection<SponsorComptiition> SponsorComptiition {  get; set; }
        public ICollection<TeamsCompetition> TeamsCompetitions { get; set; }
    }
}
