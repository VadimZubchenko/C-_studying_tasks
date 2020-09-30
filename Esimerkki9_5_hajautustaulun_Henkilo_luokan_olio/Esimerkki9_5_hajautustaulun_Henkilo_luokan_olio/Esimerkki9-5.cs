using System;
using System.Collections;

//Seuraavassa m��ritell��n Henkilo luokka.
class Henkilo
{
    string nimi;
    int id;
    float palkka;

    public Henkilo(string nimi, int id, float palkka)
    {
        this.nimi = nimi;
        this.id = id;
        this.palkka = palkka;
    }

    public override string ToString()
    {
        return id + " " + nimi  + " " + palkka;
    }
}

class Esimerkki9_5
{
    static void Main(string[] args)
    {
        //T�ss� luodaan rekisteri hajautustaulu.
        Hashtable rekisteri = new Hashtable();

        //Seuraavassa m��ritell��n tarvittavat apumuuttujat.
        string nimi;
        int id;
        float palkka;

        //Seuraavassa pyydet��n henkil�n tiedot.
        string jatka = "k";
        while (jatka.Equals("k"))
        {
            Console.Write("Kirjoita henki�n nimi: ");
            nimi = Console.ReadLine();

            Console.Write("Kirjoita henki�n id numero kokonaislukuna (esim. 1000): ");
            id = Int16.Parse(Console.ReadLine());

            Console.Write("Kirjoita henki�n palkka desimaalilukuna (esim. 2456,78): ");
            palkka = float.Parse(Console.ReadLine());

            //T�ss� luodaan uusi Henkilo-olio ja lis�t��n
            //hajautustauluun rekisteri.
            rekisteri.Add(id, new Henkilo(nimi, id, palkka));
            Console.WriteLine();

            //Seuraavassa tarkistetaan haluaako k�ytt�j� jatkaa.
            Console.WriteLine("Haluatko jatkaa? (k/e)");
            jatka = Console.ReadLine();
        }

        Console.WriteLine("Henkil�tiedot:");

        //Seuraavassa rekisterin sis�lt� tulostetaan n�yt�lle.
        IDictionaryEnumerator enumerator
            = rekisteri.GetEnumerator();

        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Key + "-->" +
            enumerator.Value);// t�ss� value on henkilo-objekti ToString();
        
        //Seuraavassa pyydet��n henkil�n id numero ja sen 
        //j�lkeen sit� etsit��n rekisterist�.
        Console.WriteLine("Kirjoita etsitt�v�n henkil�n id:");
        id = Int16.Parse(Console.ReadLine());

        bool henkiloLoytynyt = false;

        //T�ss� rekisterin l�pik�yntifunktio taas alustetaan.
        enumerator.Reset();

        //Seuraavassa annettu id numero etsit��n rekisterist�.
        while (enumerator.MoveNext())
        {
            if (enumerator.Key.Equals(id))
            {
                henkiloLoytynyt = true;

                //T�ss� tulostetaan l�ydetyn henkil�n tiedot. 
                //Huomaa, ett� enumerator.Value tulostaa tiedot 
                //ymm�rrett�v��n muotoon vain sen takia, et� 
                //luokalle Henkilot on m��ritelty metodi ToString(),
                //joka palauttaa merrkijonon, joka sis�lt�� henkil�n 
                //tiedot. 
                Console.WriteLine(enumerator.Key + "-->" +
                enumerator.Value);
            }
        }

        //T�ss� tulostetaan viesti jos id numero ei l�ytynyt
        //rekisterist�.
        if (!henkiloLoytynyt)
            Console.WriteLine("Id numero " + id + " ei ole rekisteriss�!");
    }
}
