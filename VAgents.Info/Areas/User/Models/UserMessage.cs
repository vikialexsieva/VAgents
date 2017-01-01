using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VAgents.Info.Model;

namespace VAgents.Info.ViewModels
{
    public class UserMessageViewModels
    {   public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreationTime { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public ICollection<UserMessageAnswerViewModels> UserAnswerMessage { get; set; }

        public static Expression<Func<UserMessage, UserMessageViewModels>> ViewModel
        {
            get
            {
                return x => new UserMessageViewModels
                {
                    Message = x.Message,
                    CreationTime = x.CreationTime,
                    
                }; 
            }
        }
    }
}
