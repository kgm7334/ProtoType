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
        ObservableCollection<ModelIOParam> LoadModelInputs(string modelName);
        ObservableCollection<ModelIOParam> LoadModelOutputs(string modelName);
        ObservableCollection<ModelIOParam> LoadModelParameters(string modelName);
        ModelDataNode SearchBaseModel(string modelName);
        ObservableCollection<ModelDataNode> LoadUnits(string unitName);
    }
}
