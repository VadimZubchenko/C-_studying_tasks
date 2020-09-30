//Tässä otetaan käyttöön System-kirjasto, joka 
//sisältää mm. komennot tekstin ruudulle tulostamiseksi. 
using System;

namespace Csharp_teht_1
{
    
    //Tämä ohjelma tulostaa "Hei maailma!"-tekstin sekä tämän
    //hetken päivämäärän ja ajan ruudulle.

    class Esimerkki2_1
    {
        /*   
         * Ohjelman suoritus alkaa seuraavasta komentorivistä.
         * public kertoo sen, että Main()-metodi on saatavilla
         * Esimerkki2_1  luokan ulkopuoleltakin.
         */

        static public void Main()
        {
            //Tässä tulostetaan "Hei maailma!" ruudulle
            System.Console.WriteLine("Hei maailma!\v");


            //Seuraavassa tulostetaan ruudulle pätkä tekstiä sekä
            //tämän hetken päivämäärä ja aika.
            System.Console.WriteLine("Tämän hetken päivämäärä ja aika on: "
            + System.DateTime.Now);

        }
    }
}
