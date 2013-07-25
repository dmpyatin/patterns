using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;
using AbstractFactory;
using Builder;
using LazyInitialization;
using Prototype;
using RAII;
using Singleton;
using Delegation;

namespace DifferntPatterns
{

    class MainProgramm
    {
        static void Main(string[] args)
        {
            var abstractFactoryPattern = new AbstractFactoryPattern();
            var factoryMethodPattern = new FactoryMethodPattern();
            var builderPattern = new BuilderPattern();
            var lazyInitializationPattern = new LazyInitializationPattern();
            var prototypePattern = new PrototypePattern();
            var rAIIPattern = new RAIIPattern();
            var singletonPattern = new SingletonPattern();
            var delegationPattern = new DelegationPattern();
        }
    }
}

