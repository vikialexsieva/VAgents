namespace Vagents.Info.Data
{
    using System.Data.Entity;
    using VAgencyes.Data.Models.Business;
    using VAgencyes.Data.Models.Demo;
    using VAgencyes.Data.Models.Events;
    using VAgencyes.Data.Models.Forums;
    using VAgencyes.Data.Models.Groups;
    using VAgencyes.Data.Models.Page;
    using VAgencyes.Data.Models.Releases;
    using VAgencyes.Data.Models.Solution;
    using VAgencyes.Data.Models.User;
    using VAgents.Info.Model.Company;

    public interface ITicketSystemData1
    {
        IRepository<VAgents.Info.Model.Policy> Policy { get; }
        IRepository<ApplicationUser> Users { get; }
        IRepository<CompanyLogo> CompanyLogos { get; }
        IRepository<BusinessAllInfo> BusinessAllInfo { get; }
        IRepository<BusinessAllInfo> BusinessAllInfoes { get; }
        IRepository<BusinessContact> BusinessContacts { get; }
        IRepository<BusinessImageFile> BusinessImageFiles { get; }
        IRepository<BusinessImage> BusinessImages { get; }
        IRepository<BusinessInfo> BusinessInfoes { get; }
        IRepository<BusinessPost> BusinessPosts { get; }
        IRepository<CompanyContact> CompanyContacts { get; }
        IRepository<CompanyFeedBackCompany> CompanyFeedBackCompany { get; }
        IRepository<CompanyInformation> CompanyInformations { get; }
        IRepository<CompanyMessage> CompanyMessages { get; }
        IRepository<DemoAllInformation> DemoAllInformations { get; }
        IRepository<DemoRevue> DemoRevues { get; }
        IRepository<Demos> Demos { get; }
        IRepository<DemoSample> DemoSamples { get; }
        IRepository<EventInformation> EventInformations { get; }
        IRepository<EventSocialLink> EventSocialLinks { get; }
        IRepository<ForumPostAnswer> ForumPostAnswers { get; }
        IRepository<ForumPostCategory> ForumPostCategorys { get; }
        IRepository<ForumPost> ForumPosts { get; }
        IRepository<ForumPostSubCategory> ForumPostSubCategory { get; }
        IRepository<ForumPostVote> ForumPostVotes { get; }
        IRepository<GroupAllInfo> GroupAllInfoes { get; }
        IRepository<GroupImageFile> GroupImageFiles { get; }
        IRepository<GroupImage> GroupImages { get; }
        IRepository<GroupsInfo> GroupsInfoes { get; }
        IRepository<PageAllInfo> PageAllInfoes { get; }
        IRepository<PageImageFile> PageImageFiles { get; }
        IRepository<PageImage> PageImages { get; }
        IRepository<PageInfo> PageInfoes { get; }
        IRepository<ReleaseHistory> Releases { get; }
        IRepository<SolutionCategory> SolutionCategoryes { get; }
        IRepository<SolutionDownloadLink> SolutionDownloadLinks { get; }
        IRepository<SolutionOtherInformation> SolutionOtherInformation { get; }
        IRepository<SolutionPackegeInclude> SolutionPackageInxludes { get; }
        IRepository<SolutionPackage> SolutionPackages { get; }
        IRepository<Solutions> Solutions { get; }
        IRepository<SolutionSocialLink> SolutionSocilaLink { get; }
        IRepository<UserAllInfo> UserAllInfos { get; }
        IRepository<UserFriendRequest> UserFriendRequests { get; }
        IRepository<UserImageComment> UserImageComments { get; }
        IRepository<UserImage> UserImages { get; }
        IRepository<UserImageViewComment> userImageViewComments { get; }
        IRepository<UserImageView> UserImageViews { get; }
        IRepository<UserInfo> UserInfoes { get; }
        IRepository<UserMessageAnswer> UserMessageAnswers { get; }
        IRepository<UserMessage> UserMessages { get; }
        IRepository<UserNewsFeed> UserNewsFeeds { get; }
        IRepository<UserPostComment> UserPostComments { get; }
        IRepository<UserPost> UserPosts { get; }
        IRepository<ApplicationUser> UserProfile { get; }
        IRepository<UserVideo> UserVideos { get; }
        IRepository<About> Abouts { get; }
        void Dispose();
        void Dispose(bool disposing);
        int SaveChanges();
    }
}