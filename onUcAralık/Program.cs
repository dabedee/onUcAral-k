using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onUcAralık
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // doğrusal veri yapıları:1. array(dizi) 2.linked list (bağlı liste)3.stack(yığın)4.Queue(kuyruk) 
            // dizilerin avantajları =rasgele erişim , performns iyidir
            //dezavantaj= boyutu dinamik değil,başa ortaya koyma
            //linked list = (head kavramı node(düğüm) kavrmaı) bir sonrakinin adresini tutar
            // değere ihtiyaç var düğüm adresine ihtiyaç var 
            // linked listlerde tek yön ve çift yön vardır.
            // çift yönlülerde hem ileri hem geriye gidioruz (veri sonraki önceki)

//linked list avantajları 1. dinamiktir fazla veri tutmaması
//linked list dezavantajı 3 veri tutmak zorunds 1 düğüm



// yığın (stack): karanlık varil : sıralı şelilde tutulur üst üste 
// lifo last in first out  2 emir var push ve pop push stacka yeni eleman basar pop en üstteki elemanı almaya yarar.
//popladıgın eleman silinir 
// z0 $ işaretleri zeminde oldugun belli eder 

/* queue ( kuyruk) fifo ilk giren ilk çıkar
 * dequeu kavramı  ve ön arka kavramı
 * kodlama kısmı linked list ılarak kdolanır
 */


// 1-stack segment 2 heap segment code segment extra segment ramin mantıksal segmentleri.
//stack segment 1 mb dır  1mb i geçince stack overflow hatası verir 
//heap segment=
//code segment=
//extra segment = bazı sitring operasyonlar


// value type: int double decimal float gibi veriler stack te tutulur (kaç byte yr kapladıgını biliyorsak vlaue dır ) 
//referans type  string obje heap te tutulur 
// stack daha hızlı heap yavaş
// bool kontrol =typeof(int)IsValueType;
// dizinin sıfırıncı indexinin adresi stackte tutulurç
// boxing == int a =123; objet x=a ; hem stackte hem heapte tuttuk sonra stackten yok edilir.
//unboxing=  int b =(int )x;
/*STACK:
 * VALUE TYPE TUTULUR
 * LIFO
 * STACK HEAP E GÖRE HIZLIDIR
 * ÇIKARILAN VERİLER STACKTAN YOK OLUR 
 * PROGRAM ÇALIŞMADAN ÖNE STAJ İÇİN YER AYRILIR
 * EĞER AYRILAN ALAN AŞILIR STACK OVERFLOW HATASI VERİR
 * HEAP:
 * REF TYPE
 * ADRESLERİ STACKTE TUTLUR
 * HEAPTE VERİLER KARIŞIK TUTULUR  BU YÜZDEN BİR MİKTAR YAVAŞTIR STACKE GÖRE
 * HEAP BÖLGESİNDE VERİLERİN SİLİNMESİ ÇÖP TOPLAYICI ALGORİTMASINA BAĞLIDIR.
 * 
 * PROGRAM ÇALIŞMADAN ÖNCE YER X OLSUN ÇALIŞMA ANINDA YER VERİLİR
 * 
 * 




// C# dilinde, dizilerde kullanılan fonksiyonlar aşağıdaki gibidir:

Array.Sort(): Dizinin elemanlarını sıralar.
Array.Reverse(): Dizinin elemanlarını tersine çevirir.
Array.Clear(): Dizinin tüm elemanlarını temizler.
Array.Copy(): Diziyi başka bir diziye kopyalar.
Array.IndexOf(): Dizide belirtilen değerin indeksini bulur.
Array.LastIndexOf(): Dizide belirtilen değerin en son bulunan indeksini bulur.
Array.BinarySearch(): Dizide belirtilen değerin olup olmadığını kontrol eder.
Array.Resize(): Dizinin boyutunu değiştirir.
Array.ToString(): Diziyi metinsel bir ifadeye dönüştürür.

Bu fonksiyonlar, dizileri daha kolay işleyebilmek için kullanılır ve bu sayede dizileri daha verimli bir şekilde kullanabilirsiniz.
}
}
}
