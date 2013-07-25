using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class AbstractProduct
    {
        public abstract void GetInfo();
    }

    class ProductOne : AbstractProduct
    {
        List<string> Body = new List<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductOne: " + Body.ToString());
        }
    }

    class ProductTwo : AbstractProduct
    {
        HashSet<string> Body = new HashSet<string>();
        public override void GetInfo()
        {
            Console.WriteLine("ProductTwo: " + Body.ToString());
        }
    }

    interface IAbstractFactory
    {
        AbstractProduct CreateProduct();
    }

    class FactoryOne : IAbstractFactory
    {
        public AbstractProduct CreateProduct()
        {
            return new ProductOne();
        }
    }

    class FactoryTwo : IAbstractFactory
    {
        public AbstractProduct CreateProduct()
        {
            return new ProductTwo();
        }
    }

    class Client
    {
        private AbstractProduct abstractProduct;

        public Client(IAbstractFactory factory)
        {
            abstractProduct = factory.CreateProduct();
        }

        public AbstractProduct GetProduct()
        {
            return abstractProduct;
        }
    }


    class FactoryMethodPattern
    {
        public FactoryMethodPattern()
        {
            Console.WriteLine("FactoryMethodPattern");

            var clientOne = new Client(new FactoryOne());
            var clientTwo = new Client(new FactoryTwo());

            var productOne = clientOne.GetProduct();
            var productTwo = clientTwo.GetProduct();

            productOne.GetInfo();
            productTwo.GetInfo();
        }
    }
}
