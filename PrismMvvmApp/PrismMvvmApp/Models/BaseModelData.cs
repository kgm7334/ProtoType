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
        public BaseModelData( int modelId, string name, Point offset,  Size size, string group)
        {
            ModelID = modelId;
            Name = name;
            Offset = offset;
            Size = size;
            Group = group;
            Inputs = new ObservableCollection<ModelIOPatram>();
            Outputs = new ObservableCollection<ModelIOPatram>();
            Parameters = new ObservableCollection<ModelIOPatram>();
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

        private ObservableCollection<ModelIOPatram> _inputs;
        public ObservableCollection<ModelIOPatram> Inputs
        {
            get { return _inputs; }
            set { SetProperty(ref _inputs, value); }
        }
        private ObservableCollection<ModelIOPatram> _outputs;
        public ObservableCollection<ModelIOPatram> Outputs
        {
            get { return _outputs; }
            set { SetProperty(ref _outputs, value); }
        }
        private ObservableCollection<ModelIOPatram> _parameters;
        public ObservableCollection<ModelIOPatram> Parameters
        {
            get { return _parameters; }
            set { SetProperty(ref _parameters, value); }
        }
    }
}
