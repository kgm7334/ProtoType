using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMvvmApp.ViewModels
{
    class MenuViewModel : BindableBase
    {

        private DelegateCommand _gotoEquipManagementcommand;
        public DelegateCommand GotoEquipManagementCommand { get; private set; }

        private DelegateCommand _gotoIOManagementCommandcommand;
        public DelegateCommand GotoIOManagementCommand { get; private set; }

        private DelegateCommand _gotoBaseModelcommand;
        public DelegateCommand GotoBaseModelCommand { get; private set; }

        private DelegateCommand _gotoCustomModelcommand;
        public DelegateCommand GotoCustomModelCommand { get; private set; }

        private DelegateCommand _gotoLayoutDesigncommand;
        public DelegateCommand GotoLayoutDesignCommand { get; private set; }

        private DelegateCommand _gotoTestSimmulatorcommand;
        public DelegateCommand GotoTestSimmulatorCommand { get; private set; }

        private DelegateCommand _gotoMonitoringcommand;
        public DelegateCommand GotoMonitoringCommand { get; private set; }

        private readonly IRegionManager _iRegionManager;
        private readonly IEventAggregator _eventAggregator;

        public MenuViewModel(IRegionManager iregionManager,IEventAggregator eventAggregtor)
        {
            GotoEquipManagementCommand = new DelegateCommand(ExcuteEquipManagement);
            GotoIOManagementCommand = new DelegateCommand(ExcuteIOManagement);
            GotoBaseModelCommand = new DelegateCommand(ExcuteBaseModel);
            GotoCustomModelCommand = new DelegateCommand(ExcuteCustomModel);
            GotoLayoutDesignCommand = new DelegateCommand(ExcuteLayoutDesign);
            GotoTestSimmulatorCommand = new DelegateCommand(ExcuteTestSimmulator);
            GotoMonitoringCommand = new DelegateCommand(ExcuteMonitoring);

            _iRegionManager = iregionManager;
            _eventAggregator = eventAggregtor;
        }

        private void GotoContents(string MenunName)
        {
            switch(MenunName){
                case "EquipManagement":
                    _iRegionManager.RequestNavigate("ContentsRegion", "EquipManagementView");
                    break;
                case "I/OManagement":
                    _iRegionManager.RequestNavigate("ContentsRegion", "IOManagementView");
                    break;
                case "BaseModel":
                    _iRegionManager.RequestNavigate("ContentsRegion", "BaseModelView");
                    break;
                case "CustomModel":
                    _iRegionManager.RequestNavigate("ContentsRegion", "CustomModelView");
                    break;
                case "LayoutDesign":
                    _iRegionManager.RequestNavigate("ContentsRegion", "LayoutDesignView");
                    break;
                case "TestSimmulator":
                    _iRegionManager.RequestNavigate("ContentsRegion", "TestSimmulatorView");
                    break;
                case "Monitoring":
                    _iRegionManager.RequestNavigate("ContentsRegion", "MonitoringView");
                    break;
            }
        }
        private void ExcuteEquipManagement()
        {
            GotoContents("EquipManagement");
        }
        private void ExcuteIOManagement()
        {
            GotoContents("I/OManagement");
        }
        private void ExcuteBaseModel()
        {
            GotoContents("BaseModel");
        }
        private void ExcuteCustomModel()
        {
            GotoContents("CustomModel");
        }
        private void ExcuteLayoutDesign()
        {
            GotoContents("LayoutDesign");
        }
        private void ExcuteTestSimmulator()
        {
            GotoContents("TestSimmulator");
        }
        private void ExcuteMonitoring()
        {
            GotoContents("Monitoring");
        }



        private void EventPublisher()
        {
            _eventAggregator.GetEvent<MessageEvent>().Publish("MenuViewModelFunction3BUtton");
            MessageBox.Show("커맨드3");
        }

    }
}
