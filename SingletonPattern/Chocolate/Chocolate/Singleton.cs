using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    public class Singleton
    {
        private volatile static Singleton uniqueInstance;
        private static object syncRoot = new Object();
        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if(uniqueInstance == null)
            {
                lock(syncRoot)
                {
                    uniqueInstance = new Singleton();
                }
            }
            return uniqueInstance;
        }
    }
}