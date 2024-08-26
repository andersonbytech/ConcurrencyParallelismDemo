using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace ConcurrencyParallelismDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int taskCount = 10;

            Console.WriteLine("Not Concurrent, Not Parallel:");
            NotConcurrentNotParallel(taskCount);

            Console.WriteLine("\nConcurrent (Asynchronous):");
            await ConcurrentNotParallel(taskCount);

            Console.WriteLine("\nParallel (Threads):");
            NotConcurrentParallel(taskCount);

        }
        static void NotConcurrentNotParallel(int taskCount)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < taskCount; i++)
            {
                SimulateTask(i+1);
            }

            sw.Stop();

            Console.WriteLine($"Tempo Total: {sw.ElapsedMilliseconds} ms");
        }

        static async Task ConcurrentNotParallel(int taskCount)
        {
            var sw = Stopwatch.StartNew();

            var tasks = new Task[taskCount];
            for (int i = 0; i < taskCount; i++)
            {
                tasks[i] = SimulateTaskAsync(i + 1);
            }

            await Task.WhenAll(tasks);

            sw.Stop();
            Console.WriteLine($"Tempo Total: {sw.ElapsedMilliseconds} ms");
        }

        static void NotConcurrentParallel(int taskCount)
        {
            var sw = Stopwatch.StartNew();

            var threads = new Thread[taskCount];
            for (int i = 0; i < taskCount; i++)
            {
                int taskNumber = i + 1;
                threads[i] = new Thread(() => SimulateTask(taskNumber));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            sw.Stop();
            Console.WriteLine($"Tempo Total: {sw.ElapsedMilliseconds} ms");
        }

        static void SimulateTask(int taskNumber)
        {
            Console.WriteLine($"Task {taskNumber} iniciada.");
            Thread.Sleep(2000);
            Console.WriteLine($"Task {taskNumber} concluída.");
        }
        static async Task SimulateTaskAsync(int taskNumber)
        {
            Console.WriteLine($"Task {taskNumber} iniciada.");
            await Task.Delay(2000);  
            Console.WriteLine($"Task {taskNumber} concluída.");
        }
    }
}
