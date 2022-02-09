using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismMvvmApp.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class CustomModelViewModel: BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        /// <summary>
        /// 파일 아이콘(비트맵)
        /// </summary>
        private string _customModelPicture;
        public string CustomModelPicture
        {
            get { return _customModelPicture; }
            set { SetProperty(ref _customModelPicture, value); }
        }

        private DelegateCommand<string> _customModelPictureCommand;
        public DelegateCommand<string> CustomModelGetPictureCommand
        {
            get
            {
                return _customModelPictureCommand;
            }
            set
            {
                SetProperty(ref _customModelPictureCommand, value);
            }
        }

        public CustomModelViewModel(IEventAggregator eventAggregator)
        {
            CustomModelGetPictureCommand = new DelegateCommand<string>(ChangeCustomModelPicture);
            Message = "This is CustomModel View";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageRecevied);
        }

        private void ChangeCustomModelPicture(string PictureName)
        {
            string imagespath = @"C:\vms\Images\";
            if (File.Exists(imagespath + PictureName)) CustomModelPicture = imagespath + PictureName;
        }

        private void MessageRecevied(string payload)
        {
            Message = payload;
        }
    }
}
