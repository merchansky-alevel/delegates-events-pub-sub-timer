using HomeworkTimer.Subscribers;
using System;

namespace HomeworkTimer
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set timer time (min):");
            Console.SetCursorPosition(22, 0);
            string stringTime = Console.ReadLine();

            try
            {
                int time = Int32.Parse(stringTime);

                if (time.GetType() == typeof(Int32))
                {
                    Timer timer = Timer.Instance();
                    Conditioner conditioner = new Conditioner();
                    WashMachine washMachine = new WashMachine();
                    
                    timer.OnEvent += conditioner.Activate;
                    timer.OnEvent += washMachine.Activate;
                    timer.SetAlarm(time);
                }
                else
                {
                    Console.WriteLine("Sorry, invalid number");
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Invalid format!");
            }

            Console.ReadKey();
        }
    }
}
