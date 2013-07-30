using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IMyClass
    {
        void Send(string message);
        void Notify(string message);
    }

    class MyClassA : IMyClass
    {
        protected IMediator Mediator;

        public MyClassA(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }

    class MyClassB : IMyClass
    {
        protected IMediator Mediator;

        public MyClassB(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }


    interface IMediator
    {
        void Send(string message, IMyClass myclass);
    }

    class Mediator : IMediator
    {
        private MyClassA classA;
        private MyClassB classB;

        public MyClassA ClassA
        {
            set { classA = value; }
        }

        public MyClassB ClassB
        {
            set { classB = value; }
        }

        public void Send(string message, IMyClass myclass)
        {
            if (classA == myclass)
            {
                classA.Notify(message);
            }
            else
            {
                classB.Notify(message);
            }
        }
    }


    class MediatorPattern
    {
        public MediatorPattern()
        {
            Console.WriteLine("MediatorPattern");

            var mediator = new Mediator();

            var classA = new MyClassA(mediator);

            var classB = new MyClassB(mediator);

            mediator.ClassA = classA;
            mediator.ClassB = classB;

            classA.Send("Message from A");
            classB.Send("Message from B");
        }
    }
}
