using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassQ : IInterfaceQ
    {
        private IInterfaceJ _j;
        public void SetJ(IInterfaceJ j)
        {
            _j = j;
        }
        public void Method3()
        {
            
            _j.Method1();
        }
    }
}
