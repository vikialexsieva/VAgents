using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VAgents.Info.Model;

namespace VAgents.Areas.Users.Models
{
    public class ListUserImageCommentViewModel
    {
        public int Id { get; set; }
        
        public string Content { get; set; }
        public string AuthorUserName { get; internal set; }
    }
}