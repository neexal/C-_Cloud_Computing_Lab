﻿using System;
using System.Threading;
namespace MultithreadingApplication{
    public class Program{
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts.");
        }


    public static void Main(string[] args){
        ThreadStart childrenf=new ThreadStart(CallToChildThread);
        Console.WriteLine("Main creating the child thread.");
        Thread childThread=new Thread(childrenf);
        childThread.Start();
        Console.ReadKey();
        
    }
    }
}