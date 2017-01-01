using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VAgents.Info.Model;

namespace VAgents.Info.ViewModels
{
    public class UserLikeViewModels
    {
        public int Id { get; set; }
        public string Like { get; set; }

        public static Expression<Func<UserLike, UserLikeViewModels>> ViewModel
        {
            get
            {
                return x => new UserLikeViewModels
                {
                    Like = x.Like
                };
            }
        }
    }
}
