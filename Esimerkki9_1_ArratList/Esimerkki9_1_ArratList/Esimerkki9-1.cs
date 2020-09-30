//ArrayList luokan k�ytt�� varten otetaan k�ytt��n
//System.Collections-kirjasto.
using System;
using System.Collections;

class Esimerkki9_1
{
    static void Main(string[] args)
    {
        //T�ss� luodaan ArrayList-kokoelma henkilot.
        ArrayList henkilot = new ArrayList();

        //T�ss� tulostetaan kokoelman henkilot kapasiteetti.
        Console.WriteLine("Alussa henkilot.Capacity=" +
        henkilot.Capacity);

        //Seuraavassa lis�t��n dataa kokoelmaan henkilot.
        henkilot.Add("Pessi");
        henkilot.Add("AnnaLiisa");
        henkilot.Add("Taina");
        henkilot.Add("Elias");
        henkilot.Add("Illuusia");

        //T�ss� tulostetaan kokoelman henkilot kapasiteetti
        //uudelleen.
        Console.WriteLine("Alkioiden lis�yksen j�lkeen henkilot.Capacity=" + henkilot.Capacity);

        //T�ss� kokoelman henkilot kapasiteetti astetaan 
        //sen alkioiden lukum��r�ksi.
        henkilot.TrimToSize();

        //T�ss� tulostetaan kokoelman henkilot kapasiteetti
        //uudelleen.
        Console.WriteLine("TrimToSize()-metodin kutsun j�lkeen: henkilot.Capacity=" + henkilot.Capacity);

        //T�ss� tulostetaan kokoelman henkilot alkioiden
        //lukum��r�.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);

        //T�ss� kokoelman henkilot ensimm�inen elementti 
        //haetaan ja kopioidaan muuttujaan henkilo.
        string henkilo = (string)henkilot[0];

        //T�ss� tulostetaan muuttujan henkilo sis�lt�. 
        Console.WriteLine("henkilo=" + henkilo);

        Console.WriteLine("Henkil�iden lista ennen lajittelua:");

        //Seuraavassa kokoelman henkilot kaikki alkiot 
        //tulostetaan n�yt�lle k�ytt�m�ll� foreach silmukkaa.
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        Console.WriteLine("'Elias'-alkion indeksi=" +
        henkilot.IndexOf("Elias"));

        //T�ss� kokoelman henkilot sis�lt� lajitellaan 
        //nousevaan j�rjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkil�iden lista lajittelun j�lkeen:");

        //T�ss� kokoelman henkilot kaikki alkiot taas 
        //tulostetaan n�yt�lle. 
        PrintIndexAndValues(henkilot);
        Console.WriteLine();

        //T�ss� kokoelman henkilot sis�lt� lajitellaan 
        //laskevaan j�rjestykseen.
        henkilot.Reverse();

        Console.WriteLine("Henkil�iden lista k��nteislajittelun j�lkeen:");

        //T�ss� kokoelman henkilot kaikki alkiot taas 
        //tulostetaan n�yt�lle 
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        //T�ss� kokoelman henkilot ensimm�inen elementti 
        //poistetaan.
        henkilot.RemoveAt(0);

        Console.WriteLine("Henkil�iden lista ensimm�isen alkion poiston j�lkeen:");

        //T�ss� kokoelman henkilot kaikki alkiot taas 
        //tulostetaan n�yt�lle. 
        PrintIndexAndValues(henkilot);

        Console.WriteLine();

        //T�ss� luodaan uusi ArrayList-kokoelma, johon 
        //kopioidaan kokoelman henkilot sis�lt�. 
        //Huomaa, ett� metodi Clone() palauttaa object-olion,
        //joka pit�� muuntaa ArrayList-tyyppiseksi 
        //uusiHenkilot-olion alustamiseksi.
        Console.WriteLine("\nClone(): Luo matalan kopion (shallow copy) ArrayList-kokoelmasta. ");
        ArrayList uusiHenkilot = (ArrayList)henkilot.Clone();

        Console.WriteLine("uusiHenkil�iden uusi lista:");

        //T�ss� kokoelman uusiHenkilot kaikki alkiot taas 
        //tulostetaan n�yt�lle. 
        PrintIndexAndValues(uusiHenkilot);
        Console.WriteLine();

        //T�ss� poistetaan kokoelman henkilot kaikki alkiot.
        henkilot.Clear();

        Console.WriteLine("Henkil�iden lukum��r� Clear()-metodin kutsun j�lkeen:");

        //T�ss� taas tulostetaan kokoelman henkilot 
        //alkioiden lukum��r�.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);
        //T�ss� taas tulostetaan kokoelman uusiHenkilot 
        //alkioiden lukum��r�.
        Console.WriteLine("uusiHenkil�iden lukum��r�: ");
        Console.WriteLine("uusihenkilot.Count=" +
        uusiHenkilot.Count);

        Console.WriteLine("\nCopyTo(): Kopioi ArrayList-kokoelman sis�ll�n tavalliseen yksiulotteiseen taulukkoon:");
        //T�ss� k�sitell��n CopyTo method ArrayList to Array
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
        // Copies the entire source ArrayList to the target Array starting at index 3, eli "the" j�lkeen.
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
