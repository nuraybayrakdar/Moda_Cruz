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
        ObservableCollection<Urunler> urunler;
        public HomeTab()
        {
            InitializeComponent();
            List<Image> images = new List<Image>()
            {
               new Image(){Title="Img1", Url="https://i.hizliresim.com/5gcs6r6.jpeg"},
               new Image(){Title="Img3", Url="https://i.hizliresim.com/pnumf7t.jpeg"},
               new Image(){Title="Img3", Url="https://i.hizliresim.com/628ovj7.jpeg"},
               new Image(){Title="Img3", Url="https://i.hizliresim.com/s7ol4vr.jpeg"},

            };
            Carousel.ItemsSource = images;
            urunler = new ObservableCollection<Urunler>
            {
                new Urunler{Name="Elbise", Color="Kırmızı", Marka="Zara" ,  Price="90 TL", Size="Beden:M", Image="elbise1.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise},
                new Urunler{Name="Elbise", Color="Beyaz", Marka="DeFacto" ,  Price="75 TL", Size="Beden:L", Image="elbise2.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise},
                new Urunler{Name="Ayakkabı", Color="Beyaz", Marka="Nike" ,  Price="240 TL", Size="Beden:42", Image="ayakkabi1.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Ayakkabı},
                new Urunler{Name="Ayakkabı", Color="Kırmızı", Marka="Nike" ,  Price="190 TL", Size="Beden:28", Image="ayakkabi2.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ayakkabı},
                new Urunler{Name="Ceket", Color="Siyah", Marka="Derimod" ,  Price="325 TL", Size="Beden:L", Image="ceket1.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Ceket},
                new Urunler{Name="Ceket", Color="Mavi", Marka="Stradivarius" ,  Price="143 TL", Size="Beden:S", Image="ceket2.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ceket},
                new Urunler{Name="Ceket", Color="Beyaz", Marka="Mango" ,  Price="179 TL", Size="Beden:M", Image="ceket3.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ceket},
                new Urunler{Name="Gömlek", Color="Beyaz", Marka="LC Waikiki" ,  Price="54 TL", Size="Beden:L", Image="gomlek1.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek}, 
            };
            Urunlerim.ItemsSource = urunler;
        }
        private void searchbar1TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredlist = urunler.Where(a => a.Name.StartsWith(e.NewTextValue));
            Urunlerim.ItemsSource = filteredlist;

        }
    }
}