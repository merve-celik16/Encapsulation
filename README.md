# Pratik - Encapsulation
Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.

 * Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

 * Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

 * Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.

   ## Kod Açıklaması :
   * Kapsülleme: Bir nesnenin iç durumunu korumak ve dışarıdan erişimi kontrol etmek için kullanılan bir kavramdır. Bu örnekte KapiSayisi özelliği için kapsülleme yaparak, bu özelliğe sadece get ve set metotları aracılığıyla erişim sağlıyoruz.
   * Private Değişken: kapiSayisi adında private bir değişken tanımlayarak, bu değişkene dışarıdan doğrudan erişimi engelledik.
   * Set Metodu: KapiSayisi özelliğine değer atanırken tetiklenen metottur. Bu metotta, atanan değerin 2 veya 4 olup olmadığını kontrol ediyoruz. Eğer değilse, bir uyarı mesajı veriyoruz ve _kapiSayisi değişkenine -1 değerini atıyoruz.
   * Get Metodu: KapiSayisi özelliğinden değer okunurken tetiklenen metottur. Bu metot, _kapiSayisi değişkeninin değerini döndürür.
   
