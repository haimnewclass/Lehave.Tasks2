using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks2.Core
{
    public class MainMng2
    {
        Random random = new Random();   
        Task t1;
        int val;
        public int iteration =0;
        public void Run()
        {
            

        }
        public Task<int> GetNumberFromHttp()
        {
            Task<int> taskRet =  Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    iteration++;
                    System.Threading.Thread.Sleep(1000);
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
