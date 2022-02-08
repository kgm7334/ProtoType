using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.Models
{
    class IOCode_Source : BindableBase
    {
        public IOCode_Source()
        {

        }

        private string _group;
        public string Group
        {
            get { return _group; }
            set { SetProperty(ref _group, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _position;
        public string Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        private string _datatype;
        public string DataType
        {
            get { return _datatype; }
            set { SetProperty(ref _datatype, value); }
        }
    }
}
