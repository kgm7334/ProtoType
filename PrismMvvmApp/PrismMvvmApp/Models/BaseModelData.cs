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
    public class BaseModelData : BindableBase
    {
        public BaseModelData()
        {
        }
        public BaseModelData( int modelId, string name, Point offset,  Size size, string group)
        {
            ModelID = modelId;
            Name = name;
            Offset = offset;
            Size = size;
            Group = group;
            Inputs = new ObservableCollection<ModelIOParam>();
            Outputs = new ObservableCollection<ModelIOParam>();
            Parameters = new ObservableCollection<ModelIOParam>();
        }

        private string _group;
        public string Group
        {
            get { return _group; }
            set { SetProperty(ref _group, value); }
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
       
        private Point _offset;
        public Point Offset
        {
            get { return _offset; }
            set { SetProperty(ref _offset, value); }
        }

        private Size _size;
        public Size Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
        }

        private ObservableCollection<ModelIOParam> _inputs;
        public ObservableCollection<ModelIOParam> Inputs
        {
            get { return _inputs; }
            set { SetProperty(ref _inputs, value); }
        }

        private ObservableCollection<ModelIOParam> _parameters;
        public ObservableCollection<ModelIOParam> Parameters
        {
            get { return _parameters; }
            set { SetProperty(ref _parameters, value); }
        }
        private ObservableCollection<ModelIOParam> _outputs;
        public ObservableCollection<ModelIOParam> Outputs
        {
            get { return _outputs; }
            set { SetProperty(ref _outputs, value); }
        }
    }
}
