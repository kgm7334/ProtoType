using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using PrismMvvmApp.Models;

namespace PrismMvvmApp.ViewModels
{
    class MainViewModel: BindableBase
    {
        private MainModel _mainmodel;
        public MainModel MainModel
        {
            get
            {return _mainmodel;}
            set
            {
                SetProperty(ref _mainmodel,value);
            }
        }
        public MainViewModel()
        {
            MainModel = new MainModel();
        }
      
    }
}
