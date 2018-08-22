using HomeworkTimer.Interfaces;
using System;
using System.Threading;

namespace HomeworkTimer
{
    class Timer : ITimer
    {
        private Timer() { }
        private int _currentTime = 0;
        private int _secondsRender = 0;
        private void Cleaner() => Console.Clear();

        public delegate void Count();
        public event Count OnEvent;

        public void SetAlarm(int minutes)
        {
            Cleaner();
            int seconds = minutes * 60;
            _secondsRender = seconds;

            while (_currentTime < seconds)
            {
                Thread.Sleep(1000);
                _currentTime++;
                _secondsRender--;
                ShowCurrentTime();
            }

            Cleaner();
            OnEvent();
        }

        public void ShowCurrentTime()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"|{_secondsRender}| seconds remaining...");
        }

        public static Timer Instance()
        {
            return new Timer();
        }
    }
}
