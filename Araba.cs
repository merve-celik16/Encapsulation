using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        public string marka { get; set; } 
        public string model { get; set; }
        public string renk { get; set; }

        private int kapiSayisi; // private ile kapsülleme yapıldı.

        
        public int Kapisayisi // Kapsülleme yapıldığı için get ve set metotu kullanıldı
        {
            get
            {
                return kapiSayisi;

            }
            set
            {
                
                if (value == 2 || value == 4) // Girilen değer 2 veya 4 e eşit ise kapısı sayısını atayacak
                {
                    kapiSayisi = value;
                }
                else // girilen kapı sayısı 2 veya 4 değil ise -1 olacak
                {
                    Console.WriteLine("Bir arabanın kapı sayısı 2 veya 4 olabilir. Kapı sayısı -1 olarak ayarlandı.");
                    kapiSayisi = -1;
                }
            }

        }
        public Araba(string _marka, string _model, string _renk, int _kapisayisi) // Parametreli yapıcı metot tanımlanmıştır
        {
            marka = _marka;
            model = _model; 
            renk = _renk;
            Kapisayisi= _kapisayisi;
        }
    }

}
