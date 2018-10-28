using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using testApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private Pie pie;
        public MainPage()
        {
            //DisplayAlert("neki title", "w", "izadji mala");
            InitializeComponent();

            pie = new FakePieRepo().GetSingle();
            this.BindingContext = pie;

            var data = GetData();
            DisplayAlert("neki title", data.ToString(), "izadji mala");
        }

        private async Task<string> GetData()
        {
            var client = createHttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:8107/api/users");
            if (response.IsSuccessStatusCode)
            {
                string someMessage = await response.Content.ReadAsStringAsync();
                return someMessage;
            }
            return string.Empty;

        }

        public HttpClient createHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            pie.Price += 177;
        }
       
    }
}
