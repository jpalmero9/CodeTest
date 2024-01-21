namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadSecond);
            t.Start();
            while (true)
            {
                //principal Thread
                Console.WriteLine("Th1");
            }
        }

        static void ThreadSecond()
        {
            while (true)
            {
                Console.WriteLine("Th2");
            }
        }
    }
}
