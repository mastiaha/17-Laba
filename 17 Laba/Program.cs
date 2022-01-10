using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            double balans = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            string fio = Console.ReadLine();
            Bank<int> vladelec1 = new Bank<int>(numInt, balans, fio);
            Console.WriteLine(vladelec1.GetInfo());

            Console.WriteLine("Введите строковый номер счета");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            balans = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            fio = Console.ReadLine();
            Bank<string> vladelec2 = new Bank<string>(numString, balans, fio);
            Console.WriteLine(vladelec2.GetInfo());
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");

            Console.ReadKey();
        }
    }
}
