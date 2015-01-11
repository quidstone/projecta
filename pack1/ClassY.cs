using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;
using Package3;

namespace Package3
{
    public class ClassY : IInterfaceYP1, IInterfaceYP3
    {
        public int Method2()
        {
            return 5;
			// this is a comment
        }
    }
}
