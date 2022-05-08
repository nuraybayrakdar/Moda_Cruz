using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Moda_Cruz.ViewModels;
using Moda_Cruz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilteringView : ContentPage
    {
        IEnumerable<Urunler> geciciListe;
        IEnumerable<Urunler> geciciListe2;
        public FilteringView()
        {
           InitializeComponent();
        }
        public static string ToTitleCase(string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
        private async void ProductSelection3(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Urunler;
            await Navigation.PushModalAsync(new ProducDetailPage(itemSelected));
        }
        void SearchBar3TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {

          geciciListe = (IEnumerable<Urunler>)(cvFilter.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Cinsiyet.ToString().ToLower().StartsWith(e.NewTextValue)).ToList());
        }
        void SearchBar4TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if(geciciListe == null)
                cvFilter.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Marka.ToString().ToLower().StartsWith(e.NewTextValue)).ToList();
            else
                geciciListe2 = (IEnumerable<Urunler>)(cvFilter.ItemsSource = geciciListe.Where(s => s.Kategori.ToString().ToLower().StartsWith(e.NewTextValue)).ToList());


        }
        void SearchBar5TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if(geciciListe2 == null)
                cvFilter.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Marka.ToString().ToLower().StartsWith(e.NewTextValue)).ToList();

            else
                cvFilter.ItemsSource = geciciListe2.Where(s => s.Marka.ToLower().StartsWith(e.NewTextValue)).ToList();
        }
   
    }
}