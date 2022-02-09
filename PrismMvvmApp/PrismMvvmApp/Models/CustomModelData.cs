using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMvvmApp.Models
{
    public class CustomModelData : BindableBase
    {
        public CustomModelData(string group, int id, string name, Point position, Size size, enDataType type)
        {
            ModelID = id;
            Name = name;
            Position = position;
            DataType = type;
        }
        private enDataType _datatype;
        public enDataType DataType
        {
            get { return _datatype; }
            set { SetProperty(ref _datatype, value); }
        }
        private int _modelId;
        public int ModelID
        {
            get { return _modelId; }
            set { SetProperty(ref _modelId, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }


        private Point _position;
        public Point Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }
        private Size _size;
        public Size Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
        }
        private ObservableCollection<IOCodeSource> _inputs;
        public ObservableCollection<IOCodeSource> Inputs
        {
            get { return _inputs; }
            set { SetProperty(ref _inputs, value); }
        }
        private ObservableCollection<IOCodeSource> _outputs;
        public ObservableCollection<IOCodeSource> Outputs
        {
            get { return _outputs; }
            set { SetProperty(ref _outputs, value); }
        }
        private ObservableCollection<IOCodeSource> _parameters;
        public ObservableCollection<IOCodeSource> Parameters
        {
            get { return _parameters; }
            set { SetProperty(ref _parameters, value); }
        }
    }
}
