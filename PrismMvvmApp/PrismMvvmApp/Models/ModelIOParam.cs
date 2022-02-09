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
    public class ModelIOPatram : IOCodeSource
    {
        public ModelIOPatram(int index, Point offset, string group, int id, string name, int position, enDataType type )
            :base(group, id, name, position, type)
        {
            Index = index;
            Offset = offset;
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
