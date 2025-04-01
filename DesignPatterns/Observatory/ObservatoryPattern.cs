using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Observatory
{
    public class Publisher
    {
        List<INotify> list = new List<INotify>();

        public void SendNotification(string broadcastMessage)
        {
            foreach (INotify subscriber in list)
            {
                subscriber.InvokeNotification(broadcastMessage);
            }
        }

        public void AddSubscriber(INotify subscriber)
        {
            list.Add(subscriber);
        }

        public void RemoveSubscriber(INotify subscriber)
        {
            list.Remove(subscriber);
        }
    }


// Notification Interface
    public interface INotify
    {
        void InvokeNotification(string notification);
    }



//Implement Interface
    public class Subscriber : INotify
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void InvokeNotification(string notification)
        {
             Console.WriteLine( "Hi " + _name + "  -" + notification);
        }
    }





}