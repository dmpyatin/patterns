using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class MyClass
    {
        public int property;

        public MyClass(int value)
        {
            property = value;
        }

        public void GetInfo()
        {
            Console.WriteLine("property value: " + property); 
        }

        public MyClass Clone(){
            return (MyClass)this.MemberwiseClone(); ;
        }

    }

    class PrototypePattern
    {
        

        public PrototypePattern()
        {
            Console.WriteLine("PrototypePattern");

            var ObjectOne = new MyClass(100500);
            var ObjectTwo = ObjectOne.Clone();

            ObjectOne.property += 1;

            ObjectOne.GetInfo();
            ObjectTwo.GetInfo();

        }
    }
}
