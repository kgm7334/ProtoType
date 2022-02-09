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

         public ObservableCollection<ModelIOParam> LoadModelInputs(string modelName)
        {
            int idx;
            string group = GetModelGroup(modelName);
            int count = 1;
            var rnd = new Random();

            IOCodeSource target;
            var result = new ObservableCollection<ModelIOParam>();
            switch (modelName)
            {
                case "N1":
                    count = 3;
                    break;
                case "N2":
                    count = 4;
                    break;
                case "N3":
                    count = 2;
                    break;
                case "N4":
                    count = 1;
                    break;
                case "S2":
                    count = 3;
                    break;
                case "S3":
                    count = 3;
                    break;
                case "S4":
                    count = 2;
                    break;
                case "M1":
                    count = 2;
                    break;
                case "M3":
                    count = 5;
                    break;
                case "V2":
                    count = 2;
                    break;
                case "V3":
                    count = 2;
                    break;
            }
            int no = 1;
            var inputs = LoadInputCode().Where(x => x.Group == group).ToList();
            for (int i = 0; i < count; i++)
            {
                idx = rnd.Next(0, 10);
                target = inputs[(idx % inputs.Count) - 1];
                result.Add(new ModelIOParam(enIOParamType.Input, no++, new System.Windows.Point(0, 24 + (i + 1) * 8), target.Group, target.ID, target.Name, target.Position, target.DataType));
            }
           
            return result;
        }

        public ObservableCollection<ModelIOParam> LoadModelOutputs(string modelName)
        {
            int idx;
            string group = GetModelGroup(modelName);
            int count = 1;
            var rnd = new Random();

            IOCodeSource target;
            var result = new ObservableCollection<ModelIOParam>();
            if (modelName.StartsWith("N"))
                group = "Nozzle";
            switch (modelName)
            {
                case "N1":
                    count = 2;
                    break;
                case "N2":
                    break;
                case "N3":
                    count = 2;
                    break;
                case "N4":
                    count = 2;
                    break;
                case "S1":
                    count = 2;
                    break;
                case "S2":
                    count = 2;
                    break;
                case "S4":
                    count = 3;
                    break;
                case "V1":
                case "V2":
                    count = 2;
                    break;
                case "V4":
                    count = 4;
                    break;
            }
            int no = 1;
            
            var outputs = LoadOutputCode().Where(x => x.Group == group).ToList();
            idx = rnd.Next(0, 10);
            for (int i = 0; i < count; i++)
            {
                idx = rnd.Next(0, 10);
                target = outputs[(idx % outputs.Count) - 1];
                result.Add(new ModelIOParam(enIOParamType.Output, no++, new System.Windows.Point(300, 24 + (i + 1) * 8), target.Group, target.ID, target.Name, target.Position, target.DataType));
            }
            return result;
        }


        public ObservableCollection<ModelIOParam> LoadModelParameters(string modelName)
        {
            int idx;
            string group = GetModelGroup(modelName);
            int count = 1;
            var rnd = new Random();

            IOCodeSource target;
            var result = new ObservableCollection<ModelIOParam>();
            if (modelName.StartsWith("N"))
                group = "Nozzle";
            switch (modelName)
            {
                case "N1":
                    count = 2;
                    break;
                case "N2":
                    break;
                case "N3":
                    count = 2;
                    break;
                case "N4":
                    count = 2;
                    break;
                case "S1":
                    count = 2;
                    break;
                case "S2":
                    count = 2;
                    break;
                case "S4":
                    count = 3;
                    break;
                case "V1":
                    count = 4;
                    break;
                case "V3":
                    count = 2;
                    break;
                case "V4":
                    count = 3;
                    break;
            }
            int no = 1;

            var paras = LoadParameterCode().Where(x => x.Group == group).ToList();
            idx = rnd.Next(0, 10);
            for (int i = 0; i < count; i++)
            {
                idx = rnd.Next(0, 10);
                target = paras[(idx % paras.Count) - 1];
                result.Add(new ModelIOParam(enIOParamType.Parameter, no++, new System.Windows.Point(24 + (i + 1) * 8, 0), target.Group, target.ID, target.Name, target.Position, target.DataType));
            }
            return result;
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
    }
}
