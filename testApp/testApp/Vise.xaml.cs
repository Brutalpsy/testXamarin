using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp.ListExtension;
using testApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Vise : ContentPage
	{
        public ObservableCollection<Pie> pies { get; set; }
		public Vise()
		{
			InitializeComponent ();
            pies = new FakePieRepo().GetAll().ToObservableCollection<Pie>();
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            //var firstPie = pies.SingleOrDefault(x =>x.Id==1);

            //firstPie.Price += 22.11M;

            pies = pies.Select(x =>
            {
                x.Price += 22.12M;
                return x;
            }).ToObservableCollection<Pie>();

            DisplayAlert("Price changed", "changed", "Cancel");
        }
    }
}