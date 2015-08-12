using System;

namespace ZKEShop.Common
{
   public class TimeParser
    {

        public static int SecondToMinute(int Second)
        {
            decimal num = Second / 60M;
            return Convert.ToInt32(Math.Ceiling(num));
        }


        #region �õ�һ�ܵ���һ�����յ�����
        /// <summary> 
        /// ���㱾�ܵ���һ���� 
        /// </summary> 
        /// <returns></returns> 
        public static DateTime GetMondayDate()
        {
            return GetMondayDate(DateTime.Now);
        }
        /// <summary> 
        /// ���㱾�����յ����� 
        /// </summary> 
        /// <returns></returns> 
        public static DateTime GetSundayDate()
        {
            return GetSundayDate(DateTime.Now);
        }
        /// <summary> 
        /// ����ĳ����ʼ���ڣ����һ�����ڣ� 
        /// </summary> 
        /// <param name="someDate">����������һ��</param> 
        /// <returns>�������һ���ڣ�����ľ���ʱ���֡���ʹ���ֵ���</returns> 
        public static DateTime GetMondayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Monday;
            if (i == -1) i = 6;// iֵ > = 0 ����Ϊö��ԭ��Sunday������ǰ����ʱSunday-Monday=-1������+7=6�� 
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Subtract(ts);
        }
        /// <summary> 
        /// ����ĳ�ս������ڣ�����յ����ڣ� 
        /// </summary> 
        /// <param name="someDate">����������һ��</param> 
        /// <returns>������������ڣ�����ľ���ʱ���֡���ʹ���ֵ���</returns> 
        public static DateTime GetSundayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Sunday;
            if (i != 0) i = 7 - i;// ��Ϊö��ԭ��Sunday������ǰ��������Ҫ��7���� 
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Add(ts);
        }
        #endregion

        /// <summary>
        /// ��ʽ����ʾʱ��Ϊ������,����ǰ,��Сʱǰ,������ǰ,����ǰ
        /// </summary>
        /// <param name="dt">Ҫ��ʽ����ʾ��ʱ��</param>
        /// <returns>������,����ǰ,��Сʱǰ,������ǰ,����ǰ</returns>
        public static string DateStringFromNow(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            if (span.TotalDays > 60)
            {
                return dt.ToShortDateString();
            }
            else
                if (span.TotalDays > 30)
                {
                    return
                    "1����ǰ";
                }
                else
                    if (span.TotalDays > 14)
                    {
                        return
                        "2��ǰ";
                    }
                    else
                        if (span.TotalDays > 7)
                        {
                            return
                            "1��ǰ";
                        }
                        else
                            if (span.TotalDays > 1)
                            {
                                return
                                string.Format("{0}��ǰ", (int)Math.Floor(span.TotalDays));
                            }
                            else
                                if (span.TotalHours > 1)
                                {
                                    return
                                    string.Format("{0}Сʱǰ", (int)Math.Floor(span.TotalHours));
                                }
                                else
                                    if (span.TotalMinutes > 1)
                                    {
                                        return
                                        string.Format("{0}����ǰ", (int)Math.Floor(span.TotalMinutes));
                                    }
                                    else
                                        if (span.TotalSeconds >= 1)
                                        {
                                            return
                                            string.Format("{0}��ǰ", (int)Math.Floor(span.TotalSeconds));
                                        }
                                        else
                                        {
                                            return
                                            "1��ǰ";
                                        }
        }

    }
}
