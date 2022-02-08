using Prism.Ioc;
using Prism.Modularity;
using PrismMvvmApp.Module;
using PrismMvvmApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMvvmApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var shell = Container.Resolve<Main>();//Where Main is a window to display on start up which present in view folder
            return shell;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<EquipManagementView>();
            containerRegistry.RegisterForNavigation<IOManagementView>();
            containerRegistry.RegisterForNavigation<BaseModelView>();
            containerRegistry.RegisterForNavigation<CustomModelView>();
            containerRegistry.RegisterForNavigation<LayoutDesignView>();
            containerRegistry.RegisterForNavigation<TestSimmulatorView>();
            containerRegistry.RegisterForNavigation<MonitoringView>();
            containerRegistry.RegisterForNavigation<HeaderView>();
            containerRegistry.RegisterForNavigation<MenuView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
        }
    }
}
