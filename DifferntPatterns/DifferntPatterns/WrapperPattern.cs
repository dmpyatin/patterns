using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper
{
    interface IMyClass
    {
        void GetInfo();
    }

    class MyClass : IMyClass
    {
        public void GetInfo()
        {
            Console.WriteLine("MyClass Info");
        }
    }

    class WrapperOne : IMyClass
    {
        protected IMyClass myClass;

        public WrapperOne(IMyClass myclass)
        {
            myClass = myclass;
        }

        public void GetInfo()
        {
            if (myClass != null)
            {
                myClass.GetInfo();
                Console.WriteLine("Wrapped MyClass info by Wrapper One");
            }
        }
    }

    class WrapperTwo : IMyClass
    {
        protected IMyClass myClass;

        public WrapperTwo(IMyClass myclass)
        {
            myClass = myclass;
        }

        public void GetInfo()
        {
            if (myClass != null)
            {
                myClass.GetInfo();
                Console.WriteLine("Wrapped MyClass info by Wrapper Two");
            }
        }
    }

    class WrapperThree : IMyClass
    {
        protected IMyClass myClass;

        public WrapperThree(IMyClass myclass)
        {
            myClass = myclass;
        }

        public void GetInfo()
        {
            if (myClass != null)
            {
                myClass.GetInfo();
                Console.WriteLine("Wrapped MyClass info by Wrapper Three");
            }
        }
    }


    class WrapperPattern
    {
        public WrapperPattern()
        {
            Console.WriteLine("WrapperPattern");

            var MyObject = new MyClass();
            var MyWrapperObject = new WrapperThree(new WrapperTwo(new WrapperOne(MyObject)));

            MyWrapperObject.GetInfo();
        }
    }
}
