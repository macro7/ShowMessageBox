using System;
using System.Collections.Generic;

namespace ShowMessageBox.Utils
{
    /// <summary>
    /// 显示等待框
    /// </summary>
    public class WaitFormUtils
    {
        static List<int> processIds = new List<int>();
        #region 截屏等待
        /// <summary>
        /// 显示等待窗体,但是代码继续执行
        /// </summary>
        /// <param name="message">等待消息内容</param>
        /// <param name="title">标题</param>
        /// <param name="timeOut">倒计时，自动关闭等待</param>
        /// <param name="opacity">透明度</param>
        /// <param name="width">高度</param>
        /// <param name="height">宽度</param>
        public static void ShowWaitForm(string message = "", string title = "", int timeOut = -1, double opacity = -1, int width = 0, int height = 0)
        {
            string args = "";
            string strOpacity = "-1";
            string strTimeOut = "0";
            string strWidth = "0";
            string strHeight = "0";
            try
            {
                if (message.Trim() == "")
                {
                    message = "、";
                }
                if (title.Trim() == "")
                {
                    title = "、";
                }
                if (timeOut >= 0)
                {
                    strTimeOut = timeOut.ToString();
                }
                if (opacity >= 0)
                {
                    strOpacity = opacity.ToString();
                }
                if (width >= 0)
                {
                    strWidth = width.ToString();
                }
                if (height >= 0)
                {
                    strHeight = height.ToString();
                }
                System.Diagnostics.Process prossce = new System.Diagnostics.Process();
                message = message.Replace(" ", "");
                title = title.Replace(" ", "");
                args = string.Format("{0} {1} {2} {3} {4} {5}", message, title, strTimeOut, strOpacity, strWidth, strHeight);
                prossce.StartInfo.FileName = "WKWaitForm.exe";
                prossce.StartInfo.Arguments = args;
                prossce.Start();
                processIds.Add(prossce.Id);
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        /// <summary>
        /// 关闭显示等待窗体,但是代码继续执行的窗口
        /// </summary>
        public static void CloseWaitForm()
        {
            try
            {
                if (processIds.Count > 0)
                {
                    foreach (int processId in processIds)
                    {
                        try
                        {
                            System.Diagnostics.Process.GetProcessById(processId).Kill();
                        }
                        catch { }
                    }
                    processIds = new List<int>();
                }
                else
                {
                    System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcesses();
                    for (int i = 0; i < process.Length; i++)
                    {
                        if (process[i].ProcessName.ToUpper().Contains("WKWaitForm".ToUpper()))
                        {
                            process[i].Kill();
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorLog(e);
            }
        }
        #endregion
    }
}
