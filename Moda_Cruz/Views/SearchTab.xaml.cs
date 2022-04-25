using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchTab : ContentPage
    {
        ObservableCollection<Urunler> urunler2;
        public SearchTab()
        {
            InitializeComponent();
            urunler2 = new ObservableCollection<Urunler>
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
                new Urunler{Name="Beyaz Gömlek", Color="Beyaz", Marka="Addax" ,  Price="60 TL", Size="Beden:M", Image="gomlek2.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek},
                new Urunler{Name="Mor Gömlek", Color="Mor", Marka="Trendyolmilla" ,  Price="65TL", Size="Beden:S", Image="gomlek3.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek},
                new Urunler{Name="Turuncu Gömlek", Color="", Marka="Turuncu" ,  Price="75 TL", Size="L", Image="gomlek4.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek},
                new Urunler{Name="Çizgili Gömlek", Color="Beyaz", Marka="LC Waikiki" ,  Price="54 TL", Size="Beden:L", Image="gomlek1.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek},
                new Urunler{Name="Beyaz Kazak", Color="Beyaz", Marka="MAngo" ,  Price="40 TL", Size="Beden:XS", Image="kazak.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Kazak},
                new Urunler{Name="Canvas Pantolon", Color="Krem", Marka="Zara" ,  Price="120 TL", Size="Beden:40", Image="pant1.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Pantolon},
                new Urunler{Name="Kumaş Pantolon", Color="Kırmızı", Marka="LTB" ,  Price="95 TL", Size="Beden:38 ", Image="pant2.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Pantolon},
                new Urunler{Name="Kor Pantolon", Color="Mavi", Marka="Mavi" ,  Price="165 TL", Size="Beden:38", Image="pant3.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Pantolon},
                new Urunler{Name="Simli Tişört", Color="Siyah", Marka="HM" ,  Price="85 TL", Size="Beden:L", Image="tisort1.jpeg" ,
                    Gender=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Tişört},
                new Urunler{Name="Siyah Tişört", Color="Siyah", Marka="Adidas" ,  Price="155 TL", Size="Beden:L", Image="tisort2.jpeg" ,
                    Gender=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Tişört}
            };
            Urunlerim2.ItemsSource = urunler2;
        }
        private void searchbar2TextChanged(object sender, TextChangedEventArgs e)
        {

            var filteredlist = urunler2.Where(a => a.Name.StartsWith(e.NewTextValue));
            Urunlerim2.ItemsSource = filteredlist;

        }
    }
}