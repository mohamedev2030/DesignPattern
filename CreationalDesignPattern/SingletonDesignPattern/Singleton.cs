using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    //Not Save Threading 
    //public sealed class Singleton
    //    {
    //        //This variable value will be increment by 1 each time the object of the class is created
    //        private static int Counter = 0;
    //        //This variable is going to store the Singleton Instance
    //        private static Singleton Instance = null;
    //        //The following Static Method is going to return the Singleton Instance
    //        public static Singleton GetInstance()
    //        {
    //            //If the variable instance is null, then create the Singleton instance 
    //            //else return the already created singleton instance
    //            //This version is not thread safe
    //            if (Instance == null)
    //            {
    //                Instance = new Singleton();
    //            }
    //            //Return the Singleton Instance
    //            return Instance;
    //        }
    //        //Constructor is Private means, from outside the class we cannot create an instance of this class
    //        private Singleton()
    //        {
    //            //Each Time the Constructor called, increment the Counter value by 1
    //            Counter++;
    //            Console.WriteLine("Counter Value " + Counter.ToString());
    //        }
    //        //The following can be accesed from outside of the class by using the Singleton Instance
    //        public void PrintDetails(string message)
    //        {
    //            Console.WriteLine(message);
    //        }
    //    }


    //Thread Save With Lock 
    //public sealed class Singleton
    //{
    //    //This variable value will be increment by 1 each time the object of the class is created
    //    private static int Counter = 0;
    //    //This variable is going to store the Singleton Instance
    //    private static Singleton Instance = null;
    //    //To use the lock, we need to create one variable
    //    private static readonly object Instancelock = new object();
    //    //The following Static Method is going to return the Singleton Instance
    //    public static Singleton GetInstance()
    //    {
    //        //This is thread-safe
    //        //As long as one thread locks the resource, no other thread can access the resource
    //        //As long as one thread enters into the Critical Section, 
    //        //no other threads are allowed to enter the critical section
    //        lock (Instancelock)
    //        { //Critical Section Start
    //            if (Instance == null)
    //            {
    //                Instance = new Singleton();
    //            }
    //        } //Critical Section End
    //        //Once the thread releases the lock, the other thread allows entering into the critical section
    //        //But only one thread is allowed to enter the critical section
    //        //Return the Singleton Instance
    //        return Instance;
    //    }

    //    private Singleton()
    //    {
    //        //Each Time the Constructor is called, increment the Counter value by 1
    //        Counter++;
    //        Console.WriteLine("Counter Value " + Counter.ToString());
    //    }
    //    //The following method can be accessed from outside of the class by using the Singleton Instance
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}


    //thread save with Double-Checked Locking
    //public sealed class Singleton
    //{
    //    //This variable value will be increment by 1 each time the object of the class is created
    //    private static int Counter = 0;
    //    //This variable is going to store the Singleton Instance
    //    private static Singleton Instance = null;
    //    //To use the lock, we need to create one variable
    //    private static readonly object Instancelock = new object();
    //    //The following Static Method is going to return the Singleton Instance
    //    public static Singleton GetInstance()
    //    {
    //        //This is thread-Safe
    //        if (Instance == null)
    //        {
    //            //As long as one thread locks the resource, no other thread can access the resource
    //            //As long as one thread enters into the Critical Section, 
    //            //no other threads are allowed to enter the critical section
    //            lock (Instancelock)
    //            { //Critical Section Start
    //                if (Instance == null)
    //                {
    //                    Instance = new Singleton();
    //                }
    //            } //Critical Section End
    //            //Once the thread releases the lock, the other thread allows entering into the critical section
    //            //But only one thread is allowed to enter the critical section
    //        }

    //        //Return the Singleton Instance
    //        return Instance;
    //    }

    //    private Singleton()
    //    {
    //        //Each Time the Constructor is called, increment the Counter value by 1
    //        Counter++;
    //        Console.WriteLine("Counter Value " + Counter.ToString());
    //    }
    //    //The following method can be accessed from outside of the class by using the Singleton Instance
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}



    //thread saving with Eager loading
    //public sealed class Singleton
    //{
    //    //This variable value will be increment by 1 each time the object of the class is created
    //    private static int Counter = 0;
    //    //This variable is going to store the Singleton Instance
    //    //Initiazling the Variable at the time of class start-up and make it ready to be used in Future
    //    private static readonly Singleton singleInstance = new Singleton();

    //    //The following Static Method is going to return the Singleton Instance
    //    //This is Thread-Safe as it use Eager Loading
    //    public static Singleton GetInstance()
    //    {
    //        //Now we don't need to use any NULL Checking code
    //        //We don't need to write Explicit code for thread-safety
    //        //Object initialization and Thread-Safety will be taken care by CLR as we are using Eager Loading
    //        //Return the Singleton Instance
    //        return singleInstance;
    //    }
    //    private Singleton()
    //    {
    //        //Each Time the Constructor is called, increment the Counter value by 1
    //        Counter++;
    //        Console.WriteLine("Counter Value " + Counter.ToString());
    //    }
    //    //The following method can be accessed from outside of the class by using the Singleton Instance
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}




    public sealed class Singleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        //This will make the Singleton Instance Lazy Loading
        //Lazy Object are Thread-Safe by default
        private static readonly Lazy<Singleton> SingleInstance = new Lazy<Singleton>(() => new Singleton());
        //The following Static Method is going to return the Singleton Instance
        //This is Thread-Safe as it uses Lazy<T> Object
        public static Singleton GetInstance()
        {
            //Now we don't need to use any NULL Checking code
            //We don't need to write Explicit code for thread-safety
            //Call the Value property of the Lazy object which will return the Singleton Instance
            return SingleInstance.Value;
        }
        private Singleton()
        {
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }


}
