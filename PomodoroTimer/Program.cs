using System;
using System.Threading;

namespace PomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==============Welcome to Pomodoro Timer!===============");

            while (true)
            {
                StartTimer(1); // 25 minutes work interval
                Console.WriteLine("Time's up! Take a short break.\n");
                Beeps();
                StartTimer(5); // 5 minutes break interval
                Console.WriteLine("Break's over! Let's get back to work.\n");
            }
        }

        static void StartTimer(int minutes)
        {
            int seconds = minutes * 60;
            while (seconds > 0)
            {
                Console.Write($"\r{TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss")}");
                Thread.Sleep(1000);
                seconds--;
            }
        }

        static void Beeps()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }
        }
    }
}

