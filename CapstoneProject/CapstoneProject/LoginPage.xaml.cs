﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapstoneProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent();
        }

        private async void SubmitAttempt(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
    }
}