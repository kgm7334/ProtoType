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
    public class ModelDataNode : BaseModelData
    {
        public ModelDataNode(string group, int id, string name, Point position, Size size, int parentId, int childId)
            :base(id, name, position, size, group)
        {
            ParentID = parentId;
            ChildID = childId;
        }

        private int _parentId;
        public int ParentID
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }
        private int _childId;
        public int ChildID
        {
            get { return _childId; }
            set { SetProperty(ref _childId, value); }
        }
    }
}
