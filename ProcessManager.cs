using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace ShowMessageBox.Utils
{
    /// <summary>
    /// 进程处理类
    /// </summary>
    public class ProcessUtils
    {
        /// <summary>
        /// 杀进程
        /// </summary>
        /// <param name="exe">应用程序名称</param>
        public static void KillProcess(string exe)
        {
            try
            {
                Process[] processes = Process.GetProcesses();//
                if (processes != null && processes.Length > 0)
                {
                    foreach (Process p in processes)
                    {
                        if (p.ProcessName == exe)
                        {
                            p.Kill();
                        }
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 杀进程
        /// </summary>
        /// <param name="processId">应用程序进程ID</param>
        public static void KillProcess(int processId)
        {
            try
            {
                Process.GetProcessById(processId).Kill();
            }
            catch { }
        }
        #region 调用系统API（系统快捷键 Alt+Tab）切换应用程序
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序
        /// </summary>
        /// <param name="process">程序进程</param>
        private static void SetForegroundWin(Process process)
        {
            try
            {
                ShowWindowAsync(process.MainWindowHandle, 1);  //调用api函数，正常显示窗口
                SetForegroundWindow(process.MainWindowHandle); //将窗口放置最前端
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序，如果该程序没有启动，则自动启动
        /// </summary>
        /// <param name="process">应用程序名称</param>
        /// <param name="fileName">应用程序运行路径</param>
        private static void SetForegroundWin(Process process, string fileName)
        {
            try
            {
                ShowWindowAsync(process.MainWindowHandle, 1);  //调用api函数，正常显示窗口
                SetForegroundWindow(process.MainWindowHandle); //将窗口放置最前端
                if (!(Process.GetProcesses().Any(a => a.ProcessName == process.ProcessName)))
                {
                    Process.Start(fileName);
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序
        /// </summary>
        /// <param name="processName">应用程序名称</param>
        private static void SetForegroundWin(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcesses();//
                if (processes != null && processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            ShowWindowAsync(process.MainWindowHandle, 1);  //调用api函数，正常显示窗口
                            SetForegroundWindow(process.MainWindowHandle); //将窗口放置最前端
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序，如果该程序没有启动，则自动启动
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="fileName">应用程序运行路径</param>
        private static void SetForegroundWin(string processName, string fileName)
        {
            try
            {
                bool exists = false;
                processName = processName.Replace(".exe", "");
                Process[] processes = Process.GetProcesses();//
                if (processes != null && processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            exists = true;
                            ShowWindowAsync(process.MainWindowHandle, 1);  //调用api函数，正常显示窗口
                            SetForegroundWindow(process.MainWindowHandle); //将窗口放置最前端
                        }
                    }
                }
                if (!exists)
                {
                    Process.Start(fileName);
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="fAltTab"></param>
        [DllImport("User32.dll")]
        private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序
        /// </summary>
        /// <param name="process">程序进程</param>
        public static void SwitchToThisWin(Process process)
        {
            try
            {
                SwitchToThisWindow(process.MainWindowHandle, true);
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序，如果该程序没有启动，则自动启动
        /// </summary>
        /// <param name="processName">应用程序名称</param>
        /// <param name="fileName">应用程序运行路径</param>
        public static void SwitchToThisWin(Process processName, string fileName)
        {
            try
            {
                SwitchToThisWindow(processName.MainWindowHandle, true);
                if (!(Process.GetProcesses().Any(a => a.ProcessName == processName.ProcessName)))
                {
                    Process.Start(fileName);
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序
        /// </summary>
        /// <param name="processName">应用程序名称</param>
        public static void SwitchToThisWin(string processName)
        {
            try
            {
                if (processName.ToLower().Contains(".exe"))
                {
                    processName = processName.Substring(processName.Length - ".exe".Length, ".exe".Length);
                }
                Process[] processes = Process.GetProcesses();//
                if (processes != null && processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            SwitchToThisWindow(process.MainWindowHandle, true);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 调用系统API（系统快捷键 Alt+Tab）切换应用程序，如果该程序没有启动，则自动启动
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="fileName">应用程序运行路径</param>
        public static void SwitchToThisWin(string processName, string fileName)
        {
            try
            {
                bool exists = false;
                if (processName.ToLower().Contains(".exe"))
                {
                    processName = processName.Substring(0, processName.Length - ".exe".Length);
                }
                Process[] processes = Process.GetProcessesByName(processName);//
                if (processes != null && processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            exists = true;
                            SwitchToThisWindow(process.MainWindowHandle, true);
                            return;
                        }
                    }
                }
                if (!exists)
                {
                    Process.Start(fileName);
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }




        /// <summary>
        /// 允许Cmd命令
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="createNoWindow">是否静默运行</param>
        /// <returns>System.String.</returns>
        public static string RunCmd(string command, bool createNoWindow = true)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";           //設定程序名
            p.StartInfo.Arguments = "/c " + command;    //設定程式執行參數
            p.StartInfo.UseShellExecute = false;        //關閉Shell的使用
            p.StartInfo.RedirectStandardInput = true;   //重定向標準輸入
            p.StartInfo.RedirectStandardOutput = true;  //重定向標準輸出
            p.StartInfo.RedirectStandardError = true;   //重定向錯誤輸出
            p.StartInfo.CreateNoWindow = createNoWindow;          //設置不顯示窗口
            p.Start();   //啟動   
            return p.StandardOutput.ReadToEnd();        //從輸出流取得命令執行結果
        }

        /// <summary>
        /// 注册DLL文件
        /// </summary>
        /// <param name="fileName">注册目标文件.</param>
        /// <param name="noInfomation">是否不用谈消息框</param>
        /// <param name="createNoWindow">設置不顯示窗口</param>
        /// <returns>System.String.</returns>
        public static string DllRegisterServer(string fileName, bool noInfomation, bool createNoWindow)
        {
            string command = "regsvr32 " + fileName + (noInfomation ? " /s" : "");
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";           //設定程序名
            p.StartInfo.Arguments = "/c " + command;    //設定程式執行參數
            p.StartInfo.UseShellExecute = false;        //關閉Shell的使用
            p.StartInfo.RedirectStandardInput = true;   //重定向標準輸入
            p.StartInfo.RedirectStandardOutput = true;  //重定向標準輸出
            p.StartInfo.RedirectStandardError = true;   //重定向錯誤輸出
            p.StartInfo.CreateNoWindow = createNoWindow;          //設置不顯示窗口
            p.StartInfo.Verb = "RunAs";
            p.Start();   //啟動   
            return p.StandardOutput.ReadToEnd();        //從輸出流取得命令執行結果
        }

        /// <summary>
        /// 注册DLL文件
        /// </summary>
        /// <param name="fileName">注册目标文件.</param>
        /// <returns>System.String.</returns>
        public static string DllRegisterServer(string fileName)
        {
            string command = "regsvr32 " + fileName;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";           //設定程序名
            p.StartInfo.Arguments = "/s " + command;    //設定程式執行參數
            p.Start();   //啟動   
            return p.StandardOutput.ReadToEnd();        //從輸出流取得命令執行結果
        }

        #region 内存回收
        /// <summary>
        /// 释放内存
        /// </summary>
        /// <param name="process"></param>
        /// <param name="minSize"></param>
        /// <param name="maxSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary> 
        /// 释放内存
        /// </summary> 
        public static void GCCollect()
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
                }
            }
            catch { }
        }
        #endregion
        internal static void ClearMemory()
        {
            GCCollect();
        }
    }
}
