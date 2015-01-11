using Ninject;
using Package1;
using Package2;
using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ModuleBinding());

       
            ClassB b = new ClassB();
            b.Method1();
            b.Method2();
            b.Method3();

           

            ClassE e = new ClassE();
            e.Method2();
            e.Method5();

            ClassG g = new ClassG();
 

            ClassH h = new ClassH();
            h.SetG(kernel.Get<IInterfaceG>());
            h.Method2();

            ClassK k = new ClassK();
            k.Method1();

            ClassJ j = new ClassJ();
            j.SetK(k);        // cannot bind
            j.Method1();


            ClassM m = new ClassM();
            m.Method2();
            m.Method3();
            m.Method7();
            m.Method8();

            ClassN n = new ClassN();
            n.Method3();

 

            ClassP p = new ClassP();
            p.Method10();
            p.Method2();
            p.Method9();

            ClassL l = new ClassL(kernel.Get<IInterfaceP>());
            l.Method1();

            ClassQ q = new ClassQ();
            q.SetJ(j);      //cannot bind
            q.Method3();

            ClassR r = new ClassR();
            r.Method1();

            ClassS s = new ClassS();
            s.Method1();
            s.Method2();
            s.Method3();

 

            ClassU u = new ClassU();
            u.Mehthod1();

            ClassC c = new ClassC();
            ClassV v = new ClassV();
            v.SetC(kernel.Get<IInterfaceC>());
            v.Method2();

            ClassY y = new ClassY();
            y.Method2();

            ClassW w = new ClassW(kernel.Get <IInterfaceSomething>());
            w.Method2(kernel.Get<IInterfaceYP3>());
            w.Method3();

            ClassX x = new ClassX();
            x.SetR(kernel.Get<IInterfaceR>());
            x.Method1();


            ClassZ z = new ClassZ();
            z.SetJ(j);      //cannot bind
            z.SetQ(q);       //cannot bind
            z.Method2();
            ClassA a = new ClassA();
            a.SetS(kernel.Get<IInterfaceS>());
            a.SetY1(kernel.Get<IInterfaceYP1>());
            a.Method1();
            a.Method2(); // hello world
            a.Method3();


            ClassD d = new ClassD(a);
            d.Method1();

            ClassT t = new ClassT(kernel.Get<IInterfaceE>());
            t.SetX(x);         //cannot bind
            t.SetR(r);         //cannot bind
            t.Method2();

            ClassO o = new ClassO();
            o.SetT(t);           //cannot bind
            o.Method2();
        }
    }
}
