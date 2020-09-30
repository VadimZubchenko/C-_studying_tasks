//Seuraavassa otetaan serialisoinnin vaatimat 
//Serialization- ja Binary- luokat k‰yttˆˆn.

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


//Seuraavassa m‰‰ritell‰n Tuote -luoka, joka merkit‰‰n
//serialisoitavaksi.
[Serializable]
class Tuote
{
    string nimi;
    int maara;
    float yksikkoHinta;

    //T‰ss‰ m‰‰ritell‰‰n luokan muodostin.
    public Tuote(string nimi, int maara, float yksikkoHinta)
    {
        this.nimi = nimi;
        this.maara = maara;
        this.yksikkoHinta = yksikkoHinta;
    }

    //T‰ss‰ m‰‰ritell‰ readOnly KokonaisHinta -ominaisuus.
    public float KokonaisHinta
    {

        get
        {
            return (maara * yksikkoHinta);
        }

    }

    //T‰ss‰ m‰‰ritell‰‰n luokan ToString() -metodi.
    public override string ToString()
    {

        return nimi + " " + maara + " " + yksikkoHinta;
    }
}

class Esimerkki10_11
{
    static void Main(string[] args)
    {
        //T‰ss‰ m‰‰ritell‰‰n tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/VadimNew/tuotteet.dat";

        //T‰ss‰ luodaan FileStream -olio, jonka avulla
        //serialisointi suoritetaan.
        FileStream fOutStream = File.OpenWrite(tiedosto);

        //T‰ss‰ luodaan BinaryFormatter-olio, jolla serialisointi tapahtuu.
        BinaryFormatter bFormatter = new BinaryFormatter();

        //Seuraavassa luodaan tuotteet -taulukko, jossa 
        //s‰ilytet‰‰n tuotteiden tiedot.
        Tuote[] tuotteet = new Tuote[3];

        tuotteet[0] = new Tuote("Omena", 100, 1.58f);
        tuotteet[1] = new Tuote("Viiniryp‰le", 32, 5.5f);
        tuotteet[2] = new Tuote("Vesimeloni", 50, 1.5f);

        //Seuraavassa Tuote -oliot kirjoitetaan tiedostoon.
        for (int i = 0; i < tuotteet.Length; i++)
            bFormatter.Serialize(fOutStream, tuotteet[i]);

        //T‰ss‰ tiedot kirjoitetaan lopullisesti tiedostoon.
        fOutStream.Flush();

        //T‰ss‰ virta suljetaan.
        fOutStream.Close();

        //T‰ss‰ m‰‰ritell‰‰n lukuvirta.
        FileStream fInStream = File.OpenRead(tiedosto);

        Console.WriteLine("Tuotteet tiedostossa: ");

        //Seuraavassa m‰‰ritell‰‰n apumuuttujat.
        Tuote tuote = null;
        float kokonaisHinta = 0.0f;

        //T‰ss‰ k‰yd‰‰n fInStream -lukuvirta k‰yd‰‰n l‰pi. 
        //Huomaa, kuinka (fInStream.Position != fInStream.Length)
        //-ehdon avulla tarkistetaan kuinka ollaan p‰‰sty tiedoston
        //loppuun.
        while (fInStream.Position != fInStream.Length)
        {
            //T‰ss‰ luodaan oliot kerrallaan ja tallennetaan
            //tuote -olioon, joka on tyyppi‰ Tuote. Koska 
            //Deserialize() -metodi palauttaa object -olioita, 
            //joudutaan suorittamaan tyyppimuunnos!
            tuote = (Tuote)(bFormatter.Deserialize(fInStream));

            //T‰ss‰ lasketaan tuotteiden kokonaishinta.
            kokonaisHinta += ((Tuote)tuote).KokonaisHinta;

            //T‰ss‰ tuotteeiden tiedot tulostetaan. Huomaa, ett‰
            //t‰ss‰ automaattisesti kutsutaan olion ToString() -metodia.
            Console.WriteLine(tuote);

        };

        //T‰ss‰ tuotteiden kokonaishinta tulostetaan n‰ytˆlle.
        Console.WriteLine("Tuotteiden kokonaishinta on: " + kokonaisHinta);

        //T‰ss‰ suljetaan lukuvirta.
        fInStream.Close();


    }
}