using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VAgents.Info.Model;

namespace VAgents.Info.ViewModels
{
    public class UserImagesViewModels
    {
        public int Id { get; set; }

        public static Expression<Func<UserImages, UserImagesViewModels>> ViewModel
        {
            get
            {
                return x => new UserImagesViewModels
                {
                    Id = x.Id
                };
            }
        }
    }
}
