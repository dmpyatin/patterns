using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAII
{
    class MyClass : IDisposable
    {

        public MyClass()
        {
            Console.WriteLine("MyClass was created");
        }

        //Для внутренних ресурсов (можно не использовать т. к. есть сборщик мусора
        ~MyClass()
        {
            Console.WriteLine("MyClass was destroyed");
        }

        //Для внешних ресурсов
        public void Dispose()
        {

        }
    }

    class RAIIPattern
    {
        public RAIIPattern()
        {
            Console.WriteLine("RAIIPattern");

            var MyObject = new MyClass();

        }
    }
}
