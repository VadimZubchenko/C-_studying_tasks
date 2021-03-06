using System;

class Esimerkki2_2
{
    public static void Main()
    {
        //Tässä määritellään muuttuja b, joka on tyyppiä byte.
        byte b = 75;

        //Tässä esitellään muuttuja i, joka on tyyppiä int.
        int i;

        //Seuraavassa suoritetaan implisiittinen tyyppimuunos
        //kopioimalla b-muuttujan arvo i-muuttujaan. Tämä on 
        //sallittu koska byte-tyyppi vie vähemmän muistitilaa
        //kuin int-tyyppi.
        i = b;

        //Tässä tulostetaan b ja i.
        System.Console.WriteLine("b (byte)=" + b + " i (int)=" + i);

        //Seuraava lause aiheuttaa virheen! Koska suurempaa
        //tietotyyppiä olevan muuttujan arvoa yritetään kopioida 
        //pienempää tietotyyppiä olevaan muuttujaan.
        //b = i;

        //Tässä määritellään muuttuja f, joka on tyyppiä float.
        float f = 2.95f;

        //Tässä määritellään muuttuja d, joka on tyyppiä double.
        double d;

        //Seuraavassa f-muuttujan arvo kopioidaan d-muuttujaan.
        //Tämä on sallittu koska pienempää tyyppiä olevan muuttujan 
        //arvo kopioidaan suurempaa tyyppiä olevaan muuttujaan.
        d = f;

        //Tässä tulostetaan f ja d.
        System.Console.WriteLine("f (float)=" + f + " d (decimal)=" + d);

        //Seuraavassa määritellään muuttuja s, joka on tyyppiä
        //short. 
        short s = 32760;

        //Seuraavassa s-muuttuja muunnetaan byte-tyyppiseksi ja 
        //sitten sen arvo kopioidaan b-muuttujaan, joka esiteltiin
        //aiemmin.
        b = (byte)s;

        //Tässä tulostetaan s ja b.
        System.Console.WriteLine("s (short)=" + s + " b (byte)=" + b);

        //Tässä määritellään ch-muuttuja, joka on tyyppiä char.
        char ch = 'k';

        //Seuraavassa suoritetaan eksplisiittinen tyyppimuunnos
        //ch-muuttujalle ja sen arvo kopioidaan b-muuttujaan.
        b = (byte)ch;

        //Tässä tulostetaan b.
        System.Console.WriteLine("ch (char)=" + ch + " b (byte)=" + b);

        //Tässä esitellään muuttuja dec, joka on tyyppiä decimal.
        decimal dec;

        //Seuraavassa suoritetaan eksplisiittinen tyyppimuunnos
        //f-muuttujalle ja sen arvo kopioidaan d-muuttujaan.
        dec = (decimal)f;

        //Tässä tulostetaan f ja dec.
        System.Console.WriteLine("f (float)=" + f + " dec (decimal)=" + dec);

        //Tässä määritellään muuttuja j.
        int j = 5000;

        //Seuraavassa checked-operaatiolla tarkistetaan 
        //tapahtuuko tyyppimuunnoksen yhteydessä informaation
        //hukka. Huomaa, että seuraava operaatio aiheuttaa
        //virheilmoituksen, koska suurempaa kokoa olevaa
        //muuttujaa yritetään kopioida pienempää kokoa olevaan
        //muuttujaan.
        byte k = checked((byte)j);
    }
}
