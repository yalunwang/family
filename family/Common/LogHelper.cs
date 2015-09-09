using System;
using log4net;

//log4net的配置在app.config中
//[assembly:log4net.Config.DOMConfigurator(ConfigFileExtension="config",Watch=true)]
//log4net自己的配置文件
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", ConfigFileExtension = "config", Watch = true)]

namespace ZKEShop.Common
{
    /// <summary>
    /// 日志处理助手
    /// 不需要给每个程序都添加 程序集引用，只需要在 app/web 项目的根目录下 添加 log4net.config 配置文件即可
    /// </summary>
    public static class LogHelper
    {
        private const string LOG_REPOSITORY = "Default"; // this should likely be set in the web config.
        private readonly static ILog m_log = log4net.LogManager.GetLogger(typeof(object));

        /// <summary>
        /// 临时日志 测试用
        /// </summary>
        /// <returns></returns>
        public static ILog GetLog() 
        {
            return log4net.LogManager.GetLogger(typeof(object));
        }

        /// <summary>
        /// 初始化日志系统
        /// 在系统运行开始初始化 Global.asax Application_Start 内
        /// 如果已经使用 [assembly] 方式配置，这里就不需要启动了
        /// </summary>
        public static void Init()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net.config"));
        }
        /// <summary>
        /// 写入DeBug级别的日志
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void DeBug(string message)
        {
            DoLog(message, LogMessageType.Debug, null);
        }
        /// <summary>
        /// 写入Info级别的日志
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void Write(string message) 
        {
            DoLog(message, LogMessageType.Info, null);
        }
        /// <summary>
        /// 写入Error级别的日志
        /// </summary>
        /// <param name="message">Error</param>
        /// <param name="ex">异常</param>
        public static void Error(string message,Exception ex)
        {
            DoLog(message, LogMessageType.Error, ex);
        }
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        public static void Write(string message, LogMessageType messageType)
        {
            DoLog(message, messageType, null);
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">异常</param>
        public static void Write(string message, LogMessageType messageType, Exception ex)
        {
            DoLog(message, messageType, ex);
        }

        /// <summary>
        /// 断言
        /// </summary>
        /// <param name="condition">条件</param>
        /// <param name="message">日志信息</param>
        public static void Assert(bool condition, string message)
        {
            if (condition == false)
            {
                Write(message, LogMessageType.Info);
            }
        }

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">异常</param>
        private static void DoLog(string message, LogMessageType messageType, Exception ex)
        {
            switch (messageType)
            {
                case LogMessageType.Debug:
                    LogHelper.m_log.Debug(message, ex);
                    break;

                case LogMessageType.Info:
                    LogHelper.m_log.Info(message, ex);
                    break;

                case LogMessageType.Warn:
                    LogHelper.m_log.Warn(message, ex);
                    break;

                case LogMessageType.Error:
                    LogHelper.m_log.Error(message, ex);
                    break;

                case LogMessageType.Fatal:
                    LogHelper.m_log.Fatal(message, ex);
                    break;
            }
        }

        /// <summary>
        /// 日志类型
        /// </summary>
        public enum LogMessageType
        {
            /// <summary>
            /// 调试
            /// </summary>
            Debug,
            /// <summary>
            /// 信息
            /// </summary>
            Info,
            /// <summary>
            /// 警告
            /// </summary>
            Warn,
            /// <summary>
            /// 错误
            /// </summary>
            Error,
            /// <summary>
            /// 致命错误
            /// </summary>
            Fatal
        }
    }
}

