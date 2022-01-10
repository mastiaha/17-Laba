using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Laba
{
    class Bank<T>
    {
        private T Num { get; set; }
        private double Balans { get; set; }
        private string Fio { get; set; }

        internal Bank(T num, double balans, string fio)
        {
            Num = num;
            Balans = balans;
            Fio = fio;
        }

        internal string GetInfo()
        {
            return $"{Num} {Balans} {Fio}";
        }
    }
}
