using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;

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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            #region insert
            string pathDatabase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConnection = "DataSource= " + pathDatabase + "; password='1234'";

            SqlCeConnection db = new SqlCeConnection(strConnection);

            try
            {
                db.Open();
                
                SqlCeCommand cmd = new SqlCeCommand(); ;
                cmd.Connection = db;

                var id = Guid.NewGuid().ToString("N").GetHashCode();
                string nome = textBox_name.Text;
                string email = textBox_email.Text;
                string cell = textBox_cell.Text;
                string documents = textBox_documents.Text;


                cmd.CommandText = $"INSERT INTO PESSOA VALUES ({id}, '{nome}', '{email}', '{cell}', '{documents}')";
                cmd.ExecuteNonQuery();
                
                cmd.Dispose();

                label_resultado.Text = "Inserido com súcesso!";

            }catch(Exception ex)
            {
                label_resultado.Text = ex.Message;
            }
            finally
            {
                db.Close();
            }
            #endregion
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            label_resultado.Text = "";
            List_results.Rows.Clear();

            string pathDatabase = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConnection = "DataSource= " + pathDatabase + "; password='1234'";

            SqlCeConnection db = new SqlCeConnection(strConnection);

            try
            {
                string query = "SELECT * FROM PESSOA";  

                if (textBox_name.Text != "")
                {
                    query = "SELECT * FROM PESSOA WHERE nome LIKE '" + textBox_name.Text + "'";
                }

                DataTable data = new DataTable();                                             // Não inserimos os dados direto no table 
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, strConnection);       // Criamos os essa classe para fazer o tratamento dos dados antes de enviarmos para tabela

                db.Open();

                adapter.Fill(data);
                    
                foreach (DataRow _data in data.Rows)                                        // DataRow -> Vai trazer a fileira dos dados, e data.Rows -> vai trazer todas as fileiras da tabela de dados
                {
                    List_results.Rows.Add(_data.ItemArray);                                 // Vai adicionar um item do tipo array na fileira do List_result
                }                                                                           // O _data precisa ter a propriedade ItemArray para trazer os valores dessa fileira, se não adicionalo vai apenas trazer o tipo dela
            }
            catch (Exception ex)
            {
                List_results.Rows.Clear();
                label_resultado.Text = ex.Message;
            }
            finally
            {
                db.Close();
            }

        }
    }
}
