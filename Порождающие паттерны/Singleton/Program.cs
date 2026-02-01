using System;

namespace Singleton
{
    public class DatabaseHelper
    {
        private string data;
        private static DatabaseHelper databaseConnection;
        private static readonly object lockObject = new object();

        private DatabaseHelper() => Console.WriteLine("подключение к БД");
        public static DatabaseHelper GetConnection()
        {
            if (databaseConnection == null)
            {
                lock (lockObject)
                {
                    if (databaseConnection == null)
                    {
                        databaseConnection = new DatabaseHelper();
                    }
                }
            }
            return databaseConnection;
        }

        public string SelectData() => data;
        public void InsertData(string d)
        {
            Console.WriteLine("Новые данные: " + d + ", внесены в БД");
            data = d;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //DatabaseHelper connection = new DatabaseHelper()
            DatabaseHelper.GetConnection().InsertData("123");
            Console.WriteLine("Выборка данных из БД " + DatabaseHelper.GetConnection().SelectData());
        }
    }
}
