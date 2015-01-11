using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassV
    {
        private IInterfaceC _c;
        public void SetC(IInterfaceC c)
        {
            _c = c;
        }
        public void Method2()
        {
           
            _c.Method1();
        }
    }
}
