using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];  //przypisanie do name pierwszej wartości tablicy args 
            //Console.WriteLine("witaj świecie la la la! " + name);
            //Console.ReadKey();

            //foreach (var item in args)
            //{
            //    Console.WriteLine("witaj " + item);
            //}

            ValueTypes();

            for (; ; )
            {
                Przywitanie();
                Wiek();
                Ustawienia();
            }


        }
        /// <summary>
        /// podaje wartości minimalne i maksymalne dla typów int i long
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minint = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt= " + maxInt);
            Console.WriteLine("minInt= " + minint);
            Console.WriteLine("maxLong= " + maxLong);
            Console.WriteLine("minLong= " + minLong);
        }

        /// <summary>
        /// przwraca ustawienia
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// pyta o wiek i wyświetla komunikat
        /// </summary>
        private static void Wiek()
        {
            Console.Write("podaj ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo jesteś pełnioletni i możesz wypić browarka!");
            }
            else if (result == false)
            {
                Console.WriteLine("podałeś błędny wiek");
            }
            else
            {
                Console.WriteLine("możemy Ci zaproponować mleko");
            }
        }
        /// <summary>
        /// pyta o imię i wita
        /// </summary>
        private static void Przywitanie()
        {
            Console.Write("podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("witaj " + name);
        }
    }
}
