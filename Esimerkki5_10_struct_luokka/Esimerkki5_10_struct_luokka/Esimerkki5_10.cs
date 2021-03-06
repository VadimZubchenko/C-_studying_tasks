  using System;  
  
  //Seuraavassa määritellään Henkilo-tietorakenne.
  struct Henkilo
  {
    //Seuraavassa esitellään kentät.
    public float kiloPaino;
    public float metriPituus;
    public int ika;
    public bool aikuinen;
    
    //Seuraavassa määritellään tietorakenteelle muodostin 
    //parametreilla. Muista, että struct-tietorakenteelle ei 
    //saa määritellä oletusmuodostinta, eli muodostin ilman 
    //parametreja!
    public Henkilo(float kiloPaino, float metriPituus, int 
    ika)
    {
      //Seuraavassa alustetaan kentät.
      this.kiloPaino = kiloPaino;
      this.metriPituus = metriPituus;
      this.ika = ika;
      //Seuraavassa alustetaan aikuinen-kenttä, jonka arvo 
      //riippuu ika-kentästä.
      if (this.ika >= 18)
      aikuinen = true;
      else
      aikuinen = false;
    }
    
    //Seuraava metodi ilmoittaa henkilön vartalon muodon 
    //laskemalla painoindeksin ja vertaamalla sitä ennalta 
    //määrättyihin arvoihin.
    public void VartalonMuoto()
    {
      //Tässä määrietllään lokaalimuuttuja painoIndeksi.
      float painoIndeksi=0.0f;
      
      //if-lauseella varmistetaan, että nollalla jako ei 
      //tapahdu esim. jos olio on luotu oletusmuodostimella 
      //ja metriPituus-kentän arvoksi on asetettu 0. 
      if(metriPituus !=0)
      painoIndeksi=(float) kiloPaino 
      /(metriPituus*metriPituus);

      Console.WriteLine("Henkilön tiedot: ");
      Console.WriteLine("Paino (kg): " + kiloPaino);
      Console.WriteLine("Pituus (m): " + metriPituus);
      Console.WriteLine("Ikä: " + ika);
      Console.WriteLine("Aikuinen: " + aikuinen);

      //Seuraavissa varmistetaan, että metriPituus-kentän
      //arvo ei ole 0 ja ikä on vähintään 18, minkä jälkeen 
      //selvitetään vartalon muoto.
      if (metriPituus !=0 && ika >= 18)
      {
        if (painoIndeksi >= 18.5f && painoIndeksi <= 25f)
         Console.WriteLine("Painoindeksi={0,0:f2} ->  Henkilö on terveellisen normaalipainoinen!", painoIndeksi);
      else if (painoIndeksi > 25f && painoIndeksi <= 29.9f)
        Console.WriteLine("Painoindeksi={0,0:f2} -> Henkilö on ylipainoinen!", painoIndeksi);
      else if (painoIndeksi >= 30f && painoIndeksi <= 34.9f)
        Console.WriteLine("painoindeksi={0,0:f2} -> Henkilön ylipainosta sairastumisriskki on suuri!", painoIndeksi);
      else if (painoIndeksi >= 35f && painoIndeksi <= 39.9f)
        Console.WriteLine("Painoindeksi={0,0:f2} -> Henkilö on vaikeasti lihava!", painoIndeksi);
      else
        Console.WriteLine("Painoindeksi={0,0:f2} -> Henkilö on sairaalloisen lihava!", painoIndeksi);
      }
      else
        Console.WriteLine("Painoindeksi ei ole luotettava!");
      Console.WriteLine("----------------");
    }
  }

  class Esimerkki5_10
  {
    static void Main(string[] args)
    {
      //Seuraavassa luodaan henkilo1-olio. Koska olio luodaan 
      //new-operaattorilla ja oletusmuodostimella, kentät 
      //alustetaan oletusarvoilla: numeerinen kentät
      //nolllla, bool kentät false-arvolla ja string kentät
      //null-arvolla.
      Henkilo henkilo1 = new Henkilo();
      Console.WriteLine("Oletusmuodostimella ja new-operaattorilla luodun olion tiedot: ");
      
      //Seuraavassa kutsutaan henkilo1-olion VartalonMuoto()-
      //metodi.
      henkilo1.VartalonMuoto();
      
      //Seuraavassa luodaan henkilo2 new-operaattorilla ja 
      //muodostimella, jonka kautta kentät alustetaan. 
      
      Henkilo henkilo2 = new Henkilo(53f, 1.60f, 35);
      Console.WriteLine("Muodostimella ja new-operaattorilla luodun olion tiedot: ");
      henkilo2.VartalonMuoto();
      
      //Tässä luodaan henkilo3-olio ilman muodostinta. 
      //Huomaa, että ennen kuin pystytään
      //kutsumaan olion metodeja, kaikki kentät tulee ensin 
      //alustaa.
      
      Henkilo henkilo3;
      //Seuraavassa alustetaan henkilo3-olion attribuutit.
      henkilo3.kiloPaino = 200f;
      henkilo3.metriPituus=2.10f;
      henkilo3.ika = 38;
      henkilo3.aikuinen = true;
      Console.WriteLine("Ilman new-operaattoria luodoun olion tiedot (attribuutit on alustettu erikseen):");
      henkilo3.VartalonMuoto();
    }
  }
