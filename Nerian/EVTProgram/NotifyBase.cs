using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EVTProgram
{
    public class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            catch(Exception)
            {

            }
        }

        protected virtual void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            storage = value;
            OnPropertyChanged(propertyName);
        }
    }
}
