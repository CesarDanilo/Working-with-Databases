using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_resultado_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            
            string pathDatabase= Application.StartupPath + @"\db\DBSQLServer.sdf"; // pathDatabase -> é o caminho do nosso banco de dados
            string strConection = @"DataSource = " + pathDatabase + "; password = '1234'"; // strConection -> vai ser nossa string de conexão

            SqlCeEngine db = new SqlCeEngine(strConection);

            if (!File.Exists(pathDatabase))         // Aqui verificamos se esse arquivos não existe.
            {                                       //  Não existindo esse arquivo, usando 'db.CreateDatabase();' e criado um banco de dados
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection conn = new SqlCeConnection(strConection); // Abrindo uma conexão passando o parametro strConection 

            try
            {   
                conn.Open();
                label_resultado.Text = "Conexão bem sucedida!";

            }catch (Exception ex)
            {
                label_resultado.Text = "Conexão mau sucedida! \n" + ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
