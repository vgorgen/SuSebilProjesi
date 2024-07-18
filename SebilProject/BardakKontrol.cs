using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebilProject
{
    public class BardakKontrol
    {
        public string _bardak;
        public event EventHandler<bool> BardakDegisti;
        public int bardakMiktarı;
        public void setBardak(string bardak)
        {
            
            this._bardak = bardak;
            
            if (_bardak == "Küçük(100 ml)")
            {
                bardakMiktarı = 100;
                OnBardakDegisti(true);
            }
            else if(_bardak == "Orta(200 ml)")
            {
                bardakMiktarı = 200;
                OnBardakDegisti(true);
            }
            else if(_bardak == "Büyük(400 ml)")
            {
                bardakMiktarı = 400;
                OnBardakDegisti(true);
            }
            else
            {
                Console.WriteLine("Geçersiz bardak boyu!");
                OnBardakDegisti(false);
            }
            
            //Console.WriteLine("Bardağınız " + this._bardak + " boy olarak ayarlandı!");
        }

        public string getBardak()
        {
            if(_bardak != null)
            {
                return _bardak;
                
            }
            else
            {
                return "Lütfen bardak boyunu seçiniz!";
            }
            
        }

        protected virtual void OnBardakDegisti(bool BardakDegistimi)
        {
            BardakDegisti?.Invoke(this, BardakDegistimi);
        }


    }
}
