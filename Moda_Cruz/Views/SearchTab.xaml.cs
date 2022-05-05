using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Moda_Cruz.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Moda_Cruz.Models;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchTab : ContentPage
    {
       
        public SearchTab()
        {
            InitializeComponent();
            cv.ItemsSource = UrunlerViewModel.GetUrunlerList();
        }
        void SearchBar2Text(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            cv.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Name.StartsWith(e.NewTextValue)).ToList();
        }
        private async void ProductSelection2(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Urunler;
            await Navigation.PushModalAsync(new ProducDetailPage(itemSelected));

        }

    }
}