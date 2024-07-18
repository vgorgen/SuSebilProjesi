using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SebilProject
{
    internal class IsıKontrol
    {
        public string _sicaklik;
        public event EventHandler<bool> SuSıcaklıkDegisti;

        public string getSıcaklık()
        {
            if (_sicaklik == "Sıcak" || _sicaklik == "Ilık" || _sicaklik == "Soğuk")
            {
                return _sicaklik;
            }
            else
            {

                return "Lütfen sıcaklığı seçiniz!";
            }

        }

        public void setSıcaklık(string sıcaklık)
        {
            if (sıcaklık == "Sıcak" || sıcaklık == "Ilık" || sıcaklık == "Soğuk")
            {
                this._sicaklik = sıcaklık;
                OnSuSıcaklıkDegisti(true);
            }
            else
            {
                Console.WriteLine("Geçersiz sıcaklık durumu");
                OnSuSıcaklıkDegisti(false);
            }

        }


        protected virtual void OnSuSıcaklıkDegisti(bool SıcaklıkDegisti)
        {
            SuSıcaklıkDegisti?.Invoke(this, SıcaklıkDegisti);
        }


    }
}
