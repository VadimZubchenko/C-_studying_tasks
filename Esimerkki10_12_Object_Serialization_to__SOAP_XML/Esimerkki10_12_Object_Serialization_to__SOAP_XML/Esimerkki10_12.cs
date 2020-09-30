//Seuraavassa mm. serialisoinnin vaatimat Serialization-
//ja Soap-kirjastot otetaan k?ytt??n.
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

//Seuraavassa m??ritell?n luokka Tuote, joka merkit??n
//serialisoitavaksi.
[Serializable]
class Tuote
{
    string nimi;
    int maara;
    float yksikkoHinta;

    //T?ss? m??ritell??n luokan muodostin.
    public Tuote(string nimi, int maara, float yksikkoHinta)
    {
        this.nimi = nimi;
        this.maara = maara;
        this.yksikkoHinta = yksikkoHinta;
    }

    //T?ss? m??ritell? lukuominaisuus KokonaisHinta.
    public float KokonaisHinta
    {
        get
        {
            return (maara * yksikkoHinta);
        }
    }

    //T?ss? m??ritell??n luokan ToString()-metodi.
    public override string ToString()
    {
        return nimi + " " + maara + " " + yksikkoHinta;
    }
}

class Esimerkki10_12
{
    static void Main(string[] args)
    {
        //T?ss? m??r?t??n tiedoston sijainti.
        string tiedosto = "/users/C#_FileCreating/tuotteet.xml";

        //T?ss? luodaan FileStream-olio, jonka avulla
        //serialisointi suoritetaan.
        FileStream fOutStream = File.Open(tiedosto,
        FileMode.Create, FileAccess.Write);

        //T?ss? luodaan SoapFormatter-olio, jolla 
        //serialisointi tapahtuu.
        SoapFormatter sFormatter = new SoapFormatter();

        //Seuraavassa luodaan ArrayList-kokoelma tuotteet, 
        //johon tuotteet lis?t??n.
        ArrayList tuotteet = new ArrayList();

        tuotteet.Add(new Tuote("Suklaa", 28, 16.60f));
        tuotteet.Add(new Tuote("Kahvi", 23, 9.8f));
        tuotteet.Add(new Tuote("Murot", 15, 7.75f));

        //T?ss? tuotteet-kokoelma kirjoitetaan tiedostoon.
        sFormatter.Serialize(fOutStream, tuotteet);

        //T?ss? FileStream-kirjoitusvirta suljetaan.
        fOutStream.Flush();
        fOutStream.Close();

        //T?ss? m??ritell??n FileStream-lukuvirta.
        FileStream fInStream = File.OpenRead(tiedosto);

        Console.WriteLine("Tuotteet tiedostossa: ");

        //Seuraavassa m??ritell??n apumuuttujat.
        ArrayList tuoteLista = null;
        object obj;
        float kokonaisHinta = 0.0f;

        /*
         * T?ss? ei tarvitse k?yt?? 
         * while (fInStream.Position != fInStream.Length)
         * koska se aiheuttaa virhen
         */
        //Seuraavassa fInStream -lukuvirta k?yd??n l?pi. 
        //Huomaa, ett? (fInStream.Position != fInStream.Length)
        //-ehdon avulla tarkistetaan ollaanko p??sty tiedoston
        //loppuun.
        //while (fInStream.Position != fInStream.Length)
        //{
        //T?ss? luetaan tiedoston sis?lt? object-oliona.
        obj = sFormatter.Deserialize(fInStream);

            //Seuraavassa tarkistetaan onko obj-olio 
            //muunnettavissa tyyppiin ArrayList. Jos on, se 
            //ensin muunnetaan ArrayList-tyyppiseksi ja 
            //sitten kopioidaan muuttujaan tuoteLista.

            if (obj is ArrayList)
                tuoteLista = (ArrayList)obj;

            //T?ss? varmistetaan, ett? tuoteLista-olio ei ole
            //null ennen sen l?pik?ynti?

            if (tuoteLista != null)
            {
                //T?ss? tuoteLista -kokoelma k?yd??n olio 
                //kerrallaan l?pi. Huomaa, ett? ArrayList-
                //kokoelmasta sis?lt? luetaan object-olioina. 
                foreach (Object t in tuoteLista)
                {
                    //Seuraavassa lasketaan tuotteiden kokonaishinta.
                    //Huomaa, ett? seuraavassa ensin t -oliolle 
                    //suoritetaan tyyppimuunnos ja sen j?lkeen 
                    //kutsutaan sen KokonaisHinta -ominaisuus. 
                    kokonaisHinta += ((Tuote)t).KokonaisHinta;

                    //T?ss? tuotteeiden tiedot tulostetaan. Huomaa, 
                    //ett? t?ss? automaattisesti kutsutaan olion 
                    //ToString() -metodi.
                    Console.WriteLine(t);
                }
            }
            else
            {
                Console.WriteLine("Tiedostossa ei ole ArrayList-dataa!");
            }
        //}

        //T?ss? tuotteiden kokonaishinta tulostetaan n?yt?lle.
        Console.WriteLine("Tuotteiden kokonaishinta on {0,5:f2} euroa. ", kokonaisHinta);

        //T?ss? suljetaan lukuvirta.
        fInStream.Close();
    }
}
