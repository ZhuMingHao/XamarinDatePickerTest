using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDatePickerTest.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private DateTime? _datetime;

        public DateTime? Datetime
        {
            get => _datetime;

            set
            {
                _datetime = value;
                OnPropertyChanged();
            }
        }
        public MainPageViewModel()
        {
            this.Datetime = new DateTime(2011, 12, 18);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
