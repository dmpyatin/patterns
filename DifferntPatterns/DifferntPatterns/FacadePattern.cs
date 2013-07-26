using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class MyClassOne
    {
        public void MethodOne()
        {
            Console.WriteLine("Method One");
        }
    }

    class MyClassTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }
    }

    class MyClassThree
    {
        public void MethodThree()
        {
            Console.WriteLine("Method Three");
        }
    }

    static class Facade
    {
        static MyClassOne classOne = new MyClassOne();
        static MyClassTwo classTwo = new MyClassTwo();
        static MyClassThree classThree = new MyClassThree();

        public static  void ComplexMethodOne()
        {
            classOne.MethodOne();
            classTwo.MethodTwo();
        }

        public static  void ComplexMethodTwo()
        {
            classOne.MethodOne();
            classThree.MethodThree();
        }
    }


    class FacadePattern
    {
        public FacadePattern()
        {
            Console.WriteLine("FacadePattern");
            Facade.ComplexMethodOne();
            Facade.ComplexMethodTwo();
        }
    }
}
