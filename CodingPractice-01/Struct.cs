using System;
using System.Collections.Generic;
using System.Text;

public struct Counter
{
    public int Value;
    public Counter(int value)
    {
        Value = value; 
    }

    public static Counter operator -(Counter c)
    {
        return new Counter(-c.Value);
    }

    public static Counter operator ++(Counter c)
    {
        return new Counter(++c.Value);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

public struct Fraction
{

    public int Numerator;//분자
    public int Denominator;//분모

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int num = a.Numerator * b.Denominator + a.Denominator * b.Numerator;
        int den = a.Denominator * b.Denominator;
        return new Fraction(num, den);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Numerator,
            a.Denominator * b.Denominator
            
            );

    }



    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

public struct Money
{
    public decimal Amount;
    public string Currency;

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }


    public static bool operator ==(Money a , Money b)
    {
        return a.Currency == b.Currency && a.Amount == b.Amount;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }
    public static bool operator <(Money a, Money b)
    {
        if(a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다."); 
        }
        return a.Amount < b.Amount;

    }
    public static bool operator >(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
        return a.Amount > b.Amount;

    }

    

}


public struct Vector2
{
    public int X;
    public int Y;

    public Vector2(int x , int y)
    {
        X = x; 
        Y = y;   
    }

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);
    }
    public override string ToString()
    {
        return $"{X},{Y}";
    }
}

public struct Celsius
{
    public double Degrees;

    public Celsius(double degrees)
    {
        Degrees = degrees;
    }

    
    public static implicit operator double(Celsius c)
    {
        return c.Degrees;
    }

    
    public static implicit operator Celsius(double d)
    {
        return new Celsius(d);
    }
}