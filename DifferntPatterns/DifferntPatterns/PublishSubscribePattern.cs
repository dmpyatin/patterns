using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Did something"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }

    class Subscriber
    {
        private string id;
        public Subscriber(string Id, Publisher pub)
        {
            id = Id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }


    class PublishSubscribePattern
    {
        public PublishSubscribePattern()
        {
            Console.WriteLine("PublishSubscribePattern");

            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub1", pub);
            Subscriber sub2 = new Subscriber("sub2", pub);

            pub.DoSomething();
        }
    }
}
