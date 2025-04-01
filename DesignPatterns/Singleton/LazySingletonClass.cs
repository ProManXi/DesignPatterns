using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class LazySingletonClass
    {
        //Lazy<T> handles locking internally, so we don’t need to write lock manually.
        //Use Lazy<T> for an automatic thread-safe Singleton instead of manual locking.

        //Lazy<T> - What is it?
        //Lazy<T> delays the creation of an object until it's actually needed.
        //It ensures thread-safety internally, so we don’t have to write lock manually.

       private static readonly Lazy<LazySingletonClass> instance = new Lazy<LazySingletonClass>(() => new LazySingletonClass());

       private LazySingletonClass()
       {

       }

        public static LazySingletonClass Instance()
        {
            return instance.Value;
        }


    }
}