using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThingworxLab4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Unsubscribe<Location>(this, "locationValue");
            MessagingCenter.Subscribe<Location>(this, "locationValue", (value) =>
            {
                 Device.BeginInvokeOnMainThread(() =>
                 {
                     latitude.Text = value.Latitude.ToString();
                     longitude.Text = value.Longitude.ToString();
                 });
            });
        }

        private void StartService(object sender, EventArgs e)
        {
            MessagingCenter.Send<string>("1", "GpsService");
            info.Text = "Trwa śledzenie lokalizacji";
        }
        private void StopService(object sender, EventArgs e)
        {
            MessagingCenter.Send<string>("0", "GpsService");
            info.Text = "Śledzenie lokalizacji zatrzymane";

        }
    }
}
