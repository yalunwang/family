using System;
using System.Collections.Generic;
using System.Xml;
using ZKEShop.Common;


namespace ZKEShop.SystemFramework
{
 public    class LiveConfig
    {
        public static AppLanguage lang = AppLanguage.CN;

        static XmlDocument docCN;
        static XmlDocument docEN;
        static XmlDocument OpLogCN;
        static XmlDocument OpLogEN;

        public static string GetMessage(MsgType msgType, string messageID)
        {
            XmlNode nodex = null;
            try
            {
                switch (lang)
                {
                    case AppLanguage.CN:
                        if (docCN == null)
                        {
                            docCN = new XmlDocument();
                            docCN.Load(ApplicationConfiguration.AppRoot + @"\LanguageMessage\zh-CN.xml");
                        }
                        nodex = docCN.SelectSingleNode("//root/" + msgType.ToString() + "/" + messageID);
                        break;
                    case AppLanguage.EN:
                        if (docEN == null)
                        {
                            docEN = new XmlDocument();
                            docEN.Load(ApplicationConfiguration.AppRoot + @"\LanguageMessage\EN.xml");
                        }
                        nodex = docEN.SelectSingleNode("//root/" + msgType.ToString() + "/" + messageID);
                        break;
                }
            }
            catch (Exception)
            {

            }

            if (nodex != null)
                return nodex.InnerText;
            return "";
        }

        public static string GetMessage(MsgType msgType, string messageID, string para1)
        {
            string result = GetMessage(msgType, messageID);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%1", para1);
            return result;
        }

        public static string GetMessage(MsgType msgType, string messageID, string para1, string para2)
        {
            string result = GetMessage(msgType, messageID);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%1", para1);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%2", para2);
            return result;
        }

        public static Dictionary<string, string> GetMessageList(AppLanguage Language, MsgType msgType)
        {
            XmlNode nodex = null;
            Dictionary<string, string> dic = new Dictionary<string, string>();

            switch (Language)
            {
                case AppLanguage.CN:
                    if (docCN == null)
                    {
                        docCN = new XmlDocument();
                        docCN.Load(ApplicationConfiguration.AppRoot + @"\LanguageMessage\zh-CN.xml");
                    }
                    nodex = docCN.SelectSingleNode("//root/" + msgType.ToString());
                    break;
            }
            if (nodex != null && nodex.ChildNodes != null)
            {
                foreach (XmlNode node in nodex.ChildNodes)
                {
                    dic.Add(node.Attributes["value"].Value, node.InnerText);
                }
            }
            return dic;
        }


        public static string GetOperationLog(OpentionLog opLog, string messageID)
        {
            XmlNode nodex = null;
            try
            {
                switch (lang)
                {
                    case AppLanguage.CN:
                        if (OpLogCN == null)
                        {
                            OpLogCN = new XmlDocument();
                            OpLogCN.Load(ApplicationConfiguration.AppRoot + @"\LanguageMessage\OpLog-CN.xml");
                        }
                        nodex = OpLogCN.SelectSingleNode("//root/" + opLog.ToString() + "/" + messageID);
                        break;
                    case AppLanguage.EN:
                        if (OpLogEN == null)
                        {
                            OpLogEN = new XmlDocument();
                            OpLogEN.Load(ApplicationConfiguration.AppRoot + @"\LanguageMessage\OpLog-EN.xml");
                        }
                        nodex = OpLogEN.SelectSingleNode("//root/" + opLog.ToString() + "/" + messageID);
                        break;
                }
            }
            catch (Exception)
            {

            }

            if (nodex != null)
                return nodex.InnerText;
            return "";
        }

        public static string GetOperationLog(OpentionLog opLog, string messageID, string para1)
        {
            string result = GetOperationLog(opLog, messageID);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%1", para1);
            return result;
        }

        public static string GetOperationLog(OpentionLog opLog, string messageID, string para1, string para2)
        {
            string result = GetOperationLog(opLog, messageID);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%1", para1);
            result = System.Text.RegularExpressions.Regex.Replace(result, "%2", para2);
            return result;
        }
    }
}
