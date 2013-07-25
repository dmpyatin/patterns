using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractProductOne{
        public abstract void GetInfo();
    }


    abstract class AbstractProductTwo
    {
        public abstract void GetInfo();
    }


    class ProductOneOne : AbstractProductOne
    {
        List<string> Body = new List<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductOneOne: " + Body.ToString());
        }
    }

    class ProductTwoOne : AbstractProductTwo
    {
        HashSet<string> Body = new HashSet<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductTwoOne: " + Body.ToString());
        }
    }

    class ProductOneTwo : AbstractProductOne
    {
        List<string> Body = new List<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductOneTwo: " + Body.ToString());
        }
    }

    class ProductTwoTwo : AbstractProductTwo
    {
        HashSet<string> Body = new HashSet<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductTwoTwo: " + Body.ToString());
        }
    }

    interface IAbstractFactory
    {
       AbstractProductOne CreateProductOne();
       AbstractProductTwo CreateProductTwo();
    }

    class FactoryOne : IAbstractFactory
    {
        public AbstractProductOne CreateProductOne()
        {
            return new ProductOneOne();
        }

        public AbstractProductTwo CreateProductTwo()
        {
            return new ProductTwoOne();
        }
    }

    class FactoryTwo : IAbstractFactory
    {
        public AbstractProductOne CreateProductOne()
        {
            return new ProductOneTwo();
        }

        public AbstractProductTwo CreateProductTwo()
        {
            return new ProductTwoTwo();
        }
    }

    class Client
    {
        private AbstractProductOne abstractProductOne;
        private AbstractProductTwo abstractProductTwo;

        public Client(IAbstractFactory factory)
        {
            abstractProductOne = factory.CreateProductOne();
            abstractProductTwo = factory.CreateProductTwo();
        }

        public AbstractProductOne GetProductOne()
        {
            return abstractProductOne;
        }

        public AbstractProductTwo GetProductTwo()
        {
            return abstractProductTwo;
        }
    }


    class AbstractFactoryPattern
    {
        public AbstractFactoryPattern()
        {
            Console.WriteLine("AbstractFactoryPattern");

            var clientOne = new Client(new FactoryOne());
            var clientTwo = new Client(new FactoryTwo());

            var productOneOne = clientOne.GetProductOne();
            var productOneTwo = clientOne.GetProductTwo();

            productOneOne.GetInfo();
            productOneTwo.GetInfo();

            var productTwoOne = clientTwo.GetProductOne();
            var productTwoTwo = clientTwo.GetProductTwo();

            productOneOne.GetInfo();
            productOneTwo.GetInfo();

        }
    }
}
