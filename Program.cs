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

            //string[] cars = { "toyota", "bmw", "mercedes", "jeep", "ford", "honda", "suzuki"};

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine("Car brand: \t" + cars[i] + "\tindex no:\t" + i);
            //}

            //Console.WriteLine("----------------");

            //foreach (var x in cars)
            //{
            //    Console.WriteLine(x); // "x" isaret cubugu gibi, array deki tüm degerleri sirayla  gezer
            //}

            // --------------------------------------

            //string[] cars = { "toyota", "bmw", "mercedes", "jeep", "ford", "honda", "suzuki" };

            //foreach (var x in cars)
            //{
            //    if (x.Contains("bmw")) // "x" "bmw" yi iceriyormu diye sorgular
            //    {
            //        Console.WriteLine("Wanted car found");
            //    }
            //    else
            //    {
            //        Console.WriteLine("There is no : " + x);
            //    }
            //}

            // --------------------------------------

            //string[] cars = { "toyota", "bmw", "mercedes", "jeep", "ford", "honda", "suzuki" };

            //Array.Sort(cars);

            //foreach (var x in cars)
            //{
            //    Console.WriteLine(x);
            //}

            // --------------------------------------

            // ÖRNEK SORU: Dizinin eleman sayisini kullanici belirleyecek. Bu elemanlara dinamik olarak atama yapilacak. Bu sekilde dinamik bir array olusturacagiz.


            //int mevcut = 0;

            //Console.WriteLine("Sinif mevcudunu giriniz: ");
            //mevcut = int.Parse(Console.ReadLine());

            //Console.WriteLine("-------------------");

            //string[] student = new string[mevcut];

            //for (int i = 0; i < mevcut; i++) // döngüyü sinif mevcudu kadar kurduk.
            //{
            //    Console.Write("Ögrenci adini giriniz");
            //    student[i] = Console.ReadLine();
            //    Console.WriteLine("----------------");
            //}

            //Console.WriteLine("----------------");

            //foreach (var x in student)
            //{
            //    Console.WriteLine(x);
            //}
            // --------------------------------------

            //string[] günler = new string[7];

            //günler[0] = "Pazartesi";
            //günler[1] = "Sali";
            //günler[2] = "Carsamba";
            //günler[3] = "Persembe";
            //günler[4] = "Cuma";
            //günler[5] = "Cumartesi";
            //günler[6] = "Pazar";

            //foreach (var x in günler)
            //{
            //    Console.WriteLine(x);
            //}

            // -----------------------

            //string[] günler = new string[7];

            //for (int i = 0; i < günler.Length; i++)
            //{
            //    Console.Write((i+1) + "." + "Günü Giriniz: ");
            //    günler[i] = Console.ReadLine();
            //    Console.WriteLine("------------");
            //}

            //foreach (var gün in günler)
            //{
            //    Console.WriteLine(gün);
            //}

            // -------------------------

            string[] aylar = new string[12];

            for (int i = 0; i < aylar.Length; i++)
            {
                Console.Write((i + 1) + "." + "Ayi Giriniz: ");
                aylar[i] = Console.ReadLine();
                Console.WriteLine("------------");
            }

            foreach (var ay in aylar)
            {
                Console.WriteLine(ay);
            }

        }
    }
}
