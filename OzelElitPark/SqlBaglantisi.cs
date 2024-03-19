using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OzelElitPark
{
    public class SqlBaglantisi
    {
        //sqlbağlantı cümlesi
        public static SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS;Initial Catalog=OzelElitPark;Integrated Security=True");

        //sqlbağlantının açıp olup olmadığıbı kontrol eder eğer kapalı ise bağlantıyı açar
        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
