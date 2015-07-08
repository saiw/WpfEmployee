using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfEmployee.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public ViewModelBase()
        { }

        #region INotifyPropertyChanged
        /// <summary>
        /// Why  to create the onPropertyChange Handle
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChange(string propertyName)
        {
            //if just do PropertyChanged(this, new PropertyChangedEventArgs(name))
            //could get 'NullReferenceException' if no one  was subscribed 
            //refrence :http://tinyurl.com/qxns3b6
 
            PropertyChangedEventHandler hanlder = this.PropertyChanged;
            if (hanlder != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                hanlder(this, e);
            }
        }
        #endregion

        #region IDispose
        public void Dispose()
        {
            this.OnDispose();
            //throw new NotImplementedException();
        }
        protected virtual void OnDispose()
        {
        }
        #endregion
    }
}
