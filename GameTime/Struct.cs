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
        Hours = seconds / 3600 ;
        Minutes = seconds / 60 % 60 ;
        

    }
    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static GameTime operator *(GameTime a, int scalar)
    {
        return a * scalar;
    }
    public static GameTime operator -(GameTime a, GameTime b)
    {
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
        return Hours * 3600 + Minutes * 60 + Seconds;
    }

}