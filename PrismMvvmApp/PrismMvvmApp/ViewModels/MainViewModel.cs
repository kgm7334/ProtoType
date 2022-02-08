using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using PrismMvvmApp.Models;

namespace PrismMvvmApp.ViewModels
{
    class MainViewModel: BindableBase
    {
     
        private string _maintitle;
        public string MainTitle
        {
            get { return _maintitle; }
            set { SetProperty(ref _maintitle, value); }
        }

        public MainViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<MainTitleEvent>().Subscribe(IOModeRecevied);
        }

        private void IOModeRecevied(string payload)
        {
            MainTitle = payload;
        }
    }
}
