using System;
using System.IO;

class Esimerkki10_4
{
    //Seuraavassa määritellän metodi TulostaTiedostot, 
    //joka tulostaa hakemiston alla olevien tiedostojen nimet.
    static void TulostaTiedostot(DirectoryInfo dirInfo,
    int valiLyonnit)
    {
        //Tässä luodaan sisennystä tiedostojen nimen 
        //tulostusta varten.
        string valiLyonti = new String(' ', 2 * valiLyonnit);

        foreach (FileInfo f in dirInfo.GetFiles())
        {
            //Tässä tulostetaan välilyönnit ja tiedoston nimi.
            Console.WriteLine(valiLyonti + f.Name);
        }
    }

    //Seuraavassa määritellän metodi TulostaHakemistot(), 
    //joka tulostaa hakemiston alla olevien hakemistojen 
    //nimet. Metodi myös kutsuu metodin TulostaTiedostot()
    //tulostaaksen hakemiston alla olevien tiedostojen nimet.
    static void TulostaHakemistot(DirectoryInfo dirInfo,
    int valiLyonnit)
    {
        //Tässä luodaan sisennytä hakemistojen nimen 
        //tulostusta varten.
        string valit = new String(' ', 2 * valiLyonnit);

        //Tässä tulostetaan välilyönnit ja hakemiston nimi.
        Console.WriteLine(valit + dirInfo.Name + "\\");

        TulostaTiedostot(dirInfo, valiLyonnit + 1);

        foreach (DirectoryInfo dInfo in dirInfo.GetDirectories())
            TulostaHakemistot(dInfo, valiLyonnit + 1);
    }

    static void Main(string[] args)
    {
        //Tässä määritellään hakemiston osoite.
        string hakemisto = "/users/UusiKansio/";

        int valiLyonnit = 1;

        //Tässä luodaan DirectoryInfo-olio.
        DirectoryInfo dirInfo = new DirectoryInfo(hakemisto);

        //Tässä kutsutaan metodi TulostaHakemistot(), joka saa
        //argumenttina DirectoryInfo-olion ja kokonaisluvun, joka
        //määrää välilyöntien lukumäärän. Metodi 
        //TulostaHakemistot() tulostaa muuttuja hakemisto 
        //arvoksi asetetun /users/UusiKansio/-hakemiston alla olevien 
        //tiedostojen ja hakemistojen nimet. 
        TulostaHakemistot(dirInfo, valiLyonnit);
    }
}
