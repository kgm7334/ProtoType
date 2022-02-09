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
            for (int idx = 0; idx < 7; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 1, $"n_input{idx + 1}", idx + 11, enDataType.Numeric));
            }
            for (int idx = 0; idx < 4; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 31, $"s_input{idx + 1}", idx+1, idx%2==0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 7; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 61, $"m_input{idx + 1}", idx + 5, idx==1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 3; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 81, $"v_input{idx + 1}", idx + 25, idx==0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }

        public ObservableCollection<IOCodeSource> LoadOutputCode()
        {
            var inputCodes = new ObservableCollection<IOCodeSource>();
            for (int idx = 0; idx < 6; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 101, $"n_output_{idx + 1}", idx + 21, enDataType.Numeric));
            }
            for (int idx = 0; idx < 5; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 121, $"s_output_{idx + 1}", idx + 1, idx % 2 == 0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 5; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 141, $"m_output_{idx + 1}", idx + 15, idx == 1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 5; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 161, $"v_output_{idx + 1}", idx + 38, idx == 0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }

        public ObservableCollection<IOCodeSource> LoadParameterCode()
        {
            var inputCodes = new ObservableCollection<IOCodeSource>();
            for (int idx = 0; idx < 7; idx++)
            {
                inputCodes.Add(new IOCodeSource("Nozzle", idx + 211, $"nozzle_param_{idx + 1}", idx + 1, enDataType.Numeric));
            }
            for (int idx = 0; idx < 3; idx++)
            {
                inputCodes.Add(new IOCodeSource("Sensor", idx + 201, $"sensor_param_{idx + 1}", idx + 11, idx % 2 == 0 ? enDataType.Numeric : enDataType.String));
            }
            for (int idx = 0; idx < 5; idx++)
            {
                inputCodes.Add(new IOCodeSource("Motor", idx + 231, $"moter_param_{idx + 1}", idx + 4, idx == 1 ? enDataType.String : enDataType.Numeric));
            }
            for (int idx = 0; idx < 5; idx++)
            {
                inputCodes.Add(new IOCodeSource("Valve", idx + 241, $"valve_param_{idx + 1}", idx + 8, idx == 0 ? enDataType.Double : enDataType.Numeric));
            }
            return inputCodes;
        }

         public ObservableCollection<ModelIOParam> LoadModelInputs(string modelName)
        {
            string group = GetModelGroup(modelName);
            switch (modelName)
            {
                case "N1":
                case "S2":
                case "S3":
                    return GetIOParamsForModel(LoadInputCode(), group, 3);
                case "N2":
                    return GetIOParamsForModel(LoadInputCode(), group, 4);
                case "N3":
                case "S4":
                case "M1":
                case "V2":
                case "V3":
                    return GetIOParamsForModel(LoadInputCode(), group, 2);
                case "N4":
                case "S1":
                case "M2":
                case "V1":
                case "V4":
                    return GetIOParamsForModel(LoadInputCode(), group, 1);
                case "M3":
                    return GetIOParamsForModel(LoadInputCode(), group, 5);
            }
           
            return new ObservableCollection<ModelIOParam>();
        }

        public ObservableCollection<ModelIOParam> LoadModelOutputs(string modelName)
        {
            string group = GetModelGroup(modelName);

            switch (modelName)
            {
                case "N1":
                case "N3":
                case "N4":
                case "S1":
                case "S2":
                case "V1":
                case "V2":
                    return  GetIOParamsForModel(LoadOutputCode(), group, 2);
                case "N2":
                case "S3":
                case "M1":
                case "M2":
                case "M3":
                case "V3":
                    return GetIOParamsForModel(LoadOutputCode(), group, 1);
                case "S4":
                    return GetIOParamsForModel(LoadOutputCode(), group, 3);
                case "V4":
                    return GetIOParamsForModel(LoadOutputCode(), group, 4);
            }
            return new ObservableCollection<ModelIOParam>();
        }


        public ObservableCollection<ModelIOParam> LoadModelParameters(string modelName)
        {
            string group = GetModelGroup(modelName);
            switch (modelName)
            {
                case "N1":
                case "S3":
                case "S4":
                case "V3":
                case "M2":
                    return GetIOParamsForModel(LoadParameterCode(), group, 2);
                case "N2":
                case "S1":
                case "S2":
                case "V2":
                case "M1":
                    return GetIOParamsForModel(LoadParameterCode(), group, 1);
                case "N4":
              
                    return GetIOParamsForModel(LoadParameterCode(), group, 3);
                case "N3":
                case "V1":
                case "M3":
                case "V4":
                    return GetIOParamsForModel(LoadParameterCode(), group, 4);
           
            }
            return new ObservableCollection<ModelIOParam>();
        }

        public ModelDataNode SearchBaseModel(string modelName)
        {
            return new ModelDataNode()
            {
                Group = GetModelGroup(modelName),
                ModelID = 1,
                Name = modelName,
                Offset = new System.Windows.Point(0, 0),
                Size = new System.Windows.Size(100, 100),
                Inputs = LoadModelInputs(modelName),
                Outputs = LoadModelOutputs(modelName),
                Parameters = LoadModelParameters(modelName)
            };
        }

        private string GetModelGroup(string modelName)
        {
            if (modelName.StartsWith("N"))
                return "Nozzle";
            if (modelName.StartsWith("S"))
                return "Sensor";
            if (modelName.StartsWith("M"))
                return "Motor";
            return "Valve";
        }

        private ObservableCollection<ModelIOParam> GetIOParamsForModel(ObservableCollection<IOCodeSource> data, string group, int count)
        {
            var rnd = new Random();
            int no = 1;
            var result = new ObservableCollection<ModelIOParam>();
            var paras = data.Where(x => x.Group == group).ToList();
            for (int i = 0; i < count; i++)
            {
                var idx = rnd.Next(0, paras.Count - 1);
                var target = paras[idx];
                if (result.Any(x => x.Name == target.Name))
                {
                    --i;
                    continue;
                }
                result.Add(new ModelIOParam(enIOParamType.Parameter, no++, new System.Windows.Point(24 + (i + 1) * 8, 0), target.Group, target.ID, target.Name, target.Position, target.DataType));
            }
            return result;
        }
    }
}
