using System;

namespace ZKEShop.SystemFramework
{
    public class MyException:ApplicationException
    {
        private string myMessage;
        public override string Message
        {
            get
            {
                return myMessage;
            }
        }

        public MyException(string message):base()
        {
            myMessage = message;
        }
    }
}
