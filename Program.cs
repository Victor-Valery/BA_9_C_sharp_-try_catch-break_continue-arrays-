using System;

namespace BA_C_sharp_9__try_catch__brak_continue__arrays___
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. TRY-CATCH  -- detect errors
            // 2. BREAK-CONTINUE
            // 3. ARRAYS

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Bir tamsayi deger giriniz");
            //        int sayi = int.Parse(Console.ReadLine());
            //        Console.WriteLine(sayi);
            //    }
            //    catch  /*(Exeption x)*/ 
            //    {
            //        //Console.WriteLine(x.Message); (sistemin mesaji ekranda görünür)

            //        Console.WriteLine("Lütfen tam sayi giriniz");
            //    }
            //}
            //*******************************************

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*****************");

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            // *****************************************************

            //string name = "Victor"
            //string surname = "Valery"

            // -----------------------------

            //string[] car; // string array
            //int[] numbers; // integer array

            //string[] cars = { "toyota", "bmw", "mercedes", "jeep" }; // assigning values to arrays
            //cars[0] = "opel"; // change element of array

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //numbers[3] = 1000;

            //Console.WriteLine(cars[2]);
            //Console.WriteLine(numbers[3]);

            // --------------------------------------

            //string[] cars = { "toyota", "bmw", "mercedes", "jeep" }; 
            //cars[0] = "opel";

            //Console.WriteLine(cars.Length); // (4) number of elements of the array

            //int value = cars.Length;

            //value += 5;

            //Console.WriteLine(value); // (9)

            // --------------------------------------

            string[] cars = { "toyota", "bmw", "mercedes", "jeep", "ford", "honda", "suzuki"};

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car brand:" + cars[i] + "index no" + i + "\n");
            }











        }
    }
}
