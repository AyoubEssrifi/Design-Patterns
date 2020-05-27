using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string productName;
        private int productPrice;
        private string availability;

        public string ProductName { get; set; }
        public string ProductPrice { get; set; }

        public string Availability
        {
            get 
            {
                return availability;
            }

            set
            {
                Console.WriteLine("Availability changed !!");
                availability = value;
                Notify();
            }
        }
        public Subject(string productName, int productPrice, string availability)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.availability = availability;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(availability);
            }
        }
    }
}
