using System;
using System.Collections.Generic;
using System.Text;

namespace Moda_Cruz.Views
{
    class Urunler
    { 
        public string Name { get; set; }
        public string Marka { get; set; }
        public string Size { get; set; }
        public String Price { get; set; }
        public string Color { get; set; }
        public String Image { get; set; }
        public enum Group { Kadın ,Erkek }
        public Group Gender { get; set; }
        public enum Cagetory {Elbise, Ceket, Gömlek, Kazak , Ayakkabı, Pantolon, Tişört}
        public Cagetory Kategori { get; set; }
    }
}
