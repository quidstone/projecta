using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassZ
    {
        private IInterfaceJ _j;
        private IInterfaceQ _q;

        public void SetJ(IInterfaceJ j)
        {
            _j = j;
        }
        public void SetQ(IInterfaceQ q)
        {
            _q = q;
        }
        public void Method2()
        {
          
            _j.Method1();

            
            _q.Method3();
        }
    }
}
