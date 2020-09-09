using System;
using Ninject.Modules;
using QuickLog.Services;

namespace QuickLog.Modules
{
    public class QuickLogNavModule : NinjectModule
    {
        public override void Load()
        {
            var navService = new NavService();

            Bind<INavService>().ToMethod(x => navService).InSingletonScope();
        }
    }
}
