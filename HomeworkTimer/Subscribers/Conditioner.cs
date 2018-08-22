using HomeworkTimer.Interfaces;
using System;

namespace HomeworkTimer.Subscribers
{
    class Conditioner : Activatable
    {
        public void Activate()
        {
            base.Activate("Conditioner");
        }
    }
}
