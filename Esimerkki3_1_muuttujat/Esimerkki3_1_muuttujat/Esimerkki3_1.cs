using System;

class Esimerkki2_2

 {

    public static void Main(string[] args)

    {

     //Tässä määritellään muuttuja b, joka on tyyppiä byte.

     byte b = 75;



     //Tässä esitellään muuttuja i, joka on tyyppiä int.

     int i;



     //Seuraavassa suoritetaan implisiittinen tyyppimuunnos

     //kopioimalla muuttujan b arvo muuttujaan i. Tämä on

     //sallittu koska byte-tyyppi vie vähemmän muistitilaa

     //kuin int-tyyppi.

     i = b;



     //Tässä muuttujien b ja i arvot tulostetaan näytölle.

     Console.WriteLine("b (byte)=" + b + " i (int) =" + i);



     //Seuraava lause aiheuttaisi virheen! Koska suurempaa

     //tyyppiä olevan muuttujan arvoa yritetään kopioida

     //pienempää tyyppiä olevaan muuttujaan.

     //b = i;



     //Tässä määritellään muuttuja f, joka on tyyppiä float.

     float f = 2.95f;



     //Tässä määritellään muuttuja d, joka on tyyppiä double.

     double d;



     //Seuraavassa muuttujan f arvo kopioidaan muuttujaan d.

     //Tämä on sallittu koska pienempää tyyppiä olevan

    //muuttujan arvo kopioidaan suurempaa tyyppiä olevaan

     //muuttujaan.

     d = f;



    //Tässä muuttujien f ja d arvot tulostetaan näytölle.

     Console.WriteLine("f (float)=" + f + " d (decimal)=" + d);



     //Tässä määritellään muuttuja s, joka on tyyppiä short.

     short s = 32760;



    //Seuraavassa muuttuja s muunnetaan byte-tyyppiseksi

     //ja sitten sen arvo kopioidaan muuttujaan b, joka

     //esiteltiin aiemmin.

     b = (byte) s;



     //Tässä muuttujien s ja b arvot tulostetaan näytölle.

     Console.WriteLine("s (short)=" + s + " b (byte)=" + b);



     //Tässä määritellään muuttuja ch, joka on tyyppiä char.

     char ch = 'k';



     //Seuraavassa suoritetaan eksplisiittinen tyyppimuunnos

     //muuttujalle ch ja sen arvo kopioidaan muuttujaan b.

     b = (byte) ch;



     //Tässä muuttujien ch ja b arvot tulostetaan näytölle.

     Console.WriteLine("ch (char)=" + ch + " b (byte)=" + b);



    //Tässä esitellään muuttuja dec, joka on tyyppiä decimal.

     decimal dec;



     //Seuraavassa suoritetaan eksplisiittinen tyyppimuunnos

     //muuttujalle f ja sen arvo kopioidaan muuttujaan d.

    dec = (decimal) f;



     //Tässä muuttujien f ja dec arvot tulostetaan näytölle.

     Console.WriteLine("f (float)=" + f + " dec (decimal)=" +

     dec);



     //Tässä määritellään muuttuja j.

     int j = 5000;



     //Seuraavassa checked-operaattorilla varmistetaan ettei

     //tyyppimuunnoksen yhteydessä menetetä informaation.

     //Huomaa, että seuraava lause aiheuttaa virheilmoituksen,

     //koska suurempaa kokoa olevaa muuttujaa yritetään

     //kopioida pienempää kokoa olevaan muuttujaan.

     byte k = checked((byte)j);

    }

   }

 