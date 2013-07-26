using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IMyClass
    {
        void MyMethodOne();
        void MyMethodTwo();
    }

    class MyClass : IMyClass
    {
        public void MyMethodOne()
        {
            Console.WriteLine("My Method One");
        }

        public void MyMethodTwo()
        {
            Console.WriteLine("My Method Two");
        }
    }

    class ProxyMyClass : IMyClass
    {
        public MyClass myclass;

        public ProxyMyClass()
        {
            myclass = null;
        }

        public void MyMethodOne()
        {
            Console.WriteLine("My Method Proxy");
        }

        public void MyMethodTwo()
        {
            if (myclass == null)
                myclass = new MyClass();
            myclass.MyMethodTwo();
        }


    }

    class ProxyPattern
    {
        public ProxyPattern()
        {
            Console.WriteLine("ProxyPattern");
            var t = new ProxyMyClass();
            t.MyMethodOne();
            t.MyMethodTwo();
        }
    }
}
