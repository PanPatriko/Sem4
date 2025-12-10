using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThingworxLab2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PropertyList = new ObservableCollection<String> { "humidity", "temperature" };
            EntryURL.Text = URL;
            EntryAppKey.Text = AppKey;
            BindingContext = this;
        }
        public ObservableCollection<String> PropertyList { get; set; }
        private string URL = "http://89.227.207.10:8080/Thingworx/Things/PSW.PP19307.Thing.MojSensor01/Properties/";
        private string AppKey = "499b9165-cfd6-4e1b-b0fc-8d8d5b32a848";
        async private void Button_Clicked(object sender, EventArgs e) //read
        {
            if(PickerProperty.SelectedItem!=null)
            {
                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("x-thingworx-session", "true");
                httpClient.DefaultRequestHeaders.Add("appkey", EntryAppKey.Text);
                httpClient.DefaultRequestHeaders.Add("accept", "application/json");

                HttpResponseMessage response = await httpClient.GetAsync(EntryURL.Text + PickerProperty.SelectedItem.ToString());
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    JObject jObject = JObject.Parse(result);
                    string property = PickerProperty.SelectedItem.ToString();

                    LabelCurrentValue.Text = jObject["rows"][0][property].ToString();
                }
                else
                {
                    await DisplayAlert("Alert", "Something went wrong :(", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alert", "No property selected :(", "OK");
            }

        }

        async private void Button_Clicked_1(object sender, EventArgs e) //update
        {
            if (PickerProperty.SelectedItem != null)
            {
                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("x-thingworx-session", "true");
                httpClient.DefaultRequestHeaders.Add("appkey", EntryAppKey.Text);
                httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
                httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                // httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");

                string property = PickerProperty.SelectedItem.ToString();
                string value = EntryNewValue.Text;
                string jsonBody = "{\"" + property + "\":" + value + "}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(EntryURL.Text + PickerProperty.SelectedItem.ToString(), content);
                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Alert", "Property changed succesfully :)", "OK");
                }
                else
                {
                    await DisplayAlert("Alert", "Something went wrong :(", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alert", "No property selected :(", "OK");
            }

        }
    }
}
