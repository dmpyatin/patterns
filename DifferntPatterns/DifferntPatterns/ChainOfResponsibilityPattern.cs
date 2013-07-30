using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void ProcessRequest(Request request);
    }

    class HandlerA : IHandler
    {
        private IHandler nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            nextHandler = handler;
        }

        public void ProcessRequest(Request request)
        {
            if (request.Status == 1 || nextHandler == null)
                Console.WriteLine("Request has been processed by handler A");
            else
                nextHandler.ProcessRequest(request);
        }
    }

    class HandlerB : IHandler
    {
        private IHandler nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            nextHandler = handler;
        }

        public void ProcessRequest(Request request)
        {
            if (request.Status == 2 || nextHandler == null)
                Console.WriteLine("Request has been processed by handler B");
            else
                nextHandler.ProcessRequest(request);
        }
    }

    class HandlerC : IHandler
    {
        private IHandler nextHandler;

        public void SetNextHandler(IHandler handler)
        {
            nextHandler = handler;
        }

        public void ProcessRequest(Request request)
        {
            if (request.Status == 3 || nextHandler == null)
                Console.WriteLine("Request has been processed by handler C");
            else
                nextHandler.ProcessRequest(request);
        }
    }

  
    class Request
    {
        public int Status;

        public Request(int status)
        {
            Status = status;
        }
    }


    class ChainOfResponsibilityPattern
    {
        public ChainOfResponsibilityPattern()
        {
            Console.WriteLine("ChainOfResponsibilityPattern");

            var handlerA = new HandlerA();
            var handlerB = new HandlerB();
            var handlerC = new HandlerC();

            handlerA.SetNextHandler(handlerB);
            handlerB.SetNextHandler(handlerC);

            var request1 = new Request(1);
            var request2 = new Request(2);
            var request3 = new Request(3);
            var request4 = new Request(4);
            var request5 = new Request(5);

            handlerA.ProcessRequest(request1);
            handlerA.ProcessRequest(request2);
            handlerA.ProcessRequest(request3);
            handlerA.ProcessRequest(request4);
            handlerA.ProcessRequest(request5);

        }
    }
}
