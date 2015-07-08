/*1.do not realize how to work here with  'event CanExecuteChanged'
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfEmployee
{
   public  class Relaycommand :ICommand
    {
       readonly Action<object>_excute;
       readonly Predicate<object>_canExecute; 

        public Relaycommand(Action<object> execute)
            : this(execute, null)
        { }
        public Relaycommand(Action<object> execute ,Predicate<object> canExecute)
        {
            if(execute ==null)
                throw new ArgumentException("execute");
            _excute = execute;
            _canExecute = canExecute;
        }

        #region ICommond

       [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

       /// <summary>
       /// 
       /// </summary>
        public event EventHandler CanExecuteChanged
       {
           add { CommandManager.RequerySuggested += value; }
           remove { CommandManager.RequerySuggested -= value; }
       }

        public void Execute(object parameter)
        {
            _excute(parameter);
        }

        #endregion
    }
}
