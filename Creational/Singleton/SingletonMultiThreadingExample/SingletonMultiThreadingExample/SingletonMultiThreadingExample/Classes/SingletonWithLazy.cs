using SingletonMultiThreadingExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMultiThreadingExample.Classes
{

    /* 
     Lazy<T> is a type provided by .NET that ensures thread-safe lazy initialization. 
     It internally handles the locking and ensures that the instance is created only when it's accessed for the first time.
    */


    /// <summary>
    /// Thread-safe Singleton implementation using Lazy<T>.
    /// </summary>
    public sealed class SingletonWithLazy : ISingleton
    {
        private static readonly Lazy<SingletonWithLazy> _instance = new Lazy<SingletonWithLazy>(() => new SingletonWithLazy());
        private static int _counter = 0;

        /// <summary>
        /// Private constructor to prevent instantiation from outside.
        /// </summary>
        private SingletonWithLazy()
        {
            _counter++;
            Console.WriteLine($"SingletonWithLazy instance created. Counter: {_counter}");
        }

        /// <summary>
        /// Gets the Singleton instance, ensuring thread-safety using Lazy<T>.
        /// </summary>
        public static SingletonWithLazy Instance => _instance.Value;

        /// <summary>
        /// Perform some work and output the current thread ID.
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Doing some work on thread " + Thread.CurrentThread.ManagedThreadId);
        }
    }

}
