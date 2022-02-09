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
    public class DataProvider : IDataProvider
    {
        private IDataProvider _dataProvider;
        public DataProvider(bool isDB, bool isFake = false, string fileName = "", string dbIp="", int dbPort=0, string dbUser="", string dbPassword="")
        {
            if (isFake)
                _dataProvider = new DataProviderFake();
            else if(isDB)
                _dataProvider = new DataProviderDB(dbIp, dbPort, dbUser, dbPassword);
            else
                _dataProvider = new DataProviderFile(fileName);
        }

        public ObservableCollection<IOCodeSource> LoadInputCode()
        {
            return _dataProvider.LoadInputCode();
        }

        public ObservableCollection<IOCodeSource> LoadOutputCode()
        {
            return _dataProvider.LoadOutputCode();
        }

        public ObservableCollection<IOCodeSource> LoadParameterCode()
        {
            return _dataProvider.LoadParameterCode();
        }
    }
}
