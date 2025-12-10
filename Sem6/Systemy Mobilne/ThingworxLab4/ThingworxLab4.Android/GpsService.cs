using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.OS.Health;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThingworxLab4.Droid
{
    [Service(Label = "GpsService" )]
    class GpsService : Service
    {
        bool isRunningTimer = true;
        public override IBinder OnBind(Intent intent)
        {
            // throw new NotImplementedException();
            return null;
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void OnDestroy()
        {
            StopSelf();
            isRunningTimer = false;
            base.OnDestroy();
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
             {
                 GetLocation();
                 return isRunningTimer;
             });
            return StartCommandResult.Sticky;
        }

        public async void GetLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.High);
                var location = await Geolocation.GetLocationAsync(request);

                if(location != null)
                {
                    MessagingCenter.Send<Location>(location, "locationValue");
                    await UpdateTWXLocationAsync(location);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public async Task UpdateTWXLocationAsync(Location location)
        {
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("x-thingworx-session", "true");
            httpClient.DefaultRequestHeaders.Add("appkey", "499b9165-cfd6-4e1b-b0fc-8d8d5b32a848");
            httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");

            string url = "http://89.227.207.10:8080/Thingworx/Things/PSW.PP19307.Thing.Truck01/Properties/location";

            string jsonBody = @"{""location"": {""latitude"":" +
                location.Latitude.ToString().Replace(",", ".") + @",""longitude"": " +
                location.Longitude.ToString().Replace(",", ".") + @",""elevation"": 0.0}}";


            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync(url, content);
            Log.Debug("GPS", await response.Content.ReadAsStringAsync());
        }
    }
}