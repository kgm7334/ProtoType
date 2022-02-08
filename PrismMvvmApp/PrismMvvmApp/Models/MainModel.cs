using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PrismMvvmApp.Models
{
    class MainModel:INotifyPropertyChanged
    {
        

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public MainModel()
        {
            Title= "LabView";
        }

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
            
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
