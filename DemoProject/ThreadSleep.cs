using System;
using System.Threading;
namespace MultithreadingApplication{
    class ThreadSleep{
        public static void CallToChildThread(){
            Console.WriteLine("Child Thread Starts");
            int sleepfor=4000;
            Console.WriteLine("Child Thread Paused for {0} seconds.",sleepfor/1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }
        static void Main(string[] args){
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Main:Creating the Child Thread");

            Thread childThread=new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}