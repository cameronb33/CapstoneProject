using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CapstoneProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Pathname and api key for the firestore database 
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "8XYiiyg63vVWHlgkJeQBoFTrRZTZXoL3oUW84m8u",
                BasePath = "https://capstone-6acec.firebase.io.com/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                Console.WriteLine("Connection is eshtablished");
            }
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
