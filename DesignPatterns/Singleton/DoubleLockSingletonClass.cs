using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class DoubleLockSingletonClass
    {
        private static DoubleLockSingletonClass _instance;
        private static readonly object _lock = new object();


        private DoubleLockSingletonClass()   
        {

        }

        public static DoubleLockSingletonClass Instance()
        {
            if( _instance == null) // First check (no locking overhead if instance exists)
            {
                lock(_lock)    // Only one thread can enter this block at a time
                {
                    if(_instance == null) // Second check inside lock to see if it is still null right after it took lock
                    {
                         _instance = new DoubleLockSingletonClass();
                    }
                }
            }
            return _instance;
        }

    }
}