using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
class Tyontekija
{
    public int Id { get; set; }
    public string Nimi { get; set; }
    public float Palkka { get; set; }

    public Tyontekija(int id, string nimi, float palkka)
    {
        this.Id = id;
        this.Nimi = nimi;
        this.Palkka = palkka;
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        string tiedosto = "/users/C#_FileCreating/tyontekijat_hash.dat";
        BinaryFormatter sFormatter = new BinaryFormatter();

        
         FileStream fOutStream = File.Open(tiedosto, FileMode.Append);
        
        Hashtable tyontekijat = new Hashtable();
        
        Console.WriteLine("Anna kolmen työntekijan tiedot (id, nimi, palkka): ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Anna id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna nimi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("Anna palkka:");
            float palkka = (float)Convert.ToDouble(Console.ReadLine());

            tyontekijat.Add(id, new Tyontekija(id, nimi, palkka));
        }

        sFormatter.Serialize(fOutStream, tyontekijat);
        fOutStream.Flush();
        fOutStream.Close();
        
        FileStream fInStream = File.OpenRead(tiedosto);

        List<Tyontekija> tt_lista = new List<Tyontekija>();
        object obj;
        while (fInStream.Position != fInStream.Length)
        {
            obj = sFormatter.Deserialize(fInStream);

            if (obj is Hashtable)
            {
                tyontekijat = (Hashtable)obj;
            }
        }
        Console.WriteLine("Maara: " + tyontekijat.Count);
        haku:
        Console.WriteLine("Anna työntekijän id:");
        int haettavaId = Convert.ToInt32(Console.ReadLine());

        Tyontekija tt = (Tyontekija)tyontekijat[haettavaId];
        if (tt != null)
        {
            Console.WriteLine("id: " + tt.Id + " nimi: " + tt.Nimi + " palkka: " + tt.Palkka);
			goto haku;
        }
        else
        {
            Console.WriteLine("Työntekijää ei löytynyt id-numerolla " + haettavaId);
        }
        fInStream.Close();

        
    }
}

