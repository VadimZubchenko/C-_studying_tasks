using System;
using System.IO;

class Esimerkki10_3
{
    static void Main(string[] args)
    {
        //Seuraavassa m��ritell��n hakemiston osoite.
        // Huom! Se toimi vain jos t�m� kansio on jo luotu.
        string hakemisto = "/Users/UusiKansio/";

        // T�ss� luodaan uusi kansio VadimNew
        string newDirectory = "/Users/UusiKansio/VadimNew";
        Console.WriteLine("Luodaan uusi kansio VadimNew: ");
        Directory.CreateDirectory(newDirectory);
        
        //T�ss� tulostetaan ty�hakemiston nimi.
        Console.WriteLine("Ty�hakemiston nimi: " +
        Directory.GetCurrentDirectory());

        //T�ss� tulostetaan hakemiston luontiaika.
        Console.WriteLine(hakemisto + " -hakemiston luontiaika: "
        + Directory.GetCreationTime(hakemisto));

        //T�ss� tulostetaan hakemiston juurihakemiston nimi.
        Console.WriteLine(hakemisto + " -hakemiston juuri: " +
        Directory.GetDirectoryRoot(hakemisto));

        //T�ss� tulostetaan hakemiston ylihakemiston nimi.
        Console.WriteLine(hakemisto + " -hakemiston ylihakemisto: " + Directory.GetParent(hakemisto));

        Console.WriteLine("-----------------");

        Console.WriteLine("Loogiset asemat tietokoneella: ");

        //T�ss� selvitet��n loogisten asemien nimet 
        //tietokoneella.
        string[] loogisetAsemat = Directory.GetLogicalDrives();
        foreach (string asema in loogisetAsemat)
            Console.Write(asema + "\n");

        Console.WriteLine("\n-----------------");

        Console.WriteLine("Tiedostot ja hakemistot, joiden nimist� l�ytyy \"a*s\":");

        //Seuraavassa haetaan hakemiston sellaisten tiedostojen 
        //ja hakemistojen nimet, joiden nimet alkavat a:ll� ja 
        //loppuvat a:ll�. a:n ja a:n v�lill� voi olla muuta esim. "Asimerkki2_3.cs"
        //teksti�.
        string path = hakemisto;
        string filter = "a*s";

        string[] sisalto =
        Directory.GetFileSystemEntries(path,filter);

        foreach (string elementti in sisalto)
            Console.WriteLine(elementti);

        Console.WriteLine("-----------------");

        //Seuraavassa haetaan hakemiston alla olevien 
        //tiedostojen nimet ja tulostetaan.
        string[] tiedostot = Directory.GetFiles(hakemisto);

        Console.WriteLine(hakemisto + " -hakemiston tiedostot:");

        foreach (string tds in tiedostot)
            Console.WriteLine(tds);

        Console.WriteLine("-----------------");

        //Seuraavassa haetaan hakemiston alla olevien 
        //hakemistojen nimet ja tulostetaan.
        string[] hakemistot =
        Directory.GetDirectories(hakemisto);

        Console.WriteLine(hakemisto + " -hakemiston alihakemistot:");

        foreach (string hks in hakemistot)
            Console.WriteLine(hks);
    }
}
