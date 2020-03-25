using System;

namespace ConsoleApp10
{
    class Vihecle
{
    protected string name;
    protected int age;
    protected double max_speed;
    protected double overclock_to_100;
    protected double engine_capasity;
    protected string type;
    protected double engine_power;
    protected string transmission;

    public static string number;

    public string Name { get; set; }
    public double Max_speed { get; set; }
    public double Overclock_to_100 { get; set; }
    public double Еngine_capasity { get; set; }
    public string Type { get; set; }
    public double Engine_power { get; set; }
    public string Transmission { get; set; }

    protected string[] car_make;

    //Свойства для полей классов:

    //сделать автосвойства

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if ((value < 0) && (value >= 2020))  
            {
                age = 0;
            }
            else
            {
                age = value;
            }
        }
    }

    public Vihecle()
    {
        name = "Porshe 911R";
        age = 2017;
        max_speed = 323;
        overclock_to_100 = 3.8;
        engine_capasity = 4.0;
        engine_power = 500;
        transmission = "7-speed manual";

        type = "sportcar";
    }

    //конструктор для массива hobbies
    public Vihecle(int n)
    {
        car_make = new string[n];
    }

    public static void Show()
    {
        Console.WriteLine("Number of car: " + number);
    }

    public override string ToString()
    {
        string info = "Name: " + name + ";" + " Age: " + age + ";" + " Max speed: " + max_speed + ";" + " Overclock to 100: " + overclock_to_100 + ";" + " Еngine capasity: " + engine_capasity + ";" + " Type of car: " + Type + ";" + " Engine power : " + Engine_power + ";" + " Transmission: " + Transmission;
        return info;

    }

    public string this[int m]
    {
        get
        {
            return car_make[m];
        }

        set
        {
            car_make[m] = value;
        }
    }
}


}
