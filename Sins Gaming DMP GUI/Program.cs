using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Sins_Gaming_DMP_GUI
{
    
    static class Program
    {
        private static bool runningFlag = false;
        private static Process activeProcess;
        private static Thread runningThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        unsafe static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new Form1());
        }

        public static bool IsServerRunning()
        {
            return runningFlag;
        }

        unsafe public static void RunServer(Observer o)
        {
            if (!runningFlag)
            {
                Process p = new Process();
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = "DMPServer\\DMPServer.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Verb = "runas";
                p.Start();

                activeProcess = p;

                runningFlag = true;

                ServerFeed readerObj = new ServerFeed(p);
                Thread readerThread = new Thread(readerObj.readInputFromConsole);

                PlayerUpdater Players = new PlayerUpdater(Form.ActiveForm as Form1);

                readerObj.registerObserver(o);
                readerObj.registerObserver(Players);

                readerThread.Start();
                runningThread = readerThread;
            }
        }

        public static void executeCommand(string cmd)
        {
            if (runningFlag)
            {
                activeProcess.StandardInput.Write("/" + cmd + "\n");
            }
            else
            {
                MessageBox.Show("This command can not be executed while server is not running!");
            }
        }

        public static void StopServer()
        {
            if (runningFlag)
            {
                runningThread.Abort();
                executeCommand("quit");
                runningFlag = false;

                var form = Form.ActiveForm as Form1;
                form.writeToConsoleDisplayBox("Command Executed to shutdown server!");
                form.removeAllPlayers();
            }
        }
        
        private class ServerFeed : Observable
        {
            private Process proc;
            private List<Observer> observers;

            public ServerFeed(Process p)
            {
                proc = p;
                observers = new List<Observer>();
            }
            public void readInputFromConsole()
            {
                do
                {
                    System.Threading.Thread.Sleep(10);
                    string line = proc.StandardOutput.ReadLine();

                    notifyObserver(line);

                } while (true);
            }

            public void registerObserver(Observer o)
            {
                observers.Add(o);
            }
            public void removeObserver(Observer o)
            {
                observers.Remove(o);
            }
            public void notifyObserver(string line)
            {
                foreach(Observer o in observers)
                {
                    o.update(line);
                }
            }        
        }
        
    }
}
