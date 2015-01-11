using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassD
    {
        private IInterfaceA _a;

        public ClassD(IInterfaceA a)
        {
            _a = a;
        }

        public void Method1()
        {
            _a.Method3();
        }
    }
}
