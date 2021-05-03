using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------------------------------------------OPERATÖRLER----------------------------------------------------------------------------------*/

            // ------------------------------------------------------------Aritmatik operatörleri:

            // --------------------------Toplama Operatörü: +  ------------------------------
            // --------------------------Çıkarma Operatörü: -  ------------------------------

            byte sayi1 = 149;
            int sayi2 = 359;

                Console.WriteLine(sayi1 + sayi2);  // burda bizim için sayi1 ve sayi2 olarak atadığımız sayıları bizim için topladı.
                Console.WriteLine(sayi1 - sayi2);  // burda bizim için sayi1 den sayi2 yi çıkarttı ve ekrana yazdırdı.

            int sonuc = sayi1 + sayi2;
            int cikartmaSonuc = sayi1 - sayi2;
            int ToplaCikar = (sayi2 + sayi1) - sayi1;

                Console.WriteLine(sonuc);            // yukardakiyle aynı cevabı vercek bize vercektir sadece farklı yöntem olsun diye yazdım.
                Console.WriteLine(cikartmaSonuc);   // buda çıkartmanın aynısı.
                Console.WriteLine(ToplaCikar);     // burda  sayi bie ve ikiyi topladıktan sonra sayi1 değerini tekrar çıkardı.


         
           
            // -------------------------Çarpma Operatör: *  -----------------------------------
            // -------------------------Bölme Operatörü: / ------------------------------------


            byte sayiB = 50;
            byte sayiB2 = 25;

            int sonucBol = sayiB / sayiB2;               // burda sayiB yi sayiB2 ye böldük.
            int sonuccarp = sayiB2 * sayiB;             // burda da sayiB'yle sayiB2 yi çarptık.

                Console.WriteLine(sonucBol);          // burda da sonuçları ekrana yazdırdık.
                Console.WriteLine(sonuccarp);

            // ---------------------------Mod Alma Operatörü: % ----------------------------------

            byte sayiMod = 14;
            byte sayiMod2 = 3;

                Console.WriteLine(sayiMod % sayiMod2); // burda 14 sayısını 3 e böldük ve kalanı ekrana yazdırmış olduk. sonuç 2 olcaktır.


            //----------------------------- Arttırma Operatörü:++ -----------------------------------
            //----------------------------- Azaltma Operatörü : --   --------------------------------


            byte sayimiz = 150;                  // burda sayimiz değişkeninin içine 150 sayısını ekledik yani sayimiz = 150 şuan

            sayimiz++;                         // burda sayimiz değerine 1 ekledik yani sayimiz değeri bundan sonra 151 oldu 
                Console.WriteLine(sayimiz);   // burda sayimiz değerini yazdırdık yani en son yaptığımız 151 değeri ekrana yazıldı
            sayimiz--;                       // burda en son eklediğimiz 1 değeri tekrar çıkardık yani "--" eksi eksi yaptığımızda yani 1 çıkarcak.
                Console.WriteLine(sayimiz); // burda 150 sayısını ekrana yazdırcak çünkü en son sayimiz değerinden 1 çıkardık 151 yapmıştık tekrar 1 çıkardığımızda 150 sayısını elde ettik


            

            // ------------------------------ Atama Operatörü: = ----------------------------------------

            byte sayiATa = 25; // burda sayiATa değişkeninin içine 25 değerini atamış olduk 

                Console.WriteLine(sayiATa);


           



            // ---------------------------------------------------------------------KARŞILAŞTIRMA OPERATÖRLERİ------------------------------------------------------------------------------------



            // -----------------------------------------------Büyüktür Operatörü : > 
            // -----------------------------------------------Küçüktür Operatörü : <



            bool Kontrol = 50 > 25;                 // burda 50 25 den büyükmüdür onu kontrol etti ve bize true yani doğru olduğunu yazdırcaktır. 

                Console.WriteLine(Kontrol);       // Kontrol değerini ekrana yazdırcak

            bool Kontrol2 = 25 < 50;            // 25 in 50 den küçük olup olmadığını sormuş olduk eğer 25 50 den küçükse bize true değerini yazdırcaktır.

                Console.WriteLine(Kontrol2);  // Kontrol2 de 25 50 den küçük olduğu için bize true ifadesini vercektir.



            // ---------------------------------------------Eşittir Operatörü : == 
            // --------------------------------------------Eşit değildir(farklı) Operatörü : != 


            byte sayiEsit = 25;
            byte sayiEsitmi = 25;  // buralarda herzamanıki gibi sayılarımızı tanımladık

            bool control = sayiEsit == sayiEsitmi;   // burada tanımladığımız değişkenlerin birbirine eşit olduğunu söyledik ve kontrol edip bize cevap olarak true veya false diycek

                Console.WriteLine(control);         // iki değişken birbirine eşit olduğu için  True değerini alcaz


            byte sayim = 54;        
            byte sayimiz2 = 54;                     //burda değişkenlerimize değerlerini verdik.

            bool cozumumuz = sayim != sayimiz2;   // iki değişkenin eşit olmadığını söyledik ve bize kontrol edip true veya false değerlerini vercek

                Console.WriteLine(cozumumuz);  // bize false değerini göstercek çünkü iki değer eşitti ama biz ona eşit olmadığını söylemiştik bizim dediğimiz yanlış olduğu için false değerini alcaz
               



            // ----------------------------------------------Büyük eşit Operatörü: >=
            // ----------------------------------------------Küçük eşit Operatörü: <= 

            byte BuyukEsit = 150;
            byte BuyukEsit2 = 168;                // Değişkenlerin içine atadık

            bool anla = BuyukEsit >= BuyukEsit2;            // değişkenin büyük veya eşitmi olduğuna baktırdık eğer büyük veya eşitse bize true çıktısını vercektir.

                Console.WriteLine("büyük veya eşitmidir ?" + anla);   // burda False değerini aldık çünü hem eşit değil hemde buyukesit  değeri diğer değişkenden büyük değil.
             
            byte KucukEsit = 125;
            byte KucukEsit2 = 126;           // değerlerimizi değişkenlerin içine koyduk .

            bool kucukAnla = KucukEsit <= KucukEsit2;     // kucukesit değişkeni kucukesit2 değişkeninden küçük veya eşitse bize true değerini vercektir.

                Console.WriteLine("küçük veya eşitmidir ?  "  + kucukAnla);     // burda true değerini aldık çünki kucukesit değişkeni kucukesit2 değişkeninden küçük.



            //------------------------------------------------------------------------------MANTIKSAL OPERATÖRLER--------------------------------------------------------------------------
            


            //------------------------------------------------- VE Operatörü: && 

            // bir tane bile false varsa sonuç false dır


            int opve1 = 25;
            int opve2 = 36;
            int opve3 = 46;      // değerlerimizi değişkenlerin içine atadık.

            bool VEopersonuc = opve1 <= opve2 && opve2 < opve3;  /* burda opve1 küçük veya eşitmi opve2 ye dedik ordan true çıktısını aldık sonra kodlar devam etmesi için ve kullandık orda da 
                                                                  * opve2 küçükmüdür opve3 den dedik burdaki sonuçda true olcak. sonuç olarak da biri true diğeride true olduğu için bize True çıksını vercek*/

                
                Console.WriteLine(VEopersonuc); // burda True değerini alcaz çünü T ve T oldu yukarda. aynı lisedeki mantık konusu gibi 

         

            // ------------------------------------------------- Veya operatörü : || 

            // bir tane bile true varsa sonuç true dur.

            int opveya1 = 5;
            int opveya2 = 5;
            int opveya3 = 10;               // değişkenleri atadık

            bool CIKTIMIZ = opve1 == opve2 || opve2 > opve3 ;  // veya işaretinden önceki yaptığımız eşittirde alcağımız sonuç True olcak veya işaretinden sonraki yerse False olcak çünkü opve2 büyük değildir opve3 den.

                Console.WriteLine(CIKTIMIZ);                  // burda çıktıyız alacağız alcağımız çıktı True olcak çünü en az bir true kuralına uygun.
                



            //-------------------------------------------------Değil Operatörrü : ! 

            // yazdığımız bir değişkenin değilini alır yanı tersini yapar.

            bool Hello = true,

                Console.WriteLine(Hello);   // burda biz true değerini alcaz
                Console.WriteLine(!Hello); // ama burda False alcaz çünü başına Değil işareti ekledik.


                Console.ReadLine(); // burda ekrana yazdırdıklarmızın ekranda kalmasını sağlıyoruz yazmasaydık ekran hızlıca açılıp kapanırdı.




            /* ----------------------------------------------------------------------------------OPERATÖR DERSLERİ BİTTİ --------------------------------------------------------------------------------------*/ 
            

        }
    }
}


