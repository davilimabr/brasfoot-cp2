using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class DataBaseManager
    {
        public string stringDeConexao;
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader leitor;

        public DataBaseManager(string nomeBanco)
        {
            string caminhoDoBanco = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));     
            stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + caminhoDoBanco + nomeBanco + @".mdf';Integrated Security=True";

            conexao = new SqlConnection(stringDeConexao);
        }

        public int AtualizarBanco(string comandoDML)
        {
            try
            {
                conexao.Open();
                comando = new SqlCommand(comandoDML, conexao);

                return comando.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public DataTable ConsultarBanco(string comandoDQL)
        {
            try
            {
                conexao.Open();
                comando = new SqlCommand(comandoDQL, conexao);

                leitor = comando.ExecuteReader();

                DataTable tabela = new DataTable();

                tabela.Load(leitor);

                return tabela;
            }
            /*catch
            {
                return null;
            }*/
            finally
            {
                if (conexao != null)
                    conexao.Close();

                if (leitor != null)
                    leitor.Close();
            }
        }
    }
}
