using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class MyAbstractClass
    {
        public abstract void Method1();
        public abstract void Method2();

        protected void Method3(string value)
        {
            Console.WriteLine(value);
        }
    }

    class MyClassA : MyAbstractClass
    {
        public override void Method1()
        {
            base.Method3("Template method called from A");
        }
        public override void Method2()
        {
            base.Method3("Template method called from A");
        }
    }

    class MyClassB : MyAbstractClass
    {
        public override void Method1()
        {
            base.Method3("Template method called from B");
        }
        public override void Method2()
        {
            base.Method3("Template method called from B");
        }
    }

    class MyClassC : MyAbstractClass
    {
        public override void Method1()
        {
            base.Method3("Template method called from C");
        }
        public override void Method2()
        {
            base.Method3("Template method called from C");
        }
    }

    class TemplateMethodPattern
    {
        public TemplateMethodPattern()
        {
            Console.WriteLine("TemplateMethodPattern");

            var myclassA = new MyClassA();
            var myclassB = new MyClassB();
            var myclassC = new MyClassC();

            myclassA.Method1();
            myclassB.Method1();
            myclassC.Method1();

        }
    }
}
