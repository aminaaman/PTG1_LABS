using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
	class Worker
	{
		bool isActive = true;

		public void work()
		{
			int i = 0;
			while (isActive)
			{
				Console.WriteLine(i++);
			}
		}
		public void stop()
		{
			isActive = false;
		}
	}

	class MainClass
	{
		public static void func()
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("thread #2" + i);
				Thread.Sleep(0);
			}
			Console.ReadKey();
		}

		public static void F2()
		{
			Worker w = new Worker();
			Thread t = new Thread(w.work);
			t.Start();
			Thread.Sleep(1000);
			w.stop();
			Console.ReadKey();
		}

		public class MyThread
		{
			public void func()
			{
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine(Thread.CurrentThread.Name + " " + i);
				}
			}
			public MyThread(string threadname)
			{
				Thread thread = new Thread(this.func);
				thread.Name = threadname;
				thread.Start();
			}
		}

		public static void Main(string[] args)
		{
			//MyThread[] threads = new MyThread[5];
			MyThread thread1 = new MyThread("Thread 1");
			MyThread thread2 = new MyThread("Thread 2");
			MyThread thread3 = new MyThread("Thread 3");
			MyThread thread4= new MyThread("Thread 4");
			MyThread thread5 = new MyThread("Thread 5");

		}
	}
}
