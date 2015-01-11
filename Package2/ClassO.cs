using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassO
    {
       
        private IInterfaceT _t;

        public void SetT(IInterfaceT t)
        {
            _t = t;
            
        }
        public void Method2()
        {
            
            _t.Method2();
			
			// this is another test comment
        }
    }
}
