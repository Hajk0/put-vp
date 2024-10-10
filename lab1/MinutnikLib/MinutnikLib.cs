namespace MinutnikLib;
using System;
using System.Timers;

public class MinutnikLib
{
    private DateTime end;
    private DateTime now;
    private Timer timer;

    public MinutnikLib(DateTime end)
    {
        now = DateTime.Now;
        //DateTime end = new DateTime(2024, 10, 3, 18, 20, 0);
        this.end = end;

        this.timer = new System.Timers.Timer(1000);
        this.timer.AutoReset = true;
        this.timer.Elapsed += OnElapsed;
        this.timer.Start();
    }
    
    private void OnElapsed(object? sender, ElapsedEventArgs e) {

        if (now >= end) {
            timer.Stop();
            return;
        }
        Console.Clear();
        Console.SetCursorPosition(40, 0);
        now = DateTime.Now;
        Console.WriteLine("Czas do końca: " + (end - now).ToString("hh\\:mm\\:ss"));
    }
}
