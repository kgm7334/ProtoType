using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.DAO;
using PrismMvvmApp.Events;
using PrismMvvmApp.Interface;
using PrismMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class BaseModelViewModel : BindableBase
    {
        private readonly IDataProvider _dataProvider;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        private ModelDataNode _currentModel;
        public ModelDataNode CurrentModel
        {
            get { return _currentModel; }
            set { SetProperty(ref _currentModel, value); }
        }

        private DelegateCommand<string> _baseModelGetPictureCommand;
        public DelegateCommand<string> BaseModelGetPictureCommand
        {
            get 
            {
                return _baseModelGetPictureCommand;
            }
            set
            {
                SetProperty(ref _baseModelGetPictureCommand, value);
            }
        }
        
        /// <summary>
        /// 파일 아이콘(비트맵)
        /// </summary>
        private string _baseModelPicture;
        public string BaseModelPicture
        {
            get { return _baseModelPicture; }
            set { SetProperty(ref _baseModelPicture, value); }
        }

        public BaseModelViewModel(IEventAggregator eventAggregator)
        {
            _dataProvider = new DataProvider(false, true);
            BaseModelGetPictureCommand = new DelegateCommand<string>(ChangeBaseModelPicture);
            Message = "This is BaseModel View";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageRecevied);
        }

        private void ChangeBaseModelPicture(string pictureName)
        {
            string imagespath = @"C:\vms\Images\";
            if (File.Exists(imagespath + pictureName))BaseModelPicture = imagespath + pictureName;
            CurrentModel = _dataProvider.SearchBaseModel(Path.GetFileNameWithoutExtension(pictureName));
        }

        private void MessageRecevied(string payload)
        { 
            Message = payload;
        }
    }
}
