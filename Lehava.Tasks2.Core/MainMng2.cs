using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks2.Core
{
    public class MainMng2
    {
        public delegate void delNumArrive(int num);
        public event delNumArrive Handler_120Arrived;

        Queue<int> q = new Queue<int>();
        Random random = new Random();   
        Task t1;
        int val;
        public int iteration =0;
        public void Run()
        {
            GetNumberFromHttp();

        }
        //public DoWork doWork;       

        public Task<int> GetNumberFromHttp()
        {
            Task<int> taskRet =  Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    iteration++;
                    System.Threading.Thread.Sleep(10);
                    int v = random.Next(100, 200);
                    if(v== 120)
                    {
                        // Worker Thread will stop to work
                        //doWork.StopWork = true;
                        Handler_120Arrived(120);
                    }
                    q.Enqueue(v);
                }
                iteration = 0;
                int ret = random.Next(100, 10000);

                return ret;
            });
          
            return taskRet;
        }

        public async void MainLoop()
        {

           int httpResult = await GetNumberFromHttp();


            iteration =  httpResult;

        }

        public void MainLoop2()
        {
            t1.Wait();

            iteration = val;

        }

        public int GetNum(int i)
        {
            return i * i;
        }

    }
}
