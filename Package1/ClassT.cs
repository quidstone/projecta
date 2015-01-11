using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassT : IInterfaceT
    {
        private IInterfaceE _ie;
        private IInterfaceR _r;
        private IInterfaceX _x;

        public ClassT(IInterfaceE ie)
        {
            _ie = ie;
        }
        public void SetR(IInterfaceR r)
        { 
            _r = r;
        }
        public void SetX(IInterfaceX x)
        {
            _x = x;
        }

        public void Method2()
        {
            _x.SetR(_r);
            _x.Method1();

            _ie.Method5();
        }
    }
}
