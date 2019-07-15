using System;
using System.Threading;

namespace Hang.Jobs
{
    public class MyJob
    {
        public void DoJob (int sleep)
        {
            Thread.Sleep(sleep);
        }
    }
}
