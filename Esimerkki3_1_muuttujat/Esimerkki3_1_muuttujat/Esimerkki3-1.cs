using System;

class Esimerkki3_1
{
    public static void Main()
    {
        //Tässä määritellään vakio, jonka nimi on kerroin.
        const double kerroin = 3.0 / 4;

        //Tässä tulostetaan näytölle vakion arvo.
        System.Console.WriteLine("kerroin=" + kerroin);

        //Seuraavissa muuttujat alustetaan määrittelynsä yhteydessä.
        double pi = 3.14159;
        float sade = 0.985f;

        //Tässä tulostetaan näytölle muuttujen arvot.
        System.Console.WriteLine("pi={0} sade={1}", pi, sade);

        //Tässä esitellään muuttuja tilavuus, muttei sitä alusteta.
        double tilavuus;

        //Tässä muuttujaan tilavuus sijoitetaan lausekkeen arvo.
        tilavuus = kerroin * pi * sade * sade * sade;

        //Tässä tulostetaan näytölle muuttujen arvot.
        System.Console.WriteLine("tilavuus={0,6:f4}", tilavuus);

    }
}