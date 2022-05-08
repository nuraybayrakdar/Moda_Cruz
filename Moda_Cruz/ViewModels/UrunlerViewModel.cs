using Moda_Cruz.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Text;
using Xamarin.Forms;

namespace Moda_Cruz.ViewModels
{
    public class UrunlerViewModel 
    {
        private ObservableCollection<Urunler> urunlerList;

        private List<Urunler> genderFilter;
        Urunler selectedGender;

        private List<Urunler> kategoriFilter;
        Urunler selectedKategori;

        private List<Urunler> markaFilter;
        Urunler selectedMarka;
        public Urunler SelectedGender
        {
            get { return selectedGender; }
            set
            {
                if (value != null)
                {
                    selectedGender = value;
                    
                }
            }
        }
        public Urunler SelectedKategori
        {
            get { return selectedKategori; }
            set
            {
                if (value != null)
                {
                    selectedKategori = value;

                }
            }
        }
        public Urunler SelectedMarka
        {
            get { return selectedMarka; }
            set
            {
                if (value != null)
                {

                    selectedMarka = value;
                }
            }
        }
        public List<Urunler> GenderFilter
        {
            get { return genderFilter; }
            set { genderFilter = value; }
        }
        public List<Urunler> KategoriFilter
        {
            get { return kategoriFilter; }
            set { kategoriFilter = value; }
        }
        public List<Urunler> MarkaFilter
        {
            get { return markaFilter; }
            set { markaFilter = value; }
        }
        public ObservableCollection<Urunler> UrunlerList
        {
            get { return urunlerList; }
            set { urunlerList = value; }
        }
        public UrunlerViewModel()
        {

            UrunlerList = GetUrunlerList();

            GenderFilter = Genders().OrderBy(t => t.Cinsiyet).ToList() ;
            KategoriFilter = Kategoriler().OrderBy(t => t.Kategori).ToList();
            MarkaFilter = GetUrunlerList().OrderBy(t => t.Marka).ToList();

        }
        public static List<Urunler> Genders()
        {
            return new List<Urunler>()
            {
                new Urunler(){ Cinsiyet = Urunler.Group.Kadın},
                new Urunler(){ Cinsiyet = Urunler.Group.Erkek}
            };
        }
        public static List<Urunler> Kategoriler()
        {
            return new List<Urunler>()
            {
                new Urunler(){ Kategori = Urunler.Cagetory.Gömlek},
                new Urunler(){ Kategori = Urunler.Cagetory.Ceket},
                new Urunler(){ Kategori = Urunler.Cagetory.Ayakkabı},
                new Urunler(){ Kategori = Urunler.Cagetory.Kazak},
                new Urunler(){ Kategori = Urunler.Cagetory.Elbise},
                new Urunler(){ Kategori = Urunler.Cagetory.Pantolon},
                new Urunler(){ Kategori = Urunler.Cagetory.Tişört},
                
            };
        }
        public static ObservableCollection<Urunler> GetUrunlerList()
        {
            return new ObservableCollection<Urunler>
            {
                new Urunler{Name="Elbise", Renk=Urunler.Color.Kırmızı, Marka="Beymen" ,  Price="90 TL", Beden=Urunler.Size.XS, Image="elbise1.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise,Durum=Urunler.Status.AzKullanılmış , Owner="tugce_81", OwnerPhoto="user1.jpeg", Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."} ,
                new Urunler{Name="Elbise", Renk=Urunler.Color.Beyaz, Marka="DeFacto" ,  Price="75 TL", Beden=Urunler.Size.M, Image="elbise2.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Elbise, Durum=Urunler.Status.YeniEtiketli, Owner="tugce_81",OwnerPhoto="user1.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ayakkabı", Renk=Urunler.Color.Beyaz, Marka="Nike" ,  Price="240 TL", Beden=Urunler.Size.L, Image="ayakkabi1.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek , Kategori=Urunler.Cagetory.Ayakkabı,Durum=Urunler.Status.AzKullanılmış, Owner="tugce_81",OwnerPhoto="user1.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Ayakkabı", Renk=Urunler.Color.Kırmızı, Marka="Puma" ,  Price="190 TL", Beden=Urunler.Size.S, Image="ayakkabi2.jpeg" ,
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
                new Urunler{Name="Turuncu Gömlek",Renk=Urunler.Color.Turuncu, Marka="Kırmızı Butik" ,  Price="75 TL", Beden=Urunler.Size.XS, Image="gomlek4.jpeg" ,
                    Cinsiyet=Urunler.Group.Erkek, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Çizgili Gömlek", Renk=Urunler.Color.Beyaz, Marka="FullaModa" ,  Price="54 TL", Beden=Urunler.Size.M, Image="gomlek1.jpeg" ,
                    Cinsiyet=Urunler.Group.Kadın, Kategori=Urunler.Cagetory.Gömlek,Durum=Urunler.Status.AzKullanılmış,Owner="selen34",OwnerPhoto="user3.jpeg",Description="Ürün yeni sayılır. Hediye geldi, bana büyük oldğu için satıyorum.Bu ürün kaçmaz."},
                new Urunler{Name="Beyaz Kazak", Renk=Urunler.Color.Beyaz, Marka="Moonlight" ,  Price="40 TL",Beden=Urunler.Size.L, Image="kazak.jpeg" ,
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
