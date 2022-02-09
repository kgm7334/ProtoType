using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class Add_IOCodeListDialogViewModel : BindableBase, IDialogAware
    {
        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand =>
            _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));

        public string Title => "ADD";

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        private ObservableCollection<string> _dataTypes = new ObservableCollection<string>();
        public ObservableCollection<string> DataTypes
        {
            get { return _dataTypes; }
            set { SetProperty(ref _dataTypes, value); }
        }
        private ObservableCollection<string> _groups = new ObservableCollection<string>();
        public ObservableCollection<string> Groups
        {
            get { return _groups; }
            set { SetProperty(ref _groups, value); }
        }

        public Add_IOCodeListDialogViewModel()
        {
            DataTypes.Add("Numeric");
            DataTypes.Add("String");
            DataTypes.Add("Double");

            Groups.Add("Nozzle");
            Groups.Add("Sensor");
            Groups.Add("Motor");
            Groups.Add("Valve");
            Groups.Add("Pump");

        }

        public event Action<IDialogResult> RequestClose;

        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
                result = ButtonResult.OK;
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.Cancel;

            RaiseRequestClose(new DialogResult(result));
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        public virtual bool CanCloseDialog()
        {
            return true;
        }

        public virtual void OnDialogClosed()
        {

        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
