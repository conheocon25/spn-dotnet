using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EmailMarketing
{
    public class CDeliver
    {
        public int nMessage;
        public bool WaitForComplete;
        public ManualResetEvent Event;

        public CDeliver()
        {
            nMessage = 0;
        }

        public void Produce(CScheduler scheduler)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Consume), scheduler);
            nMessage++;
        }

        public void Consume(Object obj)
        {            
            //Gửi tin nhắn đi nhe
            ((CScheduler)obj).sendMail();
            Thread.Sleep(5000);
            nMessage--;
            if (WaitForComplete)
            {
                if (nMessage == 0)
                {
                    Event.Set();
                }
            }; 
        }

        public void Wait()
        {
            if (nMessage == 0)
            {
                return;
            }
            Event = new ManualResetEvent(false);
            WaitForComplete = true;
            Event.WaitOne();
        }

    }
}
