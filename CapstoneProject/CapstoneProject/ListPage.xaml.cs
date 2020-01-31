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
    public partial class ListPage : ContentPage
    {
		public ListPage ()
		{
			InitializeComponent();
        }

        private async void BtnHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }

        private async void BtnCalendar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CalendarPage();
        }

        private async void BtnProfile_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ProfilePage();
        }

        private async void BtnModUsers_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ModUserPage();
        }

        private async void BtnNewTask_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NewTaskPage();
        }
    }
}