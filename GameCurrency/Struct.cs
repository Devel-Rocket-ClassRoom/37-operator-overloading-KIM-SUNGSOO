using System;
using System.Collections.Generic;
using System.Text;


struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b)
    {
        return new GameCurrency(a.Gold + b.Gold, a.Silver+b.Silver);
    }
    public static GameCurrency operator -(GameCurrency a, GameCurrency b)
    {
        if(a.Gold > b.Gold)
            return new GameCurrency(a.Gold - b.Gold, a.Silver - b.Silver);
        else
            return new GameCurrency(b.Gold - a.Gold, b.Silver - a.Silver);
    }
    public static bool operator ==(GameCurrency g, GameCurrency s)
    {
        return g.Gold == s.Gold && g.Silver == s.Silver;
    }
    public static bool operator !=(GameCurrency g, GameCurrency s)
    {
        return !(g==s);
    }


    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }

}
