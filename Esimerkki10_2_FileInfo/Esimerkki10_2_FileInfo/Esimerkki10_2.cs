using System;
using System.IO;

class Esimerkki10_2
{
    static void Main(string[] args)
    {
        //T‰ss‰ m‰‰ritell‰‰n tiedoston t‰ydellinen osoite.
        string tiedosto = "\\user\\vadimzubchenko\\loki.txt";

        //T‰ss‰ luodaan FileInfo -olio.
        FileInfo fileInfo = new FileInfo(tiedosto);

        //T‰ss‰ luodaan tiedosto jos sit‰ ei ole olemassa.
        if (!fileInfo.Exists)
            fileInfo.Create();

        //T‰ss‰ tarkistetaan onko tiedosto olemassa.
        Console.WriteLine(fileInfo.FullName + " olemassa? " + fileInfo.Exists);

        //T‰ss‰ tulostetaan tiedoston luontiaika.
        Console.WriteLine(fileInfo.Name + " luotiin " + fileInfo.CreationTime);

        //T‰ss‰ tulostetaan tiedoston koko.
        Console.WriteLine(fileInfo.Name + " tiedoston koko on: " + fileInfo.Length);

        //T‰ss‰ asetetaan tiedoston kaksi attribuuttia. Huomaa, kuinka
        //attribuutit erotetaan toisistaan.
        fileInfo.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.System;

        //T‰ss‰ tulsotetaan tiedoston p‰‰te.
        Console.WriteLine(fileInfo.Name + " -tiedoston p‰‰te on: " + fileInfo.Extension);
    }
}
