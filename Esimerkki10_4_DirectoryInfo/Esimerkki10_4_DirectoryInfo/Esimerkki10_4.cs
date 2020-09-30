using System;
using System.IO;

class Esimerkki10_4
{
    //Seuraavassa m��ritell�n metodi TulostaTiedostot, 
    //joka tulostaa hakemiston alla olevien tiedostojen nimet.
    static void TulostaTiedostot(DirectoryInfo dirInfo,
    int valiLyonnit)
    {
        //T�ss� luodaan sisennyst� tiedostojen nimen 
        //tulostusta varten.
        string valiLyonti = new String(' ', 2 * valiLyonnit);

        foreach (FileInfo f in dirInfo.GetFiles())
        {
            //T�ss� tulostetaan v�lily�nnit ja tiedoston nimi.
            Console.WriteLine(valiLyonti + f.Name);
        }
    }

    //Seuraavassa m��ritell�n metodi TulostaHakemistot(), 
    //joka tulostaa hakemiston alla olevien hakemistojen 
    //nimet. Metodi my�s kutsuu metodin TulostaTiedostot()
    //tulostaaksen hakemiston alla olevien tiedostojen nimet.
    static void TulostaHakemistot(DirectoryInfo dirInfo,
    int valiLyonnit)
    {
        //T�ss� luodaan sisennyt� hakemistojen nimen 
        //tulostusta varten.
        string valit = new String(' ', 2 * valiLyonnit);

        //T�ss� tulostetaan v�lily�nnit ja hakemiston nimi.
        Console.WriteLine(valit + dirInfo.Name + "\\");

        TulostaTiedostot(dirInfo, valiLyonnit + 1);

        foreach (DirectoryInfo dInfo in dirInfo.GetDirectories())
            TulostaHakemistot(dInfo, valiLyonnit + 1);
    }

    static void Main(string[] args)
    {
        //T�ss� m��ritell��n hakemiston osoite.
        string hakemisto = "/users/UusiKansio/";

        int valiLyonnit = 1;

        //T�ss� luodaan DirectoryInfo-olio.
        DirectoryInfo dirInfo = new DirectoryInfo(hakemisto);

        //T�ss� kutsutaan metodi TulostaHakemistot(), joka saa
        //argumenttina DirectoryInfo-olion ja kokonaisluvun, joka
        //m��r�� v�lily�ntien lukum��r�n. Metodi 
        //TulostaHakemistot() tulostaa muuttuja hakemisto 
        //arvoksi asetetun /users/UusiKansio/-hakemiston alla olevien 
        //tiedostojen ja hakemistojen nimet. 
        TulostaHakemistot(dirInfo, valiLyonnit);
    }
}
