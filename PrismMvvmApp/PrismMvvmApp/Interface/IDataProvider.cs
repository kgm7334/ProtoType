using PrismMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.Interface
{
    public interface IDataProvider
    {
        ObservableCollection<IOCodeSource> LoadInputCode();
        ObservableCollection<IOCodeSource> LoadOutputCode();
        ObservableCollection<IOCodeSource> LoadParameterCode();
    }
}
