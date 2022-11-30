using System;
using System.Threading;
namespace MultithreadingApplication{
    class ThreadAbort{
        public static void CallToChildThread(){
            try{
                Console.WriteLine("Child thread starts.");
                for(int counter=0;counter<=10;counter++){
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thread Completed.");
            }catch(ThreadAbortException e){
                Console.WriteLine("Thread Abort Exception");
            }
            finally{
                Console.WriteLine("Could not catch the Thread Exception");
            }

            }
            static void Main(string[] args){
                ThreadStart childref=new ThreadStart(CallToChildThread);
                Console.WriteLine("Main:Creating the Child Thread.");
                Thread childThread = new Thread(childref);
                childThread.Start();
                Thread.Sleep(2000);
                Console.WriteLine("Main:Aborting the Child Thread.");
                childThread.Abort();
                Console.ReadKey();
            }
        }
    }

