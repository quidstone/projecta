using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package2;
using Package3;


namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterfaceSomething>().To<ClassM>();
            Bind<IInterfaceA>().To<ClassA>();
            Bind<IInterfaceE>().To<ClassE>();
            Bind<IInterfaceP>().To<ClassP>();
            Bind<IInterfaceR>().To<ClassR>();
            Bind<IInterfaceS>().To<ClassS>();
            Bind<IInterfaceT>().To<ClassT>();
            Bind<IInterfaceX>().To<ClassX>();
            Bind<IInterfaceYP1>().To<ClassY>();
            Bind<IInterfaceYP3>().To<ClassY>();
            Bind<IInterfaceC>().To<ClassC>();
            Bind<IInterfaceJ>().To<ClassJ>();
            Bind<IInterfaceK>().To<ClassK>();
            Bind<IInterfaceQ>().To<ClassQ>();
            Bind<IInterfaceG>().To<ClassG>();
        }
    }
}
