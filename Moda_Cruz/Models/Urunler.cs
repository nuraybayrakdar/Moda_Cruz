using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Moda_Cruz.Models
{
    public class Urunler 
    { 
        public string Name {set;get;}
        public string Marka { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
       
        public string Color { get; set; }
        public string Image { get; set; }
        public enum Group { Kadın ,Erkek }
        public Group Gender { get; set; }
        public enum Cagetory {Elbise, Ceket, Gömlek, Kazak , Ayakkabı, Pantolon, Tişört}
        public Cagetory Kategori { get; set; }

       
    }
}
