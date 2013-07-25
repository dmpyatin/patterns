using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Цель: отделяет конструирование объекта от его представления
    class Product
    {
        public string FirstPart;
        public string SecondPart;

        public void GetBody()
        {
            Console.WriteLine(FirstPart + " ::: " + SecondPart);
        }
    }

    abstract class Builder
    {
        public virtual void FirstBuild() { }
        public virtual void SecondBuild(){ }
    }

    class BuilderOne : Builder
    {
        private readonly Product product = new Product();

        public override void FirstBuild()
        {
            product.FirstPart = "First part by Builder One";
            
        }

        public override void SecondBuild()
        {
            product.SecondPart = "Second part by Builder One";
        }

        public Product GetProduct()
        {
            return product;
        }

    }


    class BuilderTwo : Builder
    {
        private Product product = new Product();

        public override void FirstBuild()
        {
            product.FirstPart = "First part by Builder Two";

        }

        public override void SecondBuild()
        {
            product.SecondPart = "Second part by Builder Two";
        }

        public Product GetProduct()
        {
            return product;
        }

    }

    //Алгоритм создания объекта Product
    class Director
    {
        public void Create(Builder builder)
        {
            builder.FirstBuild();
            builder.SecondBuild();
        }
    }

    class BuilderPattern
    {
        public BuilderPattern()
        {
            Console.WriteLine("BuilderPattern");

            var director = new Director();

            var builderOne = new BuilderOne();
            var builderTwo = new BuilderTwo();

            director.Create(builderOne);
            director.Create(builderTwo);
          
            var product1 = builderOne.GetProduct();
            var product2 = builderTwo.GetProduct();

            product1.GetBody();
            product2.GetBody();

        }
    }
}
