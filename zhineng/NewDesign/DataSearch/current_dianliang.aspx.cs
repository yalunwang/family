using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace family.DataSearch
{
    public partial class current_dianliang : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                reset();
                if (receiveUpdClient != null)
                {

                    receiveUpdClient.Close();
                    receiveUpdClient = null;


                }
            }
        }
        Thread rec = null;

        byte[] data = new byte[1024];

        string message;
        String[] sqldata1 = new String[1024];//用来储存表地址
       float[] sqldata2 = new float[1024];//用来储存表数据
        String[] sqldata3 = new String[1];//用来存储抄表日期
        String[] sqldata4 = new String[1];//用来存储中心站时间
        String[] sqldata5 = new String[1];//用来储存操作时间
        string message1;

        string message2;
        private UdpClient receiveUpdClient;
        private IPEndPoint receivePoint;

        // private IPEndPoint Remote;



        //定义网络类型，数据连接类型和网络协议UDP
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Button2.Text == "已联网")
            {

                if (dangqian.Checked == true && zhengxiang.Checked == true && yougong.Checked == true && dianzhi.Checked == true)
                {
                    int i;
                    byte[] bsd = new byte[17];
                    string abc = System.DateTime.Now.ToString("HH");
                    bsd[12] = Convert.ToByte(abc);
                    abc = System.DateTime.Now.ToString("mm");
                    bsd[13] = Convert.ToByte(abc);
                    abc = System.DateTime.Now.ToString("ss");
                    bsd[14] = Convert.ToByte(abc);
                    bsd[0] = 0xAA;
                    bsd[1] = 0xAA;
                    bsd[2] = 0x7E;
                    bsd[3] = 0x7E;
                    bsd[4] = 0x00;
                    bsd[5] = 0x0C;
                    bsd[6] = 0x08;
                    bsd[7] = 0x00;


                    bsd[8] = Convert.ToByte(TextBox4.Text, 16);
                    bsd[9] = Convert.ToByte(TextBox5.Text, 16);
                    bsd[10] = Convert.ToByte(TextBox6.Text, 16);
                    bsd[11] = Convert.ToByte(TextBox7.Text, 16);

                  //Session["8"] = bsd[12].ToString() + "时" + bsd[13].ToString() + "分" + bsd[14] + "秒";
                    Session["8"] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                   /*string sqlstr = null;
                    DBClass dbObj = new DBClass();
               
                  
                        sqlstr = "Insert into biaoshu(操作时间)values('" + sqldata5[0] + "')";
                        SqlCommand myCmd = dbObj.GetCommandStr(sqlstr);
                        dbObj.ExecNonQuery(myCmd);*/

                   // string strtest = Session["8"].ToString();
                    bsd[15] = 0xDE;

                    for (i = 4; i < 16; i++)
                        bsd[16] += bsd[i];//加校验和
                    /*用来显示所发送的命令先去掉了
                    for (i = 0; i < bsd.Length; i++)
                    {

                        TextBox2.Text += bsd[i].ToString("X2") + " ";
                    }
                   
                    
                   TextBox2.Text += "\r\n";*/
                    //设置服务IP，设置TCP端口号
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.1.110"), 1500);//设置远端套接字
                    server.SendTo(bsd, ip);
                }
                else
                {
                    Response.Write("<script>alert('请选择相应的配置')</script>");


                }

            }
            else
            {
                Response.Write("<script>alert('请先初始化')</script>");
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (receiveUpdClient != null)
                {

                    receiveUpdClient.Close();
                    receiveUpdClient = null;
                    //System.Threading.Thread.Sleep(8000);

                }

                //  if (receiveUpdClient == null)
                {
                    receiveUpdClient = new UdpClient(int.Parse("1501"));  //接收
                    receivePoint = new IPEndPoint(IPAddress.Parse("192.168.1.110"), int.Parse("1501"));
                    // while (true)
                    {
                        int recv;
                        data = new byte[1024];
                        //server.Bind(ips);


                        rec = new Thread(jieshou);
                        rec.IsBackground = true;//后台执行
                        rec.Start();
                        Thread.Sleep(8000);
                    }

                    //  message = "";
                    Session["2"] = message;
                    Session["3"] = message1;
                    //Button1.Text = "请勿再点击";
                    // ViewState["1"] = message;
                }
            }

            finally
            {
                Button2.Text = "已联网";


            }
        }

        DateTime da1, da2, da3;
        protected void jieshou()//接收
        {

            int i;
            while (true)
            {
                Thread.Sleep(100);//让线程挂起便于接收
                data = new byte[100];
                data = receiveUpdClient.Receive(ref receivePoint);//接收udp数据
                message = "";
                for (i = 0; i < data.Length; i++)
                {
                    message = message + data[i].ToString("X2") + " ";
                }
                List<Byte> List = new List<Byte>();//用来拼接接收到的数据以得到完整的一帧数据 
                /* int b = 0;//定义List数组的索引  //第二种方法
                 for (i = 0; i <data.Length; i++)
                 {
                     List[i]=data[i];
                 }*/
                List.AddRange(data);//用来拼接接收到的数据以得到完整的一帧数据 
                if (List[List.Count - 2] == 0XDE)//数据分析
                {
                    int s, k;
                    message1 = "Start:" + "\r\n";
                    if (List[6] == 0x00 && List[7] == 0x0E)
                    {
                        int j = List[4] * 256 + List[5] - 2;
                        //this.textBox4.AppendText("节点超时");
                        for (k = 0; k < j; k++)
                            message1 += (List[k + 8].ToString("X2") + "节点超时");
                        message1 += ("\r\n");
                        List.RemoveRange(0, j + 6 + 2 + 1);//后面加1代表要多删掉校验和

                    }

                    if (List[6] == 0x00 && List[7] == 0x0F)
                    {
                        int j = List[4] * 256 + List[5] - 2;
                        for (k = 0; k < j; k++)
                            message1 += (List[k + 8].ToString("X2") + "节点已被删除");
                        message1 += ("\r\n");
                        List.RemoveRange(0, j + 6 + 2 + 1); //后面加1代表要多删掉校验和

                    }

                    if (List[6] == 0x00 && List[7] == 0X11)
                    {
                        int j = List[4] * 256 + List[5] - 2;
                        message1 += ("异常电表地址:" + "\r\n");
                        for (k = 0; k < j; k += 6)
                        {
                            message1 += (List[k + 13].ToString("X2") + List[k + 12].ToString("X2") + List[k + 11].ToString("X2") + List[k + 10].ToString("X2") + List[k + 9].ToString("X2") + List[k + 8].ToString("X2"));
                            message1 += ("\r\n");
                        }
                        List.RemoveRange(0, j + 6 + 2 + 1);//后面加1代表要多删掉校验和
                    }

                    if (List[6] == 0x00 && List[7] == 0X12)
                    {

                        int j = List[4] * 256 + List[5] - 2;
                        message1 += ("已被删除的电表地址：");
                        for (k = 0; k < j; k += 6)
                        {
                            message1 += (List[k + 13].ToString("X2") + List[k + 12].ToString("X2") + List[k + 11].ToString("X2") + List[k + 10].ToString("X2") + List[k + 9].ToString("X2") + List[k + 8].ToString("X2"));
                            message1 += ("\r\n");
                        }
                        List.RemoveRange(0, j + 6 + 2 + 1);//后面加1代表要多删掉校验和

                    }

                    if (List[6] == 0x00 && List[7] == 0x8C)
                    {
                        byte[] dat = new byte[1];
                        for (i = 4; i < List.Count - 1; i++)
                            dat[0] += List[i];//求校验和
                        if (dat[0] == List[List.Count - 1])//判断校验和是否正确
                        {
                            int m = 0, q = 0;
                            int mm = 0;
                            int w = 16;
                            message1 += ("共有" + (List[8] * 256 + List[9]).ToString() + "块电表：");
                            message1 += ("\r\n");
                            message1 += ("数据标识:" + List[10].ToString("X2") + List[11].ToString("X2") + List[12].ToString("X2") + List[13].ToString("X2"));
                            message1 += ("\r\n");
                            message1 += ("抄录时间" + List[14].ToString() + "时" + List[15].ToString() + "分" + List[16] + "秒" + "\r\n");
                            sqldata4[0] = System.DateTime.Now.ToString("yyyy-MM-dd") +" "+ List[14].ToString()+":" + List[15].ToString()+":"  + List[16].ToString();
                            da2 = DateTime.Parse(sqldata4[0]);
                            for (; m < (List[8] * 256 + List[9]); )
                            {
                                //this.textBox4.AppendText(m.ToString() + "、");
                                //m++;
                                q++;
                                message1 += ("数据标识:" + List[w + 1].ToString("X2") + List[w + 2].ToString("X2") + List[w + 3].ToString("X2") + List[w + 4].ToString("X2"));
                                message1 += ("\r\n");
                                message1 += ("抄录时间" + List[w + 5].ToString() + "时" + List[w + 6].ToString() + "分" + List[w + 7] + "秒" + "\r\n");

                                sqldata3[0] = System.DateTime.Now.ToString("yyyy-MM-dd") + " " + (List[w + 5].ToString() + ":" + List[w + 6].ToString() + ":" + List[w + 7]);
                                da1 = DateTime.Parse(sqldata3[0]);
                                message1 += ("共有" + List[w + 8].ToString() + "块电表：");
                                message1 += ("\r\n");
                                w += 8;
                                s = w;
                                for (mm = 0; mm < (List[s]); )
                                {
                                    message1 += ("表地址为：" + List[w + 6].ToString("X2") + List[w + 5].ToString("X2") + List[w + 4].ToString("X2") + List[w + 3].ToString("X2") + List[w + 2].ToString("X2") + List[w + 1].ToString("X2"));
                                    sqldata1[m] = List[w + 6].ToString("X2") + List[w + 5].ToString("X2") + List[w + 4].ToString("X2") + List[w + 3].ToString("X2") + List[w + 2].ToString("X2") + List[w + 1].ToString("X2");
                                    message1 += ("表数据为：" + (List[w + 10] - 0x33).ToString("X2") + (List[w + 9] - 0x33).ToString("X2") + (List[w + 8] - 0x33).ToString("X2") + "." + (List[w + 7] - 0x33).ToString("X2") + "Kwh");
                                    sqldata2[m] = (float.Parse((List[w + 10] - 0x33).ToString("X2") + (List[w + 9] - 0x33).ToString("X2") + (List[w + 8] - 0x33).ToString("X2")  + (List[w + 7] - 0x33).ToString("X2")))/100;//
                                   
                                    message1 += ("\r\n");
                                    w += 10;                                    m++;
                                    mm++;
                                }
                            }

                            message1 += ("本次抄表结束" + "\r\n");
                            message1 += (".........................................................................");

                            /*
                             int m = 1, q = 0;
                             message1 += ("共有" + (List[8] * 256 + List[9]).ToString() + "块电表：");
                             message1 += ("\r\n");
                             for (s = 0; (s + 22) < List.Count - 2; s += 10)
                             {
                                 message1 += (m.ToString() + "、");
                                 m++;
                                 sqldata1[q] = List[s + 18].ToString("X2") + List[s + 17].ToString("X2") + List[s + 16].ToString("X2") + List[s + 15].ToString("X2") + List[s + 14].ToString("X2") + List[s + 13].ToString("X2");
                                 sqldata2[q] = (List[s + 22] - 0x33).ToString("X2") + (List[s + 21] - 0x33).ToString("X2") + (List[s + 20] - 0x33).ToString("X2") + "." + (List[s + 19] - 0x33).ToString("X2") + "kWh";
                                 q++;
                                 message1 += ("表地址为：" + List[s + 18].ToString("X2") + List[s + 17].ToString("X2") + List[s + 16].ToString("X2") + List[s + 15].ToString("X2") + List[s + 14].ToString("X2") + List[s + 13].ToString("X2"));
                                 message1 += ("表数据为：" + (List[s + 22] - 0x33).ToString("X2") + (List[s + 21] - 0x33).ToString("X2") + (List[s + 20] - 0x33).ToString("X2") + "." + (List[s + 19] - 0x33).ToString("X2")) + "kWh";
                                 message1 += ("\r\n");
                             }
                             message1 += ("抄录时间" + List[10].ToString() + "时" + List[11].ToString() + "分" + List[12] + "秒" + "\r\n");
                             message1 += ("本次抄表结束" + "\r\n");
                             message1 += ("...........................................");

                             sqldata3[0] = List[10].ToString() + "时" + List[11].ToString() + "分" + List[12] + "秒";
                             // sqldata2[0] = "95"; sqldata2[1] = "45"; sqldata1[0] = "95.2"; sqldata1[1] = "36.1";
                             */
                            int l;//下面是插入数据库代码
                            string sqlstr = null; sqldata5[0] = Session["8"].ToString();
                            da3 = DateTime.Parse(sqldata5[0]);
                            DBClass dbObj = new DBClass();
                            for (l = 0; l < m; l++)
                            {
                                sqlstr = "Insert into biaoshu(表地址,电量,抄录时间,中心站时间,操作时间)values('" + sqldata1[l] + "','" + sqldata2[l] + "','" + da1 + "','" + da2 + "','" + da3 + "')";
                                SqlCommand myCmd = dbObj.GetCommandStr(sqlstr);
                                dbObj.ExecNonQuery(myCmd);
                            }

                            //for (i = 0; i < List.Count; i++)
                            // str += List[i].ToString("X2") + "  ";
                            // this.textBox1.AppendText(str);
                            List.Clear();//清空List数组用来储存下一帧数据
                            //b = 0;//将List数组的索引清零以保证下一帧数据的正确储存

                        }
                    }


                    Session["3"] = message1;

                    Session["2"] = message;
                }
            }
        }


        protected void Timer2_Tick(object sender, EventArgs e)
        {
            if (Session["3"] != null)
            {
                TextBox3.Text = TextBox3.Text + Session["3"].ToString() + ";";
                Session["3"] = null;
            }
        }
        protected void reset()
        {


            //存放进程使用的端口号链表

            List<int> ports = new List<int>();

            //  ports = 1051;

            Process pro = new Process();
            // 设置命令行、参数

            pro.StartInfo.FileName = "cmd.exe";

            pro.StartInfo.UseShellExecute = false;

            pro.StartInfo.RedirectStandardInput = true;

            pro.StartInfo.RedirectStandardOutput = true;

            pro.StartInfo.RedirectStandardError = true;

            pro.StartInfo.CreateNoWindow = true;
            // 启动CMD
            pro.Start();
            // 运行端口检查命令
            pro.StandardInput.WriteLine("netstat -aon");

            pro.StandardInput.WriteLine("exit");

            Regex reg = new Regex("\\s+", RegexOptions.Compiled);

            string line = null;


            line = pro.StandardOutput.ReadLine();
            while ((line = pro.StandardOutput.ReadLine()) != null)
            {

                line = line.Trim();



                if (line.StartsWith("UDP", StringComparison.OrdinalIgnoreCase))
                {

                    line = reg.Replace(line, ",");

                    string[] arr;
                    arr = new string[2048 * 8];
                    arr = line.Split(',');
                    //TextBox2.Text = TextBox2.Text + pro80.ToString() + ";";

                    if (arr[1].EndsWith(":1501"))
                    {
                        //  Console.WriteLine("80端口的进程ID：{0}", arr[4]);

                        int pid = Int32.Parse(arr[3]);
                        //  Process pro80 = Process.GetProcessById(pid);
                        // 7700 强制关闭进程
                        string strtemp = "taskkill  /F /pid" + " " + pid.ToString();
                        // 启动CMD
                        pro.Start();
                        // 运行关闭端口命令
                        pro.StandardInput.WriteLine(strtemp);

                        //  pro.StandardInput.WriteLine("exit");



                    }

                }



            }
            pro.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            TextBox3.Text = "";
        }


        protected void Button4_Click(object sender, EventArgs e)
        {


            /*int i;
            byte[] data = new byte[26]; int linshi;
            if (dangqian.Checked == true && zhengxiang.Checked == true && yougong.Checked == true && dianzhi.Checked == true)
            {

                data[0] = 0x68;//起始符
                linshi = Convert.ToByte(data.Length - 1 - 2 - 6 + 1);
                data[2] = Convert.ToByte(linshi / 256); data[1] = Convert.ToByte(linshi % 256);
                data[1] <<= 2;//向左移两位
                data[1] |= 0x02;//L
                data[3] = data[1]; data[4] = data[2];//L
                data[5] = 0x68;//起始
                data[6] = 0x4A;//控制域C
                data[7] = 0x23; data[8] = 0x02;//地址A1
                data[9] = 0x01; data[10] = 0x00;//A2 
                data[11] = 0x02; //A3
                //AFN,            帧序列SEQ，      数据单元标识：全部 pn,             F129
                data[12] = 0x0C; data[13] = 0xE1; data[14] = 0xFF; data[15] = 0x00; data[16] = 0x01; data[17] = 0x10;
                data[18] = 0;//PFC未实现
                //发送时标秒分时日......................................
                string abc = System.DateTime.Now.ToString("dd");//日
                data[22] = Convert.ToByte(abc, 16);
                abc = System.DateTime.Now.ToString("HH");//时
                data[21] = Convert.ToByte(abc, 16);
                abc = System.DateTime.Now.ToString("mm");//分
                data[20] = Convert.ToByte(abc, 16);
                abc = System.DateTime.Now.ToString("ss");//秒
                data[19] = Convert.ToByte(abc, 16);
                //发送时标结束..........................................
                data[23] = 0x01;//允许超时时间
                for (i = 6; i < 24; i++)
                    data[24] += data[i];//校验和
                data[25] = 0x16;
                for (i = 0; i < data.Length; i++)
                {
                    //StrTemp = StrTemp + "0x" + data[i].ToString("X2");
                    TextBox2.Text += data[i].ToString("X2") + " ";
                }
                TextBox2.Text += "\r\n";

            }
            else
            {
                Response.Write("<script>alert('请选择相应的配置')</script>");


            }
            */
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["3"] != null)
            {
                TextBox3.Text = TextBox3.Text + Session["3"].ToString() + ";";
                Session["3"] = null;
            }
        }

       
    }
}