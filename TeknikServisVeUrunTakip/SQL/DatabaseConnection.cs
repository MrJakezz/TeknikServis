using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.SQL
{
    public class DatabaseConnection
    {
        private static string server { get; set; } = ".";
        private static string database { get; set; } = "DBTeknikServis";
        private static bool security { get; set; } = true;
        private static string dataBaseID { get; set; } = "sa";
        private static string dataBasePassword { get; set; } = "Tugcan448077!";

        public string connectionString;
        public SqlConnection connection;

        public SqlConnection GetConnection()
        {
            connectionString = $"Data Source={server}; Initial Catalog={database}; Integrated Security={security}; User ID={dataBaseID}; Password={dataBasePassword};";
            
            connection = new SqlConnection(connectionString);

            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {

                    connection.Open();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Please try again later." + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed) {

                    connection.Close();

                }
            }

            catch
            {
                //
            }
        }
    }
}
