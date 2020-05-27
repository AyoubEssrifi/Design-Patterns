using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        private string user;
        public Observer(string username, ISubject subject)
        {
            this.user = username;
            subject.AddObserver(this);
        }
        public void Update(string availability)
        {
            Console.WriteLine("Hello " + user + " the product is now " + availability);
        }
    }
}
