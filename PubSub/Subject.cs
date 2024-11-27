using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    public class Subject<T>
    {
        private List<ObServer<T>> list = new List<ObServer<T>>();

        public Subscription<T> Subscribe(Action<T> action)
        {
            ObServer<T> obServer = new ObServer<T>(this, action);

            list.Add(obServer);

            return new Subscription<T>(obServer);

        }

        public void Notify(T message)
        {
            foreach (var item in list)
            {
                item.Next(message);
            }

        }
        public void RemoveObserve(ObServer<T> obServer)
        {
            this.list.Remove(obServer);
        }

    }
}
