using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Moda_Cruz.Models;
using Moda_Cruz.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProducDetailPage : ContentPage
    {
       
        public ProducDetailPage(Urunler itemSelected)
        {
            InitializeComponent();
            
            DetailName.Text = itemSelected.Name;
            DetailBeden.Text = itemSelected.Beden.ToString();
            DetailImage.Source = itemSelected.Image;
            DetailPrice.Text = itemSelected.Price;
            DetailRenk.Text = itemSelected.Renk.ToString();
            DetailOwner.Text = itemSelected.Owner;
            DetailOwnerPhoto.Source = itemSelected.OwnerPhoto;
            DetailDurum.Text =itemSelected.Durum.ToString();
            DetailGender.Text = itemSelected.Cinsiyet.ToString();
            DetailDesc.Text ="Açıklama: " + itemSelected.Description;
        }
        public void BackButtonClicked(object o, EventArgs args)
        {
             Navigation.PopModalAsync();
        }
        public async void SepeteEkle(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SepetView(DetailImage.Source,DetailName.Text,DetailPrice.Text,DetailOwner.Text, DetailRenk.Text, DetailDurum.Text, DetailBeden.Text));
           // new SepetView(DetailImage.Source, DetailName.Text, DetailPrice.Text, DetailOwner.Text,DetailRenk.Text,DetailDurum.Text,DetailBeden.Text);
        }
        public async void FavorilereEkle(object sender, EventArgs args)
        {

           // FavorilerViewModel.GetFavUrunlerList(DetailImage.Source, DetailName.Text, DetailPrice.Text, DetailOwner.Text, DetailRenk.Text, DetailDurum.Text, DetailBeden.Text);
            await Navigation.PushModalAsync(new FavoriTab(DetailImage.Source, DetailName.Text, DetailPrice.Text, DetailOwner.Text, DetailRenk.Text, DetailDurum.Text, DetailBeden.Text));
            
        }


    }
}