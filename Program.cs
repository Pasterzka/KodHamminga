using System;

namespace KodHamminga
{
    class Program
    {
        static void Main(string[] args)
        {

            //zmienne pomocnicze
            string pom;
            int i, y, p11 = 0, p21 = 0, p41 = 0, p81 = 0, m, p15=0;
            bool go;


            Console.WriteLine("Kod hamminga!");

            //wczytanie tablicy
            string[] liczba = new string[16];
            string[] p1 = new string[7];
            string[] p2 = new string[7];
            string[] p4 = new string[7];
            string[] p8 = new string[7];


            Console.WriteLine("Wczytaj liczbe: ");

            //pętla działania programu
            i = 0;
            do
            {

                //jeżeli potęga dwujki to wstaw "x"
                if (i == 3 || i == 7 || i == 0 || i == 1 || i == 15)
                {
                    pom = "x";
                    liczba[i] = pom;
                }
                else
                {
                    //jeżeli nie potęga dwujki to wstaw albo jeden albo dwa
                    do
                    {
                        go = true;
                        //wczytaj liczbe 
                        pom = Console.ReadLine();

                        //sprawdź czy 1 albo 0 albo co innego
                        if (pom == "1" || pom == "0")
                        {
                            //tak -> wczytaj liczbe do tablicy
                            liczba[i] = pom;
                            go = false;
                        }
                        else
                        {
                            //nie - > wczytaj jeszcze raz liczbe
                            Console.WriteLine("Zła liczba!");
                        }

                    } while (go);

                }

                i++;
                //przwerwanie pętli
                if (i == 16)
                {
                    break;
                }

            } while (true);

            //Console.WriteLine("-------------------------------");


            //sprawdzanie p1
            i = 0;
            y = 0;
            do
            {
                if (i != 3 && i != 7 && i != 0 && i != 1 && i != 15)
                {
                    //wpisanie do tablicy p1
                    p1[y] = liczba[i];
                    if (liczba[i] == "1")
                    {
                        //sprawdzeie ile jest jedynek
                        p11++;
                    }
                    y++;
                }


                i += 2;
                if (i == 16)
                {
                    break;
                }
            } while (true);

            //sprawdzanie p2
            i = 1;
            y = 0;
            do
            {
                m = i;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p2[y] = liczba[m];
                    if (p2[y] == "1")
                    {
                        p21++;
                    }
                    y++;
                    
                }
                m++;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p2[y] = liczba[m];
                    if (p2[y] == "1")
                    {
                        p21++;
                    }
                    y++;
                }


                i += 4;
                if (i == 17 || y == 7)
                {
                    break;
                }
            } while (true);

            //sprawdzanie p4
            i = 3;
            y = 0;
            do
            {

                m = i;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p4[y] = liczba[m];
                    if (p4[y] == "1")
                    {
                        p41++;
                    }
                    y++;

                }
                m++;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p4[y] = liczba[m];
                    if (p4[y] == "1")
                    {
                        p41++;
                    }
                    y++;
                }

                m++;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p4[y] = liczba[m];
                    if (p4[y] == "1")
                    {
                        p41++;
                    }
                    y++;
                }

                m++;

                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p4[y] = liczba[m];
                    if (p4[y] == "1")
                    {
                        p41++;
                    }
                    y++;
                }



                i += 8;
                if (y == 7)
                {
                    break;
                }
            } while (true);

            //sprawdzanie p8
            m = 8;
            for (int j = 0; j < 7; j++)
            {
                if (m != 0 && m != 1 && m != 3 && m != 7 && m != 15)
                {
                    p8[j] = liczba[m];
                    if (p8[j] == "1")
                    {
                        p81++;
                    }
                    m++;
                }
            }

            //-------------------------------------------------
            

            //sprawdzanie czy p są parzyste

            if (p11%2==1)
            {
                liczba[0] = "1";
                p15++;
            }
            else
            {
                liczba[0] = "0";
            }

            if (p21 % 2 == 1)
            {
                liczba[1] = "1";
                p15++;
            }
            else
            {
                liczba[1] = "0";
            }

            if (p41 % 2 == 1)
            {
                liczba[3] = "1";
                p15++;
            }
            else
            {
                liczba[3] = "0";
            }

            if (p81 % 2 == 1)
            {
                liczba[7] = "1";
                p15++;
            }
            else
            {
                liczba[7] = "0";
            }

            if (p15 % 2 == 1)
            {
                liczba[15] = "1";
            }
            else
            {
                liczba[15] = "0";
            }


            for (int j = 0; j < 16; j++)
            {
                Console.WriteLine(liczba[j] + " ");
            }

            

            Console.WriteLine("--------------------------");

            for (int j = 0; j < 16; j++)
            {
                Console.WriteLine(liczba[j] + " ");
            }

        }
    }
}
