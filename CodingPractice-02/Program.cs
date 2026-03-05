using System;

// README.md를 읽고 아래에 코드를 작성하세요.
class CodPrac
{
    static void Main()
    {
        //Prac_1();
        Prac_2();
    }

    static void Prac_1()
    {
        Celsius c = new Celsius(100);
        Fahremheit f = (Fahremheit)c;

        Console.WriteLine(c);
        Console.WriteLine(f);

    }

    static void Prac_2()
    {
        Vector3 v1 = new Vector3(1, 2, 3);
        Vector3 v2 = new Vector3(4, 5, 6);

        Console.WriteLine(v1 + v2);
        Console.WriteLine(v1 - v2);
        Console.WriteLine(v1 *2);
        Console.WriteLine(3 * v1);
        Console.WriteLine(-v1);
        Console.WriteLine(v1 == v2);
    }
}
