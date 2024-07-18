using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Threading;

namespace SebilProject
{
    internal class Program
    {

        private static SuTank _suTank = new SuTank();
        private static IsıKontrol _ısıKontrol = new IsıKontrol();
        private static BardakKontrol bardak = new BardakKontrol();
        private static bool cıkıs = false;
        private static int choice;
        private static bool flag = false;
        [DllImport("user32.dll")]
        public static extern short GetKeyState(int nVirtKey);







        static void Main(string[] args)
        {
            _suTank.setSuMiktarı(5000);
            _suTank.SuTankıDegisti += Tank_SuMiktarıDeğişti;
            _ısıKontrol.SuSıcaklıkDegisti += Su_SıcaklıkDegisti;
            bardak.BardakDegisti += Bardak_BoyDegisti;
            while (!cıkıs)
            {


                AnaMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Thread.Sleep(1000);

                        SuEkle();


                        break;
                    case 2:
                        SicakligiAyarla();

                        break;
                    case 3:
                        SicaklikGosterimi();
                        break;
                    case 4:
                        BardakSecimi();

                        break;
                    case 5:
                        SuDoldur();
                        break;
                    case 6:
                        cıkıs = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }



        }



        // Su miktarı değiştiğinde çağrılacak metod
        private static void Tank_SuMiktarıDeğişti(object sender, bool suDegistimi)
        {
            Console.WriteLine(suDegistimi ? $"Su miktarı değişti(EventHandler)\nGüncel Su Miktarı: {_suTank.getSuMiktarı()}" : "Su miktarı değiştirilemedi!(EventHandler)");

        }

        //Su sıcaklık değiştiğinde çağrılacak metod
        private static void Su_SıcaklıkDegisti(object sender, bool SıcaklıkDegistimi)
        {
            Console.WriteLine(SıcaklıkDegistimi ? $"Su sıcaklığı değişti!(EventHandler)\nGüncel Sıcaklık: {_ısıKontrol.getSıcaklık()}" : "Su Sıcaklığı Değiştirilemedi");
        }

        //Bardak boyu değiştiğinde çağrılacak metod
        private static void Bardak_BoyDegisti(object sender, bool BardakDegistimi)
        {
            Console.WriteLine(BardakDegistimi ? $"Bardak Boyu Değiştirildi!(EventHandler)\nGüncel Bardak Boyu {bardak.getBardak()}" : "Bardak boyu değiştirilemedi");
        }

        private static void AnaMenu()
        {
            Console.WriteLine("Hoş geldiniz! Lütfen yapmak istediğiniz işlemi seçin: ");


            Console.WriteLine("1. Su Ekle");
            Console.WriteLine("2. Su Sıcaklığını Ayarla");
            Console.WriteLine("3. Sıcaklığı göster");
            Console.WriteLine("4. Bardak Seçimi");
            Console.WriteLine("5. Su Doldur");
            Console.WriteLine("6. Çıkış");
        }

        private static void SuEkle()
        {
            const int VK_1 = 0x31;  // 1 tuşunun sanal kodu
            short state = GetKeyState(VK_1);
            if ((state & 0x8000) != 0)
            {
                flag = true;
            }
            while (flag)
            {
                int state2 = GetKeyState(VK_1);
                if ((state2 & 0x8000) != 0)
                {
                    Console.WriteLine("Key is pressed");
                    _suTank.SuEkle(5);
                    Console.WriteLine("Su eklendi! Güncel su miktarı: " + _suTank.getSuMiktarı());
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Key is not pressed");
                    Thread.Sleep(1000);
                    if ((state2 & 0x8000) != 0)
                    {
                        flag = true;
                    }
                    flag = false;

                }


            }




        }

        private static void SicaklikGosterimi()
        {
            if (_ısıKontrol._sicaklik != null)
            {
                Console.WriteLine("Su sıcaklığı: " + _ısıKontrol.getSıcaklık());
            }
            else
            {
                Console.WriteLine("Sıcaklık ayarlanmamış! Lütfen öncelikle sıcaklığı ayarlayın.");
            }

        }

        private static void SicakligiAyarla()
        {
            Console.WriteLine("Sıcaklık seçimini yapınız lütfen: ");
            Console.WriteLine("1. Sıcak");
            Console.WriteLine("2. Ilık");
            Console.WriteLine("3. Soğuk");
            int sicaklik = Convert.ToInt32(Console.ReadLine());
            switch (sicaklik)
            {
                case 1:
                    _ısıKontrol.setSıcaklık("Sıcak");
                    break;
                case 2:
                    _ısıKontrol.setSıcaklık("Ilık");
                    break;
                case 3:
                    _ısıKontrol.setSıcaklık("Soğuk");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }


        private static void BardakSecimi()
        {
            Console.WriteLine("Bardak seçimi yapınız: ");
            Console.WriteLine("1. Küçük");
            Console.WriteLine("2. Orta");
            Console.WriteLine("3. Büyük");
            int bardakSecim = Convert.ToInt32(Console.ReadLine());

            switch (bardakSecim)
            {
                case 1:

                    bardak.setBardak("Küçük(100 ml)");
                    break;
                case 2:
                    bardak.setBardak("Orta(200 ml)");
                    break;
                case 3:
                    bardak.setBardak("Büyük(400 ml)");
                    break;
                default:
                    bardak.setBardak(bardakSecim.ToString());
                    break;

            }
        }

        private static void SuDoldur()
        {

            if (_ısıKontrol.getSıcaklık() != "Lütfen sıcaklığı seçiniz!" || bardak.getBardak() != "Lütfen bardak boyunu seçiniz!")
            {
                Console.WriteLine("Su sıcaklık seçiminiz: " + _ısıKontrol.getSıcaklık());
                Console.WriteLine("Bardak seçiminiz: " + bardak.getBardak());
                Console.WriteLine("İşlemlerinizi onaylıyor musunuz (E/H): ");
                char onay = Console.ReadKey().KeyChar;
                Console.ReadLine();
                int eksilen_su_miktarı = 10;
                int total_eksilen_su_miktarı = 0;
                if (onay == 'E' || onay == 'e')
                {
                    Thread.Sleep(1000);
                    if (_suTank.getSuMiktarı() >= bardak.bardakMiktarı)
                    {

                        const int VK_1 = 0x31;  // 1 tuşunun sanal kodu
                        short state = GetKeyState(VK_1);
                        if ((state & 0x8000) != 0)
                        {
                            flag = true;
                        }

                        while (flag && (total_eksilen_su_miktarı != bardak.bardakMiktarı))
                        {
                            Console.WriteLine("Su dolduruluyor lütfen bekleyiniz!");
                            short state2 = GetKeyState(VK_1);
                            if ((state2 & 0x8000) != 0)
                            {
                                Console.WriteLine("Key is pressed");
                                _suTank.SuÇıkar(eksilen_su_miktarı);
                                total_eksilen_su_miktarı += eksilen_su_miktarı;
                                Console.WriteLine("Su eklendi! Güncel su miktarı: " + _suTank.getSuMiktarı());
                                Thread.Sleep(300);
                            }
                            else
                            {
                                Console.WriteLine("Key is not pressed");
                                Thread.Sleep(1000);
                                if ((state & 0x8000) != 0)
                                {
                                    flag = true;
                                }
                                flag = false;
                            }

                            //Console.WriteLine("Eklenecek su miktarını giriniz: ");
                            //int eklenecek_su_miktarı = Convert.ToInt32(Console.ReadLine());


                        }

                    }
                    else
                    {
                        Console.WriteLine("Su miktarı yetersiz!");
                    }
                }
                else
                {
                    Console.WriteLine("İşlem iptal edildi!");
                }
            }
            else
            {
                Console.WriteLine("Lütfen önce sıcaklık ve bardak seçimi yapınız!");
            }
        }
    }
}
