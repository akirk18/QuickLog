using System;
using Ninject;
using Ninject.Modules;
using QuickLog.Modules;
using QuickLog.Services;
using QuickLog.ViewModels;
using QuickLog.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickLog
{
    public partial class App : Application
    {
        public IKernel Kernel { get; set; }

        public App(params INinjectModule[] platformModules)
        {
            InitializeComponent();

            Kernel = new StandardKernel(new QuickLogCoreModule(), new QuickLogNavModule());
            Kernel.Load(platformModules);

            SetMainPage();
        }

        private void SetMainPage()
        {
            var mainPage = new NavigationPage(new HomePage());
            mainPage.BindingContext = Kernel.Get<HomeViewModel>();
            var navService = Kernel.Get<INavService>() as NavService;
            navService.XamarinFormsNav = mainPage.Navigation;
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
