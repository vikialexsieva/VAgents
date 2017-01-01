namespace Vagents.Info.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using VAgents.Info.Model;
    using VAgents.Info.Model.Company;
    using VAgents.Info.Model.Events;
    using VAgents.Info.Model.Groups;
    using VAgents.Info.Model.Page;
    using VAgents.Info.Model.Products;
    using VAgents.Info.Model.Releases;
    using VAgents.Info.Model.Solution;
    using VAgents.Info.Model.User;
    using VAgents.Info.ViewModel.Solution;
    using VAgents.Info.ViewModel.ViewModels;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public IDbSet<GroupAllInfo> GroupAllInfoes { get; set; }
        public IDbSet<GroupImage> GroupImages { get; set; }
        public IDbSet<GroupsInfo> GroupsInfoes { get; set; }
        public IDbSet<GroupImageFile> GroupImageFiles { get; set; }
        public IDbSet<About> Abouts { get; set; }
        public IDbSet<PageAllInfo> PageAllInfoes { get; set; }
        public IDbSet<PageImage> PageImages { get; set; }
        public IDbSet<PageInfo> PageInfoes { get; set; }

        public IDbSet<UserAllInfo> UserAllInfos { get; set; }
        public IDbSet<UserFriendRequest> UserFriendRequests { get; set; }
        public IDbSet<UserInfo> UserInfoes { get; set; }
        public IDbSet<UserNewsFeed> UserNewsFeeds { get; set; }
        public IDbSet<UserPost> UserPosts { get; set; }
        public IDbSet<UserPostComment> UserPostComments { get; set; }
        public IDbSet<UserVideo> UserVideos { get; set; }

        public IDbSet<CompanyLogo> CompanyLogos { get; set; }
        public IDbSet<CompanyFeedBackClient> CompanyFeedBackClients { get; set; }
        public IDbSet<CompanyFeedBackCompany> CompanyFeedBackCompanyes { get; set; }
        public IDbSet<ForumPost> ForumPosts { get; set; }
        public IDbSet<ForumPostAnswer> ForumPostsAnswers { get; set; }
        public IDbSet<ForumPostCategory> ForumPostCategoryes { get; set; }
        public IDbSet<ForumPostSubCategory> ForumPostSubCategoryes { get; set; }
        public IDbSet<ForumPostVote> ForumPostVotes { get; set; }
        public IDbSet<CompanyMessage> CompanyMessages { get; set; }
        public IDbSet<CompanyInformation> CompanyInformations { get; set; }
        public IDbSet<CompanyContact> CompanyContacts { get; set; }
        public IDbSet<ReleaseHistory> Releases { get; set; }
        public IDbSet<Demos> Demos { get; set; }
        public IDbSet<DemoSample> DemoSamples { get; set; }
        public IDbSet<DemoRevue> DemoRevues { get; set; }
        public IDbSet<DemoAllInformation> DemoAllInformations { get; set; }
        public IDbSet<EventInformation> EventInformations { get; set; }
        public IDbSet<EventSocialLink> EventSocialLinks { get; set; }
        public IDbSet<Solutions> Solutions { get; set; }
        public IDbSet<SolutionSocialLink> SolutionSocialLinks { get; set; }
        public IDbSet<SolutionPackegeInclude> SolutionpackegeIncludes { get; set; }
        public IDbSet<SolutionPackage> SolutionPackages { get; set; }
        public IDbSet<SolutionCategory> SolutionCategoryes { get; set; }
        public IDbSet<SolutionDownloadLink> SolutionDownloadLinks { get; set; }
        public IDbSet<SolutionOtherInformation> SolutionOtherInformations { get; set; }

        public DbSet<UserLikeImage> UserLikeImages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<BusinessImage> BusinessImage { get; set; }
        public DbSet<BusinessInfo> Business { get; set; }
        public DbSet<BusinessPriceRange> BusinessPricerRanges { get; set; }
        public DbSet<BusinessOtherInfo> BusinessOtherInforos { get; set; }
        public DbSet<MusicCategory> MusicCategorys { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<NewsCategory> NewsCategoryes { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductContent> ProductContents { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<Followr> Followrs { get; set; }
        public DbSet<UserImageComment> UserImageComments { get; set; }
        public DbSet<UserImages> UserImages { get; set; }
        public DbSet<UserLike> UserLikes { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<UserMessageAnswer> UserMessageAnswers { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Marketing> Marketings { get; set; }
        public DbSet<Policy> Policies { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        public DbSet<VideoComment> VideoComments { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Politic> PoliticViewModels { get; set; }

        public DbSet<OtherContact> OtherContactViewModels { get; set; }

        public DbSet<OneVideoComment> OneVideoCommentViewModels { get; set; }

        public DbSet<Languege> LanguegeViewModels { get; set; }

        public DbSet<Jobs> JobsViewModels { get; set; }
        
        public DbSet<Family> FamilyViewModels { get; set; }
                      
        public DbSet<ByrnPlace> ByrnPlaces { get; set; }
        public DbSet<StaticPageURL> StaticPageUrls { get; set; }

        public DbSet<StaticPageUrlImage> StaticPageUrlImages { get; set; }
        
    }
}
