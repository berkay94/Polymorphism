using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08012019
{
    class MyClass
    {
        public class Urun
        {
            public int Id { get; set; }
            public string UrunAd { get; set; }
            public int Yukseklik { get; set; }

            public virtual int Hacim()//virtual olduğu zaman inherit edildiği clasın içinde yeniden çağrılabilir
            {
                double hacim = Math.Pow(Convert.ToDouble(Yukseklik), 3);
                return Convert.ToInt32(hacim);
            }

            public int Fire()
            {
                return Convert.ToInt32(this.Hacim() * 0.20f);
            }
        }

        public class KupKutu : Urun
        {

        }

        public class DortgenKutu : Urun
        {
            public int KısaKenar { get; set; }
            public int UzunKenar { get; set; }
            public override int Hacim()
            {
                return Yukseklik * KısaKenar * UzunKenar;
            }


        }

        public class Silindir:Urun
        {
            private int yaricap;

            public int YariCap
            {
                get { return yaricap; }
                set { yaricap = value; }
            }
            public override int Hacim()
            {
                double hacim = (Math.Pow(yaricap, 2) * Yukseklik * Math.PI);
                return Convert.ToInt32(hacim);
            }
        }
    }
}
