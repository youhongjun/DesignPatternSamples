using System;
using System.Linq;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class LazyLoadBalancer
    {
        private IList<Server> serverList = null;

        private static readonly Lazy<LazyLoadBalancer> lazy =
            new Lazy<LazyLoadBalancer>(() => new LazyLoadBalancer());

        public static LazyLoadBalancer Instance { get { return lazy.Value; } }

        private LazyLoadBalancer()
        {
            serverList = new List<Server>();
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
