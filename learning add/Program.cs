using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Done_is_better_than_good
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zmienna = new Random();
            int suma, wynik;
            int a = zmienna.Next(10, 100);
            int b = zmienna.Next(10, 100);
            Console.WriteLine("Cześć, dodaj niżej skazane cyfry");

            Console.WriteLine(a);
            Console.WriteLine(b);   
            suma = Convert.ToInt32(Console.ReadLine());
            

            if (a+b==suma)
            {
                Console.WriteLine("Dodałeś poprawnie liczby");
            }
            else
            {
                wynik = a + b;
                Console.Write("Dodałeś błędnie liczby. Poprawny wynik to:" + wynik  );
            }
        }
    }
}
