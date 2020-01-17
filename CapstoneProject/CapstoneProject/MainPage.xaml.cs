using CapstoneProject.Helper;
using CapstoneProject.Model;
using System;
using Xamarin.Forms;

namespace CapstoneProject
{
    public partial class MainPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.AddLocation(txtName.Text, txtCity.Text);
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            await DisplayAlert("Success", "Location Added Successfully", "OK");
            var allLocations = await firebaseHelper.GetAllLocations();
            lstPersons.ItemsSource = allLocations;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.DeleteLocation(txtName.Text);
            await DisplayAlert("Success", "Location Deleted Successfully", "OK");
            var allLocations = await firebaseHelper.GetAllLocations();
            lstPersons.ItemsSource = allLocations;
        }

        private async void BtnRefresh_Clicked(object sender, EventArgs e)
        {
            var allLocations = await firebaseHelper.GetAllLocations();
            lstPersons.ItemsSource = allLocations;
        }
    }
}
