using System;
using System.IO;

class Esimerkki10_3
{
    static void Main(string[] args)
    {
        //Seuraavassa määritellään hakemiston osoite.
        // Huom! Se toimi vain jos tämä kansio on jo luotu.
        string hakemisto = "/Users/UusiKansio/";

        // Tässä luodaan uusi kansio VadimNew
        string newDirectory = "/Users/UusiKansio/VadimNew";
        Console.WriteLine("Luodaan uusi kansio VadimNew: ");
        Directory.CreateDirectory(newDirectory);
        
        //Tässä tulostetaan työhakemiston nimi.
        Console.WriteLine("Työhakemiston nimi: " +
        Directory.GetCurrentDirectory());

        //Tässä tulostetaan hakemiston luontiaika.
        Console.WriteLine(hakemisto + " -hakemiston luontiaika: "
        + Directory.GetCreationTime(hakemisto));

        //Tässä tulostetaan hakemiston juurihakemiston nimi.
        Console.WriteLine(hakemisto + " -hakemiston juuri: " +
        Directory.GetDirectoryRoot(hakemisto));

        //Tässä tulostetaan hakemiston ylihakemiston nimi.
        Console.WriteLine(hakemisto + " -hakemiston ylihakemisto: " + Directory.GetParent(hakemisto));

        Console.WriteLine("-----------------");

        Console.WriteLine("Loogiset asemat tietokoneella: ");

        //Tässä selvitetään loogisten asemien nimet 
        //tietokoneella.
        string[] loogisetAsemat = Directory.GetLogicalDrives();
        foreach (string asema in loogisetAsemat)
            Console.Write(asema + "\n");

        Console.WriteLine("\n-----------------");

        Console.WriteLine("Tiedostot ja hakemistot, joiden nimistä löytyy \"a*s\":");

        //Seuraavassa haetaan hakemiston sellaisten tiedostojen 
        //ja hakemistojen nimet, joiden nimet alkavat a:llä ja 
        //loppuvat a:llä. a:n ja a:n välillä voi olla muuta esim. "Asimerkki2_3.cs"
        //tekstiä.
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
