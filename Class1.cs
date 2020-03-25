using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{ 
    class Car
    {
        static void Main()
        {
            //работа со статическим элементом
            Vihecle.number = "6666 AB-6";
            Vihecle.Show();
            Console.WriteLine();



            //перегрузка стандартного метода ToString
            Vihecle Car1 = new Vihecle();
            Console.WriteLine(Car1);

            Console.WriteLine("Example of properties using: \n");
            Car1.Name = "Porshe 911R";
            Car1.Age = 2017;
            Car1.Type = "Sportcar";
            Car1.Max_speed = 323;
            Car1.Overclock_to_100 = 3.8;
            Car1.Еngine_capasity = 4.0;
            Car1.Engine_power = 500;
            Car1.Transmission = "7-speed manual";
            Console.WriteLine(Car1);

            //использование индексатора
            Vihecle CarMake = new Vihecle(3);
            CarMake[0] = "Porshe";
            CarMake[1] = "Dzigyli";
            CarMake[2] = "BMW";
            Console.WriteLine("Car make: " + CarMake[0] + "," + CarMake[1] + "," + CarMake[2]);
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
