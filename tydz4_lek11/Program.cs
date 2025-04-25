using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy podana liczba jest przysta czy nieparzysta.\n");

            int userNumber = 0;
            bool isNumberOk;

            do
            {  
                try
                {
                    Console.WriteLine("Podaj liczbę całkowitą:");
                    isNumberOk = GetNumber(out userNumber);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isNumberOk=false;
                }
            } while (!isNumberOk);

            Console.Clear();

            if (userNumber % 2 == 0)
                Console.WriteLine($"\n {userNumber} to liczba parzysta.");
            else
                Console.WriteLine($"\n {userNumber} to liczba nieparzysta.");
 
            
            static bool GetNumber(out int number)
            {

                if (int.TryParse(Console.ReadLine(), out number))    
                    return true;
                else
                    throw new Exception("Nie podałeś prawidłowej liczby!\n\nSpróbuj ponownie."); 

            }

        }
    }
}