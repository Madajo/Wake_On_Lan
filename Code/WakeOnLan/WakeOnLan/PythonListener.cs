#region ----- Using -----
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
#endregion ----- Using -----
namespace WakeOnLan
{
    public class PythonListener
    {
        delegate void Operations(string operations);
        private MainForm mainform;
        TcpListener listener;
        TcpClient pythonclient;
        Dictionary<string, Operations> state_machine = new Dictionary<string, Operations>(); //Dictionary of Function Pointers
        private Process pythonEngine;
        Thread threadPythonListener;
        bool running;

        public PythonListener(MainForm mainform)
        {
            this.mainform = mainform;
            threadPythonListener = new Thread(new ThreadStart(Run));
            threadPythonListener.Start();
            state_machine["CompStatus"] = CompStatus;
            state_machine["DataBase"] = DataBase;
            state_machine["Schedule"] = Schedule;
            pythonEngine = new Process();
            pythonEngine.StartInfo.FileName = @"C:\Python26\python.exe";
            pythonEngine.StartInfo.Arguments = @"C:\Users\daniel\Desktop\Wake_On_Lan\Code\PythonEngine.py";
            pythonEngine.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            pythonEngine.Start();

        }

        private void Run() //Main Function
        {
            listener = new TcpListener(9000);
            listener.Start();

            pythonclient = listener.AcceptTcpClient();
            listener.Stop();
            byte[] buff = new byte[20000];
            running = true;
            while (running) // run always to communicate with python engine
            {
                try
                {
                    int reclen = pythonclient.GetStream().Read(buff, 0, buff.Length);
                    string msg = Encoding.ASCII.GetString(buff).Substring(0, reclen);
                    string[] commands = msg.Split('#');
                    if (commands.Length > 0)
                    {
                        state_machine[commands[0]](commands[1]);
                    }

                }
                catch (Exception e) { continue; }
            }

        }

        #region ----- State Machine Functions -----
        private void CompStatus(string msg)
        {
            this.mainform.Invoke((MethodInvoker)delegate
            {
                this.mainform.CompStatus(msg);
            });
            
        }
        private void DataBase(string addresses)
        {
            string[] addr = addresses.Split('@');
            this.mainform.Invoke((MethodInvoker)delegate
            {
                this.mainform.AddComps(addr);
            });
            
        }

        private void Schedule(string tasks)
        {
            string[] addr = tasks.Split('@');
            //this.mainform.AddTasks(addr);
        }
        #endregion ----- State Machine Functions -----
        // Send Message to Python Engine
        public void Send(string msg)
        {
            pythonclient.Client.Send(Encoding.ASCII.GetBytes(msg));
        }
        public void Close()
        {
            try
            {
                if (pythonEngine != null)
                {
                    pythonEngine.Kill();
                    pythonEngine.Dispose();
                    pythonEngine = null;
                }
                if (pythonclient != null)
                {
                    pythonclient.Close();
                    pythonclient = null;
                }
            }
            catch (Win32Exception e)
            { }
            catch (InvalidOperationException e)
            { }
            finally
            {
                running = false;
            }
        }
    }

}
