using PrismMvvmApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismMvvmApp.Views
{
    /// <summary>
    /// ContentsView2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IOManagementView : UserControl
    {
        public IOManagementView()
        {
            InitializeComponent();
        }

        private void input_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var vm = this.DataContext as IOManagementViewModel;
            vm.ExcuteIOCodeListAdd();
        }
        private void modify_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var vm = this.DataContext as IOManagementViewModel;
            vm.ExcuteIOCodeListUpdate();
        }
        private void delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var vm = this.DataContext as IOManagementViewModel;
            vm.ExcuteIOCodeListRemove();
        }
    }
}
