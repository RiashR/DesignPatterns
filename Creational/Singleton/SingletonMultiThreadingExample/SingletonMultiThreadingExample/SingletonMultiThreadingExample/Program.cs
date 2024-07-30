using SingletonMultiThreadingExample.Classes;

namespace SingletonMultiThreadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which Singleton implementation to run:");
            Console.WriteLine("1. SingletonWithLock");
            Console.WriteLine("2. SingletonWithLazy");
            Console.WriteLine("3. NonThreadSafeSingleton");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunSingletonWithLock();
                    break;
                case "2":
                    RunSingletonWithLazy();
                    break;
                case "3":
                    RunNonThreadSafeSingleton();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void RunSingletonWithLock()
        {
            Console.WriteLine("Running SingletonWithLock:");
            Parallel.For(0, 10, i =>
            {
                SingletonWithLock.Instance.DoWork();
            });
        }

        private static void RunSingletonWithLazy()
        {
            Console.WriteLine("Running SingletonWithLazy:");
            Parallel.For(0, 10, i =>
            {
                SingletonWithLazy.Instance.DoWork();
            });
        }

        private static void RunNonThreadSafeSingleton()
        {
            Console.WriteLine("Running NonThreadSafeSingleton:");
            Parallel.For(0, 10, i =>
            {
                NonThreadSafeSingleton.Instance.DoWork();
            });
        }
    }
}
