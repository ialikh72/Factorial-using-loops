using System;
class Fac
{
    static void Main()
    {
       int fact= Factorial();
        Console.WriteLine("F="+fact);
    }
    static int Factorial()
    {
        Console.WriteLine("enter namber for factorial");
        int num = int.Parse(Console.ReadLine());
        int i = 1, fact = 1;
        while (i <= num)
        {
            fact = fact * i;
            i++;
        }
       
        return fact;
    }
}