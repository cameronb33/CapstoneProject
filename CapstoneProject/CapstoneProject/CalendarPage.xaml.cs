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
	public partial class CalendarPage : ContentPage
	{
        public IList<TaskItem> Tasks { get; private set; }
        public CalendarPage ()
		{
			InitializeComponent();

            Tasks = new List<TaskItem>();
            Tasks.Add(new TaskItem
            {
                Location = "MacEwan",
                Time = "8:00 AM - 9:00 AM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "Edmonton",
                Time = "9:00 AM - 9:30 AM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "Windermere",
                Time = "9:30 AM - 10:00 AM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "Windermere",
                Time = "10:00 AM - 10:30 AM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "Windermere",
                Time = "10:30 AM - 11:00 AM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "MacEwan",
                Time = "11:00 AM - 12:00 PM",
                Workers = "Brandon, Brayden"
            });

            Tasks.Add(new TaskItem
            {
                Location = "Edmonton",
                Time = "12:00 PM - 5:00 PM",
                Workers = "Brandon, Brayden"
            });

            BindingContext = this;
        }

        private async void BtnList_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ListPage();
        }

        private async void BtnTask_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TaskPage();
        }
    }
}