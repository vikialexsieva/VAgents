using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VAgents.Info.Model.Solution
{
    public class Solutions
    {
        private ICollection<SolutionCategory> solutionCategory;
        private ICollection<SolutionDownloadLink> solutionDownloadLink;
        private ICollection<SolutionOtherInformation> solutionOtherInormation;
        private ICollection<SolutionPackage> solutionPackage;
        private ICollection<SolutionSocialLink> solutionSocialLink;
        public Solutions()
        {
            this.solutionCategory = new HashSet<SolutionCategory>();
            this.SolutionDownloadLink = new HashSet<SolutionDownloadLink>();
            this.solutionSocialLink = new HashSet<SolutionSocialLink>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]

        public string Description { get; set; }

        public int ImageId { get; set; }
        public virtual ICollection<SolutionCategory> SolutionCategory
        {
            get
            {
                return this.solutionCategory;
            }
            set
            {
                this.solutionCategory = value;
            }
        }
        public virtual ICollection<SolutionDownloadLink> SolutionDownloadLink
        {
            get
            {
                return this.solutionDownloadLink;
            }
            set
            {
                this.solutionDownloadLink = value;
            }
        }
        public virtual ICollection<SolutionOtherInformation> SolutionOtherInformation
        {
            get
            {
                return this.solutionOtherInormation;
            }
            set
            {
                this.solutionOtherInormation = value;
            }
        }

        public virtual ICollection<SolutionPackage> SolutionPackage
        {
            get
            {
                return this.solutionPackage;
            }
            set
            {
                this.solutionPackage = value;
            }
        }
        public virtual ICollection<SolutionSocialLink> SolutionSocialLink { get; set; }
        public decimal Price { get; set; }
    }
}
