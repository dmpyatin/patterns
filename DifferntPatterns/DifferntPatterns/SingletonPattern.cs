using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    //версия 1
    /*public sealed class SingletonOne
    {
        private static volatile SingletonOne instance;
        private static object sycRoot = new Object();

        private SingletonOne() { }

        private static SingletonOne Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonOne();
                    }
                }

                return instance;
            }

            
        }

    }*/

    //версия 2
    public sealed class SingletonTwo
    {
        private static readonly SingletonTwo instance = new SingletonTwo();

        static SingletonTwo(){

        }

        private SingletonTwo(){

        }

        public static SingletonTwo Instance
        {
            get {

                return instance;
            }

        }
    }

    //Версия 3

    public sealed class SingletonThree
    {
        private static readonly Lazy<SingletonThree> lazy = new Lazy<SingletonThree>(() => new SingletonThree());

        public static SingletonThree Instance { get { return lazy.Value; } }

        private SingletonThree()
        {
        }
    }
   


    class SingletonPattern
    {
        public SingletonPattern()
        {
            Console.WriteLine("SingletonPattern");

            SingletonTwo s1 = SingletonTwo.Instance;
            SingletonTwo s2 = SingletonTwo.Instance;
            if (Object.ReferenceEquals(s1, s2))
                Console.WriteLine("s1 and s2 refer to same object");
          
        }
    }
}
