using System;
using System.Collections;

//Seuraavassa määritellään Henkilo luokka.
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
        //Tässä luodaan rekisteri hajautustaulu.
        Hashtable rekisteri = new Hashtable();

        //Seuraavassa määritellään tarvittavat apumuuttujat.
        string nimi;
        int id;
        float palkka;

        //Seuraavassa pyydetään henkilön tiedot.
        string jatka = "k";
        while (jatka.Equals("k"))
        {
            Console.Write("Kirjoita henkiön nimi: ");
            nimi = Console.ReadLine();

            Console.Write("Kirjoita henkiön id numero kokonaislukuna (esim. 1000): ");
            id = Int16.Parse(Console.ReadLine());

            Console.Write("Kirjoita henkiön palkka desimaalilukuna (esim. 2456,78): ");
            palkka = float.Parse(Console.ReadLine());

            //Tässä luodaan uusi Henkilo-olio ja lisätään
            //hajautustauluun rekisteri.
            rekisteri.Add(id, new Henkilo(nimi, id, palkka));
            Console.WriteLine();

            //Seuraavassa tarkistetaan haluaako käyttäjä jatkaa.
            Console.WriteLine("Haluatko jatkaa? (k/e)");
            jatka = Console.ReadLine();
        }

        Console.WriteLine("Henkilötiedot:");

        //Seuraavassa rekisterin sisältö tulostetaan näytölle.
        IDictionaryEnumerator enumerator
            = rekisteri.GetEnumerator();

        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Key + "-->" +
            enumerator.Value);// tässä value on henkilo-objekti ToString();
        
        //Seuraavassa pyydetään henkilön id numero ja sen 
        //jälkeen sitä etsitään rekisteristä.
        Console.WriteLine("Kirjoita etsittävän henkilön id:");
        id = Int16.Parse(Console.ReadLine());

        bool henkiloLoytynyt = false;

        //Tässä rekisterin läpikäyntifunktio taas alustetaan.
        enumerator.Reset();

        //Seuraavassa annettu id numero etsitään rekisteristä.
        while (enumerator.MoveNext())
        {
            if (enumerator.Key.Equals(id))
            {
                henkiloLoytynyt = true;

                //Tässä tulostetaan löydetyn henkilön tiedot. 
                //Huomaa, että enumerator.Value tulostaa tiedot 
                //ymmärrettävään muotoon vain sen takia, etä 
                //luokalle Henkilot on määritelty metodi ToString(),
                //joka palauttaa merrkijonon, joka sisältää henkilön 
                //tiedot. 
                Console.WriteLine(enumerator.Key + "-->" +
                enumerator.Value);
            }
        }

        //Tässä tulostetaan viesti jos id numero ei löytynyt
        //rekisteristä.
        if (!henkiloLoytynyt)
            Console.WriteLine("Id numero " + id + " ei ole rekisterissä!");
    }
}
