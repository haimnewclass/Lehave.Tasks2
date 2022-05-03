using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks2.Core
{
    public class DoWork
    {
        public void Run()
        {
            Worker();
        }
        public bool StopWork = false;

        public void NumArrive(int num)
        {
            if(num==120)
                StopWork = true;
        }

        public Task<int> Worker()
        {
            Queue<int> q = new Queue<int>();
            Random random = new Random();

            Task<int> taskRet = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000 && !StopWork; i++)
                {                    
                    System.Threading.Thread.Sleep(10);
                    int v = random.Next(1000, 2000);
                    q.Enqueue(v);
                }
                
                int ret = random.Next(100, 10000);

                return ret;
            });

            return taskRet;
        }
    }
}
