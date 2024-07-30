using SingletonMultiThreadingExample.Interfaces;

namespace SingletonMultiThreadingExample.Classes
{
    /// <summary>
    /// Non-thread-safe Singleton implementation.
    /// </summary>
    public sealed class NonThreadSafeSingleton : ISingleton
    {
        private static NonThreadSafeSingleton _instance = null;
        private static int _counter = 0;

        /// <summary>
        /// Private constructor to prevent instantiation from outside.
        /// </summary>
        private NonThreadSafeSingleton()
        {
            _counter++;
            Console.WriteLine($"NonThreadSafeSingleton instance created. Counter: {_counter}");
        }

        /// <summary>
        /// Gets the Singleton instance without ensuring thread-safety.
        /// </summary>
        public static NonThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NonThreadSafeSingleton();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Do some work and output the current thread ID.
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Doing some work on thread " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
