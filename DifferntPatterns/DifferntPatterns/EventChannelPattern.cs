using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventChannel
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

        public void DoSomething(string data)
        {
            OnRaiseCustomEvent(new CustomEventArgs("Did something " + data));
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

    class PublishAgent
    {
        string data;
        Publisher publisher;

        public PublishAgent(Publisher pub)
        {
            publisher = pub;
        }

        public void Publish(string data)
        {
            publisher.DoSomething(data);
        }
    }

    class Subscriber
    {
        private List<string> Ids;
        private Publisher publisher;

        public void AddAgent(SubscribeAgent sa)
        {
            Ids.Add(sa.Id);
            publisher.RaiseCustomEvent += sa.HandleCustomEvent;
        }

        public Subscriber(Publisher pub)
        {
            Ids = new List<string>();
            publisher = pub;
        }
    }

    class SubscribeAgent
    {
        public string Id;

        public SubscribeAgent(string id, Subscriber sub)
        {
            Id = id;
            sub.AddAgent(this);
        }

        public void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(Id + " received this message: {0}", e.Message);
        }
    }

    class EventChannelPattern
    {
        public EventChannelPattern()
        {
            Console.WriteLine("EventChannelPattern");

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);

            PublishAgent pub1 = new PublishAgent(publisher);
            PublishAgent pub2 = new PublishAgent(publisher);
            PublishAgent pub3 = new PublishAgent(publisher);

            SubscribeAgent sub1 = new SubscribeAgent("sub one", subscriber);
            SubscribeAgent sub2 = new SubscribeAgent("sub two", subscriber);
            SubscribeAgent sub3 = new SubscribeAgent("sub three", subscriber);
           
            pub1.Publish("publish from pub1");
            pub2.Publish("publish from pub2");
            pub3.Publish("publish from pub3");
        }
    }
}
