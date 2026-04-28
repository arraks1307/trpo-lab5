using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        // Пример использования
        Console.WriteLine(IsPrime(7));  // True
        Console.WriteLine(IsPrime(10)); // False
        Console.WriteLine(IsPrime(2));  // True
        Console.WriteLine(IsPrime(1));  // False
    }
    
    // функция которое проверяет простое число или нет

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}

