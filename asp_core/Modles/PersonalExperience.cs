using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class PersonalExperience
    {
        [Key]
        public int PersonalExperianceld { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }

        // علاقة مع جدول المستخدم (User)
        public User User { get; set; }
    }
}
