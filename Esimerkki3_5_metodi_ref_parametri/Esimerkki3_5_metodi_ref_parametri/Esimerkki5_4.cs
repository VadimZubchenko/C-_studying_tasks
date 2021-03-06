using System;

  class Opiskelija
  {
    //Seuraavassa määritellään NostaArvosanaa()-metodi, joka 
    //saa syötteenä viittauksen byte-tyyppisen muuttujaan. 
    public void NostaArvosanaa(ref byte arvoSana)
    {
       arvoSana += 1;
    }
    
    //Seuraavassa määritellään LaskeArvosanaa()-metodi, joka 
    //saa syötteenä byte-tyyppisen muuttujan arvon.
    public void LaskeArvosanaa(byte arvoSana)
    {
       arvoSana -= 1;
    }
  }
  
  class Esimerkki5_4
  {
    static void Main(string[] args)
    {
      //Seuraavassa määritellään byte-tyyppiset arvosana1
      //ja arvosana2 muuttujat.
      byte arvosana1 = 1;
      byte arvosana2 = 5;

      //Tässä määritellään opiskelija-olio.
      Opiskelija opiskelija = new Opiskelija();

      //Tässä tulostetaan muuttujan arvosana1 arvo ennen sen 
      //päästämistä NostaArvosanaa()-metodiin.
      Console.WriteLine("Alussa: arvosana1 = " + arvosana1);
      
      //Tässä kutsutaan opiskelija-olion NostaArvosanaa()-
      //metodi, johon päästetään viittaus arvosana1-
      //muuttujaan. Tämä tehdään käyttämällä ref sanaa 
      //kutsussa. Näin on myös pakko tehdä koska 
      //NostaArvosanaa()-metodi on määritelty siten, että se 
      //hyväksyy vain viittausparametrin.
      opiskelija.NostaArvosanaa(ref arvosana1);
      
      //Tässä tulostetaan muuttujan arvosana1 arvo 
      //NostaArvosanaa()-metodin kutsun jälkeen.
      Console.WriteLine("NostaArvosanaa(ref arvosana1) kutsun jälkeen: arvosana1 = " + arvosana1);

      //Tässä tulostetaan katkoviivoja.   
      Console.WriteLine("----------");

      //Tässä muuttujan arvosana2 arvo tulostetaan näytölle 
      //ennen sen päästämistä LaskeArvosanaa()-metodiin.
      Console.WriteLine("Alussa: arvosana2 = " + arvosana2);

        //Tässä kutsutaan opiskelija-olion LaskeArvosanaa()-
        //metodi, johon päästetään muuttujan arvosana2 arvo.(vain kopion muuttujien arvoista) 
        //Huomaa, että tässä ei voida ref sanaa käyttää koska
        //LaskeArvosanaa()-metodi on määritelty siten, että se 
        //hyväksyy vain arvoparametrin.
        opiskelija.LaskeArvosanaa(arvosana2);

      //Tässä muuttujan arvosana2 arvo tulostetaan näytölle 
      //LaskeArvosanaa()-metodin kutsun jälkeen.
      Console.WriteLine("LaskeArvosanaa(arvosana2) kutsun jälkeen: arvosana2 = " + arvosana2);
    }
  }