using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassW
    {
        private IInterfaceSomething _something;
        private IInterfaceYP3 _y;

        public ClassW(IInterfaceSomething something)
        {
            _something = something;
        }


        public int Method2(IInterfaceYP3 y)
        {
            _y = y;
            return _y.Method2();
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }
    }
}
