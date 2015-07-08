using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

using WpfEmployee.Model;
using WpfEmployee.DataAccess;
using System.Windows.Media;

namespace WpfEmployee.ViewModel
{
    class EmployeeListViewModel:ViewModelBase
    {
        readonly DataAccess.EmployeeRespository _employeeRespository;
        Relaycommand _invasionCommand;


        /// <summary>
        /// 
        /// </summary>
        /// <remarks> not avaiable set extend</remarks>
        public ObservableCollection<Employee> AllEmployees
        {
            get;
            private set; 
        }

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="_employeeList"></param>
        public EmployeeListViewModel(EmployeeRespository employeeRespository)
        {
            if (employeeRespository == null)
            { throw new ArgumentNullException("employeeRespository"); }

            _employeeRespository = employeeRespository;
            this.AllEmployees = new ObservableCollection<Model.Employee>(_employeeRespository.GetEmployee());
        }

        protected override void OnDispose()
        {
            this.AllEmployees.Clear();

        }

        /// <summary>
        /// 
        /// </summary>
        private Brush _bgBrush;
        public Brush BackgroundBrush
        {
            get
            {
                return _bgBrush;
            }
            set
            {
                _bgBrush = value;
                OnPropertyChange("BackgroundBrush");
            }
        }

        #region  ICommand

        public ICommand InvasionCommand
        {
            get 
            {
                if(_invasionCommand ==null)
                {
                    //param => InvasionCommandExcute
                    _invasionCommand = new Relaycommand(param => this.InvasionCommandExcute(), param => this.InvasionCommandCanExcute);
                }
                return InvasionCommand;
            }
        }

        void InvasionCommandExcute()
        {
            //TO DO BackGroundColor Change

            bool isinvasion = true;
            foreach(Model.Employee emp in this.AllEmployees)
            {
                if(emp.LastName.Trim().ToLower() =="smith")  
                { isinvasion = false; }
            }
            ///show red if include 'smith'
            if(isinvasion)
            { BackgroundBrush = new SolidColorBrush(Colors.Red); }
            else
            {
                // Color Init
                BackgroundBrush = new SolidColorBrush(Colors.White);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        bool InvasionCommandCanExcute
        {
            get
            {
                if (this.AllEmployees.Count == 0)
                { return false; }
                else
                { return true; }
            }
        }
        #endregion 

    
    }
}
