using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMvvmApp.Views;
using PrismMvvmApp.ViewModels;

namespace PrismMvvmApp.Module
{
    class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            //region.RegisterViewWithRegion("ContentsRegion", typeof(BaseModelTest));
            region.RegisterViewWithRegion("ContentsRegion",typeof(IOManagementView));
            region.RegisterViewWithRegion("HeaderRegion",typeof(HeaderView));
            region.RegisterViewWithRegion("MenuRegion", typeof(MenuView));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<Add_IOCodeListDialogView,Add_IOCodeListDialogViewModel>();
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
    }
}
