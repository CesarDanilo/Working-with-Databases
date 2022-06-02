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
            #region connection SQLServer test
            string pathDatabase = Application.StartupPath + @"\db\DBSQLServer.sdf"; // pathDatabase -> é o caminho do nosso banco de dados
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
            #endregion
        }

        private void btn_createTable_Click(object sender, EventArgs e)
        {
            #region Create table

            string pathDatabase = Application.StartupPath + @"\db\DBSQLServer.sdf";         // Pegando o caminho que esta nosso banco de dados
            string strConnection = "DataSource= " + pathDatabase + "; password='1234'";     // Passando esse caminho na nossa string de conexão

            SqlCeEngine db = new SqlCeEngine(strConnection);                                // Criando um objeto db para validar se existe o arquivo 

            if (!File.Exists(pathDatabase))                                                 // Validando e criando o arquivo se ele não existir 
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);                   // Criando um objeto conexão e passando o 'strConnection'

            try
            {
                conexao.Open();                                                                 

                SqlCeCommand command = new SqlCeCommand();                                 // Criando um objeto para fazer os comando SQL
                command.Connection = conexao;                                              // Passando nosso objeto de conexão

                command.CommandText = "CREATE TABLE PESSOA ( ID INT NOT NULL PRIMARY KEY, NOME NVARCHAR(60), EMAIL NVARCHAR(60), CELL NVARCHAR(60), DOCUMENTS NVARCHAR(60))";
                command.ExecuteNonQuery();                                                 // Mandando e executando os comandos SQL

                label_resultado.Text = "tabela criada com súcesso!!!";
                command.Dispose();
            }
            catch(Exception ex)
            {
                label_resultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
