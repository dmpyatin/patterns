using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adaptee
    {
        public void GetInfo()
        {
            Console.WriteLine("Some info");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void GetInfo()
        {
            adaptee.GetInfo();
        }
    }

    class Target
    {
        public virtual void GetInfo() { }
    }

    class AdapterPattern
    {
        public AdapterPattern()
        {
            Console.WriteLine("AdapterPattern");

            Target t = new Adapter();

            t.GetInfo();
        }
    }
}
