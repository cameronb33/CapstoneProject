using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapstoneProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();
		}

        private async void BtnList_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ListPage();
        }

        private async void BtnCalendar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CalendarPage();
        }

        private async void BtnResetPassword_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Password Changed Successfully", "OK");
        }


    }
}