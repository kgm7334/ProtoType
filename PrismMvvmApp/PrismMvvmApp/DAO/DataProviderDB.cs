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
    public class DataProviderDB : IDataProvider
    {
        public DataProviderDB(string ip, int port, string user, string password)
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
