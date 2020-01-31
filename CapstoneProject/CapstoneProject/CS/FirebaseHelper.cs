using CapstoneProject.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace CapstoneProject.Helper
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://capstone-6acec.firebaseio.com/");

        public async Task<List<Location>> GetAllLocations()
        {
            return (await firebase
              .Child("Location")
              .OnceAsync<Location>()).Select(item => new Location
              {
                  Name = item.Object.Name,
                  City = item.Object.City
              }).ToList();
        }

        public async Task AddLocation(string name, string city)
        {
            await firebase
              .Child("Location")
              .PostAsync(new Location() { Name = name, City = city });
        }

        public async Task DeleteLocation(string name)
        {
            var toDeleteLocation = (await firebase
              .Child("Location")
              .OnceAsync<Location>()).Where(a => a.Object.Name == name).FirstOrDefault();
            await firebase.Child("Location").Child(toDeleteLocation.Key).DeleteAsync();

        }



    }
}
