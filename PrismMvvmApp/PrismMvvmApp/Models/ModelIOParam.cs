using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMvvmApp.Models
{
    public class ModelIOParam : IOCodeSource
    {
        public ModelIOParam(enIOParamType ioParamType, int index, Point offset, string group, int id, string name, int position, enDataType type )
            :base(group, id, name, position, type)
        {
            Index = index;
            Offset = offset;
        }

        private enIOParamType _ioParamType;
        public enIOParamType IOParamType
        {
            get { return _ioParamType; }
            set { SetProperty(ref _ioParamType, value); }
        }
        private int _index;
        public int Index
        {
            get { return _index; }
            set { SetProperty(ref _index, value); }
        }

        private Point  _offset;
        public Point Offset
        {
            get { return _offset; }
            set { SetProperty(ref _offset, value); }
        }
    }
}
