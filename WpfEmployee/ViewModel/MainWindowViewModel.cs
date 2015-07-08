using System.Collections.ObjectModel;
using WpfEmployee.DataAccess;

namespace WpfEmployee.ViewModel
{
    public class MainWindowViewModel:ViewModelBase
    {
        readonly EmployeeRespository _employeeRespository;
        ObservableCollection<ViewModelBase> _viewModel;   ///whats this 


        #region Construct 

        public MainWindowViewModel()
        {
            _employeeRespository = new EmployeeRespository();
            //create an instance of out viewmodel add it to our collection ;
            EmployeeListViewModel vmEmployee = new EmployeeListViewModel(_employeeRespository);
            this.ViewModels.Add(vmEmployee);
        }
        #endregion

        /// <summary>
        /// Biding MainWindow.xaml 
        /// </summary>
        /// <remarks>observable<T> type  necessary</remarks>
        public ObservableCollection<ViewModelBase> ViewModels
        {
            get
            {
                if (_viewModel == null)
                {_viewModel =new ObservableCollection<ViewModelBase>();}
                return _viewModel;
            
            }
            
        }
    }
}
