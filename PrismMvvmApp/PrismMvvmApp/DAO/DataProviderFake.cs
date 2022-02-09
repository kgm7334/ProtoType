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
    public class DataProviderFake : IDataProvider
    {
        public ObservableCollection<IOCodeSource> LoadInputCode()
        {
            var inputCodes = new ObservableCollection<IOCodeSource>();
            for (int idx = 0; idx < 4; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 1, $"n_input{idx + 1}", idx + 11, enDataType.Numeric));
            }
            for (int idx = 0; idx < 2; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 31, $"s_input{idx + 1}", idx+1, idx%2==0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 7; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 61, $"m_input{idx + 1}", idx + 5, idx==1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 3; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 81, $"v_input{idx + 1}", idx + 15, idx==0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }

        public ObservableCollection<IOCodeSource> LoadOutputCode()
        {
            var inputCodes = new ObservableCollection<IOCodeSource>();
            for (int idx = 0; idx < 2; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 101, $"n_output_{idx + 1}", idx + 11, enDataType.Numeric));
            }
            for (int idx = 0; idx < 2; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 121, $"s_output_{idx + 1}", idx + 1, idx % 2 == 0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 1; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 141, $"m_output_{idx + 1}", idx + 5, idx == 1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 3; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 161, $"v_output_{idx + 1}", idx + 8, idx == 0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }

        public ObservableCollection<IOCodeSource> LoadParameterCode()
        {
            var inputCodes = new ObservableCollection<IOCodeSource>();
            for (int idx = 0; idx < 1; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 211, $"nozzle_param_{idx + 1}", idx + 1, enDataType.Numeric));
            }
            for (int idx = 0; idx < 2; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 201, $"sensor_param_{idx + 1}", idx + 2, idx % 2 == 0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 3; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 231, $"moter_param_{idx + 1}", idx + 4, idx == 1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 2; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 241, $"valve_param_{idx + 1}", idx + 8, idx == 0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }
    }
}
