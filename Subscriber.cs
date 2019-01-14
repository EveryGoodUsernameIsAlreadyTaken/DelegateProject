using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    class Subscriber
    {
        fmMain fmMain;

        public Subscriber(fmMain fm)
        {
            fmMain = fm;
        }

        public void Subscriber1(string szMsg)
        {
            fmMain.DisplaySpread("Subscriber1: " + szMsg);
        }

        public void Subscriber2(string szMsg)
        {
            fmMain.DisplaySpread("Subscriber2: " + szMsg);
        }
    }
}
