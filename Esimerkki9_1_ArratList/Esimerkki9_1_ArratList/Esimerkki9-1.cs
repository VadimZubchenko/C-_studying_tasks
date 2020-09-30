//ArrayList luokan käyttöä varten otetaan käyttöön
//System.Collections-kirjasto.
using System;
using System.Collections;

class Esimerkki9_1
{
    static void Main(string[] args)
    {
        //Tässä luodaan ArrayList-kokoelma henkilot.
        ArrayList henkilot = new ArrayList();

        //Tässä tulostetaan kokoelman henkilot kapasiteetti.
        Console.WriteLine("Alussa henkilot.Capacity=" +
        henkilot.Capacity);

        //Seuraavassa lisätään dataa kokoelmaan henkilot.
        henkilot.Add("Pessi");
        henkilot.Add("AnnaLiisa");
        henkilot.Add("Taina");
        henkilot.Add("Elias");
        henkilot.Add("Illuusia");

        //Tässä tulostetaan kokoelman henkilot kapasiteetti
        //uudelleen.
        Console.WriteLine("Alkioiden lisäyksen jälkeen henkilot.Capacity=" + henkilot.Capacity);

        //Tässä kokoelman henkilot kapasiteetti astetaan 
        //sen alkioiden lukumääräksi.
        henkilot.TrimToSize();

        //Tässä tulostetaan kokoelman henkilot kapasiteetti
        //uudelleen.
        Console.WriteLine("TrimToSize()-metodin kutsun jälkeen: henkilot.Capacity=" + henkilot.Capacity);

        //Tässä tulostetaan kokoelman henkilot alkioiden
        //lukumäärä.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);

        //Tässä kokoelman henkilot ensimmäinen elementti 
        //haetaan ja kopioidaan muuttujaan henkilo.
        string henkilo = (string)henkilot[0];

        //Tässä tulostetaan muuttujan henkilo sisältö. 
        Console.WriteLine("henkilo=" + henkilo);

        Console.WriteLine("Henkilöiden lista ennen lajittelua:");

        //Seuraavassa kokoelman henkilot kaikki alkiot 
        //tulostetaan näytölle käyttämällä foreach silmukkaa.
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        Console.WriteLine("'Elias'-alkion indeksi=" +
        henkilot.IndexOf("Elias"));

        //Tässä kokoelman henkilot sisältö lajitellaan 
        //nousevaan järjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkilöiden lista lajittelun jälkeen:");

        //Tässä kokoelman henkilot kaikki alkiot taas 
        //tulostetaan näytölle. 
        PrintIndexAndValues(henkilot);
        Console.WriteLine();

        //Tässä kokoelman henkilot sisältö lajitellaan 
        //laskevaan järjestykseen.
        henkilot.Reverse();

        Console.WriteLine("Henkilöiden lista käänteislajittelun jälkeen:");

        //Tässä kokoelman henkilot kaikki alkiot taas 
        //tulostetaan näytölle 
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        //Tässä kokoelman henkilot ensimmäinen elementti 
        //poistetaan.
        henkilot.RemoveAt(0);

        Console.WriteLine("Henkilöiden lista ensimmäisen alkion poiston jälkeen:");

        //Tässä kokoelman henkilot kaikki alkiot taas 
        //tulostetaan näytölle. 
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        //Tässä luodaan uusi ArrayList-kokoelma, johon 
        //kopioidaan kokoelman henkilot sisältö. 
        //Huomaa, että metodi Clone() palauttaa object-olion,
        //joka pitää muuntaa ArrayList-tyyppiseksi 
        //uusiHenkilot-olion alustamiseksi.
        Console.WriteLine("\nClone(): Luo matalan kopion (shallow copy) ArrayList-kokoelmasta. ");
        ArrayList uusiHenkilot = (ArrayList)henkilot.Clone();

        Console.WriteLine("uusiHenkilöiden uusi lista:");

        //Tässä kokoelman uusiHenkilot kaikki alkiot taas 
        //tulostetaan näytölle. 
        PrintIndexAndValues(uusiHenkilot);
        Console.WriteLine();

        //Tässä poistetaan kokoelman henkilot kaikki alkiot.
        henkilot.Clear();

        Console.WriteLine("Henkilöiden lukumäärä Clear()-metodin kutsun jälkeen:");

        //Tässä taas tulostetaan kokoelman henkilot 
        //alkioiden lukumäärä.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);
        //Tässä taas tulostetaan kokoelman uusiHenkilot 
        //alkioiden lukumäärä.
        Console.WriteLine("uusiHenkilöiden lukumäärä: ");
        Console.WriteLine("uusihenkilot.Count=" +
        uusiHenkilot.Count);

        Console.WriteLine("\nCopyTo(): Kopioi ArrayList-kokoelman sisällön tavalliseen yksiulotteiseen taulukkoon:");
        //Tässä käsitellään CopyTo method ArrayList to Array
        // Creates and initializes the one-dimensional target Array.
        String[] myTargetArray = new String[10];
        myTargetArray[0] = "The";
        myTargetArray[1] = "quick";
        myTargetArray[2] = "brown";
        myTargetArray[3] = "fox";
        myTargetArray[4] = "jumps";
        myTargetArray[5] = "over";
        myTargetArray[6] = "the";

        // Displays the values of the target Array.
        Console.WriteLine("The target Array contains the following (before copying):");
        PrintArrayIndexAndValues(myTargetArray);
        
        Console.WriteLine("\n");
        // Copies the entire source ArrayList to the target Array starting at index 3, eli "the" jälkeen.
        uusiHenkilot.CopyTo(myTargetArray, 6);

        Console.WriteLine("Displays the values of the myTargetArray after copying.");
        PrintArrayIndexAndValues(myTargetArray);

        Console.WriteLine("\n myArr alkioden maara: " + myTargetArray.Length);

        
        
        Console.WriteLine("\n\nToArray(): Kopioi ArrayList-kokoelman alkiot taulukkoon.");

        // Copies the elements of the ArrayList to a string array.
        String[] myArr = (String[])uusiHenkilot.ToArray(typeof(string));

        // Displays the values of the ArrayList.
        Console.WriteLine("The ArrayList contains the following values:");
        PrintIndexAndValues(uusiHenkilot);

        // Displays the contents of the string array.
        Console.WriteLine("The string array contains the following values:");
        PrintArrayIndexAndValues(myArr);

        Console.WriteLine("myArr alkioden maara: " + myArr.Length);
        static void PrintIndexAndValues(ArrayList myList)
        {
            int i = 0;
            foreach (Object o in myList)
                Console.WriteLine("\t[{0}]:\t{1}", i++, o);
            Console.WriteLine();
        }

        static void PrintArrayIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArr[i]);
            Console.WriteLine();
        }
    }
}
