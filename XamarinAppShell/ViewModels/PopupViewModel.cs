using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAppShell.ViewModels
{
    class PopupViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _field1;

        public string Field1
        {
            get => _field1;
            set
            {
                if (_field1 != value)
                {
                    _field1 = value;
                    OnPropertyChanged(); // reports this property
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
