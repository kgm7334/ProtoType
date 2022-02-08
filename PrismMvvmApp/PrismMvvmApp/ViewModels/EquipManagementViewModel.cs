using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class EquipManagementViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public EquipManagementViewModel(IEventAggregator eventAggregator)
        {
            Message = "This Is EquipManagement View";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageRecevied);   
        }

        private void MessageRecevied(string payload)
        {
            Message = payload;
        }
    }
}
