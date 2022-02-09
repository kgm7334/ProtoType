using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.DAO;
using PrismMvvmApp.Events;
using PrismMvvmApp.Interface;
using PrismMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class TestSimmulatorViewModel : BindableBase
    {
        private readonly IDataProvider _dataProvider;

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private ObservableCollection<ModelDataNode> _models;

        public ObservableCollection<ModelDataNode> Models
        {
            get
            {
                return _models;
            }
            set
            {
                SetProperty(ref _models, value);
            }
        }

        private ModelDataNode _currentModel;

        public ModelDataNode CurrentModel
        {
            get
            {
                return _currentModel;
            }
            set
            {
                SetProperty(ref _currentModel, value);
            }
        }

        public TestSimmulatorViewModel(IEventAggregator eventAggregator)
        {
            _dataProvider = new DataProvider(false, true);
            CurrentModel = _dataProvider.SearchBaseModel("V2");
            Models = _dataProvider.LoadUnits("Layout1");
            Message = "This is TestSimmulator View";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageRecevied);
        }

        private void MessageRecevied(string payload)
        {
            Message = payload;
        }
    }
}
