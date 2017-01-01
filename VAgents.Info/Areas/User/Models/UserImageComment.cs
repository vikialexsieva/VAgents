using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAgents.Info.ViewModels
{
   public class UserImageCommentViewModels
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Comment { get; set; } 
        public int UserImage { set; get; }
    }
}
