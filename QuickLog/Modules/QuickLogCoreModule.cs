using System;
using Ninject.Modules;
using QuickLog.ViewModels;

namespace QuickLog.Modules
{
    public class QuickLogCoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<HomeViewModel>().ToSelf();
            Bind<NewEntryViewModel>().ToSelf();
        }
    }
}
