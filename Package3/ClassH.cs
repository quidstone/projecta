using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassH
    {
        private IInterfaceG _g;
        public void SetG(IInterfaceG g)
        {
            _g = g;
        }
        public void Method2()
        {
            
            _g.Method1();
        }
    }
}
