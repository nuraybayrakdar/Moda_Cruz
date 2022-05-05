using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moda_Cruz.ViewModels;
using Moda_Cruz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SepetView : ContentPage
	{
		public SepetView ( ImageSource Source,string Name, string Price ,string Owner,string Renk,string Durum,string Beden)
		{
			InitializeComponent ();
			SepetImage.Source = Source;
			SepetName.Text =  Name;
			SepetPrice.Text = "Tutar: " + Price;
			SepetSatici.Text = "Satıcı: " + Owner;
			SepetRenk.Text = "Renk" + Renk;
			SepetDurum.Text = Durum;
			SepetTutar.Text = "Toplam: " + Price;
			SepetBeden.Text = "Beden: "+Beden;
		}
		
	}
}