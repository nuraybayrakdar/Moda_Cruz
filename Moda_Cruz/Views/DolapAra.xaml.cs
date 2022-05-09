using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moda_Cruz.ViewModels;
using Xamarin.Forms;
using Moda_Cruz.Models;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DolapAra : ContentPage
	{
		public DolapAra ()
		{
			InitializeComponent ();
		}
		void Dolap_Ara(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			Dolaplar.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Owner.ToLower().StartsWith(e.NewTextValue)).ToList();
		}
		
	}
}