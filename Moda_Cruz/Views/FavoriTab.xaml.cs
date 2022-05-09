using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moda_Cruz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Moda_Cruz.ViewModels;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriTab : ContentPage
    {
        public FavoriTab(ImageSource Source, string Name, string Price, string Owner, string Renk, string Durum, string Beden)
        {
            InitializeComponent();
            FavImage.Source = Source;
            FavName.Text = Name;
            FavPrice.Text = "Tutar: " + Price;
            FavSatici.Text = "Satıcı: " + Owner;
            FavRenk.Text = "Renk" + Renk;
            FavDurum.Text = Durum;
            FavBeden.Text = "Beden: " + Beden;
        }
        public void BackButtonClicked1(object o, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
    }
}