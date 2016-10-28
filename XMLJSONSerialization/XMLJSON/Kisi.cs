using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace XMLJSON
{
    public class Kisi
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public decimal Maas { get; set; }
        public bool KadinMi { get; set; }
        public byte[] Fotograf { get; set; }
        public override string ToString() => $"{this.Ad} {this.Soyad}";
        //{
        //        return String.Format("{0} {1}",this.Ad,this.Soyad);
        //}
    }
}
