using Moda_Cruz.Models;
using Moda_Cruz.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class HomeTab : ContentPage
    {
        

        public HomeTab()
        {
            InitializeComponent();
            List<Images> images = new List<Images>()
            {
               new Images(){Title="Img2", Url="https://i.hizliresim.com/swioar9.jpg"},
               new Images(){Title="Img1", Url="https://i.hizliresim.com/5gcs6r6.jpeg"},
               new Images(){Title="Img3", Url="https://i.hizliresim.com/pnumf7t.jpeg"},
               new Images(){Title="Img4", Url="https://i.hizliresim.com/628ovj7.jpeg"},
               new Images(){Title="Img5", Url="https://i.hizliresim.com/s7ol4vr.jpeg"},

            };
            Carousel.ItemsSource = images;
            cv2.ItemsSource = UrunlerViewModel.GetUrunlerList();
            
        }
        private void Searchbar1TextChanged(object sender, TextChangedEventArgs e)
        {
            cv2.ItemsSource = UrunlerViewModel.GetUrunlerList().Where(s => s.Name.StartsWith(e.NewTextValue)).ToList();

        } 
        public async void ProductSelection(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Urunler;    
            await Navigation.PushModalAsync(new ProducDetailPage(itemSelected));
                    
        }
        

       
    }
}