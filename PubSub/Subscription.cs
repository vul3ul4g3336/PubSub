using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    public class Subscription<T>
    {
        ObServer<T> obServer = null;

        public Subscription(ObServer<T> obServer)
        {
            this.obServer = obServer;
        }
        public void Unsubscribe()
        {
            obServer.Complete();
        }


    }
}
