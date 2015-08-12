using DataAccess;
using System;
using System.Linq;
using System.Reflection;

namespace ZKEShop.SystemFramework
{
    public class OperationLog
    {
        /* public YalunwangDataDataContext db = new YalunwangDataDataContext(System.Configuration.ConfigurationSettings.AppSettings["ConnStr.net"]);
         ZKEShop.DataAccess.SysObject sysobj;
         ZKEShop.Common.OperationType _operType;
         ZKEShop.DataAccess.Users user;
         public OperationLog(ZKEShop.Common.OperationType operType, ZKEShop.Common.SysObject objid, int userid)
         {
             sysobj = db.SysObject.Single(o => o.SysObjectID == (short)objid);
             user = db.Users.Single(o => o.UserID == userid);
             _operType = operType;
         }

         public OperationLog(ZKEShop.Common.OperationType operType, ZKEShop.DataAccess.SysObject SysObject, ZKEShop.DataAccess.Users User)
         {
             sysobj = SysObject;
             user = User;
             _operType = operType;
         }

         public void Log(object BeforObj, string PK)
         {
             try
             {
                 var EndObj = db.ExecuteQuery<object>("select * from " + sysobj.TableName + " where " + sysobj.TablePK + "='" + PK + "'").First();
                 Log(BeforObj, EndObj);
             }
             catch (Exception)
             {
             }
         }

         public void Log(object BeforObj,object EndObj)
         {
             var operationLog = new ZKEShop.DataAccess.OperationRecord();
             db.OperationRecord.InsertOnSubmit(operationLog);
             operationLog.LogDate = DateTime.Now;
             operationLog.OperType = (short)_operType;
             operationLog.SysObjectID = sysobj.SysObjectID;
             operationLog.UserID = user.UserID;
             string remark = user.TrueName + "对‘" + ZKEShop.Common.Common.GetObjectPropertyValue(BeforObj, sysobj.TablePK) + "’进行了操作";
             PropertyInfo[] propertys = BeforObj.GetType().GetProperties();
             foreach (PropertyInfo pinfo in propertys)
             {
                 string BeforValue = pinfo.GetValue(BeforObj, null) + "";
                 string EndValue = ZKEShop.Common.Common.GetObjectPropertyValue(EndObj, pinfo.Name);
                 if (BeforValue != EndValue)
                 {
                     var logDetail = new ZKEShop.DataAccess.OperationDetail();
                     logDetail.BeforInfo = BeforValue;
                     logDetail.EndInfo = EndValue;
                     logDetail.FieldName = pinfo.Name;
                     logDetail.OperationRecord = operationLog;
                 }
             }
             db.SubmitChanges();
         }*/
    }
}
