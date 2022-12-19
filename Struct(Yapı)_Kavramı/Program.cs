using System;

namespace Struct_Yapı__Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            dikdörtgen dikdörtgen=new dikdörtgen();
            dikdörtgen.KisaKenar=3;
            dikdörtgen.Uzunkenar=4;
            Console.WriteLine("Alan Hesabı :{0} ",dikdörtgen.AlanHesapla());

            //structlarda böyle de nesne oluşturulabilir.
            //classlardaki gibi new kullanılarak da nesne oluşturlabilir.
            // ama bu kullanımı classlarda yapamayız.
            //Dikdörtgen_Struct dikdörtgen_Struct;
            Dikdörtgen_Struct dikdörtgen_Struct=new Dikdörtgen_Struct(3,4);
           // dikdörtgen_Struct.KisaKenar=3;
           // dikdörtgen_Struct.Uzunkenar=4;
            Console.WriteLine("Alan Hesabı :{0} ",dikdörtgen_Struct.AlanHesapla());



        }
    }

    class dikdörtgen
    {
       public int KisaKenar;

       public int Uzunkenar;

       // Default Constructor'a parametre almayan kendimiz gelip kendimiz tanımlama yapabiliyoruz.
       //Bunu aynı struct içinde yazdığımız zaman hata veriyor.
       //Derki parametresi olmayan Constructor'u Strcut'lar için tanımlayamazsın de aynı koyalarsak.
       public dikdörtgen()
       {
           KisaKenar=3;
           Uzunkenar=4;
       }

       public long AlanHesapla()
       {
           return this.KisaKenar * this.Uzunkenar;
       }
    }

    struct Dikdörtgen_Struct
    {
        public int KisaKenar;

        public int Uzunkenar;

        //Bu Constructor'a izin veriyor struct yapısı
        public Dikdörtgen_Struct(int uzunkenar, int kisaKenar) 
        {
            Uzunkenar = uzunkenar;
            KisaKenar = kisaKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.Uzunkenar;
        }
    }
}
