using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEmployee.Model
{
    public class Employee
    {
        #region  Property
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        /// <summary>
        /// static Create employee object
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static Employee CreateEmployee(string firstName, string lastName)
        {
            return new Employee { FirstName = firstName, LastName = lastName };
        }
    }
}
