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
    public class BaseModelData : BindableBase
    {
        public BaseModelData(string group, int id, string name, int position, enDataType type )
        {
            ModelID = id;
            Name = name;
            Position = position;
            DataType = type;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _modelId;
        public int ModelID
        {
            get { return _modelId; }
            set { SetProperty(ref _modelId, value); }
        }

        private int _position;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        private enDataType _datatype;
        public enDataType DataType
        {
            get { return _datatype; }
            set { SetProperty(ref _datatype, value); }
        }
    }
}
