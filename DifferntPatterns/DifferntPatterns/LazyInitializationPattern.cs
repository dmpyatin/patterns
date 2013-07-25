using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    class MyClass{
        public int property;
        public MyClass(int value)
        {
            property = value;
        }

        public void GetInfo()
        {
            Console.WriteLine("property value: " + property);
        }
    }

    

    class LazyInitializationPattern
    {
        public LazyInitializationPattern(){
            Console.WriteLine("LazyInitializationPattern");

            var list = new List<Lazy<MyClass>>();

            var MyObject = new MyClass(100500);

            for (int i = 0; i < 3; ++i)
            {
                list.Add(new Lazy<MyClass>(() => MyObject));
            }

            MyObject.property += 1;

            for (int i = 0; i < 3; ++i)
            {
                list[i].Value.GetInfo();
            }

        }
    }
}
