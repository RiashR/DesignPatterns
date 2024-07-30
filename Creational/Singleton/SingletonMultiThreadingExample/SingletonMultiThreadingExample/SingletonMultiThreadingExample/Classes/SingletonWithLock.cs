using SingletonMultiThreadingExample.Interfaces;

namespace SingletonMultiThreadingExample.Classes
{
    /*
      Locks are a fundamental mechanism for ensuring that a piece of code can only be executed by one thread at a time.
      In the Singleton pattern, locks are used to make sure that only one thread can create the singleton instance
    */

    /// <summary>
    /// Thread-safe Singleton implementation using locks.
    /// </summary>
    public sealed class SingletonWithLock : ISingleton
    {
        private static SingletonWithLock _instance = null;
        private static readonly object _lock = new object();
        private static int _counter = 0;

        /// <summary>
        /// Private constructor to prevent instantiation from outside.
        /// </summary>
        private SingletonWithLock()
        {
            _counter++;
            Console.WriteLine($"SingletonWithLock instance created. Counter: {_counter}");
        }

        /// <summary>
        /// Gets the Singleton instance, ensuring thread-safety using locks.
        /// </summary>
        public static SingletonWithLock Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWithLock();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Perform some work and output the current thread ID.
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Doing some work on thread " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}