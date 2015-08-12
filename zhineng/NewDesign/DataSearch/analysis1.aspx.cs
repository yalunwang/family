using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
namespace family.DataSearch
{
    public partial class analysis1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int Total()
        {
            SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Con.Open();
            string cmdtxt1 = "select * from biaoshu";
            SqlDataAdapter dap = new SqlDataAdapter(cmdtxt1, Con);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            int P_Int_total = ds.Tables[0].Rows.Count;//访问人数统计
            return P_Int_total;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.CreateImage();
        }
        private void CreateImage()
        {
            int height = 440, width = 600;
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);

            try
            {
                //清空图片背景色
                g.Clear(Color.White);

                Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
                Font font1 = new System.Drawing.Font("宋体", 20, FontStyle.Regular);
                Font font2 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
                g.FillRectangle(Brushes.AliceBlue, 0, 0, width, height);
                Brush brush1 = new SolidBrush(Color.Blue);
                Brush brush2 = new SolidBrush(Color.SaddleBrown);

                g.DrawString("尉氏县用电曲线显示图", font1, brush1, new PointF(100, 30));
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);

                Pen mypen = new Pen(brush, 1);
                Pen mypen2 = new Pen(Color.Red, 2);
                //绘制线条
                //绘制纵向线条
                int x = 60;
                for (int i = 0; i < 9; i++)
                {
                    g.DrawLine(mypen, x, 80, x, 340);
                    x = x + 50;
                }
                Pen mypen1 = new Pen(Color.Blue, 2);
                g.DrawLine(mypen1, x - 450, 80, x - 450, 340);

                //绘制横向线条
                int y = 106;
                for (int i = 0; i < 9; i++)
                {
                    g.DrawLine(mypen, 60, y, 510, y);
                    y = y + 26;
                }
                g.DrawLine(mypen1, 60, y, 510, y);

                //x轴
                String[] n = { "王方", "陆荣卫" ,"沈新阳","申淑娟","孙中孟",  "邢宗锋",
                      "王建敏","周金领","于志辉"};
                x = 45;
                for (int i = 0; i < 9; i++)
                {
                    g.DrawString(n[i].ToString(), font, Brushes.Red, x, 348); //设置文字内容及输出位置
                    x = x + 50;
                }

                //y轴
                String[] m = {"500", "1000", " 1500", "2000", " 2500", " 3000", " 3500", " 4000","4500"
                     };
                y = 100;
                for (int i =8; i>=0 ; i--)
                {
                    g.DrawString(m[i].ToString(), font, Brushes.Red, 25, y); //设置文字内容及输出位置
                    y = y + 26;
                }

                float[] Count1 = new float[10];
                int[] Count2 = new int[10];
                SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                Con.Open();
                string cmdtxt2 = "SELECT * FROM biaoshu ";
                SqlDataAdapter da = new SqlDataAdapter(cmdtxt2, Con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a = ds.Tables[0].Rows.Count;
                for (int j = 0; j < a; j++)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        Count1[j] = 0;
                    }
                    else
                    {
                        Count1[j] =float.Parse((ds.Tables[0].Rows[j][2]).ToString()) ;
                    }
                }
                for (int j = 0; j < a; j++)
                {
                    Count2[j] = int.Parse((Count1[j] * 100).ToString());
                    Count2[j] = Count2[j] / 100;
                    Count2[j] = Count2[j]*13 / 250;
                }
                //显示折线效果
                SolidBrush mybrush = new SolidBrush(Color.Red);
                Point[] points1 = new Point[9];
                points1[0].X = 60;
                int b = 60;
                for (int j = 0; j < 9; j++)
                {
                    points1[j].X= b;

                    b = b + 50;
                    points1[j].Y = 338 - Count2[j];
             
                  
                }
                g.DrawLines(mypen2, points1);  //绘制折线

            

                //绘制标识
                g.DrawRectangle(new Pen(Brushes.Red), 150, 370, 250, 50);  //绘制范围框
                g.FillRectangle(Brushes.Red, 250, 380, 20, 10);  //绘制小矩形
                g.DrawString("民用", font2, Brushes.Red, 270, 380);
                g.FillRectangle(Brushes.Black, 250, 400, 20, 10);
                g.DrawString("商用", font2, Brushes.Black, 270, 400);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Response.ClearContent();
                Response.ContentType = "image/Jpeg";
                Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            CreateImage1();
        }
        private void CreateImage1()
        {
              int height = 400, width = 600;
        Bitmap image = new Bitmap(width, height);
           
        //创建Graphics类对象
        Graphics g = Graphics.FromImage(image);

        try
        {
            //清空图片背景色
            g.Clear(Color.White);

            Font font = new Font("Arial", 9, FontStyle.Regular);
            Font font1 = new Font("宋体", 20, FontStyle.Bold);

            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue , Color.BlueViolet, 1.2f, true);
            g.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
           // Brush brush1 = new SolidBrush(Color.Blue);

            g.DrawString("尉氏县用电直方图显示", font1, brush, new PointF(130, 30));
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);
            Pen mypen = new Pen(brush, 1);
            Pen mypen2 = new Pen(Color.Red, 2);
            //绘制线条
            //绘制纵向线条
            int x = 60;
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(mypen, x, 80, x, 340);
                x = x + 50;
            }
            Pen mypen1 = new Pen(Color.Blue, 2);
            g.DrawLine(mypen1, x - 450, 80, x - 450, 340);

            //绘制横向线条
            int y = 106;
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(mypen, 60, y, 510, y);
                y = y + 26;
            }
            g.DrawLine(mypen1, 60, y, 510, y);





            ////////////
           

            //x轴
            String[] n = { "王方", "陆荣卫" ,"沈新阳","申淑娟","孙中孟",  "邢宗锋",
                      "王建敏","周金领","于志辉"};
            x = 62;
            for (int i = 0; i < 9; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Black , x, 348); //设置文字内容及输出位置
                x = x + 50;
            }

            //y轴
            String[] m = {"500", "1000", " 1500", "2000", " 2500", " 3000", " 3500", " 4000","4500"
                     };
            y = 100;
            for (int i =8; i >=0; i--)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Black, 25, y); //设置文字内容及输出位置
                y = y + 26;
            }

            float[] Count1 = new float[9];
            SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            Con.Open();
            string cmdtxt2 = "SELECT * FROM biaoshu ";
            SqlDataAdapter da = new SqlDataAdapter(cmdtxt2, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < 9; i++)
            {
                //cmdtxt2 = "select COUNT(*) AS count, Month( LoginTime) AS month from tb_10 where Year(LoginTime)=2007 and Month(LoginTime)=" + (i + 1) + "Group By Month(LoginTime)";
              
               
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Count1[i] = 0;
                }
                else
                {
                   // Count[i] = Convert.ToInt32(ds.Tables[i].Rows[0][0].ToString()) * 100 / Total();
                   Count1[i] = float.Parse((ds.Tables[0].Rows[i][2].ToString())); 
                }
            }
            //显示柱状效果
            x = 75;
            for (int i = 0; i < 9; i++)
            {
                SolidBrush mybrush = new SolidBrush(Color.Blue);
               // g.FillRectangle(mybrush, x, 340 - Count[i] * 26 / 10, 20, Count[i] * 26 / 10);
                g.FillRectangle(mybrush, x, 340 - Count1[i] * 13 / 250, 20, Count1[i] * 13 / 250);
                x = x + 50;
            }
     
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Response.ClearContent();
            Response.ContentType = "image/Jpeg";
            Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }




        }

    }
