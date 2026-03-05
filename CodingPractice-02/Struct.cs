using System;
using System.Collections.Generic;
using System.Text;

public struct Celsius
{
    public double Degrees;
    public Celsius(double degrees)
    {
        Degrees = degrees; 
    }
    public static explicit operator Fahremheit(Celsius c)
    {
        return new Fahremheit(c.Degrees * 9 / 5 + 32);
    }

    public static explicit operator Celsius(Fahremheit f)
    {
        return new Celsius((f.Degrees - 32) * 5 / 9);
    }

    public override string ToString()
    {
        return $"{Degrees}°C";
    }
    
}

public struct Fahremheit
{
    public double Degrees;

    public Fahremheit(double degrees)
    {
        Degrees = degrees;
    }

    public override string ToString()
    {
        return $"{Degrees}°F";
    }
}

public struct Vector3
{
    public float X;
    public float Y;
    public float Z;

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X+b.X, a.Y+b.Y, a.Z+b.Z);
    }
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    public static Vector3 operator *(Vector3 v, float scalar)
    {
        return new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }
    public static Vector3 operator *(float scalar, Vector3 v)
    {
        return v * scalar;
    }

    public static Vector3 operator -(Vector3 v)
    {
        return new Vector3(-v.X, -v.Y, -v.Z);
    }
    public static bool operator ==(Vector3 a, Vector3 b)
    {
        return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    public static bool operator !=(Vector3 a, Vector3 b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }
}