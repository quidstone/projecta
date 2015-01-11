using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassX : IInterfaceX
    {
        public IInterfaceR _r;
        public void SetR(IInterfaceR r)
        {
            _r = r;
        } 
        public void Method1()
        {
            
            _r.Method1();
        }
    }
}
