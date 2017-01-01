namespace Vagents.Info.Data
{
    using System.Data.Entity;
    using VAgents.Info.Model.Company;
    using VAgents.Info.Model;
    using VAgents.Info.Model.Events;
    using VAgents.Info.Model.User;
    using VAgents.Info.Model.Releases;
    using VAgents.Info.Model.Solution;

    public interface ITicketSystemData
    {
        IRepository<UserLikeImage> UserLikeImages { get; }
        IRepository<ApplicationUser> Users { get; }
        IRepository<BusinessInfo> Business { get; }
        IRepository<BusinessAvatart> BusinessAvatar { get; }
        IRepository<BusinessCategory> BusinessCategorys { get; }
        IRepository<BusinessImage> BusinessImages { get; }
        IRepository<BusinessOtherInfo> BusinessOtherInfos { get; }
        IRepository<BusinessPriceRange> BusinessPriceRanges { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Marketing> Marketings { get; }
        IRepository<Menus> Menus { get; }
        IRepository<News> News { get; }
        IRepository<NewsCategory> NewsCategorys { get; }
        IRepository<MusicCategory> MusicCategoryes { get; }
        IRepository<Point> Points { get; }
        IRepository<ProductContent> ProductContent { get; }
        IRepository<ProductPrice> ProductPrices { get; }
        IRepository<Product> Products { get; }
        IRepository<UserAvatar> UserAvatars { get; }
        IRepository<UserImageComment> UserImageComments { get; }
        IRepository<UserImages> UserImages { get; }
        IRepository<UserLike> UserLikes { get; }
        IRepository<UserMessageAnswer> UserMessageAnswers { get; }
        IRepository<UserMessage> UserMessages { get; }
        IRepository<EventInformation> EvetnInformations { get; }
        IRepository<EventSocialLink> EventSocialLink { get; }
        IRepository<About> About { get; }
        IRepository<CompanyContact> CompanyContact { get; }
        IRepository<CompanyFeedBackClient> CompanyFeedBackClient { get; }
        IRepository<CompanyInformation> CompanyInformation { get; }
        IRepository<CompanyMessage> CompanyMessage { get; }
        IRepository<ReleaseHistory> Release { get; }
        IRepository<Solutions> Solution { get;  }
        IRepository<SolutionSocialLink> SolutionSocialLink { get; }
        IRepository<SolutionDownloadLink> SolutionDownloadLink { get; }
        IRepository<Demos> Demos { get; }
        IRepository<DemoRevue> DemoRevue { get; }
        IRepository<DemoSample> DemoSample { get; }
        IRepository<ForumPost> ForumPost { get; }
        IRepository<ForumPostAnswer> ForumPostAnswer { get; }
        IRepository<Jobs> Jobs { get; }
        IRepository<Languege> Languege { get; }
        IRepository<Politic> Politics { get; }
        IRepository<UserPost> UserPost { get; }
        IRepository<School> School { get; }
        IRepository<Policy> Policy { get; }
        DbContext Context { get; }
        IRepository<CompanyFeedBackCompany> CompanyFeedBackCompany { get; }
        IRepository<CompanyLogo> CompanyLogos { get; }
        IRepository<StaticPageURL> StatciPageURLs { get; }
        IRepository<StaticPageUrlImage> StaticPageUrlImage { get; }
        void Dispose();
        int SaveChanges();
    }
}