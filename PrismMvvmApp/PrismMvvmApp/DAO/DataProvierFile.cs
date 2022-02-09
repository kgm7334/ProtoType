using PrismMvvmApp.Interface;
using PrismMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.DAO
{
    public class DataProviderFile : IDataProvider
    {
        public DataProviderFile(string fileName)
        {
        }


        public ObservableCollection<IOCodeSource> LoadInputCode()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<IOCodeSource> LoadOutputCode()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<IOCodeSource> LoadParameterCode()
        {
            throw new NotImplementedException();
        }
    }
}
