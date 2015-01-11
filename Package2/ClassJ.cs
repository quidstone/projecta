using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassJ : IInterfaceJ
    {
        private IInterfaceK _k;
        public void SetK(IInterfaceK k)
        {
            _k = k; 
        }
        public void Method1()
        {
            
            _k.Method1();
        }
    }
}
