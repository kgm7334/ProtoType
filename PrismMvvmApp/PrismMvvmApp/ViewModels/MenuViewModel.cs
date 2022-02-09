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

        private DelegateCommand _gotoIOInputManagementCommandcommand;
        public DelegateCommand GotoIOInputManagementCommand { get; private set; }

        private DelegateCommand _gotoIOOutputManagementCommandcommand;
        public DelegateCommand GotoIOOutputManagementCommand { get; private set; }

        private DelegateCommand _gotoIOParameterManagementCommandcommand;
        public DelegateCommand GotoIOParameterManagementCommand { get; private set; }

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
            GotoIOInputManagementCommand = new DelegateCommand(ExcuteIOInputManagement);
            GotoIOOutputManagementCommand = new DelegateCommand(ExcuteIOOutputManagement);
            GotoIOParameterManagementCommand = new DelegateCommand(ExcuteIOParameterManagement);
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
            _iRegionManager.RequestNavigate("ContentsRegion", "EquipManagementView");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("EquipManagementView");
        }
        private void ExcuteIOOutputManagement()
        {
            //GotoContents("I/OManagement");
            _iRegionManager.RequestNavigate("ContentsRegion", "IOManagementView");
            _eventAggregator.GetEvent<IOTitleEvent>().Publish("Output");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("IOManagementView-Output");
        }

        private void ExcuteIOInputManagement()
        {
            //GotoContents("I/OManagement");
            _iRegionManager.RequestNavigate("ContentsRegion", "IOManagementView");
            _eventAggregator.GetEvent<IOTitleEvent>().Publish("Input");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("IOManagementView-Input");
        }

        private void ExcuteIOParameterManagement()
        {
            //GotoContents("I/OManagement");
            _iRegionManager.RequestNavigate("ContentsRegion", "IOManagementView");
            _eventAggregator.GetEvent<IOTitleEvent>().Publish("Parameter");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("IOManagementView-Parameter");
        }

        private void ExcuteBaseModel()
        {
            GotoContents("BaseModel");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("BaseModel");
        }
        private void ExcuteCustomModel()
        {
            GotoContents("CustomModel");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("CustomModel");
        }
        private void ExcuteLayoutDesign()
        {
            GotoContents("LayoutDesign");

            _eventAggregator.GetEvent<MainTitleEvent>().Publish("LayOutDesign");
        }
        private void ExcuteTestSimmulator()
        {
            GotoContents("TestSimmulator");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("TestSimmulator");
        }
        private void ExcuteMonitoring()
        {
            GotoContents("Monitoring");
            _eventAggregator.GetEvent<MainTitleEvent>().Publish("Monitoring");
        }



        private void EventPublisher()
        {
            _eventAggregator.GetEvent<MessageEvent>().Publish("MenuViewModelFunction3BUtton");
            MessageBox.Show("커맨드3");
        }

    }
}
