using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks2.Core
{
    public class MainMng
    {
        Random random = new Random();   
        Task t1;
        int val;
        public int iteration =0;
        public void Run()
        {
            t1 = Task.Factory.StartNew(() => {

                for (int i = 0; i < 10; i++)
                {
                    iteration++;
                    System.Threading.Thread.Sleep(1000);
                }
                iteration = 0;
                val = random.Next(100,10000);

            });

        }

        public void MainLoop()
        {
            while (t1.Status!=TaskStatus.RanToCompletion)
            {
                System.Threading.Thread.Sleep(1000);
            }

            iteration =  val;

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
