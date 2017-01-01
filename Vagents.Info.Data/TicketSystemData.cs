namespace Vagents.Info.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using VAgencyes.Data.Models.Business;
    using VAgencyes.Data.Models.Groups;
    using VAgencyes.Data.Models.Page;
    using VAgents.Info.Model;
    using VAgents.Info.Model.Company;
    using VAgents.Info.Model.Events;
    using VAgents.Info.Model.Releases;
    using VAgents.Info.Model.Solution;
    using VAgents.Info.Model.User;

    public class TicketSystemData : ITicketSystemData
    {
        private readonly DbContext context;


        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public TicketSystemData(DbContext context)
        {
            this.context = context;
        }
      
        public IRepository<VAgents.Info.Model.Demos> Demos
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.Demos>();
            }
        }
        public IRepository<VAgents.Info.Model.DemoRevue> DemoRevues
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.DemoRevue>();
            }
        }

        public IRepository<VAgents.Info.Model.DemoAllInformation> DemoAllInformations
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.DemoAllInformation>();
            }
        }

        public IRepository<VAgents.Info.Model.DemoSample> DemoSamples
        {

            get
            {
                return this.GetRepository<VAgents.Info.Model.DemoSample>();
            }
        }


        public IRepository<ReleaseHistory> Releases
        {
            get
            {
                return this.GetRepository<ReleaseHistory>();
            }
        }

        public IRepository<ForumPost> ForumPosts
        {
            get
            {
                return this.GetRepository<ForumPost>();
            }
        }

        public IRepository<ForumPostAnswer> ForumPostAnswers
        {
            get
            {
                return this.GetRepository<ForumPostAnswer>();
            }
        }


        public IRepository<ForumPostCategory> ForumPostCategorys
        {
            get
            {
                return this.GetRepository<ForumPostCategory>();
            }
        }


        public IRepository<ForumPostSubCategory> ForumPostSubCategory
        {
            get
            {
                return this.GetRepository<ForumPostSubCategory>();
            }
        }

        public IRepository<ForumPostVote> ForumPostVotes
        {
            get
            {
                return this.GetRepository<ForumPostVote>();
            }
        }


        public IRepository<EventInformation> EventInformations
        {
            get
            {
                return this.GetRepository<EventInformation>();
            }
        }

        public IRepository<EventSocialLink> EventSocialLinks
        {
            get
            {
                return this.GetRepository<EventSocialLink>();
            }
        }

        public IRepository<Solutions> Solutions
        {
            get
            {
                return this.GetRepository<Solutions>();
            }
        }

        public IRepository<SolutionCategory> SolutionCategoryes
        {
            get
            {
                return this.GetRepository<SolutionCategory>();
            }
        }

        public IRepository<SolutionDownloadLink> SolutionDownloadLinks
        {
            get
            {
                return this.GetRepository<SolutionDownloadLink>();
            }
        }

        public IRepository<SolutionOtherInformation> SolutionOtherInformation
        {
            get
            {
                return this.GetRepository<SolutionOtherInformation>();
            }
        }

        public IRepository<SolutionPackage> SolutionPackages
        {
            get
            {
                return this.GetRepository<SolutionPackage>();
            }
        }

        public IRepository<SolutionPackegeInclude> SolutionPackageInxludes
        {
            get
            {
                return this.GetRepository<SolutionPackegeInclude>();
            }
        }

        public IRepository<SolutionSocialLink> SolutionSocilaLink
        {
            get
            {
                return this.GetRepository<SolutionSocialLink>();
            }
        }

        public IRepository<BusinessAllInfo> BusinessAllInfoes
        {
            get
            {
                return this.GetRepository<BusinessAllInfo>();

            }

        }

        public IRepository<BusinessContact> BusinessContacts
        {
            get
            {
                return this.GetRepository<BusinessContact>();
            }
        }
        

        public IRepository<BusinessImageFile> BusinessImageFiles
        {
            get
            {
                return this.GetRepository<BusinessImageFile>();
            }
        }

        public IRepository<VAgencyes.Data.Models.Business.BusinessInfo> BusinessInfoes
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.Business.BusinessInfo>();
            }
        }

        public IRepository<BusinessPost> BusinessPosts
        {
            get
            {
                return this.GetRepository<BusinessPost>();
            }
        }

        public IRepository<GroupAllInfo> GroupAllInfoes
        {
            get
            {
                return this.GetRepository<GroupAllInfo>();
            }
        }

        public IRepository<GroupImage> GroupImages
        {
            get
            {
                return this.GetRepository<GroupImage>();
            }
        }

        public IRepository<GroupsInfo> GroupsInfoes
        {
            get
            {
                return this.GetRepository<GroupsInfo>();
            }
        }

        public IRepository<GroupImageFile> GroupImageFiles
        {
            get
            {
                return this.GetRepository<GroupImageFile>();
            }
        }

        public IRepository<PageAllInfo> PageAllInfoes
        {
            get
            {
                return this.GetRepository<PageAllInfo>();
            }
        }

        public IRepository<PageImage> PageImages
        {
            get
            {
                return this.GetRepository<PageImage>();
            }
        }

        public IRepository<PageImageFile> PageImageFiles
        {
            get
            {
                return this.GetRepository<PageImageFile>();
            }
        }

        public IRepository<PageInfo> PageInfoes
        {
            get
            {
                return this.GetRepository<PageInfo>();
            }
        }

        public IRepository<VAgencyes.Data.Models.User.UserAllInfo> UserAllInfos
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserAllInfo>();
            }
        }

        public IRepository<VAgencyes.Data.Models.User.UserFriendRequest> UserFriendRequests
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserFriendRequest>();
            }
        }
        
        public IRepository<VAgencyes.Data.Models.User.UserInfo> UserInfoes
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserInfo>();
            }
        }
        
        public IRepository<VAgencyes.Data.Models.User.UserNewsFeed> UserNewsFeeds
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserNewsFeed>();
            }
        }
        

        public IRepository<VAgencyes.Data.Models.User.UserPost> UserPosts
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserPost>();
            }
        }

        public IRepository<VAgencyes.Data.Models.User.UserPostComment> UserPostComments
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserPostComment>();
            }
        }

        public IRepository<VAgencyes.Data.Models.User.UserVideo> UserVideos
        {
            get
            {
                return this.GetRepository<VAgencyes.Data.Models.User.UserVideo>();
            }
        }

        public IRepository<BusinessAllInfo> BusinessAllInfo
        {
            get
            {
                return this.GetRepository<BusinessAllInfo>();
            }


        }
        

        public IRepository<UserLikeImage> UserLikeImages
        {
            get
            {
                return this.GetRepository<UserLikeImage>();
            }
        }
        

        public IRepository<VAgents.Info.Model.BusinessInfo> Business
        {
            get
            {
               return this.GetRepository<VAgents.Info.Model.BusinessInfo>();
            }
        }

        public IRepository<BusinessAvatart> BusinessAvatar
        {
            get
            {
                return this.GetRepository<BusinessAvatart>();
            }
        }

        public IRepository<BusinessCategory> BusinessCategorys
        {
            get
            {
                return this.GetRepository<BusinessCategory>();
            }
        }
        

        public IRepository<BusinessOtherInfo> BusinessOtherInfos
        {
            get
            {
                return this.GetRepository<BusinessOtherInfo>();
            }
        }

        public IRepository<BusinessPriceRange> BusinessPriceRanges
        {
            get
            {
                return this.GetRepository<BusinessPriceRange>();
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                return this.GetRepository<Comment>();
            }
        }

        public IRepository<Marketing> Marketings
        {
            get
            {
                return this.GetRepository<Marketing>();
            }
        }

        public IRepository<Menus> Menus
        {
            get
            {
                return this.GetRepository<Menus>();
            }
        }

        public IRepository<News> News
        {
            get
            {
                return this.GetRepository<News>();
            }
        }

        public IRepository<NewsCategory> NewsCategorys
        {
            get
            {
                return this.GetRepository<NewsCategory>();
            }
        }

        public IRepository<MusicCategory> MusicCategoryes
        {
            get
            {
                return this.GetRepository<MusicCategory>();
            }
        }

        public IRepository<Point> Points
        {
            get
            {
                return this.GetRepository<Point>();
            }
        }

        public IRepository<ProductContent> ProductContent
        {
            get
            {
                return this.GetRepository<ProductContent>();
            }
        }

        public IRepository<ProductPrice> ProductPrices
        {
            get
            {
                return this.GetRepository<ProductPrice>();
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                return this.GetRepository<Product>();
            }
        }

        public IRepository<UserAvatar> UserAvatars
        {
            get
            {
                return this.GetRepository<UserAvatar>();
            }
        }
        
        
        public IRepository<UserLike> UserLikes
        {
            get
            {
                return this.GetRepository<UserLike>();
            }
        }
        
        public IRepository<VAgents.Info.Model.Events.EventInformation> EvetnInformations
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.Events.EventInformation>();
            }
        }

        public  IRepository<ApplicationUser> Users
        {
            get
            {
                return this.GetRepository<ApplicationUser>();
            }
        }

        public IRepository<VAgents.Info.Model.BusinessImage> BusinessImages
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.BusinessImage>();
            }
        }
        
        public IRepository<UserImages> UserImages 
        {
            get
            {
                return this.GetRepository<UserImages>();
            }
        }
        

        public IRepository<UserImageComment> UserImageComments
        {
            get
            {
                return this.GetRepository<UserImageComment>();
            }
        }

        public IRepository<UserMessageAnswer> UserMessageAnswers
        {
            get
            {
                return this.GetRepository<UserMessageAnswer>();
            }
        }

        public IRepository<UserMessage> UserMessages
        {
            get
            {
                return this.GetRepository<UserMessage>();
            }
        }
        

        public IRepository<EventSocialLink> EventSocialLink
        {
            get
            {
                return this.GetRepository<EventSocialLink>();
            }
        }

        public IRepository<About> About
        {
            get
            {
                return this.GetRepository<About>();
            }
        }

        public IRepository<CompanyContact> CompanyContact
        {
            get
            {
                return this.GetRepository<CompanyContact>();
            }
        }

        public IRepository<CompanyFeedBackClient> CompanyFeedBackClient
        {
            get
            {
                return this.GetRepository<CompanyFeedBackClient>();
            }
        }

        public IRepository<CompanyInformation> CompanyInformation
        {
            get
            {
                return this.GetRepository<CompanyInformation>();
            }
        }

        public IRepository<CompanyMessage> CompanyMessage
        {
            get
            {
                return this.GetRepository<CompanyMessage>();
            }
        }

        public IRepository<ReleaseHistory> Release
        {
            get
            {
                return this.GetRepository<ReleaseHistory>();
            }
        }

        public IRepository<Solutions> Solution
        {
            get
            {
                return this.GetRepository<Solutions>();
            }
        }

        public IRepository<SolutionSocialLink> SolutionSocialLink
        {
            get
            {
                return this.GetRepository<SolutionSocialLink>();
            }
        }

        public IRepository<SolutionDownloadLink> SolutionDownloadLink
        {
            get
            {
                return this.GetRepository<SolutionDownloadLink>();
            }
        }

        public IRepository<VAgents.Info.Model.DemoRevue> DemoRevue
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.DemoRevue>();
            }
        }

        public IRepository<VAgents.Info.Model.DemoSample> DemoSample
        {
            get
            {
                return this.GetRepository<VAgents.Info.Model.DemoSample>();
            }
        }

        public IRepository<ForumPost> ForumPost
        {
            get
            {
                return this.GetRepository<ForumPost>();
            }
        }

        public IRepository<ForumPostAnswer> ForumPostAnswer
        {
            get
            {
                return this.GetRepository<ForumPostAnswer>();
            }
        }

        public IRepository<Jobs> Jobs
        {
            get
            {
                return this.GetRepository<Jobs>();
            }
        }

        public IRepository<Languege> Languege
        {
            get
            {
                return this.GetRepository<Languege>();
            }
        }

        public IRepository<Politic> Politics
        {
            get
            {
                return this.GetRepository<Politic>();
            }
        }

        public IRepository<UserPost> UserPost
        {
            get
            {
                return this.GetRepository<UserPost>();
            }
        }

        public IRepository<School> School
        {
            get
            {
                return this.GetRepository<School>();
            }
        }

        public IRepository<Policy> Policy
        {
            get
            {
                return this.GetRepository<Policy>();
            }
        }

        public DbContext Context
        {
            get
            {
                return this.context;
            }

           
        }

        public IRepository<CompanyFeedBackCompany> CompanyFeedBackCompany
        {
            get
            {
                return this.GetRepository<CompanyFeedBackCompany>();
            }
            
        }

       public  IRepository<CompanyLogo> CompanyLogos
        {
            get
            {
                return this.GetRepository<CompanyLogo>();
            }
            
        }

        public IRepository<StaticPageURL> StatciPageURLs
        {
            get
            {
                return this.GetRepository<StaticPageURL>();
            }
        }

        public IRepository<StaticPageUrlImage> StaticPageUrlImage
        {
            get
            {
                return this.GetRepository<StaticPageUrlImage>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
