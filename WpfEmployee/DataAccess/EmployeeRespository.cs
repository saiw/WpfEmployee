/////TO DO 
/////1.Respository Employee collection 
//// 2.Return new instance employee

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfEmployee.DataAccess
{
    class EmployeeRespository
    {

        readonly List<Model.Employee> _employee;

        #region Construct 
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_employee"></param>
        ///<remarks>how to define this construct ;enclose data is allowed ?</remarks>
        public EmployeeRespository()
        {
            if (_employee == null)
            { _employee = new List<Model.Employee>(); }

            
            _employee.Add(Model.Employee.CreateEmployee("John" ,"Willams"));
            _employee.Add(Model.Employee.CreateEmployee("Anna" ,"Lee"));
            _employee.Add(Model.Employee.CreateEmployee("Claire" ,"Lam"));
        }

        public EmployeeRespository( List<Model.Employee> employeeList)
        {
            _employee = employeeList;
        }
        #endregion

        /// <summary>
        /// Get 
        /// </summary>
        /// <returns></returns>
        public List<Model.Employee> GetEmployee()
        {
            /// return one more new Employee List 
            return new List<Model.Employee>(_employee); /// casue read only of _employee
        }
    }
}
