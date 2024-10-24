namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba("Skoda","Fabia","Mavi",4); // a1 adında nesne oluşmuştur
            
            Araba a2 = new Araba("Renault","Clio","Turunucu",5); // a2 adında nesne oluşmuştur.
           
            Console.WriteLine("Araba 1: " );
            Console.WriteLine( a1.marka + " " + a1.model + ", Renk: " + a1.renk + ", Kapı Sayısı: " + a1.Kapisayisi);
            Console.WriteLine("Araba 2: " );
            Console.WriteLine(a2.marka + " " + a2.model + ", Renk: " + a2.renk + ", Kapı Sayısı: " + a2.Kapisayisi);
        }

    }
    
}
