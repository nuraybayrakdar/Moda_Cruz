using Moda_Cruz.Models;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Moda_Cruz.ViewModels
{
    public class UrunlerViewModel
    {
        private ObservableCollection<Urunler> urunlerList;
        public ObservableCollection<Urunler> UrunlerList
        {
            get { return urunlerList; }
            set { urunlerList = value; }
        }
        public UrunlerViewModel()
        {

            UrunlerList = GetUrunlerList();

        }
        public static ObservableCollection<Urunler> GetUrunlerList()
        {
            return new ObservableCollection<Urunler>
            {
                new Urunler{Name="Elbise", Renk=Urunler.Color.Kırmızı, Marka="Zara" ,  Price="90 TL", Beden=Urunler.Size.XS, Image="elbise1.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise,Durum=Urunler.Status.AzKullanılmış , Owner="tugce_81", OwnerPhoto="user1.jpeg", Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."} ,
                new Urunler{Name="Elbise", Renk=Urunler.Color.Beyaz, Marka="DeFacto" ,  Price="75 TL", Beden=Urunler.Size.M, Image="elbise2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise, Durum=Urunler.Status.YeniEtiketli, Owner="tugce_81",OwnerPhoto="user1.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ayakkabı", Renk=Urunler.Color.Beyaz, Marka="Nike" ,  Price="240 TL", Beden=Urunler.Size.L, Image="ayakkabi1.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek , Kategori=Urunler.Cagetory.Ayakkabı,Durum=Urunler.Status.AzKullanılmış, Owner="tugce_81",OwnerPhoto="user1.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ayakkabı", Renk=Urunler.Color.Kırmızı, Marka="Nike" ,  Price="190 TL", Beden=Urunler.Size.S, Image="ayakkabi2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ayakkabı,Durum=Urunler.Status.YeniEtiketli,Owner="tugce_81",OwnerPhoto="user1.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ceket", Renk=Urunler.Color.Siyah, Marka="Derimod" ,  Price="325 TL",Beden=Urunler.Size.XL, Image="ceket1.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Ceket,Durum=Urunler.Status.AzKullanılmış,Owner="aysenindolabi",OwnerPhoto="user2.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ceket",Renk=Urunler.Color.Mavi, Marka="Stradivarius" ,  Price="143 TL", Beden=Urunler.Size.M, Image="ceket2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ceket,Durum=Urunler.Status.YeniEtiketli,Owner="aysenindolabi",OwnerPhoto="user2.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ceket",Renk=Urunler.Color.Beyaz, Marka="Mango" ,  Price="179 TL", Beden=Urunler.Size.S, Image="ceket3.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Ceket, Durum=Urunler.Status.AzKullanılmış,Owner="aysenindolabi",OwnerPhoto="user2.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Gömlek", Renk=Urunler.Color.Beyaz, Marka="LC Waikiki" ,  Price="54 TL", Beden=Urunler.Size.L, Image="gomlek1.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="aysenindolabi",OwnerPhoto="user2.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Beyaz Gömlek", Renk=Urunler.Color.Beyaz, Marka="Addax" ,  Price="60 TL",Beden=Urunler.Size.S, Image="gomlek2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Mor Gömlek", Renk=Urunler.Color.Mor, Marka="Trendyolmilla" ,  Price="65TL", Beden=Urunler.Size.M, Image="gomlek3.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.YeniEtiketli,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Turuncu Gömlek",Renk=Urunler.Color.Turuncu, Marka="Turuncu" ,  Price="75 TL", Beden=Urunler.Size.XS, Image="gomlek4.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Çizgili Gömlek", Renk=Urunler.Color.Beyaz, Marka="LC Waikiki" ,  Price="54 TL", Beden=Urunler.Size.M, Image="gomlek1.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Beyaz Kazak", Renk=Urunler.Color.Beyaz, Marka="MAngo" ,  Price="40 TL",Beden=Urunler.Size.L, Image="kazak.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Kazak,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Pantolon",Renk=Urunler.Color.Beyaz, Marka="Zara" ,  Price="120 TL", Beden=Urunler.Size.M, Image="pant1.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Pantolon,Durum=Urunler.Status.YeniEtiketli,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Kumaş Pantolon", Renk=Urunler.Color.Kırmızı, Marka="LTB" ,  Price="95 TL", Beden=Urunler.Size.XS, Image="pant2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Pantolon,Durum=Urunler.Status.AzKullanılmış,Owner="serdaraksy",OwnerPhoto="user4.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Kot Pantolon", Renk=Urunler.Color.Mavi, Marka="Mavi" ,  Price="165 TL", Beden=Urunler.Size.XL, Image="pant3.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Pantolon,Durum=Urunler.Status.AzKullanılmış,Owner="serdaraksy",OwnerPhoto="user4.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Simli Tişört", Renk=Urunler.Color.Siyah, Marka="HM" ,  Price="85 TL", Beden=Urunler.Size.XS, Image="tisort1.jpeg" ,
                     Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Tişört,Durum=Urunler.Status.AzKullanılmış,Owner="serdaraksy",OwnerPhoto="user4.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Tişört", Renk=Urunler.Color.Siyah, Marka="Adidas" ,  Price="155 TL", Beden=Urunler.Size.S, Image="tisort2.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Tişört, Durum=Urunler.Status.YeniEtiketli,Owner="serdaraksy",OwnerPhoto="user4.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."}
            };
        }
       
    }
}
