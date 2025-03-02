using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class University : IdentityUser
    {

        [Key]
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }

        // العلاقات
        public ICollection<User> Users { get; set; }

        public ICollection<UniversityCompetition> universityCompetitions { get; set; }

    }
}
