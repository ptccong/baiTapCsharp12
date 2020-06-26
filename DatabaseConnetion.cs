using System;

namespace DesginStack
{
    class DbConnection
    {
        static void Main(string[] args)
        {
            Console.Write("Chọn kiểu kết nối : \n1,Kết nối SQl \n2,Kết nối với Oracle ");
            var type = Console.ReadLine();
            if (Convert.ToInt32(type) == 1)
                ExecuteSql();
            else
                ExecuteOracle();

        }

        static void ExecuteSql()
        {
            Console.Write("nhập chuỗi");
            var connectionString = Console.ReadLine();
            var SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();
            new DbCommand(SqlConnection);
            SqlConnection.Close();
        }
        static void ExecuteOracle()
        {
            Console.Write("nhập chuỗi ");
            var connectionString = Console.ReadLine();

            var OracleConnection = new OracleConnection(connectionString);
            OracleConnection.Open();
            new DbCommand(OracleConnection);
            OracleConnection.Close();
        }
    }

   
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
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionType = 1;
        }

        public override void Open()
        {
            Console.WriteLine(" kết nối đã mở Sql");
        }

        public override void Close()
        {
            Console.WriteLine("Đã đóng SQl ");
        }
    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionType = 2;
        }

        public override void Open()
        {
            Console.WriteLine(" kết nối đã mở Oracle");
        }

        public override void Close()
        {
            Console.WriteLine("Đã đóng Oracle ");
        }
    }
    public class DbCommand
    {
        public DbCommand(DbConnection connection)
        {
            if (String.IsNullOrWhiteSpace(connection.ConnectionString))
                throw new InvalidOperationException("không mở được ");
            else if (connection.ConnectionType == 1)
                Console.WriteLine("hoàn thành chỉ dẫn Sql ");
            else
                Console.WriteLine("hoàn thành chỉ dẫn Oracle ");
        }
    }

}