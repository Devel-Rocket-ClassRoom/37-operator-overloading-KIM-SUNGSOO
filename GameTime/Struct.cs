using System;
using System.Collections.Generic;
using System.Text;



struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;

    public GameTime(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
        Hours = (hours * 3600 + minutes * 60 + seconds)/3600;
        Minutes = ((hours * 3600 + minutes * 60 + seconds)%3600)/60;
        Seconds = ((hours * 3600 + minutes * 60 + seconds)%3600)%60;


    }
    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static GameTime operator *(GameTime a, int scalar)
    {
        return new GameTime(a.Hours*3, a.Minutes*3, a.Seconds*3);
    }
    public static GameTime operator -(GameTime a, GameTime b)
    {
        if (a.Hours < b.Hours)
            return new GameTime(0,0,0);
        return new GameTime(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
    }
    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.Hours == b.Hours && a.Minutes == b.Minutes && a.Seconds == b.Seconds;
    }
    public static bool operator !=(GameTime a, GameTime b)
    {
        return !(a == b);
    }

    public static bool operator >(GameTime a, GameTime b)
    {
        return a.Hours > b.Hours && a.Minutes > b.Minutes && a.Seconds > b.Seconds;
    }
    public static bool operator <(GameTime a, GameTime b)
    {
        return a.Hours < b.Hours && a.Minutes < b.Minutes && a.Seconds < b.Seconds;
    }


    public int GetTotalSeconds()
    {
        return (Hours * 3600)+(Minutes * 60) + Seconds;
    }

    public override string ToString()
    {
        return $"{Hours}h {Minutes}m {Seconds}s"; 
    }
}