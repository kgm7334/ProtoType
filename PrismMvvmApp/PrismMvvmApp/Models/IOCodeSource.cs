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
    public class IOCodeSource : BindableBase
    {
        public IOCodeSource(string group, int id, string name, int position, enDataType type )
        {
            Group = group;
            ID = id;
            Name = name;
            Position = position;
            DataType = type;
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

        private int _id;
        public int ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
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
