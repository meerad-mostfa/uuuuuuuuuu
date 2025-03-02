using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Rule
    {
        [Key]
        public int RuleID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // علاقة مع جدول المستخدم (User)
        public User User { get; set; }
    }
}
