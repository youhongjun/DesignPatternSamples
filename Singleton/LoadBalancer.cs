using System;
using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    public class LoadBalancer
    {
        private IList<Server> serverList = null;

        private LoadBalancer()
        {
            serverList = new List<Server>();
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return InternalClass.instance;
        }

        class InternalClass
        {
            static InternalClass() { }
            internal static readonly LoadBalancer instance = new LoadBalancer();
        }

        public void AddServer(Server server)
        {
            var s = serverList.Where(ss => ss.Name == server.Name).FirstOrDefault();
            if (s == null)
                serverList.Add(server);
            else
                throw new Exception("Server exists!");
        }

        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
            {
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
            }
        }

        private Random rand = new Random();
        public Server GetServer()
        {
            if (serverList.Count > 0)
            {
                int index = rand.Next(serverList.Count);
                return serverList[index];
            }
            else
            {
                return null;
            }
        }
    }
}
