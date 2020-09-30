using System;
using System.Collections.Generic;
using System.Collections;

namespace Tehtava9_2_ArrayList_CompareTo
{
    class Jumppa : IComparable
    {
        String nimi;
        String[] ajat;
        String[] paikat;

        // luodaan muodostin, jonka kautta määritellään muuttujat
        public Jumppa(String nimi, String[] ajat, String[] paikat)
        {
            this.nimi = nimi;
            this.ajat = ajat;
            this.paikat = paikat;
        }

        /*public int CompareTo(object obj)
        {
            //Tässä joudutaan muuntamaan obj-olio Henkilo-
            //tyyppiseksi.
            Jumppa jumpanAsiakas = (Jumppa)obj;

            //Seuraavassa nimi-attribuutteja verrataan 
            //keskenään metodin CompareTo() avulla.
            if (this.nimi.CompareTo(jumpanAsiakas.nimi) < 1)
                return -1;
            else if (this.nimi.CompareTo(jumpanAsiakas.nimi) > 1)
                return 1;
            else
                return 0;

        }
        */
        // toinen lyhyt tapa
        public int CompareTo(object obj)
        {
            Jumppa j = obj as Jumppa;
            return this.nimi.CompareTo(j.nimi);
        }
        public override string ToString()

        {

            String jumppa = nimi + "\najat:\n";

            for (int i = 0; i < ajat.Length; i++)
            {
                jumppa += ajat[i] + "\n";
            }
            jumppa += "\npaikat:\n";

            for (int i = 0; i < paikat.Length; i++)
            {
                jumppa += paikat[i] + "\n";

            }
            return jumppa;


        }
    }

    class Tehtava9_1
    {
        static void Main(string[] args)
        {
            ArrayList aikataulu = new ArrayList();

            aikataulu.Add(new Jumppa("juniori", new string[] { "Keskiviikko 9:30", "Perjantai 9:30" },
                                                new string[] { "Liikuntasali" }));
            aikataulu.Add(new Jumppa("seniori", new string[] { "Maanantai 8:00", "Tiistai 8:30" },
                                                new string[] { "Liikuntasali" }));
            aikataulu.Add(new Jumppa("perhe", new string[] { "Lauantai 12:30", "Sunnuntai 13:00" },
                                                new string[] { "Puisto", "Liikuntasali" }));
            aikataulu.Add(new Jumppa("naisten", new string[] { "Tiistai 8:00", "Perjantai 8:00" },
                                                new string[] { "Puisto" }));
            aikataulu.Add(new Jumppa("miesten", new string[] { "Maanantai 8:00", "Tostai 8:00" },
                                                new string[] { "Liikuntasali", "Puisto" }));
            aikataulu.Sort();

            IEnumerator enumerator = aikataulu.GetEnumerator();

            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);

        }

    }
}
