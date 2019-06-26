using System;
namespace Singleton
{
    public class ThreadWithState
    {
        private int value;

        public ThreadWithState(int number)
        {
            value = number;
        }

        // The thread procedure performs the task, such as formatting
        // and printing a document.
        public void ThreadProc()
        {
            int numOfServers = 3;
            LoadBalancer balancerInThread = LoadBalancer.GetLoadBalancer();
            for (int j = 0; j < numOfServers; j++)
            {
                string serverId = (value * 10 + j).ToString("D2");
                string name = $"Server {serverId} in Thread {value}";
                Console.WriteLine(name);
                balancerInThread.AddServer(new Server() { Name = name });
            }
        }
    }
}
