using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    //: IdentityUser<int>
    public class User 
    {
        public int UserId { get; set; }

        [Key]
        public int Userid { get; set; }

        [ForeignKey("University")]
        public int UniversityId { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string University { get; set; }
        public string Image { get; set; }
        public string GithubLink { get; set; }
        public string LinkedInLink { get; set; }
        public string Cv { get; set; }

        // علاقة مع جدول المنشورات (Post) - قائمة بالمنشورات التي كتبها المستخدم
        public ICollection<Post> Posts { get; set; }

        // علاقة مع جدول الأدوار (Role) - المستخدم لديه دور واحد
        // public Role Role { get; set; }

        // علاقة مع جدول الجامعة (University) - المستخدم ينتمي إلى جامعة واحدة
        public University Universitys { get; set; }

        // علاقة مع جدول الخبرات الشخصية (PersonalExperience)
        public PersonalExperience PersonalExperience { get; set; }

        public ICollection<QAA> QAAs {  get; set; }
        public ICollection<Rule> Rules { get; set; }


    }
}
