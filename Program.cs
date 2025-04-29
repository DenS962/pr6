using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09999
{
    internal class Program
    {
        static void tabl (int numb)
        {
            int b = 1;
            if (numb < 0)
            {
                Console.WriteLine("Треба додатні цілі числа");
                return;
            }
            if(numb ==0)
            {
                for (numb=1; numb <= 9; numb++)
                {
                    for (b=1; b <= 9; b++) 
                    {
                        Console.WriteLine($"{numb} *{b} = {numb * b}");
                    }
                }
            }
            for(;b<=9; b++)
            Console.WriteLine($"{numb} *{b} = {numb *b}");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть яку табличку множення ви хочете вивести");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Таблиця множення на {t}");
                tabl(t);
            }
            catch(Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
