using System.Drawing;

namespace ZKEShop.Common
{
   public static class scaleImg
    {
       public static void makeImg(string imgPath, string savePath, int thumbWidth, int thumbHeight)
        {
            //String src = "c:/myImages/a.jpg";   //源图像文件的绝对路径
            //String dest = "c:/myImages/a_th.jpg";    //生成的缩略图图像文件的绝对路径
            //int thumbWidth = 80;    //要生成的缩略图的宽度

            System.Drawing.Image image = System.Drawing.Image.FromFile(imgPath); //利用Image对象装载源图像

            //接着创建一个System.Drawing.Bitmap对象，并设置你希望的缩略图的宽度和高度。

            int srcWidth = image.Width;
            int srcHeight = image.Height;

            Bitmap bmp = new Bitmap(thumbWidth, thumbHeight);

            //从Bitmap创建一个System.Drawing.Graphics对象，用来绘制高质量的缩小图。            System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp);

            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default ;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;

            //把原始图像绘制成上面所设置宽高的缩小图
            System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, thumbWidth, thumbHeight);
            gr.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);

            //gr.Flush();
            //保存图像，大功告成！
            bmp.Save(savePath);

            //最后别忘了释放资源
            bmp.Dispose();
            image.Dispose();



            

            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), 10, 20, 13, 7);       
        }

       //private void button1_Click(object sender, EventArgs e)
       //{
       //    Graphics graph;            
       //    //使用窗口句柄创建Graphics            
       //    graph = Graphics.FromHwnd(this.Handle);            
       //    graph.FillRectangle(new SolidBrush(Color.Blue), 30, 20, 13, 7);            
       //    //使用控件句柄创建Graphics            
       //    graph = Graphics.FromHwnd(this.pictureBox1.Handle);            
       //    graph.FillRectangle(new SolidBrush(Color.Red ), 30, 20, 13, 7);            
       //    //创建梯度            
       //    System.Drawing.Drawing2D.LinearGradientBrush lineGrBrush;            
       //    graph = Graphics.FromHwnd(this.Handle);            
       //    lineGrBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(10, 30),new Point(30, 40),Color.FromArgb(255, 255, 0, 0),Color.FromArgb (255,0,0,255));
       //    graph.FillRectangle(lineGrBrush, 10, 30, 20, 10);
       //    //路径梯度
       //    Rectangle rectSquare;
       //    System.Drawing.Drawing2D.GraphicsPath graphPath;
       //    System.Drawing.Drawing2D.PathGradientBrush brushSquare;
       //    graph = Graphics.FromHwnd(this.Handle);
       //    graphPath = new System.Drawing.Drawing2D.GraphicsPath();
       //    rectSquare = new Rectangle(50, 20, 23, 27);
       //    graphPath.AddRectangle(rectSquare);
       //    brushSquare = new System.Drawing.Drawing2D.PathGradientBrush(graphPath);
       //    brushSquare.CenterColor = Color.FromArgb(255, 0, 255, 0);
       //    brushSquare.SurroundColors = new Color[] { Color.FromArgb(255, 0, 0, 255) }; 
       //    graph.FillRectangle(brushSquare, rectSquare);
       //    //一定要注意释放资源....
       //    graph.Dispose();
       //}
    }
}
