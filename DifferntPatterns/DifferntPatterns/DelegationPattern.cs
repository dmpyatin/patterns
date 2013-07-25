using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    interface IClass
    {
        void GetInfo();
    }

    class MyClassA : IClass
    {
        public void GetInfo()
        {
            Console.WriteLine("This is class A");
        }
    }

    class MyClassB : IClass
    {
        public void GetInfo()
        {
            Console.WriteLine("This is class B");
        }
    }

    class MyClassC : IClass
    {
        IClass delegatedClass;

        public MyClassC(IClass delegated)
        {
            delegatedClass = delegated;
        }

        public void ChangeDelegate(IClass delegated)
        {
            delegatedClass = delegated;
        }

        public void GetInfo()
        {
            delegatedClass.GetInfo();
        }

    }

    class DelegationPattern
    {
        public DelegationPattern()
        {
            Console.WriteLine("DelegationPattern");

            var C = new MyClassC(new MyClassA());

            C.GetInfo();

            C.ChangeDelegate(new MyClassB());

            C.GetInfo();

        }
    }
}
