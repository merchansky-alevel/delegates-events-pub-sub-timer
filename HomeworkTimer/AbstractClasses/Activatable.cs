using System;

namespace HomeworkTimer.Interfaces
{
    abstract class Activatable
    {
        protected void Activate(string value)
        {
            Console.WriteLine($"{value} - activated!");
        }
    }
}
