using System;

namespace Pin
{
    class Program
    {
        static void Main(string[] args)
        {
            Time();
        }
        static void Time()
        {
            string time;
            Console.WriteLine("Welcome to speed camera enter your time  ");
            time = Console.ReadLine();
            int length;
            length = Convert.ToInt32(time);// convert the number to an integer
            float distance = 1500;
            float speed1;
            speed1 = 1500 / length;//performs calculation 
           
            double MPH;
            double mph = (2.23);
            MPH = speed1 * mph;
            Console.Write(MPH); //Outputs the speed of the vehicle 
            Console.Write("the car is travellling");
            Console.ReadKey();
            

        }
    }
}
