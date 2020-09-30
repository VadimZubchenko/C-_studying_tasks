using System;

namespace Teht4_1_arva_luku_if_else_while
{
    class Teht4_1
    {
        public static void Main(string[] args)
        {
            int luku;
            int i = 1;
            Console.Write("----Ensimmäinen 'while' tapa----\n\n ");
            while (i <= 5)
            {
                Console.Write("Anna luku:");
                luku = Int32.Parse(Console.ReadLine());
                if (luku == 45)
                {
                    Console.Write("Onneksi olkoon, sama luku!\n\n\n");
                    i = 6;
                }
                else if (i == 5)
                {
                    Console.Write("Kierroksia 5, lopetetaan ohjelma.\n\n\n");
                }
                i++;
            }
            Console.Write("----Toinen 'if_else' tapa----\n\n ");

            int arvonta = 45, laskuri = 1, raja = 5;

        //Tässä määritellään alku-niminen viite.
        alku:

            // Tässä tarkistetaan ettei kierroksien määrän
            // ylläättyy rajan.
            if (laskuri > raja)
            {
                Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.\n\n\n");
            }
            else
            {
                laskuri++;
                //Seuraavassa hypätään alku-kohtaan jos luku:n arvo
                //on eri kuin arvonta.
                Console.WriteLine("Anna luku:");
                var luku2 = Convert.ToInt64(Console.ReadLine());

                if (luku2 != arvonta)

                    goto alku;

                else

                    Console.WriteLine("Onneksi olkoon, sama luku!");


            }
        }
    }

}
