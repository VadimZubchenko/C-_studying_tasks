using System;

class Esimerkki2_9
{
    public static void Main()
    {
        //Tässä esitellään muuttujaa ch, joka on
        //tyyppiä char.
        char ch;
        //Tässä pyydetään merkkiä.
        Console.Write("Syötä merkki: ");

        //Tässä luetaan käyttäjän näppäimistöltä antama
        //merkki, jolla ch-muuttuja alustetaan. Huomaa, 
        //tyyppimuunnos!
        ch = (char)Console.Read();

        //Seuraavassa otetaan vastaan Enter-näppäimen
        //paianalluksia. Näin joudutaan tekemään aina,
        //kun luetaan merkkejä näppäimistöltä. Jos näin
        //ei tehdä, ohjelma hyppää odottamattomasti eteenpäin!       
        Console.Read();
        Console.Read();

        //Tässä syötetty merkki tulostetaan näytölle.
        Console.WriteLine("Syöttämäsi merkki: " + ch);

        //Tässä esitellään muuttujaa teksti, joka on 
        //tyyppiä string.
        string teksti;

        //Tässä pyydetään merkkijonoa.
        Console.Write("Syötä teksti: ");

        //Tässä luetaan tekstiä näppäimistöltä.
        teksti = Console.ReadLine();

        //Tässä syötetty merkki tulostetaan näytölle.
        Console.WriteLine("Syöttämäsi teksti on: " +
        teksti);

        //Tässä esitellään muuttujaa kokonaisLuku, joka
        //on tyyppiä int.
        int kokonaisLuku;

        //Tässä esitellään muuttujaa lukuTeksti, joka
        //on tyyppiä string.
        string lukuTeksti;

        //Tässä pyydetään merkkijonoa.
        Console.Write("Syötä kokonaisluku: ");

        //Tässä luetaan näppäimistöltä tekstimuotoinen luku,
        //jolla lukuTeksti-muuttuja alustetaan.
        lukuTeksti = Console.ReadLine();

        //Tässä luettu teksti muunnetaan kokonaisluvuksi 
        kokonaisLuku = int.Parse(lukuTeksti);

        //Tässä syötetty merkki tulostetaan näytölle.
        Console.WriteLine("Syöttämäsi luku on: {0} ",
        kokonaisLuku);

        //Tässä esitellään muuttujaa reaaliLuku, joka on tyyppiä
        //double.
        double reaaliLuku;

        //Tässä pyydetään reaalilukua. Huomaa, että käyttäjän 
        //antamalla reaaliluvulla pitäisi olla oikea 
        //desimaalierotin!
        Console.Write("Syötä reaaliluku: ");

        //Tässä luetaan näppäimistöltä tekstimuotoinen luku,
        //jolla lukuTeksti-muuttuja alustetaan.
        lukuTeksti = Console.ReadLine();

        //Tässä luettu teksti muunnetaan doubleluvuksi
        //double.Parse() metodilla
        reaaliLuku = double.Parse(lukuTeksti);

        //Tässä syötetty merkki tulostetaan näytölle.
        Console.WriteLine("Syöttämäsi reaaliluku on:{0} ",
        reaaliLuku);

        //Tässä lukuTeksti käännetään reaaliluvuksi 
        //Convert.ToDouble() metodilla.
        reaaliLuku = Convert.ToDouble(lukuTeksti);

        Console.WriteLine("Syöttämäsi luku käännetteynä "
        + "Convert.ToDouble() metodilla: {0}", reaaliLuku);

        float fluku = float.Parse(lukuTeksti);
        Console.WriteLine("Syöttämäsi luku käännetteynä "
        + "float.Parse() metodilla: {0}", fluku);

        //Seuraavassa suoritetaan implisiittinen tyyppimuunnos
        //muuttujalle fluku ja sen arvo kopioidaan muuttujaan reaaliLuku.
        reaaliLuku = fluku;

        Console.WriteLine("Implisiittinen tyyppimuunnos float to double"
        + ": {0}", reaaliLuku);

        //Tässä luku käännetään desimaaliluvuksi 
        //Convert.ToDecimal()-metodilla.
        decimal desimaaliLuku = Convert.ToDecimal(reaaliLuku);

        Console.WriteLine("Syöttämäsi luku käännettynä "
        + "Convert.ToDecimal() metodilla: {0}", desimaaliLuku);
    }
}
