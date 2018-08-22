using HomeworkTimer.Interfaces;
using System;

namespace HomeworkTimer.Subscribers
{
    class WashMachine : Activatable
    {
        public void Activate()
        {
            base.Activate("Wash machine");
        }
    }
}
