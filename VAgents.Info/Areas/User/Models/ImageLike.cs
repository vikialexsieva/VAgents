using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAgents.Info.ViewModels
{
    public class ImageLikeViewModels
    {
        public int Id { get; set; }
        public bool Like { get; set; }
        public virtual UserImagesViewModels userImage { get; set; }
    }
}
