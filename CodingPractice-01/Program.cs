using System;

// README.md를 읽고 아래에 코드를 작성하세요.

class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        Prac_4();
        Prac_5();

    }

    static void Prac_1()
    {
        Counter c = new Counter(5);
        Console.WriteLine(-c);
        c++;
        Console.WriteLine(c);
    }
    static void Prac_2() 
    {
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);

        Console.WriteLine(f1+f2);
        Console.WriteLine(f1*f2);
    }
    static void Prac_3() 
    {
        Money money1 = new Money(1000, "KRW");
        Money money2 = new Money(2000, "KRW");
        Console.WriteLine(money1 == money2);
        Console.WriteLine(money1 < money2);

    }
    static void Prac_4() 
    {
        Vector2 vector2 = new Vector2(1, 2);
        vector2 += new Vector2(3, 4);
        Console.WriteLine(vector2);

    }
    static void Prac_5() 
    {
        Celsius temp = 36.5;       
        double value = temp;        
        Console.WriteLine(value);
    }

}
