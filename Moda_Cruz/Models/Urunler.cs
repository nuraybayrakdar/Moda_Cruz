using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Moda_Cruz.Models;

namespace Moda_Cruz.Models
{
    public class Urunler 
    { 
        public string Name {set;get;}
        public string Marka { get; set; }
        public Size Beden{ get; set; }
        public enum Size { XS,S,M,L,XL }
        public string Price { get; set; }
        public enum Color { Siyah,Beyaz,Kırmızı,Mavi,Mor,Turuncu,Sarı}
        public Color Renk { get; set; }
        public string Image { get; set; }
        public enum Group { Kadın ,Erkek }
        public Group Cinsiyet { get; set; }
        public enum Cagetory {Elbise, Ceket, Gömlek, Kazak , Ayakkabı, Pantolon, Tişört}
        public Cagetory Kategori { get; set; }
        public enum Status { YeniEtiketli, AzKullanılmış };
        public Status Durum { get; set; }
        public string Owner { get; set; }
        public string OwnerPhoto{ get; set; }
        public string Description { get; set; }

    }
}
