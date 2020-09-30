using System;

namespace Teht4_6_vain_alkuluvut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna yläraja:");
            int raja = Convert.ToInt32(Console.ReadLine());

            for (long i = 2; i <= raja; i++)
            {
                bool onAlkuluku = true;

                //käsittelty kaikki luvut mutta enemmän 2 ja ennen -i-,
                //esim. jaetaan luku: 5 (2-lla,3-lla,4-lla) eli ei 1, eikä  esim. luku: 5 (2,3,4)
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        onAlkuluku = false;
                        break;
                    }
                }
                // tähän pääsee lukukin 2.
                if (onAlkuluku)
                {
                    Console.WriteLine(i);
                }
            }



            Console.WriteLine("\n\n---Mun keksimä tapa. Monimutkaisemmin!!!---\n\n");






                int alkuluku = 2;

                Console.WriteLine("Anna yläraja:");
                var ylaraja = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(alkuluku);
                while (alkuluku < ylaraja)
                {
                    alkuluku++;

                    if (alkuluku <= 7 && alkuluku % 2 != 0)

                        Console.WriteLine(alkuluku);

                    else if (alkuluku % 2 != 0 && alkuluku % 3 != 0 && alkuluku % 4 != 0 && alkuluku % 5 != 0
                             && alkuluku % 6 != 0 && alkuluku % 7 != 0)

                        Console.WriteLine(alkuluku);

                }
            }
        }
    }

