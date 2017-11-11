using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ClumsyAssistant3._0
{
    class Processes
    {
        List<String> previousProcesses;
        List<String> currentProcesses;

        Notification n;
        Thread t;

        public Processes()
        {
            previousProcesses = new List<string>();
            n = new Notification();
        }

        public void Start()
        {
            t = new Thread(ProcessProcesses);
            t.Start();
        }

        public void Stop()
        {
            t.Abort();
        }

        public void ListProcesses()
        {
            currentProcesses = new List<string>();
            Process[] processlist = Process.GetProcesses();
            
            foreach (Process theprocess in processlist)
            {
                currentProcesses.Add(theprocess.ProcessName);
            }
        }

        public void ProcessEvent(String name)
        {
            switch(name)
            {
                case "firefox":
                    n.ShowNotification("Internet", "I see you tried to open the internet in a wrong way, here, I fixed it for you!", 1000);

                    Process[] localByName = Process.GetProcessesByName("firefox");
                    foreach(Process proc in localByName)
                    {
                        proc.Kill();
                    }
                    System.Diagnostics.Process.Start("microsoft-edge:");
                    break;
            }
        }

        public void ProcessProcesses()
        {
            ListProcesses();

            List<String> differentProcesses = currentProcesses.Except(previousProcesses).ToList();
            
            foreach(String s in differentProcesses)
            {
               // Console.WriteLine(s);
                ProcessEvent(s);
            }

          //  Console.WriteLine("Run done---------------");

            previousProcesses = currentProcesses.ToList();

            Thread.Sleep(1000);

            ProcessProcesses();
        }
    }
}
