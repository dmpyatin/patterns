using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Strategy
{
    interface IStrategy
    {
        string Method();
    }

    class StrategyA : IStrategy
    {
        public string Method()
        {
            return "Method for A";
        }
    }

    class StrategyB : IStrategy
    {
        public string Method()
        {
            return "Method for B";
        }
    }


    class User
    {
        private IStrategy strategy;

        public User(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SomeMethod()
        {
            Console.WriteLine(this.strategy.Method());
        }
    }



    class StrategyPattern
    {
        public StrategyPattern()
        {
            Console.WriteLine("StrategyPattern");
            var userA = new User(new StrategyA());

            userA.SomeMethod();

            userA.ChangeStrategy(new StrategyB());

            userA.SomeMethod();

        }
    }
}
