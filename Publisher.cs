using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void SignUp(string sub);

namespace DelegateProject
{
    class Publisher
    {
        fmMain fmMain;

        SignUp subscriberList;

        public Publisher(fmMain fm)
        {
            fmMain = fm;
        }

        public void Subscribe(SignUp sp)
        {
            subscriberList += sp;

            fmMain.DisplaySub("Subcribed : " + sp.Method.Name);
        }

        public void Unsubscribe(SignUp sp)
        {
            subscriberList -= sp;
            fmMain.DisplaySub("Unsubcribed : " + sp.Method.Name);
        }

        public void Spread()
        {
            if (subscriberList == null) return;

            subscriberList(" Publisher Alert.");
        }
    }
}
