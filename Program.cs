using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6_2
{
    internal class Program
    {
        static bool dilennya (int numb1, int numb2)
        {

            if (numb1 % numb2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void dilennya ()
        {
            Console.WriteLine("Введіть числа, які ви хочете перевірити на ділення з остачею");
            int a = 0, b = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("Кратне");
            }
            else
            {
                Console.WriteLine("Не кратне");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть числа, які ви хочете перевірити на ділення з остачею");
                int a = 0, b = 0;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (dilennya(a, b) == true)
                {
                    Console.WriteLine("Кратне");
                }
                else
                {
                    Console.WriteLine("Не кратне");
                }

                dilennya();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
