using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA : IInterfaceA
    {
        private IInterfaceS _s;
        private IInterfaceYP1 _y;

        public void SetS( IInterfaceS s)
        {
            _s = s;
        }
        public void SetY1( IInterfaceYP1 y)
        {
            _y = y;
        }
        public void Method1()
        {

        }

        public void Method2()
        {
            
            _s.Method3();
            _s.Method1();
        }

        public void Method3()
        {
            
            _y.Method2();
        }
    }
}
