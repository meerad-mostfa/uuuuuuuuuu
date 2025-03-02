using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey("User")]
        public int Userld { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
     //   public int Authorld { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }

        // علاقة مع جدول المستخدم (User) - المنشور كتبه مستخدم واحد
        public User User { get; set; }
    }
}
