using System;
using System.Collections.Generic;
using System.Xml;
using System.Web;

namespace ZKEShop.Common
{
    public class GetMainMenu
    {
        #region 字段属性

        private bool is_Admin = false;  //是否为Admin登录
        private string powerIDs = ""; //当前登录用户的权限IDS
        private string jsStr = ""; //JS字符串
        private string menuStr = ""; //菜单 
        private string jsField = ""; //JS字段字符串
        private string jsShowSubmenu = ""; //显示菜单的JS
        private string jsCloseSubMenu = ""; //关闭菜单的JS
        private bool isStorageOn = true;  //是否启用仓储系统
        private int rank = 0; //节点等级
        private string powerTree;//权限节点
        private string _menuname;
        


        /// <summary>
        /// 启用了仓储系统
        /// </summary>
        public bool IsStorageOn
        {
            get { return isStorageOn; }
            set { isStorageOn = value; }
        }
        /// <summary>
        /// JS字段字符串
        /// </summary>
        public string JsField
        {
            get { return jsField; }
            set { jsField = value; }
        }
        /// <summary>
        /// JS显示子菜单字符串
        /// </summary>
        public string JsShowSubmenu
        {
            get { return jsShowSubmenu; }
            set { jsShowSubmenu = value; }
        }

        /// <summary>
        /// JS关闭子菜单函数字符串
        /// </summary>
        public string JsCloseSubMenu
        {
            get { return jsCloseSubMenu; }
            set { jsCloseSubMenu = value; }
        }

        /// <summary>
        /// 是管理员
        /// </summary>
        public bool Is_Admin
        {
            get { return is_Admin; }
            set { is_Admin = value; }
        }

        /// <summary>
        /// 权限字符串
        /// </summary>
        public string PowerIDs
        {
            get { return powerIDs; }
            set { powerIDs = value; }
        }
        /// <summary>
        /// 菜单字符串
        /// </summary>
        public string MenuStr
        {
            get { return menuStr; }
            set { menuStr = value; }
        }
        /// <summary>
        /// JS字符串
        /// </summary>
        public string JsStr
        {
            get { return jsStr; }
            set { jsStr = value; }
        }

        /// <summary>
        /// 后台菜单名称
        /// </summary>
        public string MenuName
        {
            get { return _menuname; }
            set { _menuname = value; }
        }
        #endregion

        #region 获得XML节点集合
        /// <summary>
        /// 获得XML节点集合
        /// create by Chenghh
        /// </summary>
        /// <returns></returns>
        private XmlNodeList GetXmlNodeList()
        {
            if (string.IsNullOrEmpty(_menuname))
            {
                _menuname = "menu.xml";
            }

            string filePath = System.Web.HttpContext.Current.Server.MapPath("/BackendResource/Menu");
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath + "\\" + _menuname);
            XmlNodeList list = doc.SelectSingleNode("//root").ChildNodes;
            return list;
        }
        #endregion

        #region 查询所有的节点
        /// <summary>
        /// create by Chenghh
        /// 查询所有的节点
        /// </summary>
        public void SearchMenuXML()
        {
            XmlNodeList nodeList = GetXmlNodeList();
            Dictionary<string, XmlNodeList> dictNodeList = new Dictionary<string, XmlNodeList>();

            menuStr += "<table width=\"100%\" border=\"0\" cellpadding=\"2\"><tr>";
            menuStr += "<td width=\"11\" align=\"center\"><img src=\"images/s.gif\" width=\"2\" height=\"18\"></td>";
            rank = 1;
            foreach (XmlNode node in nodeList)
            {
                //判断节点的类型是否为注释类型
                if (node.NodeType == XmlNodeType.Comment)
                {
                    continue;
                }
                //检查仓储系统是否启用
                if (node.Attributes["checkStorage"] != null && node.Attributes["checkStorage"].Value == "1")
                {
                    if (!isStorageOn)
                    {
                        continue;
                    }
                }

                //获得配置文件的属性
                string id = node.Attributes["id"].Value; //ID
                string text = node.Attributes["text"].Value; //菜单名称
                string childID = node.Attributes["childID"].Value; //子菜单名称
                string isAdmin = node.Attributes["isAdmin"].Value; //验证admin
                string powerID = node.Attributes["powerID"].Value; //权限ID

                //要验证Admin，并且当前用户不是Admin，检查是否有权限
                if (isAdmin == "1" && !is_Admin)
                {
                    if (!string.IsNullOrEmpty(powerID)) //权限ID不为空，检查是否包含该权限
                    {
                        int index = ("," + powerIDs + ",").IndexOf("," + powerID + ",");
                        if (index < 0)
                        {
                            continue;
                        }
                    }
                    else  //如果权限ID为空，该节点只允许Admin查看
                    {
                        continue;
                    }
                }

                menuStr += "<td  id=\"" + id + "\" width=\"70\" onclick=\"ClickIt=true;ShowSubmenu1('" + childID + "')\" " +
                         " onmouseover=\"ShowSubmenu1('" + childID + "');this.className='button2';\"" +
                         " onmousedown=\"this.className='button4'\" onmouseout=\"this.className=''\" align=\"center\"  nowrap class=\"style1\">" + text;

                if (!node.HasChildNodes)
                {
                    continue;
                }
                else
                {
                    if (!string.IsNullOrEmpty(childID))
                    {
                        jsStr += "document.getElementById(\"" + childID + "\").style.left = document.getElementById(\"" + id + "\").offsetLeft;" +
                                " document.getElementById(\"" + childID + "\").style.top = document.getElementById(\"" + id + "\").offsetTop + 23;";
                    }
                    dictNodeList.Add(childID, node.ChildNodes);
                }

                menuStr += "</td>";

            }
            menuStr += "<td onclick=\"ClickIt=false;CloseSubAllMenu();\"></td></tr></table>";
            GetChild(dictNodeList);  //获得所有的子节点
            GetJSPara();
        }
        #endregion

        #region 根据父节点，获得子节点
        /// <summary>
        /// 根据父节点，获得子节点
        /// create by Chenghh
        /// </summary>
        /// <param name="dictNodeList"></param>
        private void GetChild(Dictionary<string, XmlNodeList> dictNodeList)
        {
            if (dictNodeList.Count > 0) //如果子菜单有值，等级加1
            {
                rank++;
            }
            Dictionary<string, XmlNodeList> dictChildNodeList = new Dictionary<string, XmlNodeList>();

            foreach (KeyValuePair<string, XmlNodeList> item in dictNodeList)
            {
                string childIdPar = item.Key;
                XmlNodeList nodeList = item.Value;
                menuStr += "<table id=\"" + childIdPar + "\" width=\"148\" border=\"0\" cellspacing=\"0\" class=\"button2\""
               + " style=\"visibility: hidden;position: absolute;\">";
                foreach (XmlNode node in nodeList)
                {
                    //判断节点的类型是否为注释类型
                    if (node.NodeType == XmlNodeType.Comment)
                    {
                        continue;
                    }
                    //如果菜单类型为btn，则继续下一个节点
                    if (node.Attributes["type"] != null && node.Attributes["type"].Value == "btn")
                    {
                        continue;
                    }

                    //获得配置文件的属性
                    string isHR = node.Attributes["isHR"].Value;    //是否是分隔符 1：是
                    //先判断是不是分割符
                    if (isHR == "1")
                    {
                        menuStr += "<tr height=\"1\">" +
                                    "<td height=\"1\" bgcolor=\"#CCCCCC\" align=\"right\">" +
                                    "</td>" +
                                  "</tr>";
                        continue;
                    }

                    string isAdmin = node.Attributes["isAdmin"].Value; //验证admin
                    string powerID = node.Attributes["powerID"].Value; //权限ID
                    string id = node.Attributes["id"].Value; //ID
                    string text = node.Attributes["text"].Value; //菜单名称
                    string childID = node.Attributes["childID"].Value; //子菜单名称
                    string imgUrl = node.Attributes["imgUrl"].Value; //菜单前图片路径
                    string targetURL = node.Attributes["targetURL"].Value; //目标路径
                    //要验证Admin，并且当前用户不是Admin，检查是否有权限
                    if (isAdmin == "1" && !is_Admin)
                    {
                        if (!string.IsNullOrEmpty(powerID)) //权限ID不为空，检查是否包含该权限
                        {
                            int index = ("," + powerIDs + ",").IndexOf("," + powerID + ",");
                            if (index < 0)
                            {
                                continue;
                            }
                        }
                        else  //如果权限ID为空，该节点只允许Admin查看
                        {
                            continue;
                        }
                    }

                    //仓储系统不启用时显示某些节点
                    if (node.Attributes["notStorageOnShow"] != null && node.Attributes["notStorageOnShow"].Value == "1")
                    {
                        if (isStorageOn)
                        {
                            continue;
                        }
                    }

                    bool childNodeIsAllBtn = false;
                    //childNodeIsAllBtn
                    //子节点全是btn按钮
                    if (node.Attributes["childNodeIsAllBtn"] != null && node.Attributes["childNodeIsAllBtn"].Value == "1")
                    {
                        childNodeIsAllBtn = true;
                    }


                    menuStr += "<tr ";

                    //targetURL不为空，添加OnClick事件
                    if (!string.IsNullOrEmpty(targetURL))
                    {
                        menuStr += " onclick=\"" + targetURL + "\"";
                    }

                    if (node.HasChildNodes && !childNodeIsAllBtn)//有子节点,显示子节点，并且子节点不是按钮类型
                    {
                        menuStr += " onmouseover=\"ShowSubmenu" + rank + "('" + childID + "');\">";
                    }
                    else  //没有子节点，关闭子节点
                    {
                        menuStr += " onmouseover=\"CloseSubMenu(" + rank + ");\">";
                    }
                    menuStr += " <td width=\"9\" bgcolor=\"DBD8D1\" align=\"right\">" +
                                    "<img src=\"" + imgUrl + "\" width=\"16\">" +
                             " </td>" +
                             " <td id=\"" + id + "\" width=\"90%\" bgcolor=\"F9F8F7\" class=\"menuNormal\" onmouseover=\"this.className='menuSelect'\"" +
                                  "onmouseout=\"this.className='menuNormal'\">&nbsp;" + text;

                    //判断是否还有子节点
                    if (node.HasChildNodes && !childNodeIsAllBtn)//——有子节点                    {
                        //JS控制子控件显示的位置
                        if (!string.IsNullOrEmpty(id))
                        {
                            string varStr = "pos" + id;
                            jsStr += "var " + varStr + " = GetObjPos(document.getElementById(\"" + id + "\"));" +
                                     " document.getElementById(\"" + childID + "\").style.left = " + varStr + ".x + 130;" +
                                     " document.getElementById(\"" + childID + "\").style.top = " + varStr + ".y;";
                        }
                        try
                        {
                            dictChildNodeList.Add(childID, node.ChildNodes);
                        }
                        catch (Exception)
                        {
                            HttpContext.Current.Response.Write("子菜单ID：" + childID + node.Attributes["text"].Value + "重复");
                        } 
                    }
                    menuStr += "</td></tr>";
                }
                menuStr += "</table>";
            }
            if (dictChildNodeList.Count > 0)
            {
                GetChild(dictChildNodeList);
            }
        }
        #endregion

        #region 获得菜单的JS字符串
        /// <summary>
        /// 获得菜单的JS字符串
        /// create by Chenghh
        /// </summary>
        private void GetJSPara()
        {
            for (int i = 1; i < rank; i++)
            {
                //JS变量
                jsField += "var LastSubMenu" + i + " = \"\";";

                //显示子菜单

                if (i != 1)
                {
                    jsShowSubmenu += "function ShowSubmenu" + i + "(ShowID) {" +
                                        "if(ShowID=='')return;if (LastSubMenu" + i + " != \"\") {" +
                                        "    document.all(LastSubMenu" + i + ").style.visibility = \"hidden\";" +
                                        "}" +
                                        "document.all(ShowID).style.visibility = \"visible\";" +
                                        "LastSubMenu" + i + " = ShowID;" +
                                    "}";
                }

                //关闭子菜单

                if (!string.IsNullOrEmpty(jsCloseSubMenu))
                {
                    jsCloseSubMenu += " else ";
                }
                jsCloseSubMenu += "if (i == " + i + "){";
                for (int j = i; j < rank; j++)
                {
                    jsCloseSubMenu += "if (LastSubMenu" + j + " != \"\")" +
                                        "{" +
                                        "    document.all(LastSubMenu" + j + ").style.visibility = \"hidden\";" +
                                        "}";
                }
                jsCloseSubMenu += "}";
            }
        }
        #endregion

        #region 获得有权限的树形菜单
        /// <summary>
        /// 获得有权限的树形菜单
        /// create by Chenghh
        /// <param name="powerIDsPar">用户已存在的权限ID</param>
        /// </summary>
        /// <returns></returns>
        public string GetPowerTree(string powerIDsPar)
        {
            powerTree = "d1.add(0,-1,'权限分配');";
            XmlNodeList nodeList = GetXmlNodeList();
            foreach (XmlNode node in nodeList)
            {
                //判断节点的类型是否为注释类型
                if (node.NodeType == XmlNodeType.Comment)
                {
                    continue;
                }

                //检查仓储系统是否启用
                if (node.Attributes["checkStorage"] != null && node.Attributes["checkStorage"].Value == "1")
                {
                    if (!isStorageOn) //没有启用，则不加载仓储系统模块
                    {
                        continue;
                    }
                }

                string powerIDStr = node.Attributes["powerID"].Value; //节点的权限ID
                string text = node.Attributes["text"].Value; //菜单名称

                if (!string.IsNullOrEmpty(powerIDStr))
                {
                    int powerID = Convert.ToInt32(powerIDStr);
                    powerTree += "d1.add(" + powerID + ",0,'<input type=checkbox name=\"check\" value=" + powerID + " class=0 id=ch" + powerID + " onclick=checkStatus(" + powerID + ",this)";


                    //判断权限里是否包含节点的权限，如果包含，则默认勾选
                    int index = ("," + powerIDsPar + ",").IndexOf("," + powerID + ",");
                    if (index >= 0)
                    {
                        powerTree += " checked=checked ";
                    }


                    powerTree += ">" + text + "');";

                    if (node.HasChildNodes)
                    {
                        GetChildNodePower(powerID, node.ChildNodes, powerIDsPar);
                    }
                }
            }
            return powerTree;

        }
        #endregion

        #region 获得所有的子菜单
        /// <summary>
        /// 获得所有的子菜单
        /// created by Chenghh
        /// </summary>
        /// <param name="parentPower">父节点的权限值</param>
        /// <param name="nodeList">子节点集合</param>
        private void GetChildNodePower(int parentPower, XmlNodeList nodeList, string powerIDsPar)
        {
            foreach (XmlNode node in nodeList)
            {
                //判断节点的类型是否为注释类型
                if (node.NodeType == XmlNodeType.Comment)
                {
                    continue;
                }

                //仓储系统不启用时显示某些节点
                if (node.Attributes["notStorageOnShow"] != null && node.Attributes["notStorageOnShow"].Value == "1")
                {
                    if (isStorageOn)
                    {
                        continue;
                    }
                }


                string powerIDStr = node.Attributes["powerID"].Value; //权限ID
                string text = node.Attributes["text"].Value; //菜单名称

                if (!string.IsNullOrEmpty(powerIDStr))
                {
                    int powerID = Convert.ToInt32(powerIDStr);
                    powerTree += "d1.add(" + powerID + "," + parentPower + ",'<input type=checkbox name=\"check\" value=" + powerID + " class=" + parentPower + " id=ch" + powerID + " onclick=checkStatus(" + powerID + ",this)";

                    //判断权限里是否包含节点的权限，如果包含，则默认勾选
                    int index = ("," + powerIDsPar + ",").IndexOf("," + powerID + ",");
                    if (index >= 0)
                    {
                        powerTree += " checked=checked ";
                    }


                    powerTree += ">" + text + "');";

                    if (node.HasChildNodes)
                    {
                        GetChildNodePower(powerID, node.ChildNodes, powerIDsPar);
                    }
                }

            }

        }
        #endregion

        #region 获得权限对应的节点名称
        /// <summary>
        /// 获得权限对应的节点名称
        /// create by Chenghh
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetPowerMenyName()
        {
            Dictionary<int, string> name = new Dictionary<int, string>();

            XmlNodeList nodeList = GetXmlNodeList();
            foreach (XmlNode node in nodeList)
            {
                //判断节点的类型是否为注释类型
                if (node.NodeType == XmlNodeType.Comment)
                {
                    continue;
                }

                ////检查仓储系统是否启用
                //if (node.Attributes["checkStorage"] != null && node.Attributes["checkStorage"].Value == "1")
                //{
                //    if (!isStorageOn) //没有启用，则不加载仓储系统模块
                //    {
                //        continue;
                //    }
                //}

                string powerIDStr = node.Attributes["powerID"].Value; //节点的权限ID
                string text = node.Attributes["text"].Value; //菜单名称

                if (!string.IsNullOrEmpty(powerIDStr))
                {
                    try
                    {
                        name.Add(Convert.ToInt32(powerIDStr), text);
                    }
                    catch (Exception e)
                    {
                    }

                    if (node.HasChildNodes)
                    {
                        GetChild(node.ChildNodes,name);
                    }
                }
            }
            return name;
        }

        /// <summary>
        /// 获得子节点
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="name"></param>
        private void GetChild(XmlNodeList nodeList, Dictionary<int, string> name)
        {
            foreach (XmlNode node in nodeList)
            {
                //判断节点的类型是否为注释类型
                if (node.NodeType == XmlNodeType.Comment)
                {
                    continue;
                }
      
                string powerIDStr = node.Attributes["powerID"].Value; //权限ID
                string text = node.Attributes["text"].Value; //菜单名称

                if (!string.IsNullOrEmpty(powerIDStr))
                {

                    try
                    {
                        name.Add(Convert.ToInt32(powerIDStr), text);
                        
                    }
                    catch (Exception)
                    {
                        HttpContext.Current.Response.Write("权限ID：" + powerIDStr + " 重复");
                    } 

                    if (node.HasChildNodes)
                    {
                        GetChild(node.ChildNodes, name);
                    }
                }

            }
        }
        #endregion 
    }
}
