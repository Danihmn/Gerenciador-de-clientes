using System.Data;
using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de consultas
    /// <summary>
    /// Classe responsável por consultar os clientes no banco
    /// </summary>
    public class Consulta
    {
        #region Consulta todos os clientes
        /// <summary>
        /// Método responsável por exibir todos os registros do banco
        /// </summary>
        /// <returns>Retorna o DataTable proveniente da consulta, que é exibido</returns>
        public static DataTable ConsultaTodos()
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes;";

                    // Instancia novo Adapter, passando o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable);// Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta de todos os clientes. " + ex.Message);
                    throw;
                }
            }

            return dataTable;
        }
        #endregion

        #region Consulta o nome do cliente atraves do id
        /// <summary>
        /// Método responsável por consultar o registro através do id
        /// </summary>
        /// <param name="id">Id do cliente a ser consultado</param>
        /// <returns>Retorna o DataTable proveniente da consulta, que é exibido</returns>
        public static DataTable ConsultaPorId(string id)
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE id = @id;";
                    comando.Parameters.AddWithValue("@id", id); // Uso de parâmetros para segurança

                    // Instancia novo Adapter, passando o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta por id. " + ex.Message);
                    throw;
                }
            }

            return dataTable;
        }
        #endregion

        #region Consulta o id do cliente atraves do nome
        /// <summary>
        /// Método responsável por consultar o registro através do nome
        /// </summary>
        /// <param name="nome">Id do cliente a ser consultado</param>
        /// <returns>Retorna o DataTable proveniente da consulta, que é exibido</returns>
        public static DataTable ConsultaPorNome(string nome)
        {
            DataTable dataTable = new DataTable(); // Cria novo DataTable
            using (SQLiteConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand(); // Acessa a conexão e cria novo comando
                    comando.CommandText = "SELECT * FROM clientes WHERE nome = @nome;";
                    comando.Parameters.AddWithValue("@nome", nome); // Uso de parâmetros para maior segurança

                    // Instancia novo Adapter e insere o comando
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando);
                    adapter.Fill(dataTable); // Preenche o DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a consulta por nome. " + ex.Message);
                    throw;
                }

                return dataTable;
            }
        }
        #endregion
    }
    #endregion
}
