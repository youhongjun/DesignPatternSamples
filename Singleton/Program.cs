using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TryLoadBalancer();

            TryLazyLoadBalancer();

            Console.ReadKey();
        }

        static void TryLoadBalancer()
        {
            int numOfThreads = 2;
            WaitHandle[] waitHandles = new WaitHandle[numOfThreads];

            for (int i = 0; i < numOfThreads; i++)
            {
                ThreadWithState tws = new ThreadWithState(i);
                Thread t = new Thread(new ThreadStart(tws.ThreadProc));
                t.Start();
                t.Join();
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 10; i++)
            {
                Server server = balancer.GetServer();
                Console.WriteLine("Request assigns to " + server.Name);
            }
        }

        static void TryLazyLoadBalancer()
        {
            LazyLoadBalancer balancer, balancer2, balancer3;
            balancer = LazyLoadBalancer.Instance;
            balancer2 = LazyLoadBalancer.Instance;
            balancer3 = LazyLoadBalancer.Instance;

            if (balancer == balancer2 && balancer == balancer3 && balancer2 == balancer3)
            {
                Console.WriteLine("Same lazy load balancers!");
            }

            balancer.AddServer(new Server() { Name = "Server 1" });
            balancer.AddServer(new Server() { Name = "Server 2" });
            balancer.AddServer(new Server() { Name = "Server 3" });
            balancer.AddServer(new Server() { Name = "Server 4" });

            for (int i = 0; i < 10; i++)
            {
                Server server = balancer.GetServer();
                Console.WriteLine("Request assigns to " + server.Name);
            }
        }
    }
}
