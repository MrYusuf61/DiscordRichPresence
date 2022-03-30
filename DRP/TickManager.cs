using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DRP
{
    public static class TickManager
    {
        public static int Timeout => 500;
        public static List<Action> Ticks { get; } = new List<Action>();

        private static Thread tickThread;
        private static bool status = false;

        public static void Start()
        {
            status = true;
            tickThread = new Thread(() =>
            {
                START_STEP:
                try
                {
                    while (true)
                    {
                        if (!status) break;

                        foreach (var item in Ticks.ToList())
                        {
                            try
                            {
                                item?.Invoke();
                            }
                            catch (Exception) { }
                        }
                        Thread.Sleep(Timeout);
                    }
                }
                catch (Exception ex)
                {
                    if (Debugger.IsAttached)
                        Debugger.Break();
                    goto START_STEP;
                }
            });
            tickThread.Start();
        }

        public static void Stop()
        {
            status = false;
            tickThread = null;
        }
    }
}
