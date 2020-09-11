using System;
using Ninject.Modules;
using QuickLog.Services;
using QuickLog.ViewModels;
using QuickLog.Views;

namespace QuickLog.Modules
{
    public class QuickLogNavModule : NinjectModule
    {
        public override void Load()
        {
            var navService = new NavService();
            navService.RegisterViewMapping(typeof(HomeViewModel), typeof(HomePage));
            navService.RegisterViewMapping(typeof(NewEntryViewModel), typeof(NewEntryPage));

            Bind<INavService>().ToMethod(x => navService).InSingletonScope();
        }
    }
}
