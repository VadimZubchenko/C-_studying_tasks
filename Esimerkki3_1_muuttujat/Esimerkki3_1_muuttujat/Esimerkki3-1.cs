using System;

class Esimerkki3_1
{
    public static void Main()
    {
        //T�ss� m��ritell��n vakio, jonka nimi on kerroin.
        const double kerroin = 3.0 / 4;

        //T�ss� tulostetaan n�yt�lle vakion arvo.
        System.Console.WriteLine("kerroin=" + kerroin);

        //Seuraavissa muuttujat alustetaan m��rittelyns� yhteydess�.
        double pi = 3.14159;
        float sade = 0.985f;

        //T�ss� tulostetaan n�yt�lle muuttujen arvot.
        System.Console.WriteLine("pi={0} sade={1}", pi, sade);

        //T�ss� esitell��n muuttuja tilavuus, muttei sit� alusteta.
        double tilavuus;

        //T�ss� muuttujaan tilavuus sijoitetaan lausekkeen arvo.
        tilavuus = kerroin * pi * sade * sade * sade;

        //T�ss� tulostetaan n�yt�lle muuttujen arvot.
        System.Console.WriteLine("tilavuus={0,6:f4}", tilavuus);

    }
}