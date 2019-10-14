using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShowMessageBox.Utils
{
    /// <summary>
    /// 消息弹出框
    /// </summary>
    public class ShowMessageBox
    {
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Message(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框启动等待匡
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="waitMessage">等待消息框</param>
        /// <param name="interval">等待计时</param>
        public static void MessageStartWaitDiaglog(string message, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">提示标题</param>
        public static void Message(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框启动等待匡
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">提示标题</param>
        /// <param name="waitMessage">等待消息框</param>
        /// <param name="interval">等待计时</param>
        public static void MessageStartWaitDiaglog(string message, string caption, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxIcon">提醒图标</param>
        public static void Message(string message, string caption, MessageBoxIcon messageBoxIcon)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, messageBoxIcon);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 消息框启动等待匡
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxIcon">提醒图标</param>
        /// <param name="waitMessage">等待匡消息框</param>
        /// <param name="interval">计时</param>
        public static void MessageStartWaitDiaglog(string message, string caption, MessageBoxIcon messageBoxIcon, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, messageBoxIcon);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxButtons">显示按钮</param>
        /// <param name="messageBoxIcon">提醒图标</param>
        public static void Show(string message, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxButtons">显示按钮</param>
        /// <param name="messageBoxIcon">提醒图标</param>
        /// <param name="waitMessage">等待匡消息框</param>
        /// <param name="interval">计时</param>
        public static void ShowStartWaitDiaglog(string message, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }

        /// <summary>
        /// 重要消息提醒（会截屏记录到日志表）
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        public static void InformationImportant(string message, string caption = "")
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }

        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Error(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                //Logger.WriteLogInfoToSql(errorId, new Exception(message));
                string text = errorId + "：" + message;
                XtraMessageBox.Show(text, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void ErrorNoLog(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框(自动保存错误日志)
        /// </summary>
        /// <param name="message">日志内容</param>
        [Obsolete]
        public static void ErrorLog(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                //Logger.WriteErrorLog(new Exception(message));
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                //Logger.WriteLogInfoToSql(errorId, new Exception(message));
                string text = errorId + "：" + message;
                XtraMessageBox.Show(text, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch
            {
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void ErrorNoLog(Exception message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch
            {
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Error(Exception message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                //Logger.WriteErrorLog(message);
                //Logger.WriteLogInfoToSql(errorId, message);
                string text = errorId + "：" + message.Message;
                XtraMessageBox.Show(text, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch { }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        delegate void DelegateWriteLogInfoToSql(Exception message);
        /// <summary>
        /// 弹出错误消息框(自动保存错误日志)
        /// </summary>
        /// <param name="message">消息内容</param>
        [Obsolete]
        public static void ErrorLog(Exception message)
        {
            try
            {
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                string text = errorId + "：" + message.Message;
                XtraMessageBox.Show(text, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch { }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        public static void ErrorNoLog(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        public static void Error(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                string text = errorId + "：" + message;
                XtraMessageBox.Show(text, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框
        /// </summary>
        /// <param name="exception">错误消息</param>
        /// <param name="caption">消息标题</param>
        public static void Error(Exception exception, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                string text = errorId + "：" + exception.Message;
                XtraMessageBox.Show(text, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出错误消息框(自动保存错误日志)
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        [Obsolete]
        public static void ErrorLog(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                //Logger.WriteErrorLog(new Exception(message));
                string errorId = Environment.MachineName + DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                //Logger.WriteLogInfoToSql(errorId, new Exception(message));
                string text = errorId + "：" + message;
                XtraMessageBox.Show(text, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出警告消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Warning(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出警告消息框
        /// </summary>
        /// <param name="message">警告消息</param>
        /// <param name="waitMessage">等待消息内容</param>
        /// <param name="interval">等待匡计时</param>
        public static void WarningStartDialog(string message, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出警告消息框
        /// </summary>
        /// <param name="message">警告消息</param>
        /// <param name="waitMessage">等待消息内容</param>
        /// <param name="interval">等待匡计时</param>
        public static void Warning(string message, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出警告消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        public static void Warning(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出警告消息框
        /// </summary>
        /// <param name="message">警告信息</param>
        /// <param name="caption">警告标题</param>
        /// <param name="waitMessage">等待匡，消息内容</param>
        /// <param name="interval">计时</param>
        public static void WarningStartDialog(string message, string caption, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        public static void Information(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Information(string message)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="waitMessage">等待消息体</param>
        /// <param name="interval">计间（秒）。倒计时，自动关闭</param>
        public static void Information(string message, string waitMessage, int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出询问消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">标题</param>
        /// <returns>DialogResult.OK;DialogResult.Cancel</returns>
        public static DialogResult Question(string message, string caption)
        {
            WaitFormUtils.CloseWaitForm();
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="waitMessage">等待匡，消息内容</param>
        /// <param name="interval">计时</param>
        public static void InformationWaitForm(string message, string caption, string waitMessage = "", int interval = -1)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBox.Show(message, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                WaitFormUtils.ShowWaitForm(waitMessage, "", interval);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出询问消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">标题</param>
        /// <param name="messageBoxDefaultButton">默认按钮</param>
        /// <returns>DialogResult.OK;DialogResult.Cancel</returns>
        public static DialogResult Question(string message, string caption, MessageBoxDefaultButton messageBoxDefaultButton)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                return XtraMessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, messageBoxDefaultButton);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出询问消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxButtons">显示按钮</param>
        /// <param name="messageBoxDefaultButton">默认按钮</param>
        /// <returns>DialogResult</returns>
        public static DialogResult Question(string message, string caption, MessageBoxButtons messageBoxButtons, MessageBoxDefaultButton messageBoxDefaultButton)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                return XtraMessageBox.Show(message, caption, messageBoxButtons, MessageBoxIcon.Question, messageBoxDefaultButton);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出询问消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">消息标题</param>
        /// <param name="messageBoxButtons">显示按钮</param>
        /// <param name="messageBoxIcon">显示图标</param>
        /// <param name="button">默认按钮</param>
        /// <returns>DialogResult</returns>
        public static DialogResult Question(string message, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton button)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                return XtraMessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon, button);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        /// <summary>
        /// 弹出询问消息框
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="caption">标题</param>
        /// <returns>DialogResult.OK;DialogResult.No</returns>
        [Obsolete]
        public static DialogResult XtraMessageBoxForm(string message, string caption)
        {
            try
            {
                WaitFormUtils.CloseWaitForm();
                XtraMessageBoxArgs xtraMessageBoxArgs = new XtraMessageBoxArgs(null, message, caption, MessageBoxButtonsToDialogResults(MessageBoxButtons.YesNo), MessageBoxIconToIcon(MessageBoxIcon.Question), MessageBoxDefaultButtonToInt(MessageBoxDefaultButton.Button1));
                XtraMessageBoxForm form = new XtraMessageBoxForm();
                foreach (Control ctr in form.Controls)
                {
                    if (ctr is SimpleButton)
                    {
                        ((SimpleButton)ctr).Appearance.Font = new System.Drawing.Font("宋体", 18, System.Drawing.FontStyle.Regular);
                    }
                }
                form.Font = new System.Drawing.Font("宋体", 18, System.Drawing.FontStyle.Regular);
                return form.ShowMessageBoxDialog(xtraMessageBoxArgs);
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }


        private static DialogResult[] MessageBoxButtonsToDialogResults(MessageBoxButtons buttons)
        {
            try
            {
                if (!Enum.IsDefined(typeof(MessageBoxButtons), buttons))
                {
                    throw new InvalidEnumArgumentException("buttons", (int)buttons, typeof(DialogResult));
                }
                switch (buttons)
                {
                    case MessageBoxButtons.OK:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.OK
                    };
                        }
                    case MessageBoxButtons.OKCancel:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.OK,
                        DialogResult.Cancel
                    };
                        }
                    case MessageBoxButtons.AbortRetryIgnore:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.Abort,
                        DialogResult.Retry,
                        DialogResult.Ignore
                    };
                        }
                    case MessageBoxButtons.YesNoCancel:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.Yes,
                        DialogResult.No,
                        DialogResult.Cancel
                    };
                        }
                    case MessageBoxButtons.YesNo:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.Yes,
                        DialogResult.No
                    };
                        }
                    case MessageBoxButtons.RetryCancel:
                        {
                            return new DialogResult[]
                    {
                        DialogResult.Retry,
                        DialogResult.Cancel
                    };
                        }
                    default:
                        {
                            throw new ArgumentException("buttons");
                        }
                }
            }
            finally
            {
                ProcessUtils.ClearMemory();
            }
        }
        private static Icon MessageBoxIconToIcon(MessageBoxIcon icon)
        {
            if (!Enum.IsDefined(typeof(MessageBoxIcon), icon))
            {
                throw new InvalidEnumArgumentException("icon", (int)icon, typeof(DialogResult));
            }
            if (icon <= MessageBoxIcon.Hand)
            {
                if (icon == MessageBoxIcon.None)
                {
                    return null;
                }
                if (icon == MessageBoxIcon.Hand)
                {
                    return SystemIcons.Error;
                }
            }
            else
            {
                if (icon == MessageBoxIcon.Question)
                {
                    return SystemIcons.Question;
                }
                if (icon == MessageBoxIcon.Exclamation)
                {
                    return SystemIcons.Exclamation;
                }
                if (icon == MessageBoxIcon.Asterisk)
                {
                    return SystemIcons.Information;
                }
            }
            throw new ArgumentException("icon");
        }
        private static int MessageBoxDefaultButtonToInt(MessageBoxDefaultButton defButton)
        {
            if (!Enum.IsDefined(typeof(MessageBoxDefaultButton), defButton))
            {
                throw new InvalidEnumArgumentException("defaultButton", (int)defButton, typeof(DialogResult));
            }
            if (defButton == MessageBoxDefaultButton.Button1)
            {
                return 0;
            }
            if (defButton == MessageBoxDefaultButton.Button2)
            {
                return 1;
            }
            if (defButton != MessageBoxDefaultButton.Button3)
            {
                throw new ArgumentException("defaultButton");
            }
            return 2;
        }

    }
}
