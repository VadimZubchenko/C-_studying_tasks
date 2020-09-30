  using System;
  
  class Esimerkki11_3
    //Poikkeusten sieppaaminen yhdell? try- ja 3 catch-lohkolla:
{
    static void Main(string[] args)
    {
      //T?ss? esitell??n muuttujat.
      ushort[] bitit = { 0, 0, 1 };
      ushort luku = 5;
      int i=0, j = 0, toistot=3;
      
      //T?ss? luodaan Random-olio.
      Random r = new Random();
      
      string[] temp=null;
      
      //Seuraavassa ohjelmaa toistetaan 
      for (int k = 0; k < toistot; k++)
      {
        //Seuraavassa lauseet laitetaan try/catch -lohkoon.
        try
        {
          //Seuraavat lauseet suoritetaan "ikuisessa luupissa".
          for (; ; )
          {
            //Seuraavassa yritet??n temp -taulukon 
            //ensimm?ist? alkiota alustaa jos satunnaisluku
            //on pienempi kuin 2. Huomaa, ett? koska temp 
            //-taulukkoa ei ole viel? alustettu, sen alkioiden
            //alustaminen aiheuttaa poikkeustilan. 
            if (r.Next(5) < 2)
              temp[0] = "osuma";

            //T?ss? arvotaan taulukon indeksi.  
            i = r.Next(10);
            
            Console.WriteLine("i={0} --> {1}/{2}={3} ", i, 
            luku, bitit[i], (luku / bitit[i]));
            j++;
          }
        }
        catch (IndexOutOfRangeException e)
        {
          //T?ss? tulostetaan viesti, jos viitataan taulukon
          //ulkopuolelle
          Console.WriteLine("Viittaus taulukon ulkopuolelle!");
          Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
          //T?ss? tulostetaan viesti, jos yeitet??n suorittaa 
          //nollalla jako. 
          Console.WriteLine("Nollalla jako: {0}/{1}: ", luku, 
          bitit[i]);
          Console.WriteLine(e.Message);
        }
        catch (NullReferenceException e)
        {
          //T?ss? tulostetaan viesti, jos yritet??n k?ytt??
          //alustamatonta oliota! 
          Console.WriteLine("Yritys kayttaa alustamatonta oliota!");
          Console.WriteLine(e.Message);
        }
        finally
        {
          Console.WriteLine("finally -lohkossa!");
          Console.WriteLine("---------------------");
        }
      }
    }
  }
