using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_Project
{
    public class KullaniciModel
    {
        public string KullaniciAdi; 

        public string AdSoyad;

        public bool isOperator;

        public double ToplamRC;

        public string SHA256;

        public DateTime OlusturulmaTarihi;

        public bool isAccessGranted;

        public string KullaniciSifre;

    }

    public class UrunModel
    {
        public string NesneAdi;

        public string KarbonPoint;

        public int GeriDonusumTip;

        public DateTime OlusturulmaTarihi;
    }
}
