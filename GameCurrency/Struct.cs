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
        Gold = gold + silver / 100;
        Silver = silver % 100;
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
            return new GameCurrency(0, 0);
    }
    public static bool operator <(GameCurrency a, GameCurrency b)
    {
        return a.Gold < b.Gold;
    }
    public static bool operator >(GameCurrency a, GameCurrency b)
    {
        return a.Gold > b.Gold;
    }
    public static bool operator ==(GameCurrency g, GameCurrency s)
    {
        return g.Gold == s.Gold && g.Silver == s.Silver;
    }
    public static bool operator !=(GameCurrency g, GameCurrency s)
    {
        return !(g==s);
    }

    public int GetTotalSilver()
    {
        return Gold * 100 + Silver;
    }

    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }

}
