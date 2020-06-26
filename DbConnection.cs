using System;

namespace DesginStack
{
    public abstract class DbConnection
    {
        private string ConnectString { set; get; }
        private TimeSpan timeout { set; get; }
        private int ConnectType { set; get; }
        public DbConnection(string connectString)
        {
            if (String.IsNullOrWhiteSpace(ConnectString)) throw new InvalidOperationException("không kết nối được ");
            else ConnectString = connectString ;
       
        }
        public abstract void open();
        public abstract void closed();
    }

}