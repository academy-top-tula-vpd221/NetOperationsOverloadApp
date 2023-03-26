using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperationsOverloadApp
{
    internal class Money
    {
        public int Rub { set; get; }
        public int Cop { set; get; }
        public Money(int rub = 0, int cop = 0)
        {
            Rub = rub;
            Cop = cop;
        }

        public static Money operator%(Money m, int procent)
        {
            int cops = m.Rub * 100 + m.Cop;
            int proc = procent * cops / 100;
            return new Money()
            {
                Rub = proc / 100,
                Cop = proc % 100
            };
        }
    }
}
