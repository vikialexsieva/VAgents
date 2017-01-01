[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VAgents.Info.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(VAgents.Info.App_Start.NinjectWebCommon), "Stop")]

namespace VAgents.Info.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using System.Data.Entity;
    using Vagents.Info.Data;
    using Services;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICacheService>().To<InMemoryCache>();
            kernel.Bind<IDropDownListPopulator>().To<DropDownListPopulator>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
            //kernel.Bind<ISolutionDownloadLinkService>().To<SolutionDownloadLinkService>().InRequestScope();
            //kernel.Bind<ISolutionOtherInformationService>().To<SolutionOtherInformationService>().InRequestScope();
            //kernel.Bind<ISolutionPackageIncludeService>().To<SolutionPackageIncludeService>().InRequestScope();
            //kernel.Bind<ISolutionPackageService>().To<SolutionPackageService>().InRequestScope();
            //kernel.Bind<ISolutionService>().To<SolutionService>().InRequestScope();
            //kernel.Bind<ISolutionSocialLinkService>().To<SolutionSocialLinkService>().InRequestScope();
            //kernel.Bind<IReleaseService>().To<ReleaseService>().InRequestScope();
            //kernel.Bind<IForumPostAnswerService>().To<ForumPostAnswerService>().InRequestScope();
            //kernel.Bind<IForumPostCategoryService>().To<ForumPostCategoryService>().InRequestScope();
            //kernel.Bind<IForumPostService>().To<ForumPostService>().InRequestScope();
            //kernel.Bind<IForumPostSubCategoryService>().To<ForumPostSubCategoryService>().InRequestScope();
            //kernel.Bind<IForumPostVoteService>().To<ForumPostVoteService>().InRequestScope();
            //kernel.Bind<IEventInformationService>().To<EventInformationService>().InRequestScope();
            //kernel.Bind<IEventSocialLinkService>().To<EventSocialLinkService>().InRequestScope();
            //kernel.Bind<IDemoService>().To<DemoService>().InRequestScope();
            //kernel.Bind<IDemoInformationAllService>().To<IDemoInformationAllService>().InRequestScope();
            //kernel.Bind<IDemoRevueService>().To<DemoRevueService>().InRequestScope();
            //kernel.Bind<IDemoSampleService>().To<DemoSampleService>().InRequestScope();
            //kernel.Bind<ICompanyContactService>().To<CompanyContactService>().InRequestScope();
            //kernel.Bind<ICompanyInformationServices>().To<CompanyInformationService>().InRequestScope();
            //kernel.Bind<ICompanyMessageService>().To<CompanyMessageService>().InRequestScope();
            //kernel.Bind<IUserFriendRequestService>().To<UserFriendRequestService>().InRequestScope();
            ////kernel.Bind<IUserAllInfoService>().To<UserAllInfoService>().InRequestScope();
            //kernel.Bind<IUserImageCommentService>().To<UserImageCommentService>().InRequestScope();
            //kernel.Bind<IUserImageService>().To<UserImageService>().InRequestScope();
            //kernel.Bind<IUserImageViewCommentService>().To<UserImageViewCommentService>().InRequestScope();
            //kernel.Bind<IUserImageViewService>().To<UserImageViewService>().InRequestScope();
            //kernel.Bind<IUserInfoService>().To<UserInfoService>().InRequestScope();
            //kernel.Bind<IUserMessageAnswerService>().To<UserMessageAnswerService>().InRequestScope();
            //kernel.Bind<IUserMessageService>().To<UserMessageService>().InRequestScope();
            //kernel.Bind<IUserNewsFeedService>().To<UserNewsFeedService>().InRequestScope();
            //kernel.Bind<IUserPostCommentService>().To<UserPostCommentService>().InRequestScope();
            //kernel.Bind<IUserPostService>().To<UserPostService>().InRequestScope();
            //kernel.Bind<IUserVideoService>().To<UserVideoService>().InRequestScope();
            //kernel.Bind<IVideoCommentService>().To<VideoCommentService>().InRequestScope();
            //kernel.Bind<IVideoService>().To<VideoService>().InRequestScope();
            //kernel.Bind<ISchoolService>().To<SchoolService>().InRequestScope();
            //kernel.Bind<IUserInfoService>().To<UserInfoService>().InRequestScope();
            //kernel.Bind<IPoliticService>().To<PoliticService>().InRequestScope();
            //kernel.Bind<IOtherContactService>().To<OtherContactService>().InRequestScope();
            //kernel.Bind<IOneVideoCommentService>().To<OneVideoCommentService>().InRequestScope();
            //kernel.Bind<INowLifeCityService>().To<NowLifeCityService>().InRequestScope();
            //kernel.Bind<ILanguegeService>().To<LanguegeService>().InRequestScope();
            //kernel.Bind<IJobsService>().To<JobsService>().InRequestScope();
            //kernel.Bind<IFamilyService>().To<FamilyService>().InRequestScope();
            //kernel.Bind<IByrnPlaceService>().To<ByrnPlaceService>().InRequestScope();
            //kernel.Bind<IAboutService>().To<AboutService>().InRequestScope();
            kernel.Bind<DbContext>().To<ApplicationDbContext>();
            kernel.Bind<ITicketSystemData>().To<TicketSystemData>();
            
        }        
    }
}
