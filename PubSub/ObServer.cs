using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    public class ObServer<T>
    {
        Action<T> action;
        Subject<T> subject;
        public ObServer(Subject<T> subject, Action<T> action)
        {
            this.subject = subject;
            this.action = action;
        }

        public void Complete()
        {
            subject.RemoveObserve(this);
        }

        public void Next(T t)
        {
            action.Invoke(t);
        }





    }
}
