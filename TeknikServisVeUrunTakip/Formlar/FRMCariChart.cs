using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.LINQ_Sorgular;
using TeknikServisVeUrunTakip.SQL;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMCariChart : Form
    {
        private static string server { get; set; } = ".";
        private static string database { get; set; } = "DBTeknikServis";
        private static bool security { get; set; } = true;
        private static string dataBaseID { get; set; } = "sa";
        private static string dataBasePassword { get; set; } = "Tugcan448077!";

        public string connectionString;
        public SqlConnection connection;

        public FRMCariChart()
        {
            InitializeComponent();
        }

        private void FRMCariChart_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection($"Data Source={server}; Initial Catalog={database}; Integrated Security={security}; User ID={dataBaseID}; Password={dataBasePassword};");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT IL, COUNT(*) FROM TBLCari GROUP BY IL", connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dataReader[0]), int.Parse(dataReader[1].ToString()));
            }
            connection.Close();

            CariChartLINQ statistics = new CariChartLINQ(chartControl1, gridControl1);
            
            statistics.Iller();
        }
    }
}
