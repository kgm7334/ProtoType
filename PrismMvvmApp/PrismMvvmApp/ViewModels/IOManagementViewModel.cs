using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismMvvmApp.DAO;
using PrismMvvmApp.Events;
using PrismMvvmApp.Interface;
using PrismMvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMvvmApp.ViewModels
{
    class IOManagementViewModel : BindableBase
    {
        private IDataProvider _dataProvider;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _iomodetitle;
        public string IoModeTitle
        {
            get { return _iomodetitle; }
            set { SetProperty(ref _iomodetitle, value); }
        }

        private IDialogService _dialogService;

        private ObservableCollection<IOCodeSource> _iocodelist;

        public ObservableCollection<IOCodeSource> IOCodeList
        {
            get { return _iocodelist; }
            set { SetProperty(ref _iocodelist, value); }
        }

        private DelegateCommand _ioCodeListAddcommand;
        public DelegateCommand IOCodeListAddCommand {
            get
            {
                return _ioCodeListAddcommand;
            }
            set
            {
                SetProperty(ref _ioCodeListAddcommand, value);
            }
        }

        private DelegateCommand _ioCodeListRemovecommand;
        public DelegateCommand IOCodeListRemoveCommand
        {
            get
            {
                return _ioCodeListRemovecommand;
            }
            set
            {
                SetProperty(ref _ioCodeListRemovecommand, value);
            }
        }

        private DelegateCommand _ioCodeListUpdatecommand;
        public DelegateCommand IOCodeListUpdateCommand
        {
            get
            {
                return _ioCodeListUpdatecommand;
            }
            set
            {
                SetProperty(ref _ioCodeListUpdatecommand, value);
            }
        }

        public IOManagementViewModel(IEventAggregator eventAggregator, IDialogService dialogService)
        {
            _dataProvider = new DataProvider(false, true);
            IOCodeListAddCommand = new DelegateCommand(ExcuteIOCodeListAdd);
            IOCodeListRemoveCommand = new DelegateCommand(ExcuteIOCodeListRemove);
            IOCodeListUpdateCommand = new DelegateCommand(ExcuteIOCodeListUpdate);

            IOCodeList = new ObservableCollection<IOCodeSource>();

            Message = "This is I/O Management View";
            eventAggregator.GetEvent<MessageEvent>().Subscribe(MessageRecevied);
            eventAggregator.GetEvent<IOTitleEvent>().Subscribe(IOModeRecevied);
            _dialogService = dialogService;
        }

        public void ExcuteIOCodeListAdd()
        {
            if (IOCodeList != null)
            {
                var message = "This is a message that should be shown in the dialog.";

                _dialogService.ShowDialog("Add_IOCodeListDialogView", new DialogParameters($"message={message}"), r =>
                {
                    if (r.Result == ButtonResult.None)
                        Console.WriteLine("none");
                    else if (r.Result == ButtonResult.OK)
                        Console.WriteLine("ok");
                    else if (r.Result == ButtonResult.Cancel)
                        Console.WriteLine("Cancel");
                    else
                        Console.WriteLine("nothing");
                });
            }
        }

        public void ExcuteIOCodeListRemove()
        {
            if (IOCodeList != null)
            {

            }
        }

        public void ExcuteIOCodeListUpdate()
        {
            if (IOCodeList != null)
            {

            }
        }

        private void MessageRecevied(string payload)
        {
            Message = payload;
        }

        private void IOModeRecevied(string payload)
        {
            IoModeTitle = payload;
            if (payload.ToLower() == "input")
                IOCodeList = _dataProvider.LoadInputCode();
            else if (payload.ToLower() == "output")
                IOCodeList = _dataProvider.LoadOutputCode();
            else if (payload.ToLower() == "parameter")
                IOCodeList = _dataProvider.LoadParameterCode();

        }
    }
}
