using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SebilProject
{
    public class SuTank
    {
        public float suMiktarı;
        private float maxCapacity = 20000;
        public event EventHandler<bool> SuTankıDegisti;
        public event EventHandler<bool> SuTankıBosmu;

        public float getSuMiktarı()
        {
            if(Convert.ToString(suMiktarı) != null)
            {
                return suMiktarı;                
            }
            else
            {
                return 0;
            }
        }

        public void SuEkle(float miktar)
        {
            if(suMiktarı <= maxCapacity && suMiktarı > 0)
            {
                if((maxCapacity - suMiktarı) > miktar)
                {
                    Console.WriteLine("Su tankında su var");
                    suMiktarı += miktar;
                    OnSuTankıDegisti(true);
                    
                }
                else
                {
                    OnSuTankıDegisti(false);
                }
                
            }
            else
            {
                if(suMiktarı <= 0)
                {
                    OnSuTankıBosmu(true);
                }
                else
                {
                    OnSuTankıBosmu(false);
                }
            }
        }
        public void SuÇıkar(float miktar)
        {
            suMiktarı -= miktar;
            OnSuTankıDegisti(true);
        }
    
        public void setSuMiktarı(float suMiktarı)
        {
            this.suMiktarı = suMiktarı;
         
        }

        

        protected virtual void OnSuTankıDegisti(bool SuEklendimi)
        {
            SuTankıDegisti?.Invoke(this, SuEklendimi);
        }

        protected virtual void OnSuTankıBosmu(bool SuBosmu)
        {
            SuTankıBosmu?.Invoke(this, SuBosmu);
        }
        
    }
}
