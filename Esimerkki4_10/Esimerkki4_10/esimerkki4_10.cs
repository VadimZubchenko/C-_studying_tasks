  //Seuraavassa m‰‰ritell‰‰n TARKISTA_X, TARKISTA_SUMMA- ja 
  //TARKISTA_TOTAL-symbolit. Huomaa, ett‰ esik‰sittelijˆiden
  //komennot tulevat heti tiedoston alkuun ennen muuta koodia.
  #define TARKISTA_X
  #define TARKISTA_SUMMA
  #define TARKISTA_TOTAL

  //Seuraavassa TARKISTA_X-symbolin m‰‰rittely kumotaan.
  #undef TARKISTA_X

  //Seuraavassa TARKISTA_TOTAL-symbolin m‰‰rittely kumotaan.
  #undef TARKISTA_TOTAL

//T‰ss‰ otetaan System-kirjasto k‰yttˆˆn.
  using System;

  class Esimerkki4_10
  {
      static void Main(string[] args)
      {
          //Seuraava pakottaa k‰‰nt‰j‰‰ tulostamaan
          //m‰‰‰r‰ty varoitusilmoituksen.
         //#if lopetetaan #endif:ll‰.
         #if  TARKISTA_SUMMA
           #warning Varoitus: Summaa tarkistetaan!
        #endif
    
        //Seuraava pakottaisi k‰‰nt‰j‰‰ tulostamaan 
        //m‰‰‰rtyn virheilmoituksen. Virheilmoituksen
        //tulostava lause on kuitenkin kommentoitu!
        #if TARKISTA_X
         //#error Virhe: x tarkistetaan!
        #endif

         //Seuraavassa rivin numrointi aloitetaan 100:sta
         //ja virheen sattuessa l‰hdekooditiedosto nimet‰‰n
         //virhe.cs:ksi.
        #line 2000 "virhe.cs"
          float x, summa;

        //Seuraava aiheuttaa sen, ett‰ debuggeri ei ota
        //seuraavia rivej‰ huomioon, kunnes seuraava 
        //#line-komento tulee vastaan.
        #line hidden
          summa = 0.0f;

        System.Console.WriteLine("Summa alussa on: " + summa);

        //Seuraavassa m‰‰ritell‰‰n lohko, joka p‰‰ttyy 
        //#endregion-komentoon.
        #region  do lauseke
        do
        {
          //#line default aiheuttaa sen, ett‰ 
          //k‰‰nt‰j‰ kohtelee seuraavia rivej‰ normaalisti.
          #line default

            System.Console.Write("Syˆt‰ luku (0 lopettaa!): ");

          x = float.Parse(System.Console.ReadLine());
 
          summa += x;

          //Seuraavilla riveill‰ tulostetaan erilaisia 
          //viestej‰ riippuen siit‰ mitk‰ symbolit on m‰‰ritelty.
          #if TARKISTA_X
              System.Console.WriteLine("x={0}", x);
          #elif TARKISTA_SUMMA
            System.Console.WriteLine("V‰lisumma={0}", summa);
          #else
            System.Console.WriteLine("x:n ja summan arvoja " +
            "ei tulosteta!" );
          #endif
        } while (x != 0.0);

        //T‰ss‰ p‰‰tet‰‰n lohko.
        #endregion

        System.Console.WriteLine("Kokonaissumma on: " + summa);
      }
  }

