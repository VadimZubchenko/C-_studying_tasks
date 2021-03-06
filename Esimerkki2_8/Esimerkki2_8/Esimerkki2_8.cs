
//Tässä otetaan käyttöön System kirjasto. Tämän takia
//Console.WriteLine() voidaan lyhentää seuraavasti:
//Console.WriteLine().
using System;

class Esimerkki2_8
{
    public static void Main(string[] args)
    {
        //Kokonaislukujen formatointi
        int i = 1234;
        Console.WriteLine("Kokonaislukujen formatointi:\n");

        //Tässä tulostetaan i oletusformaatilla. \t tulostaa
        //sarkaimen.
        Console.WriteLine("{0}\t\t:i Oletusformaatilla", i);

        //Seuraavassa muuttujalle i varataan vain 2 paikkaa! 
        //Huomaa, että koska varattujen paikkojen määrä on 
        //pienempi, kuin luvun oma pituus, luku tulostetaan
        //sellaisenaan.
        Console.WriteLine("{0, 2}\t\t:i 2-merkin pituisena", i);

        //Tässä muuttujalle i varataan 6 paikkaa.
        Console.WriteLine("{0, 6}\t\t:i 6-merkin pituisena", i);

        //Tässä muuttujalle i varataan 8 paikkaa. \t tulostaa 
        //sarkaimen.
        Console.WriteLine("{0, 8}\t:i 8-merkin pituisena", i);

        //Tässä muuttujalle i varataan 10 paikkaa.
        Console.WriteLine("{0, 10}\t:i 10-merkin pituisena", i);

        //Tässä muuttujaa i muotoillaan heksadesimaaliluvuksi
        //ja sille varataan 10 paikkaa 
        Console.WriteLine("{0,10:x}\t:i 10:x-formaatissa " +
         "(heksadesimaalilukuna)", i);

        Console.WriteLine("{0:D10}\t:i 10:d-formaatissa", i);

        //Liukulukujen formatointi
        Console.WriteLine("------------------\v");
        Console.WriteLine("Liukulukujen formatointi:\n");
        float f = -546.8263f;

        //Tässä muuttuja f tulostetaan oletusformaatissa.
        Console.WriteLine("{0}\t:f oletusformaatissa", f);

        //Tässä muuttujalle f varataan 2 paikkaa ja tulostetaan
        //ilman desimaaliosiolla. Huomaa, että koska varattujen 
        //paikkojen määrä on pienempi, kuin luvun oma pituus, 
        //luku tulostetaan sellaisenaan.
        Console.WriteLine("{0,2:f0}\t\t:f 2:f0-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja 
        //tulostetaan ilman desimaaliosiolla.
        Console.WriteLine("{0,10:f0}\t:f 10:f0-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja 
        //tulostetaan yhdellä desimaalinumerolla.
        Console.WriteLine("{0,10:f1}\t:f 10:f1-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //kahdella desimaalinumerolla.
        Console.WriteLine("{0,10:f2}\t:f 10:f2-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //viidella desimaalinumerolla.
        Console.WriteLine("{0,10:f5}\t:f 10:f5-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //eksponentiaalilukuna.      
        Console.WriteLine("{0,10:e2}\t:f 10:e2-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //prosenttilukuna.      
        Console.WriteLine("{0,10:p1}\t:f 10:p2-prosentti_formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //siten, että käytetään pilkkua erottimena.
        Console.WriteLine("{0,10:n2}\t:f 10:n2-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //siten, että käytetään joko reaaliluku- tai 
        //eksponentiaalinotaatiota
        Console.WriteLine("{0,10:g2}\t:f 10:g2-formaatissa", f);

        //Tässä muuttujalle f varataan 10 paikkaa ja tulostetaan
        //siten, että loppuun laitetaan paikallisen rahayksikön
        //notaatio.
        Console.WriteLine("{0,10:c2}\t:f 10:c2-formaatissa", f);

    }
}