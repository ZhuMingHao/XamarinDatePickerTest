using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDatePickerTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void TestDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var viewmode = this.BindingContext as ViewModel.MainPageViewModel;
            viewmode.Datetime = e.NewDate;
        }
    }
}
