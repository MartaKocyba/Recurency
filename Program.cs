
namespace recurency
{
    class recurency1
    {
        static void Main(string[] args)
        {


            bool recurency(int x, int y)
            {
                x = x - 1;

                if (x == 1)
                {
                    //return 1;
                    return true;
                }
                else if (y == 2)
                {
                    //return 2;
                    return true;
                }
                else if (y % 2 == 0)
                {
                    //return 3;
                    return false;
                }
                else if (y % x == 0)
                {
                    //return x;
                    return false;
                }
                else if (x == 0)
                {
                    //return 5;
                    return false;
                }


                //if ( (x == 0)(x == 1) )
                //{
                //    return false;
                //}



                return recurency(x, y);
            }


            Console.WriteLine("Podaj liczbę naturalną do sprawdzenia czy jest liczbą pierwszą \n(oprócz 0 i 1 - przyjmujemy, że nie są liczbami pierwszymi): ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1 || number == 0)
            {
                Console.Clear();
                Console.WriteLine("Liczba jest równa 0 lub 1");
            }
            else if (number > 1)
            {
                if (recurency(number, number))
                {
                    Console.WriteLine("Liczba ta jest liczbą pierwszą");
                }
                else
                {
                    Console.WriteLine("Liczba ta nie jest liczbą pierwszą");
                }

            }
            else
            {
                Console.WriteLine("Podano nieprawidłową liczbę.");
            }
            Console.WriteLine("\nWciśnij dowolny klawisz aby zakończyć program");
            Console.ReadKey(); 

        }
    }
}